using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 用户
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IUserApi
{
    #region Anonymous

    /// <summary>
    /// Get User
    /// </summary>
    /// <param name="id">User ID</param>
    /// <returns></returns>
    [Get("/user/{id}")]
    Task<UserResponse?> GetUserAsync(string id);

    /// <summary>
    /// Approve User deletion
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    [Post("/user/delete/{code}")]
    Task<Response> ApproveUserDeletionAsync(string code);

    #endregion

    #region Authorization

    /// <summary>
    /// Get User list
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support Params: limit offset ids[] username UserListOrder</param>
    /// <returns></returns>
    [Get("/user")]
    Task<UserListResponse?> GetUserListAsync([Authorize] string token, [Query("")] UserListQuery? query = null);

    /// <summary>
    /// Get logged User details
    /// </summary>
    /// <param name="token">Token</param>
    /// <returns></returns>
    [Get("/user/me")]
    Task<UserResponse?> GetLoggedUserDetailsAsync([Authorize] string token);

    /// <summary>
    /// Update User password
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="edit">UpdateUserPassword</param>
    /// <returns></returns>
    [Post("/user/password")]
    Task<Response> UpdateUserPasswordAsync([Authorize] string token, [Body] UserPasswordEdit edit);

    /// <summary>
    /// Update User email
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="edit">UpdateUserEmail</param>
    /// <returns></returns>
    [Post("/user/email")]
    Task<Response> UpdateUserEmailAsync([Authorize] string token, [Body] UserEmailEdit edit);

    /// <summary>
    /// Delete User
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/user/{id}")]
    Task<Response> DeleteUserAsync([Authorize] string token, string id);

    #endregion
}