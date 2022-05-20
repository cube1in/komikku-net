using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Komikku.Kernel.Models;

/// <summary>
/// 有关的
/// 此数据用于漫画关系的“相关”领域
/// </summary>
public enum Related
{
    /// <summary>
    /// 默认，无
    /// </summary>
    None,

    /// <summary>
    /// 这部漫画的单色变体
    /// </summary>
    [EnumMember(Value = "monochrome")]
    Monochrome,

    /// <summary>
    /// 这部漫画的彩色变体
    /// </summary>
    [EnumMember(Value = "colored")]
    Colored,

    /// <summary>
    /// 保存
    /// 这部漫画在正式连载之前的原版
    /// </summary>
    [EnumMember(Value = "preserialization")]
    Preserialization,

    /// <summary>
    /// 连载
    /// 这部漫画的正式连载
    /// </summary>
    [EnumMember(Value = "serialization")]
    Serialization,

    /// <summary>
    /// 前传
    /// 同一系列中的上一个条目
    /// </summary>
    [EnumMember(Value = "prequel")]
    Prequel,

    /// <summary>
    /// 续集
    /// 同一系列的下一个条目
    /// </summary>
    [EnumMember(Value = "sequel")]
    Sequel,

    /// <summary>
    /// 主要
    /// 这部漫画的是基于原始叙事
    /// </summary>
    [EnumMember(Value = "main_story")]
    MainStory,

    /// <summary>
    /// 小故事
    /// 与这部漫画的故事同时发生的副业
    /// </summary>
    [EnumMember(Value = "side_story")]
    SideStory,

    /// <summary>
    /// 改编自
    /// 这部衍生漫画的原著改编自
    /// </summary>
    [EnumMember(Value = "adapted_from")]
    AdaptedFrom,

    /// <summary>
    /// 分离
    /// 基于这部漫画的官方衍生作品
    /// </summary>
    [EnumMember(Value = "spin_off")]
    SpinOff,

    /// <summary>
    /// 基于
    /// 这部自助出版的衍生漫画是基于原著
    /// </summary>
    [EnumMember(Value = "based_on")]
    BasedOn,

    /// <summary>
    /// 斗金石
    /// 根据这部漫画自行出版的衍生作品
    /// </summary>
    [EnumMember(Value = "doujinshi")]
    DouJinShi,

    /// <summary>
    /// 同样的特权
    /// 这部漫画的知识产权和这部漫画一样
    /// </summary>
    [EnumMember(Value = "same_franchise")]
    SameFranchise,

    /// <summary>
    /// 共享宇宙
    /// 一部漫画发生在和这部漫画一样的虚构世界里
    /// </summary>
    [EnumMember(Value = "shared_universe")]
    SharedUniverse,

    /// <summary>
    /// 另一个故事
    /// 这部漫画的另一个故事
    /// </summary>
    [EnumMember(Value = "alternate_story")]
    AlternateStory,

    /// <summary>
    /// 替代版本
    /// 这部漫画的另一个版本没有其他特别的区别
    /// </summary>
    [EnumMember(Value = "alternate_version")]
    AlternateVersion,
}
