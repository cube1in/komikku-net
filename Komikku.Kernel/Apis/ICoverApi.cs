using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 封面
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface ICoverApi
{
    #region Anonymous

    /// <summary>
    /// Get Cover list
    /// </summary>
    /// <param name="query">Support Params: limit offset manga[] ids[] uploaders[] locales[] CoverListOrder</param>
    /// <returns></returns>
    [Get("/chapter")]
    Task<CoverListResponse?> GetCoverListAsync([Query("")] CoverListQuery? query = null);

    /// <summary>
    /// 获取封面
    /// </summary>
    /// <param name="mangaOrCoverId">漫画id或封面id</param>
    /// <param name="includes"></param>
    /// <returns></returns>
    [Get("/cover/{mangaOrCoverId}")]
    Task<CoverResponse?> GetCoverAsync(string mangaOrCoverId,
        [AliasAs("includes[]")] [Query(CollectionFormat.Multi)]
        string[]? includes = null);

    #endregion

    #region Authorization

    /// <summary>
    /// Upload Cover
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="mangaOrCoverId">Is Manga UUID on POST</param>
    /// <returns></returns>
    Task<Cover?> UploadCoverAsync([Authorize] string token, string mangaOrCoverId)
    {
        // TODO: Content-Type: multipart/form-data
        throw new NotImplementedException();
    }

    /// <summary>
    /// Update Cover
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="mangaOrCoverId">漫画id或封面id</param>
    /// <param name="edit">CoverEdit</param>
    /// <returns></returns>
    [Put("/cover/{mangaOrCoverId")]
    Task<CoverResponse?> UpdateCoverAsync([Authorize] string token, string mangaOrCoverId, [Body] CoverEdit edit);

    /// <summary>
    /// Delete Cover
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="mangaOrCoverId">漫画id或封面id</param>
    /// <returns></returns>
    [Delete("/cover/{mangaOrCoverId")]
    Task<Response> DeleteCoverAsync([Authorize] string token, string mangaOrCoverId);

    #endregion
}