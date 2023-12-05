using System;
using LotyPlus.ViewModels;

namespace LotyPlus.Models
{
    public class Service :BaseViewModel
    {
        public int Id { get; set; }
        public string LockedIcon { get; set; } = "lockedserviceicon.png";
        public string UnlockedIcon { get; set; }
        public bool IsLocked { get; set; }

        bool isSelected;
        public bool IsSelected
        {
            set
            {
                isSelected = value;
                OnPropertyChanged();
            }
            get => isSelected;
        }
        public Color IndicatorColor
        {
            get
            {
                if (IsLocked)
                    return (Color)Application.Current.Resources["GreyColor"];
                else
                    return (Color)Application.Current.Resources["SecondoryColor"];
            }
        }
    }
}

