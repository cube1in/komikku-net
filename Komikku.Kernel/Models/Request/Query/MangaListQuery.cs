using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaListQuery : IncludesQuery
{
    [AliasAs("title")]
    public string? Title { get; set; }

    [AliasAs("authors[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Authors { get; set; }

    [AliasAs("artists[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Artists { get; set; }

    [AliasAs("year")]
    public int? Year { get; set; }

    [AliasAs("includedTags[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? IncludedTags { get; set; }

    [AliasAs("includedTagsMode")]
    public IncludedTagsMode? IncludedTagsMode { get; set; }

    [AliasAs("excludedTags[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? ExcludedTags { get; set; }

    [AliasAs("excludedTagsMode")]
    public ExcludedTagsMode? ExcludedTagsMode { get; set; }

    [AliasAs("status[]")]
    [Query(CollectionFormat.Multi)]
    public Status[]? Status { get; set; }

    [AliasAs("originalLanguage[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? OriginalLanguages { get; set; }

    [AliasAs("excludedOriginalLanguage[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? ExcludedOriginalLanguages { get; set; }

    [AliasAs("availableTranslatedLanguage[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? AvailableTranslatedLanguages { get; set; }

    [AliasAs("publicationDemographic[]")]
    [Query(CollectionFormat.Multi)]
    public PublicationDemographic[]? PublicationDemographics { get; set; }

    [AliasAs("ids[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Ids { get; set; }

    [AliasAs("contentRating[]")]
    [Query(CollectionFormat.Multi)]
    public ContentRating[]? ContentRatings { get; set; }

    [AliasAs("createdAtSince")]
    [Query(Format = "YYYY-MM-DDTHH:MM:SS")]
    public DateTime? CreatedAtSince { get; set; }

    [AliasAs("updatedAtSince")]
    [Query(Format = "YYYY-MM-DDTHH:MM:SS")]
    public DateTime? UpdatedAtSince { get; set; }

    [AliasAs("order[")]
    public MangaListOrder? Order { get; set; }

    [AliasAs("hasAvailableChapters")]
    public bool? HasAvailableChapters { get; set; }

    [AliasAs("group")]
    public string? Group { get; set; }
}