// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class UploadSessionFile
{
    public string Id { get; set; } = null!;

    public EntityType Type { get; set; }

    public UploadSessionFileAttributes Attributes { get; set; } = null!;
}
