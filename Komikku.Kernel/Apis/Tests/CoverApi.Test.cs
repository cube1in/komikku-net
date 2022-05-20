using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

public class CoverApiTest
{
    private readonly ICoverApi _coverApi = RestService.For<ICoverApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Theory]
    [InlineData("")]
    internal async void CoverTest(string mangaOrCoverId)
    {
        var cover = await _coverApi.GetCoverAsync(mangaOrCoverId);
        Assert.NotNull(cover);
    }
}
