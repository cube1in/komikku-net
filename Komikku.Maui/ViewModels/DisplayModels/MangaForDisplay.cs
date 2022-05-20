namespace Komikku.Maui.ViewModels;

public class MangaForDisplay
{
    /// <summary>
    /// Id
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// 状态
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// 作者
    /// </summary>
    public string Author { get; set; } = null!;

    /// <summary>
    /// 章节
    /// </summary>
    public string Chapter { get; set; } = null!;

    /// <summary>
    /// 扫描组
    /// </summary>
    public string ScanlationGroup { get; set; } = null!;

    /// <summary>
    /// 可读时间
    /// </summary>
    public string ReadableAt { get; set; } = null!;

    /// <summary>
    /// 封面
    /// </summary>
    public string Cover { get; set; } = null!;

    /// <summary>
    /// 背景
    /// </summary>
    public string Background { get; set; } = null!;

    /// <summary>
    /// 标签
    /// </summary>
    public IEnumerable<string> Tags { get; set; } = null!;

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; } = null!;
}
