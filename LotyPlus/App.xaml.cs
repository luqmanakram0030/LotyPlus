using LotyPlus.Views;

namespace LotyPlus;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        if (VersionTracking.IsFirstLaunchEver)
            MainPage = new OnBoardingPage();
        else
            MainPage = new NavigationPage(new LoginPage());
       // MainPage = new AppShell();
	}
}

