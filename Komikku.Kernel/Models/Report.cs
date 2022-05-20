// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class Report
{
    public string Id { get; set; } = null!;

    public EntityType Type { get; set; }

    public ReportAttributes Attributes { get; set; } = null!;

    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
