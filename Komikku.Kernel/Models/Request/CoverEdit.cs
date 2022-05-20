// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 2KB
/// </summary>
public class CoverEdit : VersionProperty
{
    /// <summary>
    /// minLength: 0
    /// maxLength: 8
    /// </summary>
    public string? Volume { get; set; }

    /// <summary>
    /// minLength: 0
    /// maxLength: 512
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// pattern: '^[a-z]{2}(-[a-z]{2})?$'
    /// </summary>
    public string? Locale { get; set; }
}
