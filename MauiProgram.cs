using System.Diagnostics;
using GoBackNavigation.Views;

namespace GoBackNavigation;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePrism(prism => prism.RegisterTypes(PrismStartup.RegisterTypes)
                .CreateWindow(navigationService => navigationService.CreateBuilder().AddNavigationPage()
                    .AddSegment<MainPage>()
                    .NavigateAsync(HandleNavigationError))
            )
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }

    private static void HandleNavigationError(Exception obj)
    {
        Trace.WriteLine(obj);
    }
}
