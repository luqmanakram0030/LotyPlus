using LotyPlus.Views;
using LotyPlus.Views.TabPages;

namespace LotyPlus;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjgwODkxNUAzMjMzMmUzMDJlMzBBMlNESW9YanNjejYxQldPbVFBVHZ6dUUvZWtzMjNyekZWTjdLWVlJK2JzPQ ==");
        InitializeComponent();
        if (VersionTracking.IsFirstLaunchEver)
            MainPage = new NavigationPage(new OnBoardingPage());
        else
            MainPage = new NavigationPage(new LoginPage());

        // MainPage = new AppShell();
        // MainPage =new NavigationPage( new SearchShopPage());
    }
    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Border frame = sender as Border;
        RadioButton button = (RadioButton)frame.Parent;
        button.IsChecked = true;
    }
}

