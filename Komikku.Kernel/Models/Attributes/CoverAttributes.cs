// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 封面
/// </summary>
[RegisterRelationshipSupport(EntityType.CoverArt)]
public class CoverAttributes : AdditionalProperties
{
    /// <summary>
    /// 文件名称
    /// </summary>
    public string FileName { get; set; } = null!;

    /// <summary>
    /// 卷
    /// </summary>
    public string? Volume { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 语言环境
    /// </summary>
    public string? Locale { get; set; }
}
