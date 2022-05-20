using CommunityToolkit.Mvvm.Input;
using Komikku.Kernel;
using Komikku.Kernel.Apis;
using Komikku.Kernel.Models;
using Komikku.Maui.Views;
using Refit;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Komikku.Maui.ViewModels;

public partial class LatestUpdateViewModel : BaseViewModel
{
    #region Private Members

    /// <summary>
    /// 漫画服务
    /// </summary>
    private readonly IMangaApi _mangaApi;

    /// <summary>
    /// 章节服务
    /// </summary>
    private readonly IChapterApi _chapterApi;

    /// <summary>
    /// 每次请求数
    /// </summary>
    private readonly int _limit = 24;

    /// <summary>
    /// 跳过
    /// </summary>
    private int _offset = 0;

    #endregion

    #region Public Properties

    /// <summary>
    /// 所有推荐
    /// </summary>
    public ObservableCollection<MangaForDisplay> MangaForDisplayList { get; set; } = new();

    /// <summary>
    /// 是否在下拉刷新中
    /// </summary>
    public bool IsRefreshing { get; set; }

    /// <summary>
    /// 剩余项目的阈值
    /// 也就是当不可见的项目等于这个数时，会触发相应的命令和事件
    /// <see cref="ThresholdReachedCommand"/>
    /// </summary>
    public virtual int RemainingItemsThreshold { get; set; } = 1;

    #endregion

    #region Commands

    /// <summary>
    /// 到达阈值时触发的命令 <see cref="RemainingItemsThreshold"/>
    /// </summary>
    public ICommand ThresholdReachedCommand => new AsyncRelayCommand(ThresholdReachedAsync);

    /// <summary>
    /// 刷新命令
    /// </summary>
    public ICommand RefreshCommand => new AsyncRelayCommand(RefreshAsync);

    /// <summary>
    /// 去往详情页
    /// </summary>
    public ICommand GoToDetailsCommand => new AsyncRelayCommand<MangaForDisplay>(GoToDetailsAsync);

    #endregion

    #region Constructor

    /// <summary>
    /// 默认构造函数
    /// </summary>
    public LatestUpdateViewModel()
    {
        _mangaApi = RestService.For<IMangaApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
        _chapterApi = RestService.For<IChapterApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
        _ = InitializeAsync();
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// 初始化
    /// </summary>
    /// <returns></returns>
    internal async Task InitializeAsync()
    {
        // 载入数据
        try
        {
            IsLoading = true;
            await Run(() => IsBusy, FetchAsync);
        }
        finally
        {
            IsLoading = false;
        }
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// 去往详情页
    /// </summary>
    /// <param name="mangaForDisplay"></param>
    /// <returns></returns>
    private async Task GoToDetailsAsync(MangaForDisplay? mangaForDisplay)
    {
        if (mangaForDisplay == null)
            return;

        await Shell.Current.GoToAsync(nameof(Details), true, new Dictionary<string, object>{
            {"MangaForDisplay", mangaForDisplay }
        });
    }

    /// <summary>
    /// 执行刷新
    /// </summary>
    /// <returns></returns>
    private async Task RefreshAsync()
    {
        // 载入数据
        try
        {
            await Run(() => IsBusy, FetchAsync);
        }
        finally
        {
            IsRefreshing = false;
        }
    }

    /// <summary>
    /// 到达阈值时触发
    /// </summary>
    /// <returns></returns>
    private async Task ThresholdReachedAsync()
    {
        // TODO: 后续考虑当没有数据后如何做
        await Run(() => IsBusy, FetchAsync);
    }

    /// <summary>
    /// 载入数据
    /// </summary>
    /// <returns></returns>
    private async Task FetchAsync()
    {
        var chapterQuery = new ChapterListQuery
        {
            Limit = _limit,
            Offset = _offset,
            ContentRatings = new[] { ContentRating.Safe, ContentRating.Suggestive, ContentRating.Erotica, ContentRating.Pornographic },
            TranslatedLanguages = new[] { "zh", "zh-hk" },
            Includes = new[] { "manga", "scanlation_group" },
            Order = new ChapterListOrder { ReadableAt = OrderMode.Desc }
        };

        var chapters = (await _chapterApi.GetChapterListAsync(chapterQuery))?.Data;
        var distinctChapters = chapters?.DistinctBy(c => c.Relationships.First(r => r.Type == EntityType.Manga).Id);

        var ids = (from chapter in distinctChapters
                   from relationship in chapter.Relationships
                   where relationship.Type == EntityType.Manga
                   select relationship.Id).ToArray();

        var mangaQuery = new MangaListQuery
        {
            Ids = ids,
            Limit = ids.Length,
            ContentRatings = new[] { ContentRating.Safe, ContentRating.Suggestive, ContentRating.Erotica, ContentRating.Pornographic },
            Includes = new[] { "cover_art", "author" }
        };

        var mangaList = (await _mangaApi.GetMangaListAsync(mangaQuery))?.Data.ToList();

        var list = ViewModelMapper.Map<IEnumerable<MangaForDisplay>>(distinctChapters);
        foreach (var item in list)
        {
            var manga = mangaList!.First(m => m.Id == item.Id);
            ViewModelMapper.Map(manga, item);

            if (MangaForDisplayList.All(m => m.Id != item.Id))
            {
                // Must to add, otherwise the ObservableCollection not change
                MangaForDisplayList.Add(item);
            }
        }

        _offset += _limit;
    }

    #endregion
}
