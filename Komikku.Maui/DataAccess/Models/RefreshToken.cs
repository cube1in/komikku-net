namespace Komikku.Maui.DataAccess.Models;

/// <summary>
/// 一个允许刷新的令牌
/// 有效期30天
/// </summary>
public class RefreshToken
{
    public DateTimeOffset Expire { get; set; }

    public string Token { get; set; } = null!;
}
