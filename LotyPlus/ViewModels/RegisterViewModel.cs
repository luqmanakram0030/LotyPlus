using System;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Windows.Input;
using LotyPlus.Models;

namespace LotyPlus.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        Country previosSelectedCountry;
        readonly IList<Country> countryList;

        public ObservableCollection<Country> CountryList { get; set; }
        public ICommand CountryTappedCommand { get; set; }

        public RegisterViewModel()
        {
            countryList = new List<Country>();

            CountryTappedCommand = new Command<Country>((model) =>
            {
                if (previosSelectedCountry != null)
                {
                    previosSelectedCountry.FrameColor = (Color)Application.Current.Resources["ColorOnDarkBackground"];
                    previosSelectedCountry.RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"];
                }
                model.FrameColor = (Color)Application.Current.Resources["LightSecondoryColor"];
                model.RadioColor = (Color)Application.Current.Resources["SecondoryColor"];
                previosSelectedCountry = model;
            });


            CreateCountryList();
        }

        public void CreateCountryList()
        {
            countryList.Clear();
            countryList.Add(new Country() { CountryName = "Costa Rica", FlagImage = "costarica.png", FrameColor = (Color)Application.Current.Resources["ColorOnDarkBackground"], RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"] });
            countryList.Add(new Country() { CountryName = "Panama", FlagImage = "panama.png", FrameColor = (Color)Application.Current.Resources["ColorOnDarkBackground"], RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"] });
            countryList.Add(new Country() { CountryName = "Venezuela", FlagImage = "venezuela.png", FrameColor = (Color)Application.Current.Resources["ColorOnDarkBackground"], RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"] });
            countryList.Add(new Country() { CountryName = "Colombia", FlagImage = "colombia.png", FrameColor = (Color)Application.Current.Resources["ColorOnDarkBackground"], RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"] });
            countryList.Add(new Country() { CountryName = "Puerto Rico", FlagImage = "puertorico.png", FrameColor = (Color)Application.Current.Resources["ColorOnDarkBackground"], RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"] });
            countryList.Add(new Country() { CountryName = "El Salvador", FlagImage = "elsalvador.png", FrameColor = (Color)Application.Current.Resources["ColorOnDarkBackground"], RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"] });

            countryList[0].FrameColor = (Color)Application.Current.Resources["LightSecondoryColor"];
            countryList[0].RadioColor = (Color)Application.Current.Resources["SecondoryColor"];
            previosSelectedCountry = countryList[0];

            CountryList = new ObservableCollection<Country>(countryList);
        }
    }
}

