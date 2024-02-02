namespace LotyPlus.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
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

    private void ViewPassword_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (pswrdField.IsPassword)
        {
            pswrdField.IsPassword = false;
            button.ImageSource = new FontImageSource() { FontFamily = "FontIcons", Glyph = "\U000f06d0", Color = Color.FromHex("#000000"), Size = 20 };
        }
        else
        {
            pswrdField.IsPassword = true;
            button.ImageSource = new FontImageSource() { FontFamily = "FontIcons", Glyph = "\U000f06d1", Color = Color.FromHex("#D8D8D8"), Size = 20 };
        }

        pswrdField.CursorPosition = String.IsNullOrEmpty(pswrdField.Text) == false ? pswrdField.Text.Length : 0;
    }

    private async void SignUp_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WelcomePage());
    }

    private void Login_Tapped(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new forgetPasswordPage());
    }
}