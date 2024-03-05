using LotyPlus.Models;
using LotyPlus.Views.RewardShop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LotyPlus.ViewModels.RewardShop
{
    public class RewardShopViewModel: BaseViewModel
    {
        private ObservableCollection<clsProduct> _products;

        public ObservableCollection<clsProduct> products
        {
            get { return _products; }
            set { _products = value; OnPropertyChanged(); }
        }
        private ObservableCollection<string> _categories;

        public ObservableCollection<string> categories
        {
            get { return _categories; }
            set { _categories = value; OnPropertyChanged(); }
        }
        private ObservableCollection<string> _suggestions;

        public ObservableCollection<string> suggestions
        {
            get { return _suggestions; }
            set { _suggestions = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsShops> _shopCategories;

        public ObservableCollection<clsShops> shopCategories
        {
            get { return _shopCategories; }
            set { _shopCategories = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsShops> _serviceCategories;

        public ObservableCollection<clsShops> serviceCategories
        {
            get { return _serviceCategories; }
            set { _serviceCategories = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsShops> _shopTags;
        public ObservableCollection<clsShops> shopTags
        {
            get { return _shopTags; }
            set { _shopTags = value; OnPropertyChanged(); }
        }
        public ICommand ViewShopCmd { get; set; }
        public ICommand selTagCmd { get; set; }
        public ICommand FilerCmd { get; set; }
        public RewardShopViewModel()
        {
            products = new ObservableCollection<clsProduct>();
            serviceCategories = new ObservableCollection<clsShops>();
            shopCategories = new ObservableCollection<clsShops>();
            shopTags = new ObservableCollection<clsShops>();
            suggestions = new ObservableCollection<string>();
            categories = new ObservableCollection<string>();

            suggestions.Add("Barber");
            suggestions.Add("Coffee");
            suggestions.Add("Gas");
            suggestions.Add("Super Mall");
            suggestions.Add("Pet Shop");

            categories.Add("Grocery");
            categories.Add("Barber");
            categories.Add("Beauty");
            categories.Add("Fashion");
            categories.Add("Clothing");
            categories.Add("Car Service");
            categories.Add("Pet Shop");
            categories.Add("Food");
            categories.Add("Tour & Travel");
            categories.Add("Electronics");
            categories.Add("Super Mall");
            categories.Add("Health & Wellbeing");

            shopCategories.Add(new clsShops() {ShopName="Groceries" , ShopImage = "grocery.png" });
            shopCategories.Add(new clsShops() {ShopName="Beauty" , ShopImage = "cosmetic.png" });
            shopCategories.Add(new clsShops() {ShopName="Health &\nWellbeing" , ShopImage = "health_insurance.png" });
            shopCategories.Add(new clsShops() { ShopName = "Convenience", ShopImage = "shop.png" });
            shopCategories.Add(new clsShops() { ShopName = "Electronics", ShopImage = "electronics.png" });
            shopCategories.Add(new clsShops() {ShopName="Household\n& Living" , ShopImage = "cleaning_products.png" });
            shopCategories.Add(new clsShops() { ShopName = "Pets", ShopImage = "pet_house.png" });
            shopCategories.Add(new clsShops() { ShopName = "View all\nshops", ShopImage = "dots.png" });

            serviceCategories.Add(new clsShops() { ShopName = "Barber\nShop", ShopImage = "barber_shop.png"});
            serviceCategories.Add(new clsShops() { ShopName = "Car\nService", ShopImage = "car_service.png" });
            serviceCategories.Add(new clsShops() { ShopName = "Clothing Store", ShopImage = "clothing_shop.png" });
            serviceCategories.Add(new clsShops() { ShopName = "Pet\nShop", ShopImage = "pet_shop.png" });

            shopTags.Add(new clsShops() { ShopName = "All", selected = true });
            shopTags.Add(new clsShops() { ShopName = "Grocery", selected = false });
            shopTags.Add(new clsShops() { ShopName = "Clothes", selected = false });
            shopTags.Add(new clsShops() { ShopName = "Pets", selected=false});

            products.Add(new clsProduct() { PName = "Hair Treatment 20% OFF", PImage= "shop_3.png", Price ="25.00" , Category ="Barber", Save ="5", EndIN = "2" , PriceOff ="30.00"});
            products.Add(new clsProduct() { PName = "Women Clothes 25% OFF", PImage= "shop_2.png", Price ="55.00" , Category ="Fashion", Save ="15", EndIN = "3" , PriceOff ="70.00"});
            products.Add(new clsProduct() { PName = "Baby Gift Products 15% OFF", PImage= "shop_1.png", Price ="15.00" , Category ="Kids Zone", Save ="7", EndIN = "2" , PriceOff ="22.00"});
            products.Add(new clsProduct() { PName = "Ramazan Discount Upto 50%", PImage= "shop_4.png", Price ="45.00" , Category ="Super Mall", Save ="35", EndIN = "4" , PriceOff ="80.00"});

            ViewShopCmd = new Command(SelectedShop);
            selTagCmd = new Command(SelectedTag);
            FilerCmd = new Command(Filter);
        }
        public async void Filter()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AdvanceFilterPage());
        }
        public async void SelectedShop(object obj)
        {
            var item = obj as clsShops;
            if (item.ShopName == "View all\nshops") 
            {
                await Application.Current.MainPage.Navigation.PushAsync(new AllShopsPage());
            }
        }
        public async void SelectedTag(object obj)
        {
            var newitem = obj as clsShops;
            foreach (var item in shopTags)
            {
                if (item != newitem)
                {
                    item.selected = false;
                }
            }
            newitem.selected = true;
        }
    }
}
