using LotyPlus.Views;

namespace LotyPlus;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(MyWalletPage), typeof(MyWalletPage));
        Routing.RegisterRoute(nameof(CouponHistoryPage), typeof(CouponHistoryPage));
        Routing.RegisterRoute(nameof(RunningCouponPage), typeof(RunningCouponPage));
        Routing.RegisterRoute(nameof(EditProfilePage), typeof(EditProfilePage));
        Routing.RegisterRoute(nameof(CodeRedeemPage), typeof(CodeRedeemPage));
        Routing.RegisterRoute(nameof(LimitedCouponPage), typeof(LimitedCouponPage));
        Routing.RegisterRoute(nameof(ScanCodePage), typeof(ScanCodePage));
        Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
        Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
        Routing.RegisterRoute(nameof(UpdateDetailsPage), typeof(UpdateDetailsPage));
        Routing.RegisterRoute(nameof(ChangePaymentPage), typeof(ChangePaymentPage));
        Routing.RegisterRoute(nameof(RewardShopPage), typeof(RewardShopPage));
        Routing.RegisterRoute(nameof(SearchShopPage), typeof(SearchShopPage));
        Routing.RegisterRoute(nameof(ShopEntryScanPage), typeof(ShopEntryScanPage));
        Routing.RegisterRoute(nameof(RewardClaimPage), typeof(RewardClaimPage));
    }
    private async void OnMenuItemClicked(object sender, EventArgs e)
    {
        MenuItem menuItem = sender as MenuItem;

        switch (menuItem.ClassId)
        {
            case "0":
                // code block
                break;
            case "1":
                // code block
                break;
            case "2":
                // code block
                break;
            case "3":
                await Shell.Current.GoToAsync(nameof(RewardShopPage));
                break;
            case "4":
                // code block
                break;
            case "5":
                // code block
                break;
            default:
                // code block
                break;
        }
        Shell.Current.FlyoutIsPresented = false;
    }
}

