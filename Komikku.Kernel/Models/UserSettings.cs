// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 用户设置
/// </summary>
public class UserSettings
{
    /// <summary>
    /// 设置
    /// Settings that were validated by linked template
    /// </summary>
    public object Settings { get; set; } = null!;

    /// <summary>
    /// 设置模板的 ID
    /// Settings template UUID
    /// </summary>
    public string Template { get; set; } = null!;
}
