using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

public class FeedApiTest : BaseForTest
{
    private readonly IFeedApi _feedApi = RestService.For<IFeedApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Fact]
    internal async void UserFollowedTest()
    {
        var chapterList = await _feedApi.GetLoggedUserFollowedMangaFeedAsync(Token);
        Assert.NotNull(chapterList);
    }

    [Theory]
    [InlineData("")]
    internal async void GetCustomListTest(string id)
    {
        var chapterList = await _feedApi.GetCustomListMangaFeedAsync(Token, id);
        Assert.NotNull(chapterList);
    }
}