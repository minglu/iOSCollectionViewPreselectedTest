using CommunityToolkit.Maui;
using iOSCollectionViewPreselectedTEST.ViewModel;
using Microsoft.Extensions.Logging;

namespace iOSCollectionViewPreselectedTEST;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddTransient<CollectionViewPopupPage>();
        builder.Services.AddTransient<StateSelectionViewModel>();
        return builder.Build();
    }
}

