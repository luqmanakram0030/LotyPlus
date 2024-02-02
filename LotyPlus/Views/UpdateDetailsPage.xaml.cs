namespace LotyPlus.Views;

public partial class UpdateDetailsPage : ContentPage
{
    public UpdateDetailsPage()
    {
        InitializeComponent();
    }
    private void Update_Tapped(object sender, EventArgs e)
    {

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

    private void AnotherNum_Tapped(object sender, EventArgs e)
    {
        Label label = sender as Label;
        label.IsVisible = false;
        anotherNumField.IsVisible = true;
    }
}
