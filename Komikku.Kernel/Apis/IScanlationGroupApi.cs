using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 扫描组
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IScanlationGroupApi
{
    #region Anonymous

    /// <summary>
    /// Get scanlation group list
    /// </summary>
    /// <param name="query">Support params: limit offset ids[] name focusedLanguage includes[]</param>
    /// <returns></returns>
    [Get("/group")]
    Task<ScanlationGroupListResponse?> GetScanlationGroupListAsync([Query("")] ScanlationGroupListQuery? query = null);

    /// <summary>
    /// Get scanlation group
    /// </summary>
    /// <param name="id">Scanlation Group ID</param>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/group/{id}")]
    Task<ScanlationGroupResponse?>
        GetScanlationGroupAsync(string id,
            [AliasAs("includes[]")] [Query(CollectionFormat.Multi)] string[]? includes = null);

    #endregion

    #region Authorization

    /// <summary>
    /// Create a scanlation group
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="create">CreateScanlationGroup</param>
    /// <returns></returns>
    [Post("/group")]
    Task<ScanlationGroupResponse?> CreateScanlationGroupAsync([Authorize] string token,
        [Body] CreateScanlationGroup create);

    /// <summary>
    /// Update scanlation group
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Scanlation Group ID</param>
    /// <param name="edit">ScanlationGroupEdit</param>
    /// <returns></returns>
    [Put("/group/{id}")]
    Task<ScanlationGroupResponse?> UpdateScanlationGroupAsync([Authorize] string token, string id,
        [Body] ScanlationGroupEdit edit);

    /// <summary>
    /// Delete scanlation group
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Scanlation Group ID</param>
    /// <returns></returns>
    [Delete("/group/{id}")]
    Task<Response> DeleteScanlationGroupAsync([Authorize] string token, string id);

    /// <summary>
    /// Follow scanlation group
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Scanlation Group ID</param>
    /// <returns></returns>
    [Post("/group/{id}/follow")]
    Task<Response> FollowScanlationGroupAsync([Authorize] string token, string id);

    /// <summary>
    /// Unfollow scanlation group
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Scanlation Group ID</param>
    /// <returns></returns>
    [Delete("/group/{id}/follow")]
    Task<Response> UnfollowScanlationGroupAsync([Authorize] string token, string id);

    #endregion
}