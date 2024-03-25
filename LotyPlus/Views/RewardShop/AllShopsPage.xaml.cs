using LotyPlus.Models;
using LotyPlus.ViewModels.RewardShop;

namespace LotyPlus.Views.RewardShop;

public partial class AllShopsPage : ContentPage
{
	public AllShopsPage()
	{
		InitializeComponent();
		BindingContext = new AllShopsViewModel();
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

}