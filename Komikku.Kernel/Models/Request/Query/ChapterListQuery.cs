using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ChapterListQuery : UsualQuery
{
    [AliasAs("ids[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Ids { get; set; }

    [AliasAs("title")]
    public string? Title { get; set; }

    [AliasAs("groups[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Groups { get; set; }

    [AliasAs("uploader")]
    public string? Uploader { get; set; }

    [AliasAs("manga")]
    public string? Manga { get; set; }

    [AliasAs("volume[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Volumes { get; set; }

    [AliasAs("chapter")]
    public string? Chapter { get; set; }

    [AliasAs("contentRating[]")]
    [Query(CollectionFormat.Multi)]
    public ContentRating[]? ContentRating { get; set; }

    [AliasAs("order[")]
    public ChapterListOrder? Order { get; set; }
}