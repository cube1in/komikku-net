using AutoMapper;

namespace Komikku.Kernel;

public abstract class Mapper<TProfile>
    where TProfile : Profile, new()
{
    private static readonly IMapper IMapper
        = new MapperConfiguration(cfg => cfg.AddProfile<TProfile>()).CreateMapper();

    public static TDestination Map<TDestination>(object? source)
        => IMapper.Map<TDestination>(source);

    public static TDestination Map<TSource, TDestination>(TSource source)
        => IMapper.Map<TSource, TDestination>(source);

    public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        => IMapper.Map(source, destination);

    public static object Map(object? source, Type sourceType, Type destinationType)
        => IMapper.Map(source, sourceType, destinationType);

    public static object Map(object? source, object? destination, Type sourceType, Type destinationType)
        => IMapper.Map(source, destination, sourceType, destinationType);
}
