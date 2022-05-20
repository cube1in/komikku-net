// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaRequest : VersionProperty
{
    public LocalizedString Title { get; set; } = null!;

    public IEnumerable<LocalizedString> AltTitles { get; set; } = null!;

    public LocalizedString Description { get; set; } = null!;

    public IEnumerable<string> Authors { get; set; } = null!;

    public IEnumerable<string> Artists { get; set; } = null!;

    /// <summary>
    /// https://api.mangadex.org/docs.html#section/Static-data/Manga-links-data
    /// </summary>
    public Dictionary<string, string> Links { get; set; } = null!;

    /// <summary>
    /// pattern: '^[a-z]{2}(-[a-z]{2})?$'
    /// </summary>
    public string OriginalLanguage { get; set; } = null!;

    public string? LastVolume { get; set; }

    public string? LastChapter { get; set; }

    public PublicationDemographic? PublicationDemographic { get; set; }

    public Status Status { get; set; }

    /// <summary>
    /// Year of release
    /// maximum: 9999
    /// minimum: 1
    /// </summary>
    public int? Year { get; set; }

    public ContentRating ContentRating { get; set; }

    public bool ChapterNumbersResetOnNewVolume { get; set; }

    public IEnumerable<string> Tags { get; set; } = null!;

    public string? PrimaryCover { get; set; }
}
