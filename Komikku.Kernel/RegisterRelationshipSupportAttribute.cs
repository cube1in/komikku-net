using Komikku.Kernel.Models;

namespace Komikku.Kernel;

/// <summary>
/// 为 <see cref="Relationship.Attributes"/> 提供反序列化支持
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class RegisterRelationshipSupportAttribute : Attribute
{
    /// <summary>
    /// Attributes 所属的类型
    /// </summary>
    public EntityType[] Belong { get; set; }

    /// <summary>
    /// 为 <see cref="Relationship.Attributes"/> 提供反序列化支持
    /// </summary>
    /// <param name="belong">Attributes 所属的类型</param>
    /// <param name="belongAppend">Attributes 所属的类型</param>
    public RegisterRelationshipSupportAttribute(EntityType belong, params EntityType[] belongAppend)
    {
        Belong = new EntityType[belongAppend.Length + 1];
        belongAppend.CopyTo(Belong, 0);
        Belong[belongAppend.Length] = belong;
    }
}
