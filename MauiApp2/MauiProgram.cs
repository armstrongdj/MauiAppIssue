using Microsoft.Extensions.Logging;
using Raygun4Maui;
using Telerik.Maui.Controls.Compatibility;

namespace MauiApp2
{
    public static class MauiProgram
    {
        private const string ApiKey = "YOUR KEY HERE";

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseTelerik()
                .AddRaygun4Maui(ApiKey)
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
}
