using LotyPlus.Models;

namespace LotyPlus.Views.RewardShop;

public partial class FeedbackPage : ContentPage
{
    private int _remaining;

    public int remaining
    {
        get { return _remaining; }
        set { _remaining = value; OnPropertyChanged(); }
    }

    public clsProduct model { get; set; }
    public FeedbackPage(clsProduct model)
	{
		InitializeComponent();
        this.model = model;
        BindingContext = this;
    }
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private void editer_TextChanged(object sender, TextChangedEventArgs e)
    {
        var lenght = editer.Text.Length;
        remaining = lenght;
    }
}