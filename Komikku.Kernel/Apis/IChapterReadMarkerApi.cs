using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 章节阅读标记
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IChapterReadMarkerApi
{
    #region Authorization

    /// <summary>
    /// Get manga read markers
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="ids">Manga ids</param>
    /// <param name="grouped">Group results by manga ids</param>
    /// <returns></returns>
    [Get("/manga/read")]
    Task<GroupReadMarkerResponse?> GetMangaReadMarkersAsync([Authorize] string token, IEnumerable<string> ids,
        bool grouped = false);

    /// <summary>
    /// Get manga read markers
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Get("/manga/{id}/read")]
    Task<ReadMarkerResponse?> GetMangaReadMarkersAsync([Authorize] string token, string id);

    /// <summary>
    /// Chapter read marker batch
    /// Send a lot of chapter ids for one manga to mark as read and/or unread
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <param name="batch">ChapterReadMarkerBatch</param>
    /// <returns></returns>
    [Post("/manga/{id}/read")]
    Task<Response> ChapterReadMarkerBatchAsync([Authorize] string token, string id,
        [Body] ChapterReadMarkerBatch batch);

    /// <summary>
    /// Mark chapter read
    /// Mark chapter as read for the current user
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Post("/chapter/{id}/read")]
    Task<Response> MarkChapterReadAsync([Authorize] string token, string id);

    /// <summary>
    /// Mark chapter unread
    /// Mark chapter as unread for the current user
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Delete("/chapter/{id}/read")]
    Task<Response> MarkChapterUnreadAsync([Authorize] string token, string id);

    #endregion
}