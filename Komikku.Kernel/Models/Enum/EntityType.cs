using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 类型
/// </summary>
public enum EntityType
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 漫画资源
    /// </summary>
    Manga,

    /// <summary>
    /// 标签资源
    /// </summary>
    Tag,

    /// <summary>
    /// 漫画的封面艺术
    /// </summary>
    [EnumMember(Value = "cover_art")]
    CoverArt,

    /// <summary>
    /// 章节资源
    /// </summary>
    Chapter,

    /// <summary>
    /// 扫描组资源
    /// </summary>
    [EnumMember(Value = "scanlation_group")]
    ScanlationGroup,

    /// <summary>
    /// 用户资源
    /// </summary>
    User,

    /// <summary>
    /// 自定义列表资源
    /// </summary>
    [EnumMember(Value = "custom_list")]
    CustomList,

    /// <summary>
    /// 作者资源
    /// </summary>
    Author,

    /// <summary>
    /// 作者资源（仅限抽屉）
    /// Author resource (drawers only)
    /// </summary>
    Artist,

    /// <summary>
    /// 映射 ID
    /// </summary>
    [EnumMember(Value = "mapping_id")]
    MappingId,

    /// <summary>
    /// 漫画关系
    /// </summary>
    [EnumMember(Value = "manga_relation")]
    MangaRelation,

    /// <summary>
    /// 上传会话
    /// </summary>
    [EnumMember(Value = "upload_session")]
    UploadSession,

    /// <summary>
    /// 上传会话文件
    /// </summary>
    [EnumMember(Value = "upload_session_file")]
    UploadSessionFile,

    /// <summary>
    /// 报告
    /// </summary>
    Report
}
