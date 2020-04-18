using System;
using System.Collections.Generic;
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
using Group2_CS_FinalProject.Classes;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Group2_CS_FinalProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddProducts : Page
    {
        private Product _prod = new Product();
        MessageDialog added = new MessageDialog($"Item has been added to Shopping Cart.");
        MessageDialog error = new MessageDialog($"Item Quantity Must be an Integer.");
        public AddProducts()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity1.Text);
                int x = 0;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity1.Text = "Enter Quantity";
            }
            catch(FormatException)
            {
                error.ShowAsync();
            }
        }
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity2.Text);
                int x = 1;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity2.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }
        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity3.Text);
                int x = 2;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity3.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }
        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity4.Text);
                int x = 3;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity4.Text = "Enter Quantity";

            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }
        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity5.Text);
                int x = 4;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity5.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }
        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity6.Text);
                int x = 5;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity6.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }
        private void ButtonBase_OnClick7(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity7.Text);
                int x = 6;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity7.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }
        private void ButtonBase_OnClick8(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity8.Text);
                int x = 7;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity8.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick9(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity9.Text);
                int x = 8;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity9.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick10(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity10.Text);
                int x = 9;
                _prod.AddFood(x, qty);
                added.ShowAsync();
                ItemQuantity10.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick11(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity11.Text);
                int x = 0;
                _prod.AddDrink(x, qty);
                added.ShowAsync();
                ItemQuantity11.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick12(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity12.Text);
                int x = 1;
                _prod.AddDrink(x, qty);
                added.ShowAsync();
                ItemQuantity12.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick13(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity13.Text);
                int x = 2;
                _prod.AddDrink(x, qty);
                added.ShowAsync();
                ItemQuantity13.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick14(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity14.Text);
                int x = 3;
                _prod.AddDrink(x, qty);
                added.ShowAsync();
                ItemQuantity14.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick15(object sender, RoutedEventArgs e)
        {
            try
            {
                int qty = int.Parse(ItemQuantity15.Text);
                int x = 4;
                _prod.AddDrink(x, qty);
                added.ShowAsync();
                ItemQuantity15.Text = "Enter Quantity";
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }
    }
}
