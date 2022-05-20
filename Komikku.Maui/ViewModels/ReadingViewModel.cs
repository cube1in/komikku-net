using Komikku.Kernel;
using Komikku.Kernel.Apis;
using Refit;
using System.Collections.ObjectModel;

namespace Komikku.Maui.ViewModels;

/// <summary>
/// 阅读页视图模型
/// </summary>
[QueryProperty(nameof(ChapterId), nameof(ChapterId))]
public class ReadingViewModel : BaseViewModel
{
    #region Private Members

    /// <summary>
    /// 图片阅读服务提供器
    /// </summary>
    private readonly IAtHomeApi _atHomeApi;

    #endregion

    #region Public Properties

    /// <summary>
    /// 导航过来的章节 Id
    /// </summary>
    public string ChapterId { get; set; } = null!;

    /// <summary>
    /// 图片集合
    /// </summary>
    public ObservableCollection<string> ImageList { get; set; } = new();

    /// <summary>
    /// 阅读方向
    /// </summary>
    public ItemsLayoutOrientation Orientation { get; set; } = ItemsLayoutOrientation.Horizontal;

    #endregion

    #region Constructor

    /// <summary>
    /// 默认构造函数
    /// </summary>
    public ReadingViewModel()
    {
        _atHomeApi = RestService.For<IAtHomeApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
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
    /// 载入数据
    /// </summary>
    /// <returns></returns>
    private async Task FetchAsync()
    {
        var atHome = (await _atHomeApi.GetHomeServerUrlAsync(ChapterId))!;
        var items = Retrieving.GetChapterPagesOnDataQualityMode(atHome.BaseUrl, atHome.Chapter.Hash,
            atHome.Chapter.Data);
        foreach (var item in items)
        {
            ImageList.Add(item);
        }
    }

    #endregion
}
