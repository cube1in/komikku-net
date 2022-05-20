using Komikku.Maui.DataAccess.Models;

namespace Komikku.Maui.DataAccess.Abstractions;

/// <summary>
/// 文件持久化提供器
/// </summary>
public interface IFilePersistenceProvider
{
    /// <summary>
    /// 设置刷新令牌
    /// </summary>
    /// <param name="path">路径</param>
    /// <param name="token">刷新令牌</param>
    /// <returns></returns>
    Task SetTokenAsync(string path, RefreshToken token);

    /// <summary>
    /// 获取刷新令牌
    /// </summary>
    /// <param name="path">路径</param>
    /// <returns></returns>
    Task<RefreshToken?> GetTokenAsync(string path);

    /// <summary>
    /// 移除刷新令牌
    /// </summary>
    /// <param name="path">路径</param>
    /// <returns></returns>
    Task RemoveTokenAsync(string path);
}
