using MauiPlayground.ViewModels;
using MauiPlayground.Views;
using Microsoft.Extensions.Logging;

namespace MauiPlayground;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePrism(prism =>
            {
                prism.RegisterTypes(container =>
                {
                    container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    container.RegisterForNavigation<SecondPage, SecondPageViewModel>();
                    container.RegisterForNavigation<ToolbarItemPage, ToolbarItemPageViewModel>();
                });

                prism.OnInitialized(async container =>
                {
                });

                prism.CreateWindow(async navigationService =>
                {
                    var result = await navigationService.CreateBuilder()
                        .AddNavigationPage()
                        .AddSegment<MainPageViewModel>()
                        .NavigateAsync();
                    
                });
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}