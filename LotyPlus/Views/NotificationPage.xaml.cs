using LotyPlus.ViewModels;

namespace LotyPlus.Views;

public partial class NotificationPage : ContentPage
{
	public NotificationPage()
	{
		InitializeComponent();
        BindingContext = new NotificationViewModel();
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}