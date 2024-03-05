using Android.App;
using Android.Runtime;

namespace LotyPlus;

[Application]
[MetaData("com.google.android.maps.v2.API_KEY",
            Value = "AIzaSyBNKHUtgXr6zS0rJlKLSpDLBk8mpCWIwqg")]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

