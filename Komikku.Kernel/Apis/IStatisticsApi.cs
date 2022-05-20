using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 统计数据
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IStatisticsApi
{
    #region Authorization

    /// <summary>
    /// Get statistics about given Manga
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="uuid">Manga ID</param>
    /// <returns></returns>
    [Get("/statistics/manga/{uuid}")]
    Task<MangaStatisticsResponse?> GetMangaStatisticsAsync([Authorize] string token, string uuid);

    /// <summary>
    /// Find statistics about given Manga
    /// TODO: manga array
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="manga"></param>
    /// <returns></returns>
    [Get("/statistics/manga")]
    Task<MangaStatisticsResponse?> GetMangaStatisticsAsync([Authorize] string token, IEnumerable<string> manga);

    #endregion
}