// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 和普通的 Response 有些不同
/// </summary>
public class CheckResponse : Check
{
    public Result Result { get; set; }
}
