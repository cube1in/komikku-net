// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ScanlationGroup
{
    public string Id { get; set; } = null!;

    public EntityType Type { get; set; }

    public ScanlationGroupAttributes Attributes { get; set; } = null!;

    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
