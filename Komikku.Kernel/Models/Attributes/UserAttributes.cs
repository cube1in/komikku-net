// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 用户
/// </summary>
[RegisterRelationshipSupport(EntityType.User)]
public class UserAttributes : VersionProperty
{
    /// <summary>
    /// 用户名
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// 角色
    /// </summary>
    public IEnumerable<string> Roles { get; set; } = null!;
}
