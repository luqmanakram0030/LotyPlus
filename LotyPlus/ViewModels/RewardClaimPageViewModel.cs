using System;
using System.Collections.ObjectModel;
using LotyPlus.Models;

namespace LotyPlus.ViewModels
{
    public class RewardClaimPageViewModel : BaseViewModel
    {
        int totalServices;
        public int TotalServices
        {
            get => totalServices;
            set
            {
                totalServices = value;
                OnPropertyChanged();
            }
        }

        int unlockedServices;
        public int UnlockedServices
        {
            get => unlockedServices;
            set
            {
                unlockedServices = value;
                OnPropertyChanged();
            }
            
        }

        bool isRewardUnlocked = false;
        public bool IsRewardUnlocked
        {
            get => isRewardUnlocked;
            set
            {
                isRewardUnlocked = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Service> ServicesList { get; set; }

        public RewardClaimPageViewModel()
        {
            ServicesList = new ObservableCollection<Service>()
            {
                new Service(){ Id = 0, IsLocked = false, UnlockedIcon = "unlockedserviceicon1.png" },
                new Service(){ Id = 1, IsLocked = false, UnlockedIcon = "unlockedserviceicon2.png" },
                new Service(){ Id = 2, IsLocked = false, UnlockedIcon = "unlockedserviceicon3.png" },
                new Service(){ Id = 3, IsLocked = false, UnlockedIcon = "unlockedserviceicon4.png" },
                new Service(){ Id = 4, IsLocked = true, UnlockedIcon = "unlockedserviceicon5.png" },
                new Service(){ Id = 5, IsLocked = true, UnlockedIcon = "unlockedserviceicon6.png" },
                new Service(){ Id = 6, IsLocked = true, UnlockedIcon = "unlockedserviceicon7.png" },
                new Service(){ Id = 7, IsLocked = true, UnlockedIcon = "unlockedserviceicon8.png" },
                new Service(){ Id = 8, IsLocked = true, UnlockedIcon = "unlockedserviceicon9.png" },
            };

            TotalServices = ServicesList.Count;
            foreach (var service in ServicesList)
            {
                if (!service.IsLocked)
                    UnlockedServices += 1;
            }

            //_ = AnimateCell();
        }

        //async Task AnimateCell()
        //{
        //    await Task.Delay(1000);

        //    ServicesList[3].IsSelected = true;
        //}
    }
}

