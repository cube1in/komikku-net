using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 章节
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IChapterApi
{
    #region Anonymous

    /// <summary>
    /// Get Chapter list
    /// Chapter list. If you want the Chapters of a given Manga, please check the feed endpoints.
    /// </summary>
    /// <param name="query">Support Params: limit offset ids[] title groups[] uploader manga volume[]
    ///                           chapter translatedLanguage[] originalLanguage[] excludedOriginalLanguage[]
    ///                           contentRating[] excludedGroups[] excludedUploaders[] includeFutureUpdates
    ///                           createdAtSince updatedAtSince publishAtSince ChapterListOrder includes[]
    /// </param>
    /// <returns></returns>
    [Get("/chapter")]
    Task<ChapterListResponse?> GetChapterListAsync([Query("")] ChapterListQuery? query = null);

    /// <summary>
    /// Get Chapter
    /// </summary>
    /// <param name="id">Chapter ID</param>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/chapter/{id}")]
    Task<ChapterResponse?> GetChapterAsync(string id,
        [AliasAs("includes[]")] [Query(CollectionFormat.Multi)] string[]? includes = null);

    #endregion

    #region Authorization

    /// <summary>
    /// Update Chapter
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Chapter ID</param>
    /// <param name="edit">ChapterEdit</param>
    /// <returns></returns>
    [Put("/chapter/{id}")]
    Task<ChapterResponse?> UpdateChapterAsync([Authorize] string token, string id, [Body] ChapterEdit edit);

    /// <summary>
    /// DeleteChapter
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/chapter/{id}")]
    Task<Response> DeleteChapterAsync([Authorize] string token, string id);

    #endregion
}