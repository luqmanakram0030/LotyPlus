using CommunityToolkit.Maui.Views;

namespace LotyPlus.Views.PopUps;

public partial class AlertPopup : Popup
{
	public AlertPopup(string image, string title, string description)
	{
		InitializeComponent();
        popupImage.Source = FileImageSource.FromFile(image);
        popupTitle.Text = title;
        popupDescription.Text = description;
    }
    private async void Back_Clicked(object sender, EventArgs e)
    {
        this.Close();
    }
}
