using LotyPlus.Models;
using LotyPlus.Views.RewardShop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LotyPlus.ViewModels
{
    public class NotificationViewModel : BaseViewModel
    {
        private ObservableCollection<clsNotifications> _notify1;

        public ObservableCollection<clsNotifications> notify1
        {
            get { return _notify1; }
            set { _notify1 = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsNotifications> _notify2;

        public ObservableCollection<clsNotifications> notify2
        {
            get { return _notify2; }
            set { _notify2 = value; OnPropertyChanged(); }
        }
        private ObservableCollection<clsNotifications> _notify3;

        public ObservableCollection<clsNotifications> notify3
        {
            get { return _notify3; }
            set { _notify3 = value; OnPropertyChanged(); }
        }
        public ICommand notiSelCmd { get; set; }
        public NotificationViewModel()
        {
            notify1 = new ObservableCollection<clsNotifications>();
            notify2 = new ObservableCollection<clsNotifications>();
            notify3 = new ObservableCollection<clsNotifications>();

            notify1.Add(new clsNotifications() { Title= "New coupon in the shop!", Detail= "Tecobell brings a new coupon in town ...", Time = "2h ago", selected=true });
            notify1.Add(new clsNotifications() { Title= "Waiting for review", Detail= "You have used a coupon. Give it a feedback", Time = "12h ago", selected=true });
            notify1.Add(new clsNotifications() { Title= "Win a Reward!!!", Detail= "You have won a reward! Check these out.", Time = "18h ago", selected=true });

            notify2.Add(new clsNotifications() { Title= "New coupon in shop", Detail= "TravelBD brings a new coupon! Check that ...", Time = "yesterday", selected=false , color= Color.FromHex("#00ffffff") });
            notify2.Add(new clsNotifications() { Title= "Waiting for review", Detail= "You have used a coupon. Give it a feedback", Time = "yesterday", selected=true, color = Color.FromHex("#00ffffff") });
            notify2.Add(new clsNotifications() { Title= "Waiting for review", Detail= "You have used a coupon. Give it a feedback", Time = "yesterday", selected=true, color = Color.FromHex("#00ffffff") });

            notify3.Add(new clsNotifications() { Title= "New coupon in shop", Detail= "TravelBD brings a new coupon! Check that ...", Time = "03-05-2023", selected=false, color = Color.FromHex("#00ffffff") });
            notify3.Add(new clsNotifications() { Title= "Review Complete!!!", Detail= "Thanks for your valuable review here", Time = "03-05-2023", selected=false, color = Color.FromHex("#00ffffff") });

            notiSelCmd = new Command(Selected);
        }
        public async void Selected(object obj)
        {
            var item = obj as clsNotifications;
            item.selected = false;
            if (item.Title == "Waiting for review")
            {
                var model = new clsProduct();
                model.PName = "Tecobell";
                await Application.Current.MainPage.Navigation.PushAsync(new FeedbackPage(model));
            }
        }
    }
}
