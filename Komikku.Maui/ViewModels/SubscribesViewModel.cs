using CommunityToolkit.Mvvm.Input;
using Komikku.Kernel;
using Komikku.Kernel.Apis;
using Komikku.Kernel.Models;
using Komikku.Maui.DataAccess;
using Komikku.Maui.Views;
using PropertyChanged;
using Refit;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Komikku.Maui.ViewModels;


/// <summary>
/// 订阅页视图模型
/// </summary>
public class SubscribesViewModel : BaseViewModel
{
    #region Private Members

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
    /// 所有订阅集合
    /// </summary>
    public ObservableCollection<MangaForDisplay> MangaForDisplayList { get; set; } = new();

    /// <summary>
    /// 是否在下拉刷新中
    /// </summary>
    public bool IsRefreshing { get; set; }

    /// <summary>
    /// 是否登录
    /// </summary>
    [AlsoNotifyFor(nameof(IsLogout))]
    public bool IsLogin { get; set; }

    /// <summary>
    /// 是否登出
    /// </summary>
    public bool IsLogout => !IsLogin;

    #endregion

    #region Commands

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
    public SubscribesViewModel(AuthorizeManager authorizeManager)
    {
        _authorizeManager = authorizeManager;
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
        if (await _authorizeManager.IsLoginAsync())
        {
            // 二次不加载
            if (MangaForDisplayList.Any()) return;

            IsLogin = true;
            IsLoading = true;

            // 载入数据
            try
            {
                await Run(() => IsBusy, FetchAsync);
            }
            finally
            {
                IsLoading = false;
            }
        }
        else
        {
            MangaForDisplayList.Clear();
            IsLogin = false;
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
    /// 执行刷新命令
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
    /// 载入数据
    /// </summary>
    /// <returns></returns>
    private async Task FetchAsync()
    {
        var query = new IncludesQuery
        {
            Includes = new[] { "cover_art" }
        };

        var mangaList = await _followsApi.GetUserFollowedMangaListAsync((await _authorizeManager.GetTokenAsync())!, query);
        var displays = ViewModelMapper.Map<IEnumerable<MangaForDisplay>>(mangaList?.Data);

        if (MangaForDisplayList.Any()) MangaForDisplayList.Clear();
        // Must to add, otherwise the ObservableCollection not change
        foreach (var display in displays) MangaForDisplayList.Add(display);
    }

    #endregion
}
