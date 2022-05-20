using Refit;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class MangaDraftListQuery : IncludesQuery
{
    [AliasAs("order[")]
    public DraftListOrder? Order { get; set; }

    [AliasAs("state")]
    public State? State { get; set; }
}