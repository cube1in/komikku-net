using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Komikku.Kernel;
using Komikku.Kernel.Apis;
using Komikku.Kernel.Models;
using Komikku.Maui.DataAccess;
using Komikku.Maui.Views;
using Refit;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Komikku.Maui.ViewModels;

/// <summary>
/// 详情页视图模型
/// </summary>
[QueryProperty(nameof(MangaForDisplay), nameof(MangaForDisplay))]
public partial class DetailsViewModel : BaseViewModel
{
    #region Private Members

    /// <summary>
    /// 漫画提供器
    /// </summary>
    private readonly IMangaApi _mangaApi;

    /// <summary>
    /// 订阅提供器
    /// </summary>
    private readonly IFollowsApi _followsApi;

    /// <summary>
    /// 验证管理
    /// </summary>
    private readonly AuthorizeManager _authorizeManager;

    #endregion

    #region Public Properties

    /// <summary>
    /// 漫画
    /// </summary>
    [ObservableProperty]
    MangaForDisplay mangaForDisplay = null!;

    /// <summary>
    /// 订阅按钮文本
    /// </summary>
    public string SubscribeButtonText { get; set; } = "登录可订阅";

    /// <summary>
    /// 漫画聚合集合(卷和章)
    /// </summary>
    public ObservableCollection<ChapterGroupForDisplay> ChapterGroupForDisplayList { get; set; } = new();

    #endregion

    #region Commands

    /// <summary>
    /// 前往阅读
    /// </summary>
    public ICommand GoToReadingCommand => new AsyncRelayCommand<string>(GoToReadingAsync);

    /// <summary>
    /// 订阅
    /// </summary>
    public ICommand SubscribeCommand => new AsyncRelayCommand(SubscribeAsync);

    #endregion

    #region Constructor

    /// <summary>
    /// 默认构造函数
    /// </summary>
    public DetailsViewModel(AuthorizeManager authorizeManager)
    {
        _authorizeManager = authorizeManager;
        _mangaApi = RestService.For<IMangaApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
        _followsApi = RestService.For<IFollowsApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// 初始化
    /// </summary>
    /// <returns></returns>
    internal async Task InitializeAsync()
    {
        try
        {
            IsLoading = false;
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
    /// 前往阅读
    /// </summary>
    /// <param name="chapterId"></param>
    /// <returns></returns>
    private async Task GoToReadingAsync(string? chapterId)
    {
        if (chapterId == null)
            return;

        await Shell.Current.GoToAsync($"{nameof(Reading)}?{nameof(ReadingViewModel.ChapterId)}={chapterId}", true);
    }

    /// <summary>
    /// 订阅按钮点击后触发
    /// </summary>
    /// <returns></returns>
    private async Task SubscribeAsync()
    {
        await Run(() => IsBusy, async () =>
        {
            switch (SubscribeButtonText)
            {
                case "订阅漫画":
                    var result1 = await _mangaApi.FollowMangaAsync((await _authorizeManager.GetTokenAsync())!, MangaForDisplay.Id);
                    if (result1?.Result == Result.Ok) SubscribeButtonText = "已订阅";
                    break;
                case "已订阅":
                    var result2 = await Shell.Current.DisplayAlert("是否取消订阅", "人家那么好看，给个机会把~", "取消订阅", "再想想");
                    if (result2)
                    {
                        var result3 = await _mangaApi.UnfollowMangaAsync((await _authorizeManager.GetTokenAsync())!, MangaForDisplay.Id);
                        if (result3?.Result == Result.Ok) SubscribeButtonText = "订阅漫画";
                    }

                    break;
            }
        });
    }

    /// <summary>
    /// 数据加载
    /// </summary>
    /// <returns></returns>
    private async Task FetchAsync()
    {
        var query = new MangaFeedQuery
        {
            TranslatedLanguages = new[] { "zh", "zh-hk" },
            Limit = 96,
            Offset = 0,
            Order = new MangaFeedOrder { Volume = OrderMode.Desc, Chapter = OrderMode.Desc },
            Includes = new[] { "scanlation_group", "user" },
            ContentRatings = new[] { ContentRating.Safe, ContentRating.Suggestive, ContentRating.Erotica, ContentRating.Pornographic }
        };

        _ = SetFollowsStateAsync();

        var chapterList = (await _mangaApi.GetMangaFeedAsync(MangaForDisplay.Id, query))!;
        var displays = ViewModelMapper.Map<IEnumerable<ChapterForDisplay>>(chapterList.Data);
        foreach (var group in displays.GroupBy(d => d.Volume))
        {
            ChapterGroupForDisplayList.Add(new(group.Key is null ? "最新卷" : $"第{group.Key}卷", group));
        }
    }

    /// <summary>
    /// 设置订阅状态
    /// </summary>
    private async Task SetFollowsStateAsync()
    {
        if (await _authorizeManager.IsLoginAsync())
        {
            // TODO: It takes a long time 
            try
            {
                await _followsApi.CheckUserFollowsMangaAsync((await _authorizeManager.GetTokenAsync())!, MangaForDisplay.Id);
                SubscribeButtonText = "已订阅";
            }
            catch
            {
                SubscribeButtonText = "订阅漫画";
            }
        }
    }

    #endregion
}
