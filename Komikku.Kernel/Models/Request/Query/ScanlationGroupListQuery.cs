using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ScanlationGroupListQuery : IncludesQuery
{
    [AliasAs("ids[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Ids { get; set; }

    [AliasAs("name")]
    public string? Name { get; set; }

    [AliasAs("focusedLanguage")]
    public string[]? FocusedLanguage { get; set; }

    [AliasAs("order[")]
    public ScanlationGroupListOrder? Order { get; set; }
}