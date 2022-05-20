// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 10KB
/// </summary>
public class MappingIdBody
{
    public MappingType Type { get; set; }

    public IEnumerable<int> Ids { get; set; } = null!;
}

public enum MappingType
{
    None,
    Group,
    Manga,
    Chapter,
    Tag
}
