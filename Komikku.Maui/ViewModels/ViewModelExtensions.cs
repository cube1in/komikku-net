// ReSharper disable once CheckNamespace

namespace Komikku.Maui.ViewModels;

/// <summary>
/// 视图模型拓展
/// </summary>
internal static class ViewModelExtensions
{
    /// <summary>
    /// 配置ViewModels
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<ShellViewModel>();
        builder.Services.AddSingleton<LatestUpdateViewModel>();
        builder.Services.AddSingleton<SubscribesViewModel>();
        builder.Services.AddSingleton<MeViewModel>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddTransient<DetailsViewModel>();
        builder.Services.AddTransient<ReadingViewModel>();

        return builder;
    }
}