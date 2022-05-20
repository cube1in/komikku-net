using Komikku.Kernel;
using Komikku.Maui.DataAccess.Abstractions;
using Komikku.Maui.DataAccess.Models;
using Newtonsoft.Json;

namespace Komikku.Maui.DataAccess;

public class FilePersistenceProvider : IFilePersistenceProvider
{
    public async Task SetTokenAsync(string path, RefreshToken token)
    {
        var jsonString = JsonConvert.SerializeObject(token, KernelSettings.SerializerSettings);
        await File.WriteAllTextAsync(path, jsonString);
    }

    public async Task<RefreshToken?> GetTokenAsync(string path)
    {
        if (!File.Exists(path)) return null;

        var token = await File.ReadAllTextAsync(path);
        return JsonConvert.DeserializeObject<RefreshToken>(token, KernelSettings.SerializerSettings);
    }

    public async Task RemoveTokenAsync(string path)
    {
        if (File.Exists(path)) await Task.FromResult(() => File.Delete(path));
    }
}
