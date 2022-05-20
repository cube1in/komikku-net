// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 上传文件会话
/// </summary>
[RegisterRelationshipSupport(EntityType.UploadSessionFile)]
public class UploadSessionFileAttributes : VersionProperty
{
    /// <summary>
    /// 原始文件名
    /// </summary>
    public string OriginalFileName { get; set; } = null!;

    /// <summary>
    /// 文件哈希
    /// </summary>
    public string FileHash { get; set; } = null!;

    /// <summary>
    /// MIME 类型
    /// </summary>
    public string MimeType { get; set; } = null!;

    /// <summary>
    /// 文件大小
    /// </summary>
    public int FileSize { get; set; }

    /// <summary>
    /// 源
    /// </summary>
    public Source Source { get; set; }
}
