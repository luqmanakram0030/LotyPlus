using LotyPlus.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LotyPlus.ViewModels.RewardShop
{
    public class LocationViewModel : BaseViewModel
    {
        private ObservableCollection<clsShops> _shopTags;
        public ObservableCollection<clsShops> shopTags
        {
            get { return _shopTags; }
            set { _shopTags = value; OnPropertyChanged(); }
        }
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; OnPropertyChanged(); }
        }

        public ICommand selTagCmd { get; set; }
        public LocationViewModel()
        {
            shopTags = new ObservableCollection<clsShops>();
            Title = "Home";
            shopTags.Add(new clsShops() { ShopName = "Home", selected = true });
            shopTags.Add(new clsShops() { ShopName = "Office", selected = false });
            shopTags.Add(new clsShops() { ShopName = "Others", selected = false });
            selTagCmd = new Command(SelectedTag);
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
            Title = newitem.ShopName;
        }
    }
}
