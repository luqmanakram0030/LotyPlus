namespace LotyPlus.Views.TabPages;

public partial class ScanPage : ContentPage
{
	public ScanPage()
	{
		InitializeComponent();
	}
    private async void Cart_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CartPage));
    }
    private void Menu_Tapped(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}
