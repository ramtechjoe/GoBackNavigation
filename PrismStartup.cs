using GoBackNavigation.Views;

namespace GoBackNavigation;

internal static class PrismStartup
{


    public static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
                     .RegisterInstance(SemanticScreenReader.Default);

        containerRegistry.RegisterForNavigation<FirstPage>();
        containerRegistry.RegisterForNavigation<SecondPage>();
    }
}
