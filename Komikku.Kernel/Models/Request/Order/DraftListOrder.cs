using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// DraftList 排序
/// </summary>
public class DraftListOrder
{
    /// <summary>
    /// 标题排序
    /// </summary>
    [AliasAs("title]")]
    public OrderMode? Title { get; set; }

    /// <summary>
    /// 年份
    /// </summary>
    [AliasAs("year]")]
    public OrderMode? Year { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    [AliasAs("createdAt]")]
    public OrderMode? CreatedAt { get; set; }

    /// <summary>
    /// 上传时间
    /// </summary>
    [AliasAs("updatedAt]")]
    public OrderMode? UpdatedAt { get; set; }
}