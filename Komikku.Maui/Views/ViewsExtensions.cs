namespace Komikku.Maui.Views;

internal static class ViewsExtensions
{
    public static MauiAppBuilder ConfigureViews(this MauiAppBuilder builder)
    {
        // main tabs of the app
        builder.Services.AddSingleton<LatestUpdate>();
        builder.Services.AddSingleton<Subscribes>();
        builder.Services.AddSingleton<Me>();
        builder.Services.AddSingleton<Login>();

        // pages that are navigated to
        builder.Services.AddTransient<Details>();
        builder.Services.AddTransient<Reading>();

        return builder;
    }
}
