// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public interface IHasRelationship
{
    IEnumerable<Relationship> Relationships { get; }
}
