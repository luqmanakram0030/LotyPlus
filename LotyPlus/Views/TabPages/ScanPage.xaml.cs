using Android.Service.Controls.Templates;
using Camera.MAUI;

namespace LotyPlus.Views.TabPages;

public partial class ScanPage : ContentPage
{
	public ScanPage()
	{
		InitializeComponent();
        cameraView.CamerasLoaded += CameraView_CamerasLoaded;
       // cameraView.BarcodeDetected += CameraView_BarcodeDetected;
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
    private async void Cart_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(CartPage));
    }
    private void Menu_Tapped(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = true;
    }
}
