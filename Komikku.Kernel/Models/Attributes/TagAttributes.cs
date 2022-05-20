using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 标签
/// </summary>
[RegisterRelationshipSupport(EntityType.Tag)]
public class TagAttributes : VersionProperty
{
    /// <summary>
    /// 名称
    /// </summary>
    public LocalizedString Name { get; set; } = null!;

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
    /// 组
    /// </summary>
    public string Group { get; set; } = null!;
}
