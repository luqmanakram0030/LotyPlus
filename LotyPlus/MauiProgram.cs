using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace LotyPlus;

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
				fonts.AddFont("Poppins-Regular.ttf", "Regular");
				fonts.AddFont("Poppins-Medium.ttf", "Medium");
				fonts.AddFont("Poppins-SemiBold.ttf", "SemiBold");
				fonts.AddFont("Poppins-Bold.ttf", "Bold");
				fonts.AddFont("materialdesignicons-webfont.ttf", "FontIcons");

            });
        FormHandler.RemoveBorders();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

