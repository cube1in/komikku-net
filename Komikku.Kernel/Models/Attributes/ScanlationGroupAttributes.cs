// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 扫描组
/// </summary>
[RegisterRelationshipSupport(EntityType.ScanlationGroup)]
public class ScanlationGroupAttributes : AdditionalProperties
{
    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 替代名称
    /// </summary>
    public IEnumerable<LocalizedString> AltNames { get; set; } = null!;

    /// <summary>
    /// 网址
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// Irc 服务器
    /// </summary>
    public string? IrcServer { get; set; }

    /// <summary>
    /// Irc 频道
    /// </summary>
    public string? IrcChannel { get; set; }

    /// <summary>
    /// 不和谐
    /// </summary>
    public string? Discord { get; set; }

    /// <summary>
    /// 联系邮件地址
    /// </summary>
    public string? ContactEmail { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: '^https?://'
    /// </summary>
    public string? Twitter { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: '^https:\/\/www\.mangaupdates\.com\/groups\.html\?id=\d+'
    /// maxLength: 128
    /// </summary>
    public string? MangaUpdates { get; set; }

    /// <summary>
    /// item pattern: '^[a-z]{2}(-[a-z]{2})?$'
    /// </summary>
    public IEnumerable<string>? FocusedLanguage { get; set; }

    /// <summary>
    /// 锁定
    /// </summary>
    public bool Locked { get; set; }

    /// <summary>
    /// 官方
    /// </summary>
    public bool Official { get; set; }

    /// <summary>
    /// 不活跃
    /// </summary>
    public bool Inactive { get; set; }

    /// <summary>
    /// 发布延迟
    /// Should respected ISO 8601 duration specification: https://en.wikipedia.org/wiki/ISO_8601#Durations
    /// example: "P4D"
    /// pattern: '^(P([1-9]|[1-9][0-9])D)?(P?([1-9])W)?(P?T(([1-9]|1[0-9]|2[0-4])H)?(([1-9]|[1-5][0-9]|60)M)?(([1-9]|[1-5][0-9]|60)S)?)?$'
    /// </summary>
    public string? PublishDelay { get; set; };
}
