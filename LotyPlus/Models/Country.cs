using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LotyPlus.Models
{
    public class Country : INotifyPropertyChanged
    {
        public string FlagImage { get; set; }
        public string CountryName { get; set; }
        public bool IsChecked { get; set; }

        Color frameColor;
        public Color FrameColor
        {
            set
            {
                frameColor = value;
                onPropertyChanged();
            }
            get => frameColor;
        }
        Color radioColor;
        public Color RadioColor
        {
            set
            {
                radioColor = value;
                onPropertyChanged();
            }
            get => radioColor;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

