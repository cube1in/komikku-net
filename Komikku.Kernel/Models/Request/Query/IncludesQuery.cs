using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class IncludesQuery : PaginationQuery
{
    [AliasAs("includes[]")]
    [Query(CollectionFormat.Multi)]
    public string[]? Includes { get; set; }
}