using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class AuthorListQuery : IncludesQuery
{
    [AliasAs("ids[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Ids { get; set; }

    [AliasAs("name")]
    public string? Name { get; set; }

    [AliasAs("order[")]
    public AuthorListOrder? Order { get; set; }
}