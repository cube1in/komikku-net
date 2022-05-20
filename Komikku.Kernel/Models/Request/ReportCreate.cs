// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 8KB
/// </summary>
public class ReportCreate
{
    public ReportCategory Category { get; set; }

    /// <summary>
    /// minLength: 36
    /// maxLength: 36
    /// </summary>
    public string Reason { get; set; } = null!;

    public string ObjectId { get; set; } = null!;

    public string Details { get; set; } = null!;
}
