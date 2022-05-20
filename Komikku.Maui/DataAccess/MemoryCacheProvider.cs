using Komikku.Persistence.Abstractions;
using Microsoft.Extensions.Caching.Memory;

namespace Komikku.Persistence;

/// <summary>
/// 缓存提供器
/// </summary>
public class MemoryCacheProvider : IMemoryCacheProvider
{
    /// <summary>
    /// Memory cache
    /// </summary>
    private readonly IMemoryCache _cache;

    /// <summary>
    /// 默认构造函数
    /// </summary>
    /// <param name="cache"></param>
    public MemoryCacheProvider(IMemoryCache cache)
    {
        _cache = cache;
    }

    /// <summary>
    /// 获取
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public object? Get(string key)
    {
        if (_cache.TryGetValue(key, out object value))
            return value;
        else
            return default;
    }

    /// <summary>
    /// 获取
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <returns></returns>
    public T? Get<T>(string key)
    {
        if (_cache.TryGetValue(key, out T value))
            return value;
        else
            return default;
    }


    /// <summary>
    /// 设置
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <param name="absoluteExpiry"></param>
    public void Set<T>(string key, T value, DateTimeOffset absoluteExpiry)
    {
        _cache.Set(key, value, absoluteExpiry);
    }

    /// <summary>
    /// 获取或创建
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <param name="factory"></param>
    /// <returns></returns>
    public T GetOrCreate<T>(string key, Func<ICacheEntry, T> factory)
    {
        return _cache.GetOrCreate(key, factory);
    }

    /// <summary>
    /// 获取或创建
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <param name="factory"></param>
    /// <returns></returns>
    public Task<T> GetOrCreateAsync<T>(string key, Func<ICacheEntry, Task<T>> factory)
    {
        return _cache.GetOrCreateAsync(key, factory);
    }

    /// <summary>
    /// 移除
    /// </summary>
    /// <param name="key"></param>
    public void Remove(string key)
    {
        _cache.Remove(key);
    }
}
