// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 刷新 token
/// </summary>
public class RefreshResponse : Response
{
    /// <summary>
    /// 15 minutes token
    /// </summary>
    public Token Token { get; set; } = null!;
}
