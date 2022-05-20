// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// <see cref="AtHome"/> 章节
/// </summary>
public class AtHomeChapter
{
    /// <summary>
    /// 哈希
    /// </summary>
    public string Hash { get; set; } = null!;

    /// <summary>
    /// 原始质量数据
    /// </summary>
    public IEnumerable<string> Data { get; set; } = null!;

    /// <summary>
    /// 压缩质量数据
    /// </summary>
    public IEnumerable<string> DataSaver { get; set; } = null!;
}
