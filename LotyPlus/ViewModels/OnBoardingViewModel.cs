using LotyPlus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LotyPlus.ViewModels
{
    public class OnBoardingViewModel : BaseViewModel
    {
        private List<OnBoardingItem> onBoardingList;

        public List<OnBoardingItem> OnBoardingList
        {
            get { return onBoardingList; }
            set { this.onBoardingList = value; }
        }
        private int _position;

        public int position
        {
            get { return _position; }
            set { _position = value; OnPropertyChanged(); }
        }

        public OnBoardingViewModel()
        {
            OnBoardingList = new List<OnBoardingItem>()
            {
                new OnBoardingItem()
                {
                    Image = "onboardingimg1.png",
                    Title = "You Are Discovering",
                    Description = "The most versatile app to get\npromotions and participate on big\nsweeptakes"
                },
                new OnBoardingItem()
                {
                    Image = "onboardingimg2.png",
                    Title = "We Have 3 Types Of\nSweeptakes",
                    Description = "This coupon is wonderful to redeem at\nthe moment.\nFor example, a discount for a meal."
                },
                new OnBoardingItem()
                {
                    Image = "onboardingimg3.png",
                    Title = "Coupons You Redeem\nOn The Business",
                    Description = "You can buy the coupon here and\nthen redeem it later. Usually this\ncoupons are limited in a quantity."
                },
                new OnBoardingItem()
                {
                    Image = "onboardingimg4.png",
                    Title = "Coupons You Buy\nBecause Are Limited",
                    Description = "And you can take advantage of all of\nthem."
                },
                new OnBoardingItem()
                {
                    Image = "onboardingimg5.png",
                    Title = "And The Big One, Lovely\nSweeptakes",
                    Description = "Paper is on the past, you can\nparticipate on big prizes that business\ncurrently have on the market."
                },
                new OnBoardingItem()
                {
                    Image = "onboardingimg6.png",
                    Title = "That's All You Need To\nKnow",
                    Description = ""
                }
            };
        }
    }
}
