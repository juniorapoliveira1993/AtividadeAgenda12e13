using Microsoft.Extensions.Logging;

namespace AtividadeAgenda12e13
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
                    fonts.AddFont("Urbanist-Bold.ttf", "UrbanistBold");
                    fonts.AddFont("Urbanist-Regular.ttf", "Urbanist");
                    fonts.AddFont("Urbanist-Thin.ttf", "UrbanistThin");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
