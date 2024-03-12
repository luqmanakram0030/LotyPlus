using CommunityToolkit.Maui.Views;

namespace LotyPlus.Views;

public partial class ScanCodePage : ContentPage
{
    bool hasLiked = false;

    public ScanCodePage()
    {
        InitializeComponent();
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync("..");
        await Navigation.PopAsync();
    }

    private void Like_Tapped(object sender, EventArgs e)
    {
        Image heart = sender as Image;

        if (hasLiked)
        {
            heart.Source = new FontImageSource() { Glyph = "\U000f02d5", FontFamily = "FontIcons", Size = 40, Color = (Color)Application.Current.Resources["PrimaryColor"] };
            hasLiked = false;
        }
        else
        {
            heart.Source = new FontImageSource() { Glyph = "\U000f02d1", FontFamily = "FontIcons", Size = 40, Color = (Color)Application.Current.Resources["PrimaryColor"] };
            hasLiked = true;
        }
    }

    private void Increase_Tapped(object sender, EventArgs e)
    {
        int count = Convert.ToInt16(StepperLabel.Text);
        StepperLabel.Text = (count += 1).ToString("D2");
    }

    private void Decrease_Tapped(object sender, EventArgs e)
    {
        int count = Convert.ToInt16(StepperLabel.Text);

        if (count <= 0)
            return;
        StepperLabel.Text = (count -= 1).ToString("D2");
    }

    private async void GetCoupon_Tapped(object sender, EventArgs e)
    {
        // await PopupNavigation.Instance.PushAsync(new QRCodePopup(2));
        var popup = new Views.PopUps.QRCodePopup(2);
        this.ShowPopup(popup);
    }
}
