using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// ScanlationGroupList 排序
/// default: latestUploadedChapter: desc
/// </summary>
public class ScanlationGroupListOrder
{
    /// <summary>
    /// 名称排序
    /// </summary>
    [AliasAs("name]")]
    public OrderMode? Name { get; set; }

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
    /// 追随人数
    /// </summary>
    [AliasAs("followedCount]")]
    public OrderMode? FollowedCount { get; set; }

    /// <summary>
    /// 相关程度
    /// </summary>
    [AliasAs("relevance]")]
    public OrderMode? Relevance { get; set; }
}