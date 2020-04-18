using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Input.Spatial;
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
    public sealed partial class CreditCardAddingPage : Page
    {
        public CreditCardAddingPage()
        {
            this.InitializeComponent();
            PopulateComboBoxes(); //calls the method that fills ComboBoxes 
            //CreditValidation();


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

        private void AddCard_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                CreditValidation();
                CreditCard card = new CreditCard() //when the user enter the data it will create a new card and assigns the values for it
                {
                    CardNumber = int.Parse(NumberOnCreditCard.Text),
                    Cvv = int.Parse(CvvNumber.Text),
                    Date = $"{DayOfBirthComboBox.Text} {MonthOfBirthComboBox.Text} {YearOfBirthComboBox.Text}",
                    Name = NameOnCredit.Text,
                    CardStatus = CreditCardStatus.Approved

                };


                if (CreditValidation())
                {
                    this.Frame.Navigate(typeof(ShoppingCartPage), card);
                }
                else
                {
                    MessageDialog message = new MessageDialog("Please enter the correct amount of digits");
                    message.ShowAsync();
                }
            }
            catch (Exception)
            {
                MessageDialog message = new MessageDialog("Please enter a valid data"); //if the user entered invalid data this message will popup 
                message.ShowAsync(); 

            }

        }

        private bool CreditValidation()
        {

            bool isValid = NumberOnCreditCard.Text.Length == 16 && CvvNumber.Text.Length == 3;

         
            return isValid; 
        }

    }
}
