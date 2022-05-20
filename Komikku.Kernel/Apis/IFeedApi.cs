using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 喂养
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IFeedApi
{
    #region Authorization

    /// <summary>
    /// 获取登录用户订阅的章节列表
    /// Get logged User followed Manga feed (Chapter list)
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support params: limit offset translatedLanguage[] originalLanguage[]
    ///                           excludedOriginalLanguage[] contentRating[] excludedGroups[] 
    ///                           excludedUploaders[] includeFutureUpdates
    ///                           createdAtSince updatedAtSince publishAtSince ChapterListOrder includes[]
    /// </param>
    /// <returns></returns>
    [Get("/user/follows/manga/feed")]
    Task<ChapterListResponse?> GetLoggedUserFollowedMangaFeedAsync([Authorize] string token, FeedQuery? query = null);

    /// <summary>
    /// CustomList Manga feed
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id"></param>
    /// <param name="query">Support params: limit offset translatedLanguage[] originalLanguage[]
    ///                           excludedOriginalLanguage[] contentRating[] excludedGroups[] 
    ///                           excludedUploaders[] includeFutureUpdates
    ///                           createdAtSince updatedAtSince publishAtSince ChapterListOrder includes[]
    /// </param>
    /// <returns></returns>
    [Get("/list/{id}/feed")]
    Task<ChapterListResponse?>
        GetCustomListMangaFeedAsync([Authorize] string token, string id, FeedQuery? query = null);

    #endregion
}