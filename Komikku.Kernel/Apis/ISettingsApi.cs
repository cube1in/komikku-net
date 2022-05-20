using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 设置
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface ISettingsApi
{
    #region Authorization

    /// <summary>
    /// Get latest Settings template
    /// </summary>
    /// <param name="token">Token</param>
    /// <returns></returns>
    [Get("/settings/template")]
    Task<string?> GetLatestSettingsTemplateAsync([Authorize] string token);

    /// <summary>
    /// Create settings template
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="jsonSchema">A JSON Schema to validate settings</param>
    /// <returns></returns>
    [Post("/settings/template")]
    Task<string?> CreateSettingsTemplateAsync([Authorize] string token, string jsonSchema);

    /// <summary>
    /// Get Settings template by version id
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="version">Version ID</param>
    /// <returns></returns>
    [Get("/settings/template/{version}")]
    Task<string?> GetSettingsTemplateByVersionIdAsync([Authorize] string token, string version);

    /// <summary>
    /// Get an User Settings
    /// </summary>
    /// <param name="token">Token</param>
    /// <returns></returns>
    [Get("/settings")]
    Task<UserSettingsResponse?> GetUserSettingsAsync([Authorize] string token);

    #endregion
}