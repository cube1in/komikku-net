// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

public class GroupReadingStatus
{
    public Dictionary<string, ReadingStatus> Statuses { get; set; } = null!;
}
