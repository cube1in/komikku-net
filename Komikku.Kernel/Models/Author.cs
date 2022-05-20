// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 作者
/// </summary>
public class Author
{
    public AuthorAttributes Attributes { get; set; } = null!;

    public Relationship Relationship { get; set; } = null!;
}
