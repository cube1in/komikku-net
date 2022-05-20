// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// MangaDex@Home
/// </summary>
public class AtHome
{
    /// <summary>
    /// The base URL to construct final image URLs from.
    /// The URL returned is valid for the requested chapter only, and for a duration of 15 minutes
    /// example: https://abcdef.xyz123.mangadex.network:12345/some-temporary-access-token
    /// </summary>
    public string BaseUrl { get; set; } = null!;

    public AtHomeChapter Chapter { get; set; } = null!;
}
