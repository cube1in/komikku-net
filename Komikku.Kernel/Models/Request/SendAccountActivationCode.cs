// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// The size of the body is limited to 1KB
/// </summary>
public class SendAccountActivationCode
{
    public string Email { get; set; } = null!;
}
