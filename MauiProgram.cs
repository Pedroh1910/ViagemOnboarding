using Microsoft.Extensions.Logging;
using ViagemOnboarding.ViewModels;
using ViagemOnboarding.Views;

namespace ViagemOnboarding
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<ViagemOnboardingViewModel>();
            builder.Services.AddTransient<ViagemOnboardingPage>();

            return builder.Build();
        }
    }
}