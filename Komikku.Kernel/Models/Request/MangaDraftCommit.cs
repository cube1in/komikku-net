// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// A Manga Draft that is to be submitted must have at least one cover in the original language, 
/// must be in the "draft" state and must be passed the correct version in the request body.
/// </summary>
public class MangaDraftCommit : VersionProperty
{
}
