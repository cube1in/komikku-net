// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ReportReasons
{
    public string Id { get; set; } = null!;

    public string Type { get; set; } = null!;

    public ReportReasonsAttributes Attributes { get; set; } = null!;
}
