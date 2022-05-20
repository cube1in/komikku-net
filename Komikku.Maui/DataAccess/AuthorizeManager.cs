using Komikku.Kernel;
using Komikku.Kernel.Apis;
using Komikku.Maui.DataAccess.Abstractions;
using Komikku.Persistence.Abstractions;
using Refit;

namespace Komikku.Maui.DataAccess;

public class AuthorizeManager
{
    /// <summary>
    /// 用户认证提供器
    /// </summary>
    private readonly IAuthApi _authApi;

    /// <summary>
    /// 内存缓存提供器
    /// </summary>
    private readonly IMemoryCacheProvider _memoryCacheProvider;

    /// <summary>
    /// 文件持久化提供器
    /// </summary>
    private readonly IFilePersistenceProvider _filePersistenceProvider;

    public AuthorizeManager(IMemoryCacheProvider memoryCacheProvider, IFilePersistenceProvider filePersistenceProvider)
    {
        _memoryCacheProvider = memoryCacheProvider;
        _filePersistenceProvider = filePersistenceProvider;
        _authApi = RestService.For<IAuthApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);
    }

    public async Task<bool> IsLoginAsync()
    {
        return _memoryCacheProvider.Get<string>(AppSettings.SessionToken) != null ||
            await _filePersistenceProvider.GetTokenAsync(Path.Combine(AppSettings.PersonalFolder, AppSettings.RefreshToken)) != null;
    }

    public async Task<string?> GetTokenAsync()
    {
        var token = _memoryCacheProvider.Get<string>(AppSettings.SessionToken);
        if (token == null)
        {
            var refresh = await _filePersistenceProvider.GetTokenAsync(Path.Combine(AppSettings.PersonalFolder, AppSettings.RefreshToken));
            if (refresh != null && refresh.Expire > DateTimeOffset.Now)
            {
                var response = await _authApi.RefreshAsync(new Kernel.Models.RefreshToken { Token = refresh.Token });
                if (response != null) token = response.Token.Session;
            }
        }

        return token;
    }

    public async Task CacheSessionAsync(string session)
    {
        await Task.FromResult(() => _memoryCacheProvider.Set(AppSettings.SessionToken, session, AppSettings.SessionTokenExpireTime));
    }

    public async Task SetRefrshAsync(string refresh)
    {
        await _filePersistenceProvider.SetTokenAsync(Path.Combine(AppSettings.PersonalFolder, AppSettings.RefreshToken), new Models.RefreshToken
        {
            Token = refresh,
            Expire = AppSettings.RefreshTokenExpireTime
        });
    }

    public async Task LogoutAsync()
    {
        _memoryCacheProvider.Remove(AppSettings.SessionToken);
        await _filePersistenceProvider.RemoveTokenAsync(Path.Combine(AppSettings.PersonalFolder, AppSettings.RefreshToken));
    }
}
