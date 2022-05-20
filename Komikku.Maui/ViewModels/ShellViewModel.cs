using Komikku.Maui.Resources.Strings;

namespace Komikku.Maui.ViewModels;

public class ShellViewModel
{
    #region Public Properties

    /// <summary>
    /// 最新更新
    /// </summary>
    public AppSection LatestUpdate { get; set; } = null!;

    /// <summary>
    /// 订阅
    /// </summary>
    public AppSection Subscribes { get; set; } = null!;

    /// <summary>
    /// 我的
    /// </summary>
    public AppSection Me { get; set; } = null!;

    #endregion
    /// <summary>
    /// 默认构造函数
    /// </summary>
    public ShellViewModel()
    {
        LatestUpdate = new()
        {
            Title = AppResource.LatestUpdate,
            Icon = "discover.svg",
            IconDark = "discover_dark.svg"
        };
        Subscribes = new()
        {
            Title = AppResource.Subscribes,
            Icon = "subscribes.svg",
            IconDark = "subscribes_dark.svg"
        };
        Me = new()
        {
            Title = AppResource.Me,
            Icon = "setting.svg",
            IconDark = "setting_dark.svg"
        };
    }
}
