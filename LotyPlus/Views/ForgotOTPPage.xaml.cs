using CommunityToolkit.Maui.Core.Platform;

namespace LotyPlus.Views;

public partial class ForgotOTPPage : ContentPage
{
	public ForgotOTPPage()
	{
		InitializeComponent();
        Entry1.Focus();
        Entry1.IsEnabled = true;
        Entry2.IsEnabled = false;
        Entry3.IsEnabled = false;
        Entry4.IsEnabled = false;
        OTPSection.IsVisible = true;
    }
    private async void Continue_Tapped(object sender, EventArgs e)
    {
        
            await Navigation.PushAsync(new SetNewPasswordPage());
        
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

    async void Entry1_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        if (Entry1.Text != "")
        {
            Entry1.IsEnabled = false;
            Entry2.IsEnabled = true;
            Entry2.Focus();

        }
        else
        {
            Entry2.IsEnabled = false;
            Entry1.IsEnabled = true;
            Entry1.Focus();
        }
    }

    void Entry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        if (Entry2.Text != "")
        {

            Entry2.IsEnabled = false;
            Entry3.IsEnabled = true;
            Entry3.Focus();
        }
        else
        {
            Entry2.IsEnabled = false;
            Entry1.IsEnabled = true;
            Entry1.Focus();
        }
    }

    void Entry3_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        if (Entry3.Text != "")
        {

            Entry3.IsEnabled = false;
            Entry4.IsEnabled = true;
            Entry4.Focus();
        }
        else
        {
            Entry3.IsEnabled = false;
            Entry2.IsEnabled = true;
            Entry2.Focus();
        }
    }

    void Entry4_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        if (Entry4.Text != "")
        {
            //Entry4.IsEnabled = false;
            Entry4.Focus();
        }
        else
        {
            Entry4.IsEnabled = false;
            Entry3.IsEnabled = true;
            Entry3.Focus();
        }
    }

    async void Entry1_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {
        await KeyboardExtensions.ShowKeyboardAsync(Entry2, default);
    }

}
