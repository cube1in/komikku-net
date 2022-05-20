using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class UserListOrder
{
    /// <summary>
    /// 用户名排序
    /// </summary>
    [AliasAs("username]")]
    public OrderMode Username { get; set; }
}
