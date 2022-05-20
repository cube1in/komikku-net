// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 内容分级
/// </summary>
public enum ContentRating
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 安全
    /// </summary>
    Safe,

    /// <summary>
    /// 性暗示
    /// </summary>
    Suggestive,

    /// <summary>
    /// 黄色
    /// </summary>
    Erotica,

    /// <summary>
    /// 色情
    /// </summary>
    Pornographic
}
