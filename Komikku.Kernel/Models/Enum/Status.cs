// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 漫画状态
/// </summary>
public enum Status
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 漫画还在继续
    /// </summary>
    Ongoing,

    /// <summary>
    /// 漫画完成了
    /// </summary>
    Completed,

    /// <summary>
    /// 漫画暂停了
    /// </summary>
    Hiatus,

    /// <summary>
    /// 漫画被取消了
    /// </summary>
    Cancelled
}
