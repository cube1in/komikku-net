// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 漫画相关
/// </summary>
[RegisterRelationshipSupport(EntityType.MangaRelation)]
public class MangaRelationAttributes : VersionProperty
{
    /// <summary>
    /// 关系
    /// </summary>
    public Related Relation { get; set; }
}
