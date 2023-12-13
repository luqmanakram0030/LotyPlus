using LotyPlus.ViewModels;

namespace LotyPlus.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class RewardShopPage : ContentPage
{
    RunningCouponPageViewModel viewModel = new RunningCouponPageViewModel();
    public RewardShopPage()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void Search_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SearchShopPage));
    }
}
