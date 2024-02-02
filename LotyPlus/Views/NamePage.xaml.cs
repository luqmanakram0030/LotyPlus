namespace LotyPlus.Views;

public partial class NamePage : ContentPage
{
	public NamePage()
	{
		InitializeComponent();
	}
    private async void Continue_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new IdNumberPage());
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
