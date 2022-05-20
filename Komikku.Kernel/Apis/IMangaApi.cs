using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 漫画
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IMangaApi
{
    #region Anonymous

    /// <summary>
    /// Manga list
    /// </summary>
    /// <param name="query">Support params: all query string</param>
    /// <returns></returns>
    [Get("/manga")]
    Task<MangaListResponse?> GetMangaListAsync([Query("")] MangaListQuery? query = null);

    /// <summary>
    /// Get mage by id
    /// </summary>
    /// <param name="id">Manga ID</param>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/manga/{id}")]
    Task<MangaResponse?> GetMangaAsync(string id,
        [AliasAs("includes[]")] [Query(CollectionFormat.Multi)] string[]? includes = null);

    /// <summary>
    /// Get Manga volumes & chapters
    /// </summary>
    /// <param name="id">Manga ID</param>
    /// <param name="query">Support params: translatedLanguage[] groups[]</param>
    /// <returns></returns>
    [Get("/manga/{id}/aggregate")]
    Task<MangaAggregateResponse?> GetMangaAggregateAsync(string id, MangaAggregateQuery? query = null);

    /// <summary>
    /// Manga feed
    /// </summary>
    /// <param name="id">Manga ID</param>
    /// <param name="query">Support params: limit offset translatedLanguage[] originalLanguage[] includeFutureUpdates
    ///                           excludedOriginalLanguage[] excludedGroups[] excludedUploaders[] createdAtSince updatedAtSince
    ///                           publishAtSince ChapterListOrder includes[]
    /// </param>
    /// <returns></returns>
    [Get("/manga/{id}/feed")]
    Task<ChapterListResponse?> GetMangaFeedAsync(string id, [Query("")] MangaFeedQuery? query = null);

    /// <summary>
    /// Get a random manga
    /// </summary>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/manga/random")]
    Task<MangaResponse?> GetRandomMangaAsync(
        [AliasAs("includes[]")] [Query(CollectionFormat.Multi)] string[]? includes = null);

    /// <summary>
    /// Get tag list
    /// </summary>
    /// <returns></returns>
    [Get("/manga/tag")]
    Task<TagListResponse?> GetTagListAsync();

    /// <summary>
    /// Get Manga relation list
    /// </summary>
    /// <param name="mangaId">Manga ID</param>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/manga/{mangaId}/relation")]
    Task<MangaRelationListResponse?> GetMangaRelationListAsync(string mangaId,
        [AliasAs("includes[]")] [Query(CollectionFormat.Multi)]
        string[]? includes = null);

    #endregion

    #region Authorization

    /// <summary>
    /// Follow manga
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Post("/manga/{id}/follow")]
    Task<Response> FollowMangaAsync([Authorize] string token, string id);

    /// <summary>
    /// Unfollow manga
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Delete("/manga/{id}/follow")]
    Task<Response> UnfollowMangaAsync([Authorize] string token, string id);

    /// <summary>
    /// Get all Manga reading status for logged User
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="filter">Used to filter the list by given status</param>
    /// <returns></returns>
    [Get("/manga/status")]
    Task<GroupReadingStatusResponse?> GetAllMangaReadingStatusAsync([Authorize] string token,
        ReadingStatus? filter = null);

    /// <summary>
    /// Get a Manga reading status
    /// "null" if unfollow, "not null" if follow
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Get("/manga/{id}/status")]
    Task<ReadingStatusResponse?> GetMangaReadingStatusAsync([Authorize] string token, string id);

    /// <summary>
    /// Update Manga reading status
    /// Using a "null" value in status field will remove the Manga reading status. 
    /// The size of the body is limited to 2KB. 
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <param name="update">Manga reading status</param>
    /// <returns></returns>
    [Post("/manga/{id}/status")]
    Task<Response> UpdateMangaReadingStatusAsync([Authorize] string token, string id, [Body] UpdateMangaStatus update);

    /// <summary>
    /// Create a new manga
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="create"></param>
    /// <returns></returns>
    [Post("/manga")]
    Task<MangaResponse?> CreateMangaAsync([Authorize] string token, [Body] MangaCreate create);

    /// <summary>
    /// Update a manga
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <param name="edit">MangaEdit</param>
    /// <returns></returns>
    [Put("/manga/{id}")]
    Task<MangaResponse?> UpdateMangaAsync([Authorize] string token, string id, [Body] MangaEdit edit);

    /// <summary>
    /// Delete a manga
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Delete("/manga/{id}")]
    Task<Response> DeleteMangaAsync([Authorize] string token, string id);

    /// <summary>
    /// Get a list of Manga Drafts
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support params: limit offset state DraftListOrder includes[]</param>
    /// <returns></returns>
    [Get("/author")]
    Task<MangaResponse?> GetMangaDraftListAsync([Authorize] string token,
        [Query("")] MangaDraftListQuery? query = null);

    /// <summary>
    /// Get a specific Manga Draft
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/manga/draft/{id}")]
    Task<MangaResponse?> GetSpecificMangaDraftAsync([Authorize] string token, string id,
        [AliasAs("includes[]")] [Query(CollectionFormat.Multi)] string[]? includes = null);

    /// <summary>
    /// Submit a Manga Draft
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <param name="commit">MangaDraftCommit</param>
    /// <returns></returns>
    [Post("/manga/draft/{id}")]
    Task<MangaResponse?> CommitMangaDraftAsync([Authorize] string token, string id, [Body] MangaDraftCommit commit);

    /// <summary>
    /// Create Manga relation
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="mangaId">Manga ID</param>
    /// <param name="create">MangaRelationCreate</param>
    /// <returns></returns>
    [Post("/manga/{mangaId}/relation")]
    Task<MangaRelationResponse?> CreateMangaRelationAsync([Authorize] string token, string mangaId,
        [Body] MangaRelationCreate create);

    /// <summary>
    /// Delete Manga relation
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="mangaId">Manga ID</param>
    /// <param name="id">Relation ID</param>
    /// <returns></returns>
    [Delete("/manga/{mangaId}/relation/{id}")]
    Task<Response> DeleteMangaRelationAsync([Authorize] string token, string mangaId, string id);

    #endregion
}