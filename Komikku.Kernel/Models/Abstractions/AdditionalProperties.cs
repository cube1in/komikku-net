// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public abstract class AdditionalProperties : VersionProperty
{
    public string CreatedAt { get; set; } = null!;

    public string UpdatedAt { get; set; } = null!;
}
