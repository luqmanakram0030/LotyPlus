namespace LotyPlus.Views;

public partial class CartPage : ContentPage
{
	public CartPage()
	{
		InitializeComponent();
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void BorderlessEntry_Focused(object sender, FocusEventArgs e)
    {
        try
        {
            Entry entry = (Entry)sender;
            Frame frame = entry.Parent as Frame;
            frame.BorderColor = (Color)Application.Current.Resources["SecondoryColor"];
        }
        catch (Exception ex)
        {

        }
    }

    private void BorderlessEntry_Unfocused(object sender, FocusEventArgs e)
    {
        Entry entry = (Entry)sender;
        Frame frame = entry.Parent as Frame;
        frame.BorderColor = (Color)Application.Current.Resources["GreyColor"];
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

    private async void Checkout_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CheckoutPage));
    }
}
