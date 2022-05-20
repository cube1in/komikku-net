// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 登录响应
/// </summary>
public class LoginResponse : Response
{
    /// <summary>
    /// 15 minutes token
    /// </summary>
    public Token Token { get; set; } = null!;
}
