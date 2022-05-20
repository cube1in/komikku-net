using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 漫画聚合
/// </summary>
public class MangaAggregate
{
    /// <summary>
    /// 卷
    /// "none": {xxx}
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, VolumItem>? Volumes { get; set; }

    /// <summary>
    /// 卷内部属性
    /// "none": {xxx}
    /// </summary>
    [JsonProperty(PropertyName = "volumes")]
    public JToken? InternalVolumes { get; set; }

    [OnDeserialized]
    internal void OnDeserialized(StreamingContext context)
    {
        if (InternalVolumes is JArray ja && ja.HasValues)
        {
            throw new NotSupportedException();
        }

        if (InternalVolumes is JObject)
        {
            Volumes = InternalVolumes.ToObject<Dictionary<string, VolumItem>>()!;
        }
    }
}

public class VolumItem
{
    /// <summary>
    /// 卷名
    /// "none"
    /// </summary>
    public string Volume { get; set; } = null!;

    /// <summary>
    /// 这一卷的数量
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// 章节
    /// "51": {xxx}
    /// </summary>
    public Dictionary<string, ChapterItem> Chapters { get; set; } = null!;
}

public class ChapterItem
{
    /// <summary>
    /// 章节名
    /// "51"
    /// </summary>
    public string Chapter { get; set; } = null!;

    /// <summary>
    /// 本章 ID
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 其他章的 ID
    /// </summary>
    public IEnumerable<string> Others { get; set; } = null!;

    /// <summary>
    /// 本章数量
    /// </summary>
    public int Count { get; set; }
}
