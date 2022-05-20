using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 首页
/// </summary>
public interface IAtHomeApi
{
    /// <summary>
    /// Get MangaDex@Home server URL
    /// The base URL to construct final image URLs from.
    /// The URL returned is valid for the requested chapter only, and for a duration of 15 minutes from the time of the response.
    /// </summary>
    /// <param name="chapterId">Chapter ID</param>
    /// <returns></returns>
    [Get("/at-home/server/{chapterId}")]
    Task<AtHome?> GetHomeServerUrlAsync(string chapterId);
}