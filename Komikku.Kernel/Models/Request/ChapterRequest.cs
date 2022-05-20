// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ChapterRequest : VersionProperty
{
    /// <summary>
    /// maxLength: 255
    /// </summary>
    public string? Title { get; set; }

    public string? Volume { get; set; }

    /// <summary>
    /// maxLength: 8
    /// </summary>
    public string? Chapter { get; set; }

    /// <summary>
    /// pattern: '^[a-z]{2}(-[a-z]{2})?$'
    /// </summary>
    public string TranslatedLanguage { get; set; } = null!;

    /// <summary>
    /// uuid
    /// minLength: 36
    /// maxLength: 36
    /// </summary>
    public IEnumerable<string> Groups { get; set; } = null!;
}
