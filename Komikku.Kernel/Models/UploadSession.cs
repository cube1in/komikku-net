// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class UploadSession
{
    public string Id { get; set; } = null!;

    public EntityType Type { get; set; }

    public UploadSessionAttributes Attributes { get; set; } = null!;
}
