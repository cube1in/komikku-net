// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 2KB
/// </summary>
public class RecoverCompleteBody
{
    /// <summary>
    /// minLength: 8
    /// maxLength: 1024
    /// </summary>
    public string NewPassword { get; set; } = null!;
}
