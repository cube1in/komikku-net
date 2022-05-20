using Refit;
// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class AtSinceQuery : IncludesQuery
{
    [AliasAs("createdAtSince")]
    [Query(Format = "YYYY-MM-DDTHH:MM:SS")]
    public DateTime? CreatedAtSince { get; set; }

    [AliasAs("updatedAtSince")]
    [Query(Format = "YYYY-MM-DDTHH:MM:SS")]
    public DateTime? UpdatedAtSince { get; set; }

    [AliasAs("publishAtSince")]
    [Query(Format = "YYYY-MM-DDTHH:MM:SS")]
    public DateTime? PublishAtSince { get; set; }
}