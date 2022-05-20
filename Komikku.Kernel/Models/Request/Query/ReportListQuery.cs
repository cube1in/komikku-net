using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ReportListQuery : PaginationQuery
{
    [AliasAs("reportCategory")]
    public ReportCategory? ReportCategory { get; set; }

    [AliasAs("reportStatus")]
    public ReportStatus? ReportStatus { get; set; }

    [AliasAs("order[")]
    public ReportListOrder? Order { get; set; }
}