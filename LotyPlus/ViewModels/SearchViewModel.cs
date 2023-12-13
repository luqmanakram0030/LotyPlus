using System;
using LotyPlus.Models;

namespace LotyPlus.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        private List<SearchCategory> promoTypeList;

        public List<SearchCategory> PromoTypeList
        {
            get { return promoTypeList; }
            set { this.promoTypeList = value; }
        }

        private List<SearchCategory> businessTypeList;

        public List<SearchCategory> BusinessTypeList
        {
            get { return businessTypeList; }
            set { this.businessTypeList = value; }
        }

        public SearchViewModel()
        {
            PromoTypeList = new List<SearchCategory>();
            BusinessTypeList = new List<SearchCategory>();
            PromoTypeList = new List<SearchCategory>()
            {
                new SearchCategory(){ Id = 0, Icon = "icon1.png", Title = "By scanning a code", Description = "Like gas stations" },
                new SearchCategory(){ Id = 1, Icon = "icon2.png", Title = "By redeeming a code", Description = "Like a discount for a food restaurant" },
                new SearchCategory(){ Id = 2, Icon = "icon3.png", Title = "By buying limited coupon", Description = "Like a special package for a car wash" }
            };

            BusinessTypeList = new List<SearchCategory>()
            {
                new SearchCategory(){ Id = 3, Icon = "icon4.png", Title = "Gas Stations", Description = "4 availables" },
                new SearchCategory(){ Id = 4, Icon = "icon5.png", Title = "Clothes", Description = "Zara added promos recently" },
                new SearchCategory(){ Id = 5, Icon = "icon6.png", Title = "Restaurants", Description = "15% on Mcdonald" },
                new SearchCategory(){ Id = 6, Icon = "icon7.png", Title = "Supermarkets", Description = "No promos availables" },
                new SearchCategory(){ Id = 6, Icon = "icon7.png", Title = "Supermarkets", Description = "No promos availables" },
                new SearchCategory(){ Id = 6, Icon = "icon7.png", Title = "Supermarkets", Description = "No promos availables" },
                new SearchCategory(){ Id = 6, Icon = "icon7.png", Title = "Supermarkets", Description = "No promos availables" },
            };
        }
    }
}

