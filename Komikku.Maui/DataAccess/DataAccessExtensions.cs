using Komikku.Maui.DataAccess.Abstractions;
using Komikku.Persistence;
using Komikku.Persistence.Abstractions;
using Microsoft.Extensions.Caching.Memory;

namespace Komikku.Maui.DataAccess;

internal static class DataAccessExtensions
{
    /// <summary>
    /// 配置DataAccess
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static MauiAppBuilder ConfigureDataAccess(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<IFilePersistenceProvider, FilePersistenceProvider>();
        builder.Services.AddSingleton<IMemoryCache, MemoryCache>(builder => new MemoryCache(new MemoryCacheOptions { }));
        builder.Services.AddSingleton<IMemoryCacheProvider, MemoryCacheProvider>();
        builder.Services.AddSingleton<AuthorizeManager>();

        return builder;
    }
}
