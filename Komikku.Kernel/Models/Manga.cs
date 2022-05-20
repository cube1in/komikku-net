// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 漫画
/// </summary>
public class Manga : IHasRelationship
{
    /// <summary>
    /// 漫画 ID
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 实体类型
    /// </summary>
    public EntityType Type { get; set; }

    /// <summary>
    /// 属性
    /// </summary>
    public MangaAttributes Attributes { get; set; } = null!;

    /// <summary>
    /// 关系
    /// </summary>
    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
