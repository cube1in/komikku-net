using Komikku.Kernel.Models;
using Refit;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 章节
/// </summary>
public class ChapterApiTest
{
    private readonly IChapterApi _chapterApi = RestService.For<IChapterApi>(KernelSettings.ServerUrl, KernelSettings.RefitSettings);

    [Fact]
    internal async void ChapterListTest()
    {
        var query = new ChapterListQuery
        {
            Limit = 10,
            Offset = 0,
            ContentRatings = new[] { ContentRating.Safe, ContentRating.Suggestive, ContentRating.Erotica, ContentRating.Pornographic },
            TranslatedLanguages = new[] { "zh", "zh-hk" },
            Includes = new[] { "manga", "scanlation_group" },
            Order = new ChapterListOrder { ReadableAt = OrderMode.Desc }
        };

        var chapter = await _chapterApi.GetChapterListAsync(query);
        Assert.NotNull(chapter);
    }

    [Theory]
    [InlineData("6f477c16-c05a-4a5c-8441-a18ae9209eb5")]
    internal async void ChapterTest(string id)
    {
        var chapter = await _chapterApi.GetChapterAsync(id);
        Assert.NotNull(chapter);
    }
}
