// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 上传会话
/// </summary>
[RegisterRelationshipSupport(EntityType.UploadSession)]
public class UploadSessionAttributes : AdditionalProperties
{
    /// <summary>
    /// 是否确认
    /// </summary>
    public bool IsCommitted { get; set; }

    /// <summary>
    /// 是否已经处理
    /// </summary>
    public bool IsProcessed { get; set; }

    /// <summary>
    /// 是否删除
    /// </summary>
    public bool IsDeleted { get; set; }
}
