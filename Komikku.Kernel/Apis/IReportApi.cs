using Komikku.Kernel.Models;
using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Apis;

/// <summary>
/// 报告
/// </summary>
[Headers("Content-Type: application/json", "Accept: application/json")]
public interface IReportApi
{
    #region Authorization

    /// <summary>
    /// Get a list of report reasons
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="report">ReportCategory</param>
    /// <returns></returns>
    [Get("/report/reasons/{category}")]
    Task<ReportReasonsListResponse?> GetReportReasonsListAsync([Authorize] string token, ReportCategory report);

    /// <summary>
    /// Get a list of reports by the user
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="query">Support Params: limit offset ReportCategory ReportStatus ReportListOrder</param>
    /// <returns></returns>
    [Get("/report")]
    Task<ReportListResponse?> GetReportListAsync([Authorize] string token, [Query("")] ReportListQuery? query = null);

    /// <summary>
    /// Create a new Report
    /// </summary>
    /// <param name="token">Token</param>
    /// <param name="create">ReportCreate</param>
    /// <returns></returns>
    [Post("/report")]
    Task<Response> CreateReportAsync([Authorize] string token, [Body] ReportCreate create);

    #endregion
}