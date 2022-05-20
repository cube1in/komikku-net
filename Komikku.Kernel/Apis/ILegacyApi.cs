using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 遗产
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface ILegacyApi
{
    /// <summary>
    /// Legacy ID mapping
    /// </summary>
    /// <param name="body">MappingIdBody</param>
    /// <returns></returns>
    [Post("/legacy/mapping")]
    Task<MappingIdListResponse?> CreateLegacyAsync([Body] MappingIdBody body);
}