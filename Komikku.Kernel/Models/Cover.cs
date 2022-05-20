// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class Cover : IHasRelationship
{
    public string Id { get; set; } = null!;

    public EntityType Type { get; set; }

    public CoverAttributes CoverAttributes { get; set; } = null!;

    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
