// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public abstract class PaginationResponse<T> : SuccessResponse<T>
{
    public int Limit { get; set; }

    public int Offset { get; set; }

    public int Total { get; set; }
}
