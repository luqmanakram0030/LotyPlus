namespace LotyPlus.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}
    private async void Continue_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SelectCountryPage());
    }
}
