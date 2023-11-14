namespace LotyPlus.Views;

public partial class TabViewPage : ContentPage
{
	public TabViewPage()
	{
		InitializeComponent();
	}

    private void Menu_Tapped(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }

    private async void Cart_Tapped(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(CartPage));
    }
}