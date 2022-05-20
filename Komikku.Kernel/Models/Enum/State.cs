// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 发布状态
/// </summary>
public enum State
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 草稿
    /// </summary>
    Draft,

    /// <summary>
    /// 已提交
    /// </summary>
    Submitted,

    /// <summary>
    /// 已发表
    /// </summary>
    Published,

    /// <summary>
    /// 已拒绝
    /// </summary>
    Rejected
}
