// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaRelationRequest
{
    /// <summary>
    /// uuid
    /// </summary>
    public string TargetManga { get; set; } = null!;

    public Related Relation { get; set; }
}
