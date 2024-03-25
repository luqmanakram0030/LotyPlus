using LotyPlus.ViewModels.RewardShop;

namespace LotyPlus.Views.RewardShop;

public partial class AdvanceFilterPage : ContentPage
{
	public AdvanceFilterPage()
	{
		InitializeComponent();
        BindingContext = new AdvanceFilterViewModel();
    }
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

}