using Komikku.Kernel.Models;
using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 跟随
/// </summary>
public class FollowsApiTest : BaseForTest
{
    private readonly IFollowsApi _followsApi = RestService.For<IFollowsApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Fact]
    internal async void UserFollowedMangaListTest()
    {
        var query = new IncludesQuery
        {
            Includes = new[] {"cover_art"}
        };
        var mangaList = await _followsApi.GetUserFollowedMangaListAsync(Token, query);
        Assert.NotNull(mangaList);
    }

    [Theory]
    [InlineData("1389d660-b9b1-4c6a-81af-eab4dbf3f22b")]
    internal async void CheckUserFollowsMangaTest(string id)
    {
        var result = await _followsApi.CheckUserFollowsMangaAsync(Token, id);
    }
}