using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 自定义列表
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface ICustomListApi
{
    #region Anonymous

    /// <summary>
    /// Get CustomList
    /// </summary>
    /// <param name="id">CustomList ID</param>
    /// <returns></returns>
    [Get("/list/{id}")]
    Task<CustomListResponse?> GetCustomListAsync(string id);

    /// <summary>
    /// Get user's CustomList list
    /// This only will list public CustomList
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns></returns>
    [Get("/user/{id}/list")]
    Task<CustomListListResponse?> GetUserCustomListListAsync(string id);

    #endregion

    #region Authorization

    /// <summary>
    /// Get logged User CustomList list
    /// This will list public and private CustomList
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support Params: limit offset</param>
    /// <returns></returns>
    [Get("/user/list")]
    Task<CustomListListResponse?> GetLoggedUserCustomListListAsync([Authorize] string token,
        PaginationQuery? query = null);

    /// <summary>
    /// Create CustomList
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="create">CustomListCreate</param>
    /// <returns></returns>
    [Post("/list")]
    Task<CustomListResponse?> CreateCustomListAsync([Authorize] string token, [Body] CustomListCreate create);

    /// <summary>
    /// Update CustomList
    /// </summary>
    /// <param name="edit">CustomListEdit</param>
    /// <param name="token">Token</param>
    /// <param name="id">CustomList ID</param>
    /// <returns></returns>
    [Put("/list/{id}")]
    Task<CustomListResponse?> UpdateCustomListAsync([Authorize] string token, string id, [Body] CustomListEdit edit);

    /// <summary>
    /// Delete CustomList
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">CustomList ID</param>
    /// <returns></returns>
    [Delete("/list/{id}")]
    Task<Response> DeleteCustomListAsync([Authorize] string token, string id);

    /// <summary>
    /// Add Manga in CustomList
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <param name="listId">CustomList ID</param>
    /// <returns></returns>
    [Post("/manga/{id}/list/{listId}")]
    Task<Response> AddMangaInCustomListAsync([Authorize] string token, string id, string listId);

    /// <summary>
    /// Remove Manga in CustomList
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Manga ID</param>
    /// <param name="listId">CustomList ID</param>
    /// <returns></returns>
    [Delete("/manga/{id}/list/{listId}")]
    Task<Response> RemoveMangaInCustomListAsync([Authorize] string token, string id, string listId);

    #endregion
}