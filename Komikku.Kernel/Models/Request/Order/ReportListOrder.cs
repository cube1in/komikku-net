using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// ReportList 排序
/// default: createdAt: desc
/// </summary>
public class ReportListOrder
{
    /// <summary>
    /// 创建时间排序
    /// </summary>
    [AliasAs("createdAt]")]
    public OrderMode? CreatedAt { get; set; }
}