// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 检测
/// </summary>
public class Check
{
    /// <summary>
    /// 是否验证
    /// </summary>
    public bool IsAuthenticated { get; set; }

    /// <summary>
    /// 角色
    /// </summary>
    public IEnumerable<string> Roles { get; set; } = null!;

    /// <summary>
    /// 权限
    /// </summary>
    public IEnumerable<string> Permissions { get; set; } = null!;
}
