using LotyPlus.ViewModels;

namespace LotyPlus.Views;

public partial class RunningCouponPage : ContentPage
{
    RunningCouponPageViewModel viewModel ;
    public RunningCouponPage()
    {
        InitializeComponent();
        BindingContext = viewModel = new RunningCouponPageViewModel();
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
