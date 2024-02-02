using CommunityToolkit.Maui.Views;
using LotyPlus.ViewModels;

namespace LotyPlus.Views;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class RewardClaimPage : ContentPage
{
    RewardClaimPageViewModel viewModel = new RewardClaimPageViewModel();
    public RewardClaimPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        //below code is to fix the collectionview's height issue within a scrollview
        var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
        var width = mainDisplayInfo.Width - 40; //margin of sides
        var density = mainDisplayInfo.Density;
        double widthdiu = width / density;
        double coloumnWidth = widthdiu / 3;

        int listCount = viewModel.ServicesList.Count;
        double noOfRows = listCount / 3;
        if (listCount % 3 > 0)
            noOfRows += 1;

        RewardCollection.HeightRequest = coloumnWidth * noOfRows;
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void ScanCode_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ShopEntryScanPage));
    }

    private async void ClaimReward_Tapped(object sender, EventArgs e)
    {
        var popup = new Views.PopUps.AlertPopup("bigwin.png", "Free Voucher", "Congratulations! You have won a free coupon for this shop. When you visit next time you will get a free service.");
        this.ShowPopup(popup);
    }
}
