using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaAggregateQuery
{
    [AliasAs("translatedLanguage[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? TranslatedLanguages { get; set; }

    [AliasAs("groups[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Groups { get; set; }
}