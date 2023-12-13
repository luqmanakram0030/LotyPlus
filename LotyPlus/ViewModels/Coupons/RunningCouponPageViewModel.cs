using System;
using System.Windows.Input;
namespace LotyPlus.ViewModels.Coupons
{
    public class RunningCouponPageViewModel : BaseViewModel
    {
        private List<Coupon> couponsList;

        public List<Coupon> CouponsList
        {
            get { return couponsList; }
            set { couponsList = value; }
        }

        private List<RewardShop> rewardShopList;

        public List<RewardShop> RewardShopList
        {
            get { return rewardShopList; }
            set { rewardShopList = value; }
        }

        public RunningCouponPageViewModel()
        {
            CouponsList = new List<Coupon>()
            {
                new Coupon() { CouponName = "MACDONALDS", CouponImage = "https://www.seekpng.com/png/detail/217-2178549_mcdonalds-1992-logo-with-2003-slogan-mcdonalds-logo.png", CouponValidity = "12th Nov 2021", CouponValue = "$10", CouponType = "Coupon" },
                new Coupon() { CouponName = "PIZZA HUT", CouponImage = "https://seeklogo.com/images/P/pizza-hut-logo-DBFE2E48AF-seeklogo.com.png", CouponValidity = "12th Nov 2021", CouponValue = "$12", CouponType = "Coupon" },
                new Coupon() { CouponName = "DOMINOS", CouponImage = "https://www.visitnarrabri.com.au/ukonekra/2021/02/1200px-Dominos_pizza_logo.svg.png", CouponValidity = "12th Nov 2021", CouponValue = "5%", CouponType = "Coupon" },
                new Coupon() { CouponName = "STARBUCKS", CouponImage = "https://seeklogo.com/images/S/Starbucks_Coffee-logo-DECE0A6E4B-seeklogo.com.png", CouponValidity = "12th Nov 2021", CouponValue = "50%off", CouponType = "Coupon" },
                new Coupon() { CouponName = "TACO BELL", CouponImage = "https://menuswithprices.com/wp-content/uploads/2021/01/Taco-Bell-Logo.png", CouponValidity = "12th Nov 2021", CouponValue = "Buy1Get1", CouponType = "Coupon" },
                new Coupon() { CouponName = "KFC", CouponImage = "https://image.similarpng.com/thumbnail/2020/06/kfc-logo-free-download-PNG.png", CouponValidity = "12th Nov 2021", CouponValue = "Buy1Get1", CouponType = "Coupon" }
            };

            RewardShopList = new List<RewardShop>()
            {
                new RewardShop() { ShopName = "Barber\nShop", ShopImg = "barbershop.png"},
                new RewardShop() { ShopName = "Car\nServicing", ShopImg = "carservicing.png"},
                new RewardShop() { ShopName = "Pump\nStations", ShopImg = "pumpstations.png"},
                new RewardShop() { ShopName = "Pet\nShop", ShopImg = "petshop.png"},
                new RewardShop() { ShopName = "Cloth\nStore", ShopImg = "clothstore.png"},
                new RewardShop() { ShopName = "Home\nServices", ShopImg = "homeservices.png"},
            };
        }

        public class Coupon
        {
            public string CouponName { get; set; }
            public string CouponImage { get; set; }
            public string CouponValidity { get; set; }
            public string CouponValue { get; set; }
            public string CouponType { get; set; }
        }

        public class RewardShop
        {
            public string ShopName { get; set; }
            public string ShopImg { get; set; }

            public ICommand RewardShopCommand { private set; get; }

            public RewardShop()
            {
                RewardShopCommand = new Command(execute: async () =>
                {
                    await Shell.Current.GoToAsync(nameof(Views.RewardShop.RewardClaimPage));
                }, canExecute: () => true);
            }
        }
    }
}

