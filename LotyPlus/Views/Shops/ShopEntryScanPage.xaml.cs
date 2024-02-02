using Camera.MAUI;
using ZXing.Net.Maui;

namespace LotyPlus.Views;

public partial class ShopEntryScanPage : ContentPage
{
	public ShopEntryScanPage()
	{
		InitializeComponent();
        cameraView.CamerasLoaded += CameraView_CamerasLoaded;
    }
    private void CameraView_CamerasLoaded(object sender, EventArgs e)
    {
        if (cameraView.NumCamerasDetected > 0)
        {
            if (cameraView.NumMicrophonesDetected > 0)
                cameraView.Microphone = cameraView.Microphones.First();
            cameraView.Camera = cameraView.Cameras.First();
            MainThread.BeginInvokeOnMainThread(async () =>
            {
                if (await cameraView.StartCameraAsync() == CameraResult.Success)
                {
                    // controlButton.Text = "Stop";
                    // playing = true;
                }
            });
        }
    }
    protected async override void OnAppearing()
    {
       // bool allowed = await Methods.AskForRequiredPermission();
        base.OnAppearing();
    }

    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

  
    private void ScanIndicatorImg_SizeChanged(object sender, EventArgs e)
    {
        var height = ScanIndicatorImg.Height;
        MiddleColumn.Width = height;
    }
}
