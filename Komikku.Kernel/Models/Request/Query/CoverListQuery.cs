using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class CoverListQuery
{
    [AliasAs("manga[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Mangas { get; set; }

    [AliasAs("ids[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Ids { get; set; }

    [AliasAs("uploaders[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Uploaders { get; set; }

    [AliasAs("locales[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Locales { get; set; }

    [AliasAs("order[")]
    public CoverListOrder? Order { get; set; }
}