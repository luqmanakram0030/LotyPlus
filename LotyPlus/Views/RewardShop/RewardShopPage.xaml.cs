using LotyPlus.ViewModels.Coupons;
using LotyPlus.ViewModels.RewardShop;
using System.Text;

namespace LotyPlus.Views.RewardShop;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class RewardShopPage : ContentPage
{
    RewardShopViewModel viewModel = new RewardShopViewModel();
    public RewardShopPage()
    {
        InitializeComponent();
        BindingContext = viewModel;
        search.Unfocus();
        RequestLocationPermission();
    }
    private async void MapSetting()
    {
        try
        {
            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                //var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                //var location = await Geolocation.GetLocationAsync(request);

                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Lowest

                    });

                }

                if (location != null)
                {
                    // result.geometry.location.lat = location.Latitude;
                    // result.geometry.location.lng = location.Longitude;
                    var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);

                    if (placemarks != null && placemarks.Any())
                    {
                        var placemark = placemarks.FirstOrDefault();

                        var addressBuilder = new StringBuilder();

                        if (!string.IsNullOrWhiteSpace(placemark.FeatureName))
                        {
                            addressBuilder.Append(placemark.FeatureName + ", ");
                        }

                        if (!string.IsNullOrWhiteSpace(placemark.SubLocality))
                        {
                            addressBuilder.Append(placemark.SubLocality);
                        }

                        var address = addressBuilder.ToString();

                        //addr.Text = address;
                        // result.name = address;


                        var Subaddress = $"{placemark.AdminArea}, {placemark.CountryName}";
                        currentLoc.Text =  Subaddress;
                        // Subaddr.Text = Subaddress;
                    }
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("", "Please check your device's internet.", "Ok");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Ok");
        }
    }
    private async void Back_Tapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
    public async void RequestLocationPermission()
    {
        var Status = PermissionStatus.Unknown;
        Status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
        if (Status == PermissionStatus.Granted)
        {
            MapSetting();
        }
        else
            Status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

        if (Permissions.ShouldShowRationale<Permissions.LocationWhenInUse>())
        {
            await Application.Current.MainPage.DisplayAlert("", "App needs location permission", "OK");
        }

        if (Status != PermissionStatus.Granted)
        {
            RequestLocationPermission();
        }
        else if (Status == PermissionStatus.Granted)
        {
            MapSetting();
        }
    }
    private async void Location_Tapped(object sender, EventArgs e)
    {
        await Application.Current.MainPage.Navigation.PushAsync(new LocationPage());
    }

    private void Entry_Focused(object sender, FocusEventArgs e)
    {
        entryFrame.BackgroundColor = Color.FromHex("#E8E8E8");
    }

    private void Entry_Unfocused(object sender, FocusEventArgs e)
    {
        entryFrame.BackgroundColor = Color.FromHex("#D8D8D8");
    }
}
