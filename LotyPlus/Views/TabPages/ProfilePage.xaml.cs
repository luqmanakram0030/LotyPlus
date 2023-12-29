using LotyPlus.ViewModels.TabPages;

namespace LotyPlus.Views.TabPages;

public partial class ProfilePage : ContentPage
{
    ProfilePageViewModel viewModel = new ProfilePageViewModel();
    public ProfilePage()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private void cardView_SizeChanged(object sender, EventArgs e)
    {
        double length = cardView.Width;
        cardView.HeightRequest = length / 1.85;
    }
    private async void Cart_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CartPage));
    }
    private void Menu_Tapped(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
    private void Item_Tapped(object sender, EventArgs e)
    {
        Frame frame = sender as Frame;
        ProfileItem profileItem = frame.BindingContext as ProfileItem;
        int index = viewModel.OptionsList.IndexOf(profileItem);

        switch (index)
        {
            case 0:
                Shell.Current.GoToAsync(nameof(MyWalletPage));
                break;
            case 1:
                Shell.Current.GoToAsync(nameof(CouponHistoryPage));
                break;
            case 2:
                Shell.Current.GoToAsync(nameof(RunningCouponPage));
                break;
            case 3:
                Shell.Current.GoToAsync(nameof(EditProfilePage));
                break;
        }
    }
}
