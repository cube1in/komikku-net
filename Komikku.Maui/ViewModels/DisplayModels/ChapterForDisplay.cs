namespace Komikku.Maui.ViewModels;

/// <summary>
/// 章节视图模型
/// </summary>
public class ChapterForDisplay
{
    /// <summary>
    /// 章节 ID
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 所属卷
    /// 若为 null，则是最新卷
    /// </summary>
    public string? Volume { get; set; }

    /// <summary>
    /// 所属章节
    /// </summary>
    public string Chapter { get; set; } = null!;

    /// <summary>
    /// 章节标题
    /// example: Ch.56 - 成吉思汗3
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 发布时间
    /// </summary>
    public string PublishAt { get; set; } = null!;

    /// <summary>
    /// 扫描组
    /// example: 零食汉化组
    /// </summary>
    public string ScanlationGroup { get; set; } = null!;


    /// <summary>
    /// 上传者
    /// example: wmy11011
    /// </summary>
    public string Uploader { get; set; } = null!;
}
