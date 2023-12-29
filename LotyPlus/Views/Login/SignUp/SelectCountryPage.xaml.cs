using LotyPlus.ViewModels.Login.SignUp;
using Microsoft.Maui.Controls.Shapes;


namespace LotyPlus.Views;

public partial class SelectCountryPage : ContentPage
{
    RegisterViewModel viewModel = new RegisterViewModel();

    Frame previousFrame;
    Ellipse prevoiusCircle;
    public SelectCountryPage()
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
    private async void Continue_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NamePage());
    }
    private void OnCountry_Tapped(object sender, EventArgs e)
    {
        //try
        //{
        //    Frame frame = sender as Frame;
        //    Grid grid = frame.Content as Grid;
        //    Grid innerGrid = grid.Children[0] as Grid;
        //    Ellipse circle = innerGrid.Children[1] as Ellipse;


        //    if (previousFrame != null)
        //        previousFrame.BackgroundColor = (Color)Application.Current.Resources["ColorOnDarkBackground"];
        //    if (prevoiusCircle != null)
        //        prevoiusCircle.Fill = (Color)Application.Current.Resources["ColorOnDarkBackground"];
        //    frame.BackgroundColor = (Color)Application.Current.Resources["LightSecondoryColor"];
        //    circle.Fill = (Color)Application.Current.Resources["SecondoryColor"];
        //    previousFrame = frame;
        //    prevoiusCircle = circle;

        //    //If you need the selected country :
        //    Country country = frame.BindingContext as Country;
        //}
        //catch (Exception ex)
        //{

        //}
    }
}
