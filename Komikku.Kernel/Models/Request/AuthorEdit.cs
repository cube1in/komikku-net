// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class AuthorEdit : VersionProperty
{
    /// <summary>
    /// 名字
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// 传记
    /// </summary>
    public LocalizedString Biography { get; set; } = null!;

    /// <summary>
    /// format: uri
    /// pattern: "^https?://twitter\\.com(/|$)"
    /// </summary>
    public string? Twitter { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?pixiv\\.net(/|$)"
    /// </summary>
    public string? Pixiv { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?melonbooks\\.co\\.jp(/|$)"
    /// </summary>
    public string? MelonBook { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?fanbox\\.cc(/|$)"
    /// </summary>
    public string? FanBox { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?booth\\.pm(/|$)"
    /// </summary>
    public string? Booth { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?nicovideo\\.pm(/|$)"
    /// </summary>
    public string? NicoVideo { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?skeb\\.pm(/|$)"
    /// </summary>
    public string? Skeb { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?fantia\\.pm(/|$)"
    /// </summary>
    public string? Fantia { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?tumblr\\.pm(/|$)"
    /// </summary>
    public string? Tumblr { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?youtube\\.pm(/|$)"
    /// </summary>
    public string? Youtube { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?weibo\\.pm(/|$)"
    /// </summary>
    public string? Weibo { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?naver\\.pm(/|$)"
    /// </summary>
    public string? Naver { get; set; }

    /// <summary>
    /// format: uri
    /// pattern: "^https?://(\\w+\\.)?website\\.pm(/|$)"
    /// </summary>
    public string? Website { get; set; }
}
