using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

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
            PopulateComboBoxes();
            
        }

        private void MonthOfBirthComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
            for (int i = 1; i < 13; i++)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                MonthOfBirthComboBox.Items.Add(monthName);
            }
            //years (min stud age 16 up to 60)

            for (int i = DateTime.Now.Year - 60; i <= DateTime.Now.Year - 16; i++)
            {
                YearOfBirthComboBox.Items.Add(i);
            }
        }

        private void AddCard_OnClick(object sender, RoutedEventArgs e)
        {
            //create a new instance of card

        }
    }
}
