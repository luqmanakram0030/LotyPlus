using CommunityToolkit.Maui.Views;

namespace LotyPlus.Views;

public partial class CheckoutPage : ContentPage
{
	public CheckoutPage()
	{
		InitializeComponent();
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void Payment_Tapped(object sender, EventArgs e)
    {
        var popup = new Views.PopUps.AlertPopup("successicon.png", "Success!!!", "Payment has been completed");
        this.ShowPopup(popup);
    }

    private void Increase_Clicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        StackLayout stackLayout = button.Parent as StackLayout;
        Label StepperLabel = stackLayout.Children[1] as Label;
        int count = Convert.ToInt16(StepperLabel.Text);
        StepperLabel.Text = (count += 1).ToString();
    }

    private void Decrease_Clicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        StackLayout stackLayout = button.Parent as StackLayout;
        Label StepperLabel = stackLayout.Children[1] as Label;
        int count = Convert.ToInt16(StepperLabel.Text);

        if (count <= 0)
            return;
        StepperLabel.Text = (count -= 1).ToString();
    }

    private async void Edit_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(UpdateDetailsPage));
    }

    private async void PaymentMethod_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ChangePaymentPage));
    }
}
