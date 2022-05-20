using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 首页
/// </summary>
public class AtHomeApiTest
{
    private readonly IAtHomeApi _atHomeApi = RestService.For<IAtHomeApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Theory]
    // 哥布林杀手章节
    [InlineData("00e59e41-eebd-4349-86a3-1543ebd35a1f")]
    internal async void HomeServerTest(string chapterId)
    {
        var atHome = await _atHomeApi.GetHomeServerUrlAsync(chapterId);
        Assert.NotNull(atHome);
    }
}
