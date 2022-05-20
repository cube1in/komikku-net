using Komikku.Maui.DataAccess;
using Komikku.Maui.ViewModels;
using Komikku.Maui.Views;

namespace Komikku.Maui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureViews()
            .ConfigureViewModels()
            .ConfigureDataAccess()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("FontAwesome-WebFont.ttf", "FontAwesome");
            });

        // Rigister router
        Routing.RegisterRoute(nameof(Details), typeof(Details));
        Routing.RegisterRoute(nameof(Reading), typeof(Reading));
        Routing.RegisterRoute(nameof(Login), typeof(Login));

        return builder.Build();
    }
}
