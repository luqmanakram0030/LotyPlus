using LotyPlus.Models;
using LotyPlus.ViewModels.Coupons;

namespace LotyPlus.Views.TabPages;

public partial class HomePage : ContentPage
{
    RunningCouponPageViewModel viewModel;
    bool _alreadyOpen;
    public HomePage()
    {
        InitializeComponent();
        //PrimaryContentView.IsVisible = true;
        //ResultsContentView.IsVisible = false;
        //BindingContext = viewModel = new RunningCouponPageViewModel();
    }
    //void Search_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    //{
    //    PrimaryContentView.IsVisible = false;
    //    PrimaryContentView.Opacity = 0;
    //    ResultsContentView.IsVisible = true;
    //    ResultsContentView.Opacity = 1;
    //}

    //void Search_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)

    //{
    //    PrimaryContentView.IsVisible = true;
    //    PrimaryContentView.Opacity = 1;
    //    ResultsContentView.IsVisible = false;
    //    ResultsContentView.Opacity = 0;

    //}

    //void CancelBtn_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    Search.Unfocused += Unfocused();
    //}

    //private EventHandler<FocusEventArgs> Unfocused()
    //{
    //    PrimaryContentView.IsVisible = true;
    //    ResultsContentView.IsVisible = false;
    //    return null;
    //}
    private void ViewAll_Clicked(object sender, EventArgs e)
    {

    }
    private async void Cart_Tapped(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PushAsync(new NotificationPage());
        //await Shell.Current.GoToAsync(nameof(CartPage));
    }
    private void Menu_Tapped(object sender, EventArgs e)
    {
#if ANDROID
        if (!_alreadyOpen)
        {
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Locked;
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
            _alreadyOpen = true;
        }
#endif
        Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
    }
    private void OnResult_Tapped(object sender, EventArgs e)
    {
        Grid grid = sender as Grid;
        SearchCategory searchCategory = grid.BindingContext as SearchCategory;

        switch (searchCategory.Id)
        {
            case 0:
                Shell.Current.GoToAsync(nameof(ScanCodePage));
                break;
            case 1:
                Shell.Current.GoToAsync(nameof(CodeRedeemPage));
                break;
            case 2:
                Shell.Current.GoToAsync(nameof(LimitedCouponPage));
                break;
        }
    }

    private async void RewardShop_Tapped(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(ShopEntryScanPage));
        await Shell.Current.GoToAsync(nameof(RewardShop.RewardClaimPage));

    }
}
