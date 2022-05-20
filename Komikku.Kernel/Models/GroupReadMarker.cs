using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 组阅读标记
/// </summary>
public class GroupReadMarker
{
    /// <summary>
    /// 是否为组
    /// 如果 "queryString" 中的 "grouped" 参数为 "ture" 则结果为 <see cref="ArrayValues"/>
    /// 如果 "queryString" 中的 "grouped" 参数为 "false" 则结果为 <see cref="GroupValues"/>
    /// </summary>
    [JsonIgnore]
    public bool Group => GroupValues != null;

    /// <summary>
    /// 如果 "queryString" 中的 "grouped" 参数为 "false" 则此值不为空
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string>? ArrayValues { get; set; }

    /// <summary>
    /// 如果 "queryString" 中的 "grouped" 参数为 "true" 则此值不为空
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, IEnumerable<string>>? GroupValues { get; set; }

    /// <summary>
    /// 供反序列化使用
    /// </summary>
    [JsonProperty]
    private JToken Data { get; set; } = null!;

    [OnDeserialized]
    internal void OnDeserialized(StreamingContext context)
    {
        if (Data is JArray ja && ja.HasValues)
        {
            ArrayValues = ja.ToObject<IEnumerable<string>>();
        }

        if (Data is JObject jo && jo.HasValues)
        {
            GroupValues = jo.ToObject<Dictionary<string, IEnumerable<string>>>();
        }
    }
}
