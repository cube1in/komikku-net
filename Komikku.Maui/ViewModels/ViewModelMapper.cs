using AutoMapper;
using Komikku.Kernel.Models;

namespace Komikku.Maui.ViewModels;

/// <summary>
/// ViewModel 的 Mapper
/// </summary>
internal class ViewModelMapper : Kernel.Mapper<ViewModelProfile>
{
}

internal class ViewModelProfile : Profile
{
    public ViewModelProfile()
    {
        // Manga to MangaForDisplay
        CreateMap<Manga, MangaForDisplay>()
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => LocalizedString(src.Attributes.Title)))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => StringStatus(src.Attributes.Status)))
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => ToMakeSureAttribute<AuthorAttributes>(src, new() { Name = "无名作者" }).Name))
            .ForMember(dest => dest.Cover, opt => opt.MapFrom(src => Kernel.Retrieving.GetCoverOn256(src.Id, ToMakeSureAttribute<CoverAttributes>(src, new() { FileName = "无图片" }).FileName)))
            .ForMember(dest => dest.Background, opt => opt.MapFrom(src => Kernel.Retrieving.GetCoverOnOriginal(src.Id, ToMakeSureAttribute<CoverAttributes>(src, new() { FileName = "无图片" }).FileName)))
            .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => from tag in src.Attributes.Tags select LocalizedString(tag.Attributes.Name)))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Attributes.Description == null ? "无描述" : LocalizedString(src.Attributes.Description)));

        // Chapter to MangaForDisplay
        CreateMap<Chapter, MangaForDisplay>()
            .ForMember(dest => dest.ReadableAt, opt => opt.MapFrom(src => src.Attributes.ReadableAt))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Relationships.First(r => r.Type == EntityType.Manga).Id))
            .ForMember(dest => dest.ScanlationGroup, opt => opt.MapFrom(src => ToMakeSureAttribute<ScanlationGroupAttributes>(src, new() { Name = "无名扫描组" }).Name))
            .ForMember(dest => dest.Chapter, opt => opt.MapFrom(src => $"{src.Attributes.Volume ?? "最新"}卷 {src.Attributes.Chapter}章{(string.IsNullOrWhiteSpace(src.Attributes.Title) ? "" : $"-{src.Attributes.Title}")}"));

        // Chapter to ChapterForDisplay
        CreateMap<Chapter, ChapterForDisplay>()
            .ForMember(dest => dest.Volume, opt => opt.MapFrom(src => src.Attributes.Volume))
            .ForMember(dest => dest.Chapter, opt => opt.MapFrom(src => src.Attributes.Chapter))
            .ForMember(dest => dest.Title, opt => opt.MapFrom(src => $"Ch.{src.Attributes.Chapter}-{src.Attributes.Title}"))
            .ForMember(dest => dest.PublishAt, opt => opt.MapFrom(src => src.Attributes.PublishAt))
            .ForMember(dest => dest.ScanlationGroup, opt => opt.MapFrom(src => ToMakeSureAttribute<ScanlationGroupAttributes>(src, new() { Name = "无名扫描组" }).Name))
            .ForMember(dest => dest.Uploader, opt => opt.MapFrom(src => ToMakeSureAttribute<UserAttributes>(src, new() { Username = "无名用户" }).Username));
    }

    /// <summary>
    /// 寻找 Relationship 下的特定 Attributes
    /// 由于 lambda 表达式无法传递 null，所以使用 alt 的方式解决
    /// </summary>
    /// <typeparam name="T">Attributes 类型</typeparam>
    /// <param name="value">IHasRelationship</param>
    /// <param name="alt">替代选项，如果没有找到，那么将返回 alt</param>
    /// <returns></returns>
    private static T ToMakeSureAttribute<T>(IHasRelationship value, T alt) where T : class
    {
        var attributes = from relationship in value.Relationships select relationship.Attributes;
        // Attribute may be null
        return attributes.FirstOrDefault(a => a?.GetType() == typeof(T)) as T ?? alt;
    }

    private static string StringStatus(Status? status)
        => status switch
        {
            Status.Ongoing => "[连载中]",
            Status.Completed => "[已完结]",
            Status.Hiatus => "[暂停中]",
            Status.Cancelled => "[已取消]",
            null => "[未设置状态]",
            _ => throw new NotSupportedException()
        };

    private static string LocalizedString(LocalizedString localized)
    {
        foreach (var propInfo in typeof(LocalizedString).GetProperties())
        {
            if (propInfo.GetValue(localized, null) is string strValue)
            {
                return strValue;
            }
        }

        return string.Empty;
    }
}