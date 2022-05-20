using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// CoverList 排序
/// </summary>
public class CoverListOrder
{
    /// <summary>
    /// 创建时间排序
    /// </summary>
    [AliasAs("createdAt]")]
    public OrderMode? CreatedAt { get; set; }

    /// <summary>
    /// 更新时间排序
    /// </summary>
    [AliasAs("updatedAt]")]
    public OrderMode? UpdatedAt { get; set; }

    /// <summary>
    /// 卷排序
    /// </summary>
    [AliasAs("volume]")]
    public OrderMode? Volume { get; set; }
}