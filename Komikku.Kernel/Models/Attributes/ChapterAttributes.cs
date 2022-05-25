// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

[RegisterRelationshipSupport(EntityType.Chapter)]
public class ChapterAttributes : AdditionalProperties
{
    /// <summary>
    /// 标题
    /// maxLength: 255
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// 发布时间
    /// </summary>
    public string PublishAt { get; set; } = null!;

    /// <summary>
    /// 可读时间
    /// </summary>
    public string ReadableAt { get; set; } = null!;

    /// <summary>
    /// 上传者
    /// </summary>
    public string? Uploader { get; set; }

    /// <summary>
    /// 翻译语言
    /// pattern: '^[a-z]{2}(-[a-z]{2})?$'
    /// </summary>
    public string TranslatedLanguage { get; set; } = null!;

    /// <summary>
    /// 卷
    /// </summary>
    public string? Volume { get; set; }

    /// <summary>
    /// 章节
    /// </summary>
    public string? Chapter { get; set; }

    /// <summary>
    /// 页面
    /// Count of readable images for this chapter
    /// </summary>
    public int Pages { get; set; }

    /// <summary>
    /// 外部网址
    /// Denotes a chapter that links to an external source.
    /// pattern: ^https?://
    /// maxLength: 512
    /// </summary>
    public string? ExternalUrl { get; set; }
}
