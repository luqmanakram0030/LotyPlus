using LotyPlus.ViewModels;

namespace LotyPlus.Views;

public partial class OnBoardingPage : ContentPage
{
    OnBoardingViewModel viewModel;
    public OnBoardingPage()
	{
		InitializeComponent();

        BindingContext = viewModel= new OnBoardingViewModel(); 
    }
    private void SkipBtn_Clicked_1(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new LoginPage());
    }

    private void NextBtn_Clicked(object sender, EventArgs e)
    {
        if (OnBoardingCarousal.Position == viewModel.OnBoardingList.Count() - 1)
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
        else
        {
            //viewModel.position = viewModel.position + 1;
            OnBoardingCarousal.Position += 1;
           // OnBoardingCarousal.CurrentItem =+ 1;
        }
    }

    private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
    {
        if (OnBoardingCarousal.Position == viewModel.OnBoardingList.Count - 1)
        {
            NextBtn.Text = "Get Started";
        }
        else
        {
            NextBtn.Text = "Next";
        }
    }

    private void StartBtn_Clicked(object sender, EventArgs e)
    {
        StartBtn.IsVisible = false;
        OnBoardingCarousal.Position += 1;
        //viewModel.position = viewModel.position + 1;
        OnBoardingCarousal.IsSwipeEnabled = true;
        SkiptBtn.IsVisible = true;
        NextBtn.IsVisible = true;
    }
}