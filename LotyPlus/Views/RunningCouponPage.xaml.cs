using LotyPlus.ViewModels;

namespace LotyPlus.Views;

public partial class RunningCouponPage : ContentPage
{
    RunningCouponPageViewModel viewModel = new RunningCouponPageViewModel();
    public RunningCouponPage()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
