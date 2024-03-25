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
    public class AllShopsViewModel : BaseViewModel
    {
        private ObservableCollection<clsProduct> _products;

        public ObservableCollection<clsProduct> products
        {
            get { return _products; }
            set { _products = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsShops> _shopTags;
        public ObservableCollection<clsShops> shopTags
        {
            get { return _shopTags; }
            set { _shopTags = value; OnPropertyChanged(); }
        }
        public ICommand SelCmd { get; set; }
        public ICommand selTagCmd { get; set; }
        public ICommand FavCmd { get; set; }
        public AllShopsViewModel()
        {
            shopTags = new ObservableCollection<clsShops>();
            products = new ObservableCollection<clsProduct>();

            shopTags.Add(new clsShops() { ShopName = "All", selected = true });
            shopTags.Add(new clsShops() { ShopName = "Grocery", selected = false });
            shopTags.Add(new clsShops() { ShopName = "Clothes", selected = false });
            shopTags.Add(new clsShops() { ShopName = "Pets", selected = false });
            shopTags.Add(new clsShops() { ShopName = "Sports", selected = false });
            shopTags.Add(new clsShops() { ShopName = "Food", selected = false });

            products.Add(new clsProduct() { PName = "Super Mercado de Vander", PImage = "shop4inlist.png",Distance="20", Coupons="3", Rating ="4.8" , Favorite= true});
            products.Add(new clsProduct() { PName = "Aqua Street", PImage = "shop7inlist.png", Distance = "5", Coupons = "2", Rating = "4.2", Favorite = false });
            products.Add(new clsProduct() { PName = "Drivezy", PImage = "shop2inlist.png", Distance = "28", Coupons = "4", Rating = "4.7", Favorite = false });
            products.Add(new clsProduct() { PName = "Teco Bell", PImage = "shop8inlist.png", Distance = "30", Coupons = "2", Rating = "5.0", Favorite = true });
            products.Add(new clsProduct() { PName = "Desh Travels", PImage = "shop6inlist.png", Distance = "20", Coupons = "5", Rating = "4.4", Favorite = false });
            products.Add(new clsProduct() { PName = "Jamuna Future Park", PImage = "shop3inlist.png", Distance = "10", Coupons = "8", Rating = "4.6", Favorite = false });
            products.Add(new clsProduct() { PName = "Illiyeen", PImage = "shop1inlist.png", Distance = "40", Coupons = "4", Rating = "4.7", Favorite = true });
            products.Add(new clsProduct() { PName = "Scissor Man's World", PImage = "shop5inlist.png", Distance = "5", Coupons = "3", Rating = "5.0", Favorite = false });
           
            selTagCmd = new Command(SelectedTag);
            FavCmd = new Command(Favorite);
            SelCmd = new Command(Selected);
        }
        public async void Selected(object obj)
        {
            var item = obj as clsProduct;
            await Application.Current.MainPage.Navigation.PushAsync(new FeedbackPage(item));
        }
        public async void Favorite(object obj)
        {
            var item = obj as clsProduct;
            
            item.Favorite = !item.Favorite;
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
