// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 这个 Attributes 不需要为 <see cref="Relationship"/> 提供支持
/// 仅供 <see cref="ReportReasons"/> 使用
/// </summary>
public class ReportReasonsAttributes : VersionProperty
{
    public LocalizedString Reason { get; set; } = null!;

    public bool DetailsRequired { get; set; }

    public ReportCategory Category { get; set; }
}
