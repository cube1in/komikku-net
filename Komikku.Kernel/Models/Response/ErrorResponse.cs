// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class ErrorResponse : Response
{
    public IEnumerable<Error> Errors { get; set; } = null!;
}

public class Error
{
    public string Id { get; set; } = null!;

    public int Status { get; set; }

    public string Title { get; set; } = null!;

    public string Detail { get; set; } = null!;
}
