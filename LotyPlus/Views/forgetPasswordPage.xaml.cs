namespace LotyPlus.Views;

public partial class forgetPasswordPage : ContentPage
{
	public forgetPasswordPage()
	{
		InitializeComponent();
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
    async void Continue_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
       await Navigation.PushAsync(new ForgotOTPPage());
    }
}
