// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 章节
/// </summary>
public class Chapter : IHasRelationship
{
    /// <summary>
    /// ID
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 实体类型
    /// </summary>
    public EntityType Type { get; set; }

    /// <summary>
    /// 章节属性
    /// </summary>
    public ChapterAttributes Attributes { get; set; } = null!;

    /// <summary>
    /// 关系
    /// </summary>
    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
