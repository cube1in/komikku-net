using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;
public enum ReportCategory
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 漫画
    /// </summary>
    Manga,

    /// <summary>
    /// 扫描组
    /// </summary>
    [EnumMember(Value = "scanlation_group")]
    ScanlationGroup,

    /// <summary>
    /// 用户
    /// </summary>
    User,

    /// <summary>
    /// 作者
    /// </summary>
    Author
}