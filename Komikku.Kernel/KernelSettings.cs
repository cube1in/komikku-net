using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Refit;
using System.Reflection;

namespace Komikku.Kernel;

public static class KernelSettings
{
    public const string ServerUrl = "https://api.mangadex.org";

    public const string RetrievingCoverUrl = "https://uploads.mangadex.org/covers";

    /// <summary>
    /// JsonSerializerSettings
    /// </summary>
    public static readonly JsonSerializerSettings SerializerSettings = new()
    {
        // 默认值
        DefaultValueHandling = DefaultValueHandling.Ignore,

        // 空值
        NullValueHandling = NullValueHandling.Ignore,

        // 循环序列化
        ReferenceLoopHandling = ReferenceLoopHandling.Error,

        // 驼峰
        ContractResolver = new CamelCasePropertyNamesContractResolver(),

        // 缩进
        Formatting = Formatting.Indented,

        // 转换器
        Converters = new JsonConverter[] { new StringEnumConverter() }
    };

    /// <summary>
    /// RefitSettings
    /// </summary>
    public static readonly RefitSettings RefitSettings = new()
    {
        ContentSerializer = new NewtonsoftJsonContentSerializer(SerializerSettings),
        UrlParameterFormatter = new CamelCaseUrlParameterFormatter()
    };

    private class CamelCaseUrlParameterFormatter : DefaultUrlParameterFormatter
    {
        public override string? Format(object? parameterValue, ICustomAttributeProvider attributeProvider, Type type)
        {
            var parameter = base.Format(parameterValue, attributeProvider, type);
            return parameter == null ? null : $"{parameter[0]}".ToLower() + parameter[1..];
        }
    }
}