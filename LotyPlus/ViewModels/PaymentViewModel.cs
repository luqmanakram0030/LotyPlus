using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using LotyPlus.Models;

namespace LotyPlus.ViewModels
{
    public class PaymentViewModel : BaseViewModel
    {
        CreditCard previosSelectedCreditCard;
        readonly IList<CreditCard> creditCardList;

        public ObservableCollection<CreditCard> CreditCardList { get; set; }
        public ICommand CreditCardTappedCommand { get; set; }
        public PaymentViewModel()
        {
            creditCardList = new List<CreditCard>();

            CreditCardTappedCommand = new Command<CreditCard>((model) =>
            {
                if (previosSelectedCreditCard != null)
                    previosSelectedCreditCard.RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"];

                model.RadioColor = (Color)Application.Current.Resources["SecondoryColor"];
                previosSelectedCreditCard = model;
            });


            CreateCreditCardList();
        }

        public void CreateCreditCardList()
        {
            creditCardList.Clear();
            creditCardList.Add(new CreditCard() { BankLogo = "https://seeklogo.com/images/B/banco-de-costa-rica-logo-1571547C6B-seeklogo.com.png", BankName = "Banco de Costa Rica", CardNumber = "123 *** 456", CardType = 1, RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"], IsDefault = true });
            creditCardList.Add(new CreditCard() { BankLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Bank_Central_Asia.svg/2560px-Bank_Central_Asia.svg.png", BankName = "Bank Central Asia", CardNumber = "098 *** 765", CardType = 2, RadioColor = (Color)Application.Current.Resources["ColorOnDarkBackground"] });

            foreach (var creditCard in creditCardList)
            {
                if (creditCard.IsDefault)
                {
                    creditCardList[0].RadioColor = (Color)Application.Current.Resources["SecondoryColor"];
                    previosSelectedCreditCard = creditCardList[0];
                }
            }

            CreditCardList = new ObservableCollection<CreditCard>(creditCardList);
        }
    }
}

