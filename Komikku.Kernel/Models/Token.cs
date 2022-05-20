// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 登录 token
/// </summary>
public class Token
{
    /// <summary>
    /// 有效期15分钟
    /// 暂时没有用到，现在只保存 <see cref="Refresh"/>
    /// </summary>
    public string Session { get; set; } = null!;


    /// <summary>
    /// 有效期30天
    /// </summary>
    public string Refresh { get; set; } = null!;
}
