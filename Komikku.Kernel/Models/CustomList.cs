// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class CustomList
{
    public string Id { get; set; } = null!;

    public CustomListAttributes Attributes { get; set; } = null!;

    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
