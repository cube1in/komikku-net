using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 跟随
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IFollowsApi
{
    #region Authorization

    /// <summary>
    /// Get logged User followed Groups
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support Params: limit offset includes[]</param>
    /// <returns></returns>
    [Get("/user/follows/group")]
    Task<ScanlationGroupListResponse?> GetLoggedUserFollowedGroupListAsync([Authorize] string token,
        IncludesQuery? query = null);

    /// <summary>
    /// Check if logged User follows a Group
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Scanlation Group ID</param>
    /// <returns></returns>
    [Get("/user/follows/group/{id}")]
    Task<Response> CheckUserFollowsGroupAsync([Authorize] string token, string id);

    /// <summary>
    /// Get logged User followed User list
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support Params: limit offset includes[]</param>
    /// <returns></returns>
    [Get("/user/follows/user")]
    Task<UserListResponse?> GetLoggedUserFollowedUserList([Authorize] string token, IncludesQuery? query = null);

    /// <summary>
    /// Check if logged User follows a User
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Scanlation Group ID</param>
    /// <returns></returns>
    [Get("/user/follows/user/{id}")]
    Task<Response> CheckUserFollowsUserAsync([Authorize] string token, string id);

    /// <summary>
    /// 获取用户订阅的漫画列表
    /// Get logged User followed Manga list
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support params: limit offset includes[]</param>
    /// <returns></returns>
    [Get("/user/follows/manga")]
    Task<MangaListResponse?> GetUserFollowedMangaListAsync([Authorize] string token, IncludesQuery? query = null);

    /// <summary>
    /// 检测用户是否订阅某本漫画
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <returns></returns>
    [Get("/user/follows/manga/{id}")]
    Task<Response> CheckUserFollowsMangaAsync([Authorize] string token, string id);

    #endregion
}