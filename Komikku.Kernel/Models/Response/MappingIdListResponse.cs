// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// This response will give you an array of mappings of resource identifiers ; 
/// the `data.attributes.newId` field corresponds to the new UUID.
/// </summary>
public class MappingIdListResponse : PaginationResponse<IEnumerable<MappingId>>
{
}
