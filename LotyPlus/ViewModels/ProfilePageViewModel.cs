using System;
namespace LotyPlus.ViewModels
{
    public class ProfilePageViewModel : BaseViewModel
    {
        private List<ProfileItem> optionsList;

        public List<ProfileItem> OptionsList
        {
            get { return optionsList; }
            set { this.optionsList = value; }
        }

        public ProfilePageViewModel()
        {
            OptionsList = new List<ProfileItem>()
            {
                new ProfileItem()
                {
                    ItemName = "My Wallet"
                },
                new ProfileItem()
                {
                    ItemName = "Coupon History"
                },
                new ProfileItem()
                {
                    ItemName = "Running Coupon"
                },
                new ProfileItem()
                {
                    ItemName = "Edit Profile"
                }
            };
        }
    }

    public class ProfileItem
    {
        public string ItemName { get; set; }
    }
}

