// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ChapterDraft
{
    /// <summary>
    /// maxLength: 8
    /// pattern: ^((0|[1-9]\d*)(\.\d+)?[a-z]?)?$
    /// </summary>
    public string? Volume { get; set; }

    /// <summary>
    /// maxLength: 8
    /// pattern: ^((0|[1-9]\d*)(\.\d+)?[a-z]?)?$
    /// </summary>
    public string? Chapter { get; set; }

    /// <summary>
    /// maxLength: 255
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// pattern: '^[a-z]{2}(-[a-z]{2})?$'
    /// </summary>
    public string TranslatedLanguage { get; set; } = null!;

    /// <summary>
    /// maxLength: 512
    /// pattern: ^https?://
    /// </summary>
    public string ExternalUrl { get; set; } = null!;

    /// <summary>
    /// pattern: '^\d{4}-[0-1]\d-([0-2]\d|3[0-1])T([0-1]\d|2[0-3]):[0-5]\d:[0-5]\d$'
    /// </summary>
    public string PublishAt { get; set; } = null!;
}
