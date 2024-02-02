namespace LotyPlus.Views;

public partial class CouponHistoryPage : ContentPage
{
	public CouponHistoryPage()
	{
		InitializeComponent();
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
