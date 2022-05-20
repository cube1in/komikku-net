﻿// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 8KB
/// </summary>
public class ScanlationGroupEdit : VersionProperty
{
    public string Name { get; set; } = null!;

    /// <summary>
    /// uuid
    /// </summary>
    public string Leader { get; set; } = null!;

    /// <summary>
    /// uuid
    /// </summary>
    public IEnumerable<string> Members { get; set; } = null!;

    public string? Website { get; set; }

    public string? IrcServer { get; set; }

    public string? IrcChannel { get; set; }

    public string? Discord { get; set; }

    public string? ContactEmail { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// uri
    /// pattern: '^https?://twitter\.com'
    /// </summary>
    public string? Twitter { get; set; }

    /// <summary>
    /// pattern: '^https:\/\/www\.mangaupdates\.com\/groups\.html\?id=\d+'
    /// maxLength: 128
    /// </summary>
    public string? MangaUpdates { get; set; }

    /// <summary>
    /// pattern: '^[a-z]{2}(-[a-z]{2})?$'
    /// </summary>
    public IEnumerable<string>? FocusedLanguages { get; set; }

    public bool Inactive { get; set; }

    public bool Locked { get; set; }

    /// <summary>
    /// pattern: "^P(([1-9]|[1-9][0-9])D)?(([1-9])W)?(T(([1-9]|1[0-9]|2[0-4])H)?(([1-9]|[1-5][0-9]|60)M)?(([1-9]|[1-5][0-9]|60)S)?)?$"
    /// </summary>
    public string? PublishDelay { get; set; }
}
