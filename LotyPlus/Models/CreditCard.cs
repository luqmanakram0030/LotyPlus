using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LotyPlus.Models
{
    public class CreditCard : INotifyPropertyChanged
    {
        public string BankLogo { get; set; }
        public string BankName { get; set; }
        public int CardType { get; set; }
        public string CardNumber { get; set; }
        public bool IsDefault { get; set; }

        public string CardIcon
        {
            get
            {
                if (CardType == 1)
                    return "https://media.designrush.com/inspiration_images/134782/conversions/_1511457479_332_visa-mobile.jpg";
                else if (CardType == 2)
                    return "https://cdn.iconscout.com/icon/free/png-256/master-card-4-842898.png";
                else
                    return "";
            }
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

