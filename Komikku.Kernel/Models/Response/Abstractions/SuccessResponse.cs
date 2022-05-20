// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public abstract class SuccessResponse<T> : Response
{
    public ResponseType Response { get; set; }

    public T Data { get; set; } = default!;
}
