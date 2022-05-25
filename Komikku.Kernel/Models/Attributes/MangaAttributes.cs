using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 漫画
/// </summary>
[RegisterRelationshipSupport(EntityType.Manga)]
public class MangaAttributes : AdditionalProperties
{
    /// <summary>
    /// 标题
    /// </summary>
    public LocalizedString Title { get; set; } = null!;

    /// <summary>
    /// 替代标题
    /// </summary>
    public IEnumerable<LocalizedString>? AltTitles { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    [JsonIgnore]
    public LocalizedString? Description { get; set; }

    /// <summary>
    /// 描述内部属性
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    private JToken? InternalDescription { get; set; }

    [OnDeserialized]
    internal void OnDeserialized(StreamingContext context)
    {
        if (InternalDescription is JArray ja && ja.HasValues)
        {
            throw new NotSupportedException();
        }

        if (InternalDescription is JObject)
        {
            Description = InternalDescription.ToObject<LocalizedString>()!;
        }
    }

    /// <summary>
    /// 是否被锁定
    /// </summary>
    public bool IsLocked { get; set; }

    /// <summary>
    /// https://api.mangadex.org/docs.html#section/Static-data/Manga-links-data
    /// </summary>
    public object Links { get; set; } = null!;

    /// <summary>
    /// 原始语言
    /// </summary>
    public string OriginalLanguage { get; set; } = null!;

    /// <summary>
    /// 最后一卷
    /// </summary>
    public string? LastVolume { get; set; }

    /// <summary>
    /// 最后一章
    /// </summary>
    public string? LastChapter { get; set; }

    /// <summary>
    /// 出版物人口统计
    /// </summary>
    public PublicationDemographic? PublicationDemographic { get; set; }

    /// <summary>
    /// 漫画状态
    /// example: 漫画还在继续
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// 发行年份
    /// </summary>
    public int? Year { get; set; }

    /// <summary>
    /// 内容评级
    /// </summary>
    public ContentRating ContentRating { get; set; }

    /// <summary>
    /// 在新卷上重置章节编号
    /// </summary>
    public bool ChapterNumbersResetOnNewVolume { get; set; }

    /// <summary>
    /// 可用翻译语言
    /// </summary>
    public IEnumerable<string> AvailableTranslatedLanguages { get; set; } = null!;

    /// <summary>
    /// 标签
    /// </summary>
    public IEnumerable<Tag> Tags { get; set; } = null!;

    /// <summary>
    /// 状态
    /// example: 草稿
    /// </summary>
    public State State { get; set; }
}
