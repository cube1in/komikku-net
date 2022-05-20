using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 认证
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IAuthApi
{
    #region Anonymous

    /// <summary>
    /// Login
    /// 返回的 token 有两个
    /// 一个是有效期为 30 天的 <see cref="Token.Refresh"/>
    /// 一个是有效期为 15 分钟的 <see cref="Token.Session"/>
    /// </summary>
    /// <param name="login"></param>
    /// <returns></returns>
    [Post("/auth/login")]
    Task<LoginResponse?> LoginAsync([Body] Login login);

    /// <summary>
    /// Refresh token
    /// 使用 refreshToken 取得 sessionToken
    /// </summary>
    /// <param name="refreshToken">有效时长为30天的 token</param>
    /// <returns></returns>
    [Post("/auth/refresh")]
    Task<RefreshResponse?> RefreshAsync([Body] RefreshToken refreshToken);

    #endregion

    #region Authorization

    /// <summary>
    /// Logout
    /// </summary>
    /// <param name="token">Token</param>
    /// <returns></returns>
    [Post("/auth/logout")]
    Task<LogoutResponse> LogoutAsync([Authorize] string token);

    /// <summary>
    /// Check
    /// </summary>
    /// <param name="token">Token</param>
    /// <returns></returns>
    [Get("/auth/check")]
    Task<CheckResponse?> CheckAsync([Authorize] string token);

    #endregion
}