using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

public interface IPingApi
{
    /// <summary>
    /// Ping server
    /// </summary>
    /// <returns></returns>
    [Get("/ping")]
    Task<string> PingAsync();
}
