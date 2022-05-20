// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 排除 Tag 的模式
/// 只用于查询，所以不会序列化和反序列化
/// </summary>
public enum ExcludedTagsMode
{
    /// <summary>
    /// 默认，并关系
    /// 注意：在 QueryString 中，此值为"AND"
    /// </summary>
    And,

    /// <summary>
    /// 或关系
    /// 注意：在 QueryString 中，此值为"OR"
    /// </summary>
    Or,
}