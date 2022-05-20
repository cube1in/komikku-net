using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class AuthorListOrder
{
    [AliasAs("name]")]
    public OrderMode Name { get; set; }
}