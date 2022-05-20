using Microsoft.Extensions.Caching.Memory;

namespace Komikku.Persistence.Abstractions;

/// <summary>
/// 缓存提供器
/// </summary>
public interface IMemoryCacheProvider
{
    /// <summary>
    /// 获取
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    object? Get(string key);

    /// <summary>
    /// 获取
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <returns></returns>
    T? Get<T>(string key);

    /// <summary>
    /// 设置
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <returns></returns>
    void Set<T>(string key, T value, DateTimeOffset absoluteExpiry);

    /// <summary>
    /// 获取或创建
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <param name="factory"></param>
    /// <returns></returns>
    T GetOrCreate<T>(string key, Func<ICacheEntry, T> factory);

    /// <summary>
    /// 获取或创建
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <param name="factory"></param>
    /// <returns></returns>
    Task<T> GetOrCreateAsync<T>(string key, Func<ICacheEntry, Task<T>> factory);

    /// <summary>
    /// 移除
    /// </summary>
    /// <param name="key"></param>
    void Remove(string key);
}
