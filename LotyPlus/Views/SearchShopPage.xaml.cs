namespace LotyPlus.Views;

public partial class SearchShopPage : ContentPage
{
	public SearchShopPage()
	{
		InitializeComponent();
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
