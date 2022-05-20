// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 标签
/// </summary>
public class Tag : IHasRelationship
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
    /// 标签属性
    /// </summary>
    public TagAttributes Attributes { get; set; } = null!;

    /// <summary>
    /// 关系
    /// </summary>
    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
