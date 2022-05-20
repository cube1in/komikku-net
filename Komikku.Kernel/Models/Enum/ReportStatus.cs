// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 报告状态
/// </summary>
public enum ReportStatus
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 等待
    /// </summary>
    Waiting,

    /// <summary>
    /// 已接受
    /// </summary>
    Accepted,

    /// <summary>
    /// 已拒绝
    /// </summary>
    Refused,

    /// <summary>
    /// 已自动处理
    /// </summary>
    Autoresolved
}
