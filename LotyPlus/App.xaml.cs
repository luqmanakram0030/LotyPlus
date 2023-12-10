using LotyPlus.Views;
using LotyPlus.Views.TabPages;

namespace LotyPlus;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //if (VersionTracking.IsFirstLaunchEver)
        //    MainPage = new NavigationPage(new OnBoardingPage());
        //else
        //    MainPage = new NavigationPage(new LoginPage());

        // MainPage = new AppShell();
         MainPage =new NavigationPage( new SearchShopPage());
    }
}

