using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 上传
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IUploadApi
{
    #region Authorization

    /// <summary>
    /// Get the current User upload session
    /// </summary>
    /// <param name="token">Token</param>
    /// <returns></returns>
    [Get("/upload")]
    Task<UploadSession?> GetCurrentUploadSessionAsync([Authorize] string token);

    /// <summary>
    /// Start an upload session
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="upload">BeginUploadSession</param>
    /// <returns></returns>
    [Post("/upload/begin")]
    Task<UploadSession?> BeginUploadSessionAsync([Authorize] string token, [Body] BeginUploadSession upload);

    /// <summary>
    /// Start an edit chapter session
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="chapterId">Chapter ID</param>
    /// <param name="edit">BeginEditSession</param>
    /// <returns></returns>
    [Post("/upload/begin/{chapterId}")]
    Task<UploadSession?> BeginEditChapterSessionAsync([Authorize] string token, string chapterId,
        [Body] BeginEditSession edit);

    /// <summary>
    /// Upload images to the upload session
    /// upload/{uploadSessionId}
    /// TODO: multipart/form-data
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="uploadSessionId"></param>
    /// <returns></returns>
    [Post("upload/{uploadSessionId}")]
    Task UploadImagesToUploadSessionAsync([Authorize] string token, string uploadSessionId);

    /// <summary>
    /// Abandon upload session
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="uploadSessionId"></param>
    /// <returns></returns>
    [Delete("upload/{uploadSessionId}")]
    Task<Response> AbandonUploadSessionAsync([Authorize] string token, string uploadSessionId);

    /// <summary>
    /// Commit the upload session and specify chapter data
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="uploadSessionId">UploadSession ID</param>
    /// <param name="commit">CommitUploadSession</param>
    /// <returns></returns>
    [Post("/upload/{uploadSessionId}/commit")]
    Task<Chapter?> CommitUploadSessionAsync([Authorize] string token, string uploadSessionId,
        [Body] CommitUploadSession commit);

    /// <summary>
    /// Delete an uploaded image from the Upload Session
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="uploadSessionId">UploadSession ID</param>
    /// <param name="uploadSessionFileId">UploadSessionFile ID</param>
    /// <returns></returns>
    [Delete("/upload/{uploadSessionId}/{uploadSessionFileId}")]
    Task<Response> DeleteUploadedImageAsync([Authorize] string token, string uploadSessionId,
        string uploadSessionFileId);

    /// <summary>
    /// Delete a set of uploaded images from the Upload Session
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="uploadSessionId"></param>
    /// <returns></returns>
    [Delete("/upload/{uploadSessionId}/batch")]
    Task<Response> DeleteUploadedImageBatchAsync([Authorize] string token, string uploadSessionId);

    #endregion
}