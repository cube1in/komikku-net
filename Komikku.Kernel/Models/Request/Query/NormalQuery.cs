using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class UsualQuery : AtSinceQuery
{
    [AliasAs("translatedLanguage[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? TranslatedLanguage { get; set; }

    [AliasAs("originalLanguage[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? OriginalLanguage { get; set; }

    [AliasAs("excludedOriginalLanguage[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? ExcludedOriginalLanguage { get; set; }

    [AliasAs("excludedGroups[]")]
    [Query(CollectionFormat.Multi)]
    public string? ExcludedGroups { get; set; }

    [AliasAs("excludedUploaders[]")]
    [Query(CollectionFormat.Multi)]
    public string? ExcludedUploaders { get; set; }

    [AliasAs("includeFutureUpdates")]
    [Query(CollectionFormat.Multi)]
    public int? IncludeFutureUpdates { get; set; }
}