// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 4KB
/// </summary>
public class BeginUploadSession
{
    /// <summary>
    /// minLength: 36
    /// maxLength: 36
    /// uuid
    /// </summary>
    public IEnumerable<string> Groups { get; set; } = null!;

    /// <summary>
    /// minLength: 36
    /// maxLength: 36
    /// uuid
    /// </summary>
    public string Manga { get; set; } = null!;
}
