using LotyPlus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotyPlus.Models
{
    public class clsShops : BaseViewModel
    {
        public string ShopName { get; set; }
        public ImageSource ShopImage { get; set; }
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
                    OnPropertyChanged(nameof(TextColor));
                }
            }
        }

        public Color BackgroundColor => selected ? Color.FromHex("#81248A") : Color.FromHex("#ffffff");
        public Color TextColor => selected ? Color.FromHex("#ffffff") : Color.FromHex("#000000");
    }
}
