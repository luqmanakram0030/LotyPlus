using CommunityToolkit.Maui.Views;

namespace LotyPlus.Views.PopUps;

public partial class QRCodePopup : Popup
{
	public QRCodePopup(int popupIndex)
	{
		InitializeComponent();

        switch (popupIndex)
        {
            case 0:
                QRCodeView.IsVisible = true;
                alreadyPurchasedView.IsVisible = false;
                offerExpiredView.IsVisible = false;
                break;
            case 1:
                QRCodeView.IsVisible = false;
                alreadyPurchasedView.IsVisible = true;
                offerExpiredView.IsVisible = false;
                break;
            case 2:
                QRCodeView.IsVisible = false;
                alreadyPurchasedView.IsVisible = false;
                offerExpiredView.IsVisible = true;
                break;
            default:
                QRCodeView.IsVisible = false;
                alreadyPurchasedView.IsVisible = false;
                offerExpiredView.IsVisible = false;
                break;
        }
    }

    private async void Close_Clicked(object sender, EventArgs e)
    {
        this.Close();
    }
}
