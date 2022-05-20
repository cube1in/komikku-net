// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 更新漫画阅读状态请求
/// <see cref="Status"/> 可为 null
/// </summary>
public class UpdateMangaStatus
{
    /// <summary>
    /// Using a "null" value in status field will remove the Manga reading status. 
    /// The size of the body is limited to 2KB. 
    /// </summary>
    public ReadingStatus? Status { get; set; }
}
