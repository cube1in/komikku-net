using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class FeedQuery : UsualQuery
{
    [AliasAs("contentRating[]")]
    [Query(CollectionFormat.Multi)]
    public ContentRating[]? ContentRatings { get; set; }
}