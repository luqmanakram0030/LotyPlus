namespace LotyPlus.Views;

public partial class SearchShopPage : ContentPage
{
	public SearchShopPage()
	{
		try
		{
            InitializeComponent();
            PrimaryContentView.IsVisible = true;
            ResultsContentView.IsVisible = false;
        }
		catch (Exception ex)
		{
			DisplayAlert("", ex.Message, "ok");
		} 
		
	}
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    void Search_Focused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)
    {

       
        PrimaryContentView.IsVisible = false;
        ResultsContentView.IsVisible = true;
    }

    void Search_Unfocused(System.Object sender, Microsoft.Maui.Controls.FocusEventArgs e)

    {
        PrimaryContentView.IsVisible = true;
        ResultsContentView.IsVisible = false;
        
    }

    void CancelBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Search.Unfocused += Unfocused();
        Search1.Focus();
    }

    private EventHandler<FocusEventArgs> Unfocused()
    {
        
        PrimaryContentView.IsVisible = true;
        ResultsContentView.IsVisible = false;
        return null;
    }
}
