using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 作者
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IAuthorApi
{
    #region Anonymous

    /// <summary>
    /// Get Author list
    /// </summary>
    /// <param name="query">Support Params: limit offset ids[] name AuthorListOrder includes[]</param>
    /// <returns></returns>
    [Get("/author")]
    Task<AuthorListResponse?> GetAuthorListAsync([Query("")] AuthorListQuery? query = null);

    /// <summary>
    /// Get Author by id
    /// </summary>
    /// <param name="id">Author ID</param>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/author/{id}")]
    Task<AuthorResponse?> GetAsync(string id,
        [AliasAs("includes[]")] [Query(CollectionFormat.Multi)]
        string[]? includes = null);

    #endregion

    #region Authorization

    /// <summary>
    /// Create Author
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="create">AuthorCreate</param>
    /// <returns></returns>
    [Post("/author")]
    Task<AuthorResponse?> CreateAuthorAsync([Authorize] string token, [Body] AuthorCreate create);

    /// <summary>
    /// Update Author
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Author ID</param>
    /// <param name="edit">AuthorEdit</param>
    /// <returns></returns>
    [Put("/author/{id}")]
    Task<AuthorResponse?> UpdateAuthorAsync([Authorize] string token, string id, [Body] AuthorEdit edit);

    /// <summary>
    /// Delete Author
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id">Author ID</param>
    /// <returns></returns>
    [Delete("/author/{id}")]
    Task<Response> DeleteAuthorAsync([Authorize] string token, string id);

    #endregion
}