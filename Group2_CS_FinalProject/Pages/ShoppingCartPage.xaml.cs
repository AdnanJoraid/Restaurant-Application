using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
        /// <summary>
        /// This page is responsible for saving/creating creditcard and shopping carts, this page also validates inputs and uses other classes. 
        /// </summary>
        private readonly List<CreditCard> _cardsHistory = new List<CreditCard>();

        private readonly List<Product> _mainShoppingCart = new List<Product>();
        public ShoppingCartPage()
        {
            this.InitializeComponent();
            PopulateComboBoxes(); //calls the method populateComboBoxes as soon as the page loads
        }


        private void CreditCardButton_OnClick(object sender, RoutedEventArgs e) //when the pay using credit card button is pressed
        {
            try
            {
                double oldBalance = _cardsHistory[0].TotalBalance; //stores the balance of the card before the payment
                var card = _cardsHistory[0]; //stores the first card object in the _cardHistoryList

                double total = 0; //sets total for 0
                foreach (var item in _mainShoppingCart) //loop over the items in shoppingcart
                {
                    total += (item.ItemPrice * item.ItemQty); //gets the total and adds it 
                }

                if (card.Pay(total, oldBalance)) //if the balance is less than the amount 
                {
                    double newBalance = card.TotalBalance - total; //gets the new total amount

                    MessageDialog mApproved = new MessageDialog($"Your payment status is '{CreditCardStatus.Approved}'. The total price of your order is {total}. Your " +
                                                        $"new balance is {newBalance}");
                    mApproved.ShowAsync();
                }
                else
                {
                    MessageDialog m2 = new MessageDialog($"Your order status is {CreditCardStatus.Declined}, your total price is less than the payment price");
                    m2.ShowAsync();
                }
                


            }
            catch (Exception)
            {
                MessageDialog message = new MessageDialog("Error. Please try again"); //shows this if there was unexpected error
                message.ShowAsync();
            }

        }


        


        protected override void OnNavigatedTo(NavigationEventArgs e) //accepts the data from pages 
        {


            try
            {
                if (e.Parameter is List<Product> products) //if the data passed is of type list of products
                {
                    foreach (var item in products) //loop over the list
                    {
                        _mainShoppingCart.Add(item); //adds item to the shopping cart 
                    
                    }

                    foreach (var VARIABLE in _mainShoppingCart) //adds item to list view
                    {
                        ShoppingCartListView.Items.Add(VARIABLE);
                    }

                }
                
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageDialog m = new MessageDialog($"Error. Please try again"); //if error this message will occur
                m.ShowAsync();
            }

            
            
        }

        

        private void LockingCreditButton(bool added) //if a creditcard is added, the button for that will be locked
        {
            if (added)
            {
                CreditAdded.IsEnabled = false;
                CreditCardButton.IsEnabled = true;
            }
                
        }

      

        private void MonthOfBirthComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) //calculate the day of month for every month
        {
            DayOfBirthComboBox.Items.Clear();
            int daysOfMonth = 0;

            switch (MonthOfBirthComboBox.SelectedIndex + 1)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysOfMonth = 31;
                    break;
                case 2:
                    daysOfMonth = 29;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysOfMonth = 30;
                    break;
            }

            for (int i = 1; i < daysOfMonth + 1; i++)
            {
                DayOfBirthComboBox.Items.Add(i);
            }
        }

        private void PopulateComboBoxes()
        {

            //month 
            for (int i = 1; i < 13; i++) //adds the months 
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                MonthOfBirthComboBox.Items.Add(monthName);
            }

            for (int i = DateTime.Now.Year + 1; i <= DateTime.Now.Year + 20; i++) //adds the years from 2020 to 2040
            {
                YearOfBirthComboBox.Items.Add(i);
            }
        }


        private void AddCreditButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CreditValidation())
                {
                    CreditCard card = new CreditCard() //when the user enter the data it will create a new card and assigns the values for it
                    {
                        CardNumber = NumberOnCreditCard.Text, //int.Parse(NumberOnCreditCard.Text),
                        Cvv = int.Parse(CvvNumber.Text),
                        Date = $"{DayOfBirthComboBox.Text} {MonthOfBirthComboBox.Text} {YearOfBirthComboBox.Text}",
                        Name = NameOnCredit.Text,
                        CardStatus = CreditCardStatus.Approved

                    };
                    _cardsHistory.Add(card);
                    card.GenerateBalance();
                    IsCreditCardAdded.Text = $"Your CreditCard status is {card.CardStatus}!\n Your current Balance is ${card.TotalBalance}";
                    LockingCreditButton(true);


                }
                else
                {
                    MessageDialog message1 = new MessageDialog("Please enter the correct amount of digits");
                    message1.ShowAsync();
                }
            }
            catch (Exception exception)
            {
                MessageDialog message = new MessageDialog($"Please enter a valid data {exception}"); //if the user entered invalid data this message will popup 
                message.ShowAsync();

            }
        }

        private bool CreditValidation() //validates the credit card input 
        {

            bool isValid = NumberOnCreditCard.Text.Length == 16 && CvvNumber.Text.Length == 3; ///var of type bool 

            return isValid; 
        }


        private void MoveToReceipt_OnClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Receipt), _mainShoppingCart); //passes data and navigate to Receipt page
        }
    }
}
