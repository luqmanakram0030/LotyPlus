using LotyPlus.ViewModels;
using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotyPlus.Models
{
    public class clsNotifications: BaseViewModel
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Time { get; set; }
        private Color _color;

        public Color color
        {
            get { return _color; }
            set { _color = value;OnPropertyChanged(); }
        }

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
                    OnPropertyChanged(nameof(Image));
                }
            }
        }
        public Color BackgroundColor => selected ? Color.FromHex("#E70B89") : Color.FromHex("#00ffffff");
        public Color TextColor => selected ? Color.FromHex("#000000") : Color.FromHex("#707070");
        public ImageSource Image => selected ? "notify_new.png" : "notify_read.png";
    }
}
