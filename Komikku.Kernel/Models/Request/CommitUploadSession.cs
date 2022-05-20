// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 4KB
/// </summary>
public class CommitUploadSession
{
    public ChapterDraft ChapterDraft { get; set; } = null!;

    /// <summary>
    /// Ordered list of Upload Session File ids
    /// format: uuid
    /// minLength: 36
    /// maxLength: 36
    /// minItems: 1
    /// maxItems: 500
    /// </summary>
    public IEnumerable<string> PageOrder { get; set; } = null!;
}
