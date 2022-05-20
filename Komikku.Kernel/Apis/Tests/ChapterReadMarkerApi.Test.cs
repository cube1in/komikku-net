using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 章节阅读标记
/// </summary>
public class ChapterReadMarkerApiTest : BaseForTest
{
    private readonly IChapterReadMarkerApi _chapterReadMarkerApi =
        RestService.For<IChapterReadMarkerApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Theory]
    [InlineData("1389d660-b9b1-4c6a-81af-eab4dbf3f22b", "67a7dfd1-a39d-46c8-8ff2-9a24a9abaeb6")]
    internal async void ManyMangaReadMarkersTest(string id1, string id2)
    {
        var ids = new[] {id1, id2};
        var readMarkers = await _chapterReadMarkerApi.GetMangaReadMarkersAsync(Token, ids, true);
        Assert.NotNull(readMarkers);
    }

    [Theory]
    [InlineData("1389d660-b9b1-4c6a-81af-eab4dbf3f22b")]
    internal async void SingleMangaReadMarkersTest(string id)
    {
        var readMarkers = await _chapterReadMarkerApi.GetMangaReadMarkersAsync(Token, id);
        Assert.NotNull(readMarkers);
    }
}