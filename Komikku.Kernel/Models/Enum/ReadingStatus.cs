using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 漫画阅读状态
/// </summary>
public enum ReadingStatus
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 正在阅读
    /// </summary>
    Reading,

    /// <summary>
    /// 等一下
    /// </summary>
    [EnumMember(Value = "on_hold")]
    OnHold,

    /// <summary>
    /// 计划阅读
    /// </summary>
    [EnumMember(Value = "plan_to_read")]
    PlanToRead,

    /// <summary>
    /// 下降
    /// </summary>
    Dropped,

    /// <summary>
    /// 重读
    /// </summary>
    [EnumMember(Value = "re_reading")]
    Rereading,

    /// <summary>
    /// 完成
    /// </summary>
    Completed
}
