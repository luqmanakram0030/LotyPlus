using Android.Content;

namespace LotyPlus.Views;

public partial class ContactInfoPage : ContentPage
{
	public ContactInfoPage()
	{
		InitializeComponent();
	}
    private async void Continue_Tapped(object sender, EventArgs e)
    {
        if (btnText.Text == "Continue")
        {
            InfoSection.IsVisible = false;
            OTPSection.IsVisible = true;
            btnText.Text = "Skip";
        }
        else
        {
            await Navigation.PushAsync(new LetsStartPage());
        }
    }

    private void BorderlessEntry_Focused(object sender, FocusEventArgs e)
    {
        Entry entry = (Entry)sender;
        StackLayout stackLayout = entry.Parent as StackLayout;
        Frame frame = stackLayout.Parent as Frame;
        frame.BorderColor = (Color)Application.Current.Resources["SecondoryColor"];
    }

    private void BorderlessEntry_Unfocused(object sender, FocusEventArgs e)
    {
        Entry entry = (Entry)sender;
        StackLayout stackLayout = entry.Parent as StackLayout;
        Frame frame = stackLayout.Parent as Frame;
        frame.BorderColor = (Color)Application.Current.Resources["GreyColor"];
    }
}
