using ZXing.Net.Maui;

namespace LotyPlus.Views;

public partial class ShopEntryScanPage : ContentPage
{
	public ShopEntryScanPage()
	{
		InitializeComponent();
	}
    protected async override void OnAppearing()
    {
       // bool allowed = await Methods.AskForRequiredPermission();
        base.OnAppearing();
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

  
    private void ScanIndicatorImg_SizeChanged(object sender, EventArgs e)
    {
        var height = ScanIndicatorImg.Height;
        MiddleColumn.Width = height;
    }
}
