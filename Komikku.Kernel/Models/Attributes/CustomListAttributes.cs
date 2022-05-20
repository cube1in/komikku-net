// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 自定义列表
/// </summary>
[RegisterRelationshipSupport(EntityType.CustomList)]
public class CustomListAttributes : VersionProperty
{
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 可见性
    /// </summary>
    public Visibility Visibility { get; set; }
}
