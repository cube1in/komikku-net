// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 8KB
/// </summary>
public class CustomListEdit : VersionProperty
{
    public string Name { get; set; } = null!;

    public Visibility Visibility { get; set; }

    /// <summary>
    /// uuid
    /// </summary>
    public IEnumerable<string> Manga { get; set; } = null!;
}
