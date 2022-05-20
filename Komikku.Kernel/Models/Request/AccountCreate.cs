// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// he size of the body is limited to 4KB
/// </summary>
public class AccountCreate
{
    /// <summary>
    /// minLength: 1
    /// maxLength: 64
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// minLength: 8
    ///maxLength: 1024
    /// </summary>
    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;
}
