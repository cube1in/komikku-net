using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// MangaList 排序
/// default: latestUploadedChapter: desc
/// </summary>
public class MangaListOrder
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
    /// 最后上传章节
    /// </summary>
    [AliasAs("latestUploadedChapter]")]
    public OrderMode? LatestUploadedChapter { get; set; }

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