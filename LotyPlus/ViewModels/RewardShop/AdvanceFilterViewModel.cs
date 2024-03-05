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
    public class AdvanceFilterViewModel : BaseViewModel
    {
        private ObservableCollection<clsProduct> _locations;

        public ObservableCollection<clsProduct> locations
        {
            get { return _locations; }
            set { _locations = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsProduct> _coupons;

        public ObservableCollection<clsProduct> coupons
        {
            get { return _coupons; }
            set { _coupons = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsProduct> _ratings;

        public ObservableCollection<clsProduct> ratings
        {
            get { return _ratings; }
            set { _ratings = value; OnPropertyChanged(); }
        }
        public ICommand selLocCmd { get; set; }
        public ICommand selCoupCmd { get; set; }
        public ICommand selRateCmd { get; set; }
        public AdvanceFilterViewModel()
        {
            ratings = new ObservableCollection<clsProduct>();
            locations = new ObservableCollection<clsProduct>();
            coupons = new ObservableCollection<clsProduct>();

            coupons.Add(new clsProduct { Coupons = "Popular", Distance="2 - 4 km area" ,selected=true });
            coupons.Add(new clsProduct { Coupons = "This Week", Distance="5 - 10 km area" ,selected=false });
            coupons.Add(new clsProduct { Coupons = "This Month", Distance="Above 10 km" ,selected=false });

            locations.Add(new clsProduct { Distance="2 - 4 km area" ,selected=false });
            locations.Add(new clsProduct {  Distance="5 - 10 km area" ,selected=false });
            locations.Add(new clsProduct {  Distance="Above 10 km" ,selected=true });

            ratings.Add(new clsProduct { Rating="5" ,selected=true });
            ratings.Add(new clsProduct { Rating="4" ,selected=false });
            ratings.Add(new clsProduct { Rating="3" ,selected=false });
            ratings.Add(new clsProduct { Rating="2" ,selected=false });
            ratings.Add(new clsProduct { Rating="1" ,selected=false });

            selLocCmd = new Command(Distance);
            selCoupCmd = new Command(Coupons);
            selRateCmd = new Command(Rating);
        }
        public async void Distance(object obj)
        {
            var newitem = obj as clsProduct;
            foreach (var item in locations)
            {
                if (item != newitem)
                {
                    item.selected = false;
                }
            }
            newitem.selected = true;
        }
        public async void Rating(object obj)
        {
            var newitem = obj as clsProduct;
            foreach (var item in ratings)
            {
                if (item != newitem)
                {
                    item.selected = false;
                }
            }
            newitem.selected = true;
        }
        public async void Coupons(object obj)
        {
            var newitem = obj as clsProduct;
            foreach (var item in coupons)
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
