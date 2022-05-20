using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// ChapterList 排序
/// </summary>
public class ChapterListOrder
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
    /// 发布时间排序
    /// </summary>
    [AliasAs("publishAt]")]
    public OrderMode? PublishAt { get; set; }

    /// <summary>
    /// 可读时间排序
    /// </summary>
    [AliasAs("readableAt]")]
    public OrderMode? ReadableAt { get; set; }

    /// <summary>
    /// 卷排序
    /// </summary>
    [AliasAs("volume]")]
    public OrderMode? Volume { get; set; }

    /// <summary>
    /// 章排序
    /// </summary>
    [AliasAs("chapter]")]
    public OrderMode? Chapter { get; set; }
}