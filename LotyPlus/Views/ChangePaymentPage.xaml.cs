using LotyPlus.ViewModels;

namespace LotyPlus.Views;

public partial class ChangePaymentPage : ContentPage
{
    PaymentViewModel viewModel = new PaymentViewModel();
    public ChangePaymentPage()
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void Update_Tapped(object sender, EventArgs e)
    {

    }

    private async void AddAnother_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MyWalletPage));
    }
}
