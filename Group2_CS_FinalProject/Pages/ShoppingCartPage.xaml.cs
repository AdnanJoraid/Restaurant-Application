using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Group2_CS_FinalProject.Classes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Group2_CS_FinalProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShoppingCartPage : Page
    {

        private List<CreditCard> _cardsHistory = new List<CreditCard>();

        private List<Product> _mainShoppingCart = new List<Product>();
        public ShoppingCartPage()
        {
            this.InitializeComponent();
        }


        private void CreditCardButton_OnClick(object sender, RoutedEventArgs e)
        {
              
        }


        private void AddCreditButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CreditCardAddingPage));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            try
            {
                
                if (_cardsHistory.Count == 0)
                {
                    var credit = e.Parameter as CreditCard;
                    credit.GenerateBalance();
                    IsCreditCardAdded.Text = $"Your CreditCard status is {credit.CardStatus}!\n Your current Balance is ${credit.TotalBalance}";
                    LockingCreditButton(true);
                     

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageDialog m = new MessageDialog($"Your CreditCard is not added, please add it by pressing the 'Add CreditCard' button");
                m.ShowAsync();
            }
            
        }

        private void LockingCreditButton(bool added)
        {
            if (added)
            {
                AddCreditButton.IsEnabled = false;
                CreditCardButton.IsEnabled = true;
            }
                
        }

        public bool IsAbleToPay()
        {
            //if the card balance is less then the total amount throw an exeption use the pay method from creditcard class.
            //var card = card[0], cart = shopping[0]; => if card.balance < cart.total return false else true; 
            
            return true;
        }


    }
}
