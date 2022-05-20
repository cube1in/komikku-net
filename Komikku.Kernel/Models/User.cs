// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class User
{
    public string Id { get; set; } = null!;

    public UserAttributes Attributes { get; set; } = null!;

    public IEnumerable<Relationship> Relationships { get; set; } = null!;
}
