// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class UserPasswordEdit
{
    /// <summary>
    /// minLength: 8
    /// maxLength: 1024
    /// </summary>
    public string OldPassword { get; set; } = null!;

    /// <summary>
    /// minLength: 8
    /// maxLength: 1024
    /// </summary>
    public string NewPassword { get; set; } = null!;
}
