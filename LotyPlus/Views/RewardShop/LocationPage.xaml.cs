using LotyPlus.ViewModels.RewardShop;
using Maui.GoogleMaps;
using System.Text;

namespace LotyPlus.Views.RewardShop;

public partial class LocationPage : ContentPage
{
	public LocationPage()
	{
		InitializeComponent();
		BindingContext = new LocationViewModel();
        MapSetting();
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


                        var Subaddress = $"{placemark.FeatureName}, {placemark.Locality}, {placemark.SubLocality},\n{placemark.AdminArea}, {placemark.CountryName}";
                        // result.formatted_address = Subaddress;
                        currentLoc.Text = Subaddress;

                        var position = new Position(location.Latitude, location.Longitude);
                        var pin = new Pin
                        {
                            Icon = BitmapDescriptorFactory.FromBundle("pin"),
                            Type = PinType.Place,
                            Position = position,
                            Label = address,
                            Address = Subaddress,
                        };
                        myMap.Pins.Add(pin);
                        myMap.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(1)));
                    }
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("","Please check your device's internet.","Ok");
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
}