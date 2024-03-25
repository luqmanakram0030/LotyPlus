using LotyPlus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotyPlus.Models
{
    public class clsProduct : BaseViewModel
    {
        public string PName { get; set; }
        public ImageSource PImage { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string PriceOff { get; set; }
        public string Save { get; set; }
        public string EndIN { get; set; }
        public string Distance { get; set; }
        public string Rating { get; set; }
        public string Coupons { get; set; }
        private bool _selected;
        public bool selected
        {
            get { return _selected; }
            set
            {
                if (_selected != value)
                {
                    _selected = value;
                    OnPropertyChanged(nameof(selected));
                    OnPropertyChanged(nameof(BackgroundColor));
                    OnPropertyChanged(nameof(BackgroundColor2));
                    OnPropertyChanged(nameof(TextColor));
                }
            }
        }
        private bool _Favorite;
        public bool Favorite
        {
            get { return _Favorite; }
            set
            {
                if (_Favorite != value)
                {
                    _Favorite = value;
                    OnPropertyChanged(nameof(Favorite));
                    OnPropertyChanged(nameof(BackgroundColor2));
                    OnPropertyChanged(nameof(TextColor));
                    OnPropertyChanged(nameof(Text));
                    OnPropertyChanged(nameof(image));
                }
            }
        }

        public string Text => Favorite ? "Favorite" : "Add to\nFavorite";
        public Color BackgroundColor => Favorite ? Color.FromHex("#81248A") : Color.FromHex("#F8F8F8");
        public Color BackgroundColor2 => Favorite ? Color.FromHex("#E70B89") : Color.FromHex("#F8F8F8");
        public Color TextColor => Favorite ? Color.FromHex("#ffffff") : Color.FromHex("#000000");
        public ImageSource image => Favorite ? "heart_fav.png" : "heart_unfav.png";
    }
}
