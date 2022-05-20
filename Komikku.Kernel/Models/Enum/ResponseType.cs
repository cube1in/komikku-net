// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 响应类型
/// 只在 <see cref="Result.Ok"/> 状态下
/// </summary>
public enum ResponseType
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 实体
    /// </summary>
    Entity,

    /// <summary>
    /// 集合
    /// </summary>
    Collection
}
