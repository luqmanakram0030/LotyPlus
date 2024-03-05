using Camera.MAUI;
using CommunityToolkit.Maui;
using Maui.GoogleMaps.Hosting;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace LotyPlus;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseBarcodeReader()
            .UseMauiCommunityToolkit()
            .UseMauiCameraView()
            .ConfigureSyncfusionCore()
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
#if ANDROID
        builder.UseGoogleMaps();
#elif IOS
        builder.UseGoogleMaps("AIzaSyBNKHUtgXr6zS0rJlKLSpDLBk8mpCWIwqg");
#endif
        return builder.Build();
	}
}

