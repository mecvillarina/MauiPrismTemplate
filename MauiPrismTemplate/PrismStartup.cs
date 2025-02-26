using MauiPrismTemplate.ViewModels;
using MauiPrismTemplate.Views;

namespace MauiPrismTemplate;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .ConfigureModuleCatalog(ConfigureModuleCatalog)
            .OnInitialized(OnInitialized)
            .CreateWindow(async (containerRegistry, navigationService) =>
            {
                await navigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
            });
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterViews();
        containerRegistry.RegisterServices();
    }

    private static void RegisterViews(this IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        containerRegistry.RegisterForNavigation<SecondPage, SecondPageViewModel>();
    }

    private static void RegisterServices(this IContainerRegistry containerRegistry)
    {
       
    }

    private static void OnInitialized(IContainerProvider container)
    {
       
    }

    private static void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        
    }
}
