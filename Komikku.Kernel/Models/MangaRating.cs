// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaRating
{
    /// <summary>
    /// Will be nullable if no ratings has been done
    /// </summary>
    public int? Average { get; set; }

    public Distribution Distribution { get; set; } = null!;

    public int Follows { get; set; }
}
