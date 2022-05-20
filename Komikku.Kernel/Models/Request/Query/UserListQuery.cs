using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class UserListQuery : IncludesQuery
{
    [AliasAs("ids[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Ids { get; set; }

    [AliasAs("username")]
    public string? Username { get; set; }

    [AliasAs("order[")]
    public UserListOrder? Order { get; set; }
}