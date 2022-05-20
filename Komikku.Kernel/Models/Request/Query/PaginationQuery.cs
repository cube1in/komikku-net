using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class PaginationQuery
{
    [AliasAs("limit")]
    public int? Limit { get; set; }

    [AliasAs("offset")]
    public int? Offset { get; set; }
}