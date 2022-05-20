// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 登录请求
/// The size of the body is limited to 2KB
/// </summary>
public class Login
{
    /// <summary>
    /// 用户名
    /// minLength: 1
    /// maxLength: 64
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// 邮箱地址
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// 密码
    /// minLength: 8
    /// maxLength: 1024
    /// </summary>
    public string Password { get; set; } = null!;
}
