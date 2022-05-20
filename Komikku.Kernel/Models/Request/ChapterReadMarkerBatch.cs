// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 批量更新章节阅读标记请求
/// The size of the body is limited to 10KB.
/// </summary>
public class ChapterReadMarkerBatch
{
    /// <summary>
    /// 增加阅读
    /// </summary>
    public IEnumerable<string>? ChapterIdsRead { get; set; }

    /// <summary>
    /// 消除阅读
    /// </summary>
    public IEnumerable<string>? ChapterIdsUnread { get; set; }
}
