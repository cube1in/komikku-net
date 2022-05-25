using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaFeedQuery : UsualQuery
{
    [AliasAs("order[")]
    public MangaFeedOrder? Order { get; set; }

    [AliasAs("contentRating[]")]
    [Query(CollectionFormat.Multi)]
    public ContentRating[]? ContentRatings { get; set; }
}