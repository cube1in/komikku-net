// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// This response will give you an array of mappings of resource identifiers ; 
/// the `data.attributes.newId` field corresponds to the new UUID.
/// </summary>
public class MappingId
{
    public string Id { get; set; } = null!;

    public EntityType Type { get; set; }

    public MappingIdAttributes Attributes { get; set; } = null!;

    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
