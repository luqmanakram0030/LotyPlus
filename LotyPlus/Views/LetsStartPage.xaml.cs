namespace LotyPlus.Views;

public partial class LetsStartPage : ContentPage
{
	public LetsStartPage()
	{
		InitializeComponent();
	}
    private void Start_Tapped(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
    }
}
