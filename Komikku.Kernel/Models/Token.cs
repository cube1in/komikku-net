// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 登录 token
/// </summary>
public class Token
{
    /// <summary>
    /// 有效期15分钟
    /// </summary>
    public string Session { get; set; } = null!;


    /// <summary>
    /// 有效期30天
    /// </summary>
    public string Refresh { get; set; } = null!;
}
