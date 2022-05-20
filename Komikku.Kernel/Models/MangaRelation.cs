// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaRelation
{
    public string Id { get; set; } = null!;

    public EntityType Type { get; set; }

    public MangaRelationAttributes Attributes { get; set; } = null!;

    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
