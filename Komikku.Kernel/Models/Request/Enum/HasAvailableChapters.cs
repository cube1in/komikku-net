// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 是否有可用章节
/// 只用于查询，所以不会序列化和反序列化
/// </summary>
public enum HasAvailableChapters
{
    /// <summary>
    /// 默认，有
    /// </summary>
    True,

    /// <summary>
    /// 没有
    /// </summary>
    False
}
