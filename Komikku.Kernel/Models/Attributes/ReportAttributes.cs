// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 报告
/// </summary>
[RegisterRelationshipSupport(EntityType.Report)]
public class ReportAttributes
{
    /// <summary>
    /// 对象Id
    /// </summary>
    public string ObjectId { get; set; } = null!;

    /// <summary>
    /// 详情
    /// </summary>
    public string Details { get; set; } = null!;

    /// <summary>
    /// 报告状态
    /// </summary>
    public ReportStatus Status { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public string CreatedAt { get; set; } = null!;
}
