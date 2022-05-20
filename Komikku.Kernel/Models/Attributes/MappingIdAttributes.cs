// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

[RegisterRelationshipSupport(EntityType.MappingId)]
public class MappingIdAttributes
{
    /// <summary>
    /// 实体类型
    /// </summary>
    public EntityType Type { get; set; }

    /// <summary>
    /// 旧版 ID
    /// </summary>
    public int LegacyId { get; set; }

    /// <summary>
    /// 新版 ID
    /// </summary>
    public int NewId { get; set; }
}
