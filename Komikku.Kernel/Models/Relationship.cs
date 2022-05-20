using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 关系
/// </summary>
public class Relationship
{
    /// <summary>
    /// ID
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// 实体类型
    /// </summary>
    public EntityType Type { get; set; }

    /// <summary>
    /// 漫画类型
    /// Related Manga type, only present if you are on a Manga entity and a Manga relationship
    /// </summary>
    public Related? Related { get; set; }

    /// <summary>
    /// 属性
    /// If Reference Expansion is applied, contains objects attributes
    /// </summary>
    public object? Attributes { get; set; }

    [OnDeserialized]
    internal void OnDeserialized(StreamingContext context)
    {
        if (Attributes is not JObject jo) return;
        var jsonString = jo.ToString();

        var classTypes = Assembly.GetExecutingAssembly().GetExportedTypes();
        foreach (var type in classTypes)
        {
            var rigister = type.GetCustomAttribute<RegisterRelationshipSupportAttribute>();
            if (rigister != null && rigister.Belong.Contains(Type))
            {
                Attributes = JsonConvert.DeserializeObject(jsonString, type, KernelSettings.SerializerSettings);
                return;
            }
        }

        // Could not find it
        throw new JsonException($"Unable to find Attributes which has [{nameof(RegisterRelationshipSupportAttribute)}({Type})] attribute.");
    }
}
