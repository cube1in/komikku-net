using Komikku.Kernel.Models;
using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

public class MangaApiTest : BaseForTest
{
    private readonly IMangaApi _mangaApi = RestService.For<IMangaApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Fact]
    internal async void MangaListTest()
    {
        var mangaList = await _mangaApi.GetMangaListAsync();
        Assert.NotNull(mangaList);
    }

    [Theory]
    [InlineData(5)]
    internal async void MangeListWithIntegerTest(int limit)
    {
        var mangaList = await _mangaApi.GetMangaListAsync();

        Assert.NotNull(mangaList);
        Assert.Equal(limit, mangaList.Data.Count());
    }

    [Theory]
    [InlineData("b6a5d154-7845-4129-b473-ba0aec3deffd")]
    internal async void MangaTest(string id)
    {
        var manga = await _mangaApi.GetMangaAsync(id, new[] {"cover_art", "author"});
        Assert.NotNull(manga);
    }

    [Theory]
    [InlineData("1389d660-b9b1-4c6a-81af-eab4dbf3f22b")]
    internal async void MangaAggregateTest(string id)
    {
        var aggregate = await _mangaApi.GetMangaAggregateAsync(id);
        Assert.NotNull(aggregate);
    }

    [Theory]
    [InlineData("1389d660-b9b1-4c6a-81af-eab4dbf3f22b")]
    internal async void MangaFeedTest(string id)
    {
        var chapterList = await _mangaApi.GetMangaFeedAsync(id);
        Assert.NotNull(chapterList);
    }

    [Fact]
    internal async void RandomMangaTest()
    {
        var manga = await _mangaApi.GetRandomMangaAsync();
        Assert.NotNull(manga);
    }

    [Fact]
    internal async void TagListTest()
    {
        var tags = await _mangaApi.GetTagListAsync();
        Assert.NotNull(tags);
    }

    [Theory]
    [InlineData("d785280c-04d2-4194-87d7-857fb72f1038")]
    internal async void FollowMangaTest(string id)
    {
        var result = await _mangaApi.FollowMangaAsync(Token, id);
        Assert.NotNull(result);
    }

    [Theory]
    [InlineData("d785280c-04d2-4194-87d7-857fb72f1038")]
    internal async void UnfollowMangaTest(string id)
    {
        var result = await _mangaApi.UnfollowMangaAsync(Token, id);
        Assert.NotNull(result);
    }

    [Theory]
    [InlineData("1389d660-b9b1-4c6a-81af-eab4dbf3f22b")]
    internal async void MangaReadingStatusTest(string id)
    {
        var status = await _mangaApi.GetMangaReadingStatusAsync(Token, id);

        // Noting to check, "null" if unfollow, "not null" if follow
    }

    [Theory]
    [InlineData("1389d660-b9b1-4c6a-81af-eab4dbf3f22b")]
    internal async void UpdateMangaReadingStatusTest(string id)
    {
        var result = await _mangaApi.UpdateMangaReadingStatusAsync(Token, id, new() {Status = ReadingStatus.Rereading});
        Assert.NotNull(result);
    }
}