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
    //Adam Czubernat - AddProducts.xaml.cs
    //This xaml.cs has all the button click events for when user adds item and when user adds his items to the shopping cart.
    //for each button it adds an instance of product to a list ListItems, qty and x are sent to either AddFood or AddDrink to determine item name,
    //price and qty, then stores it in the ListItems list. then each button that adds item to list, there is try and catch that assures that the user enters
    //a interger for the quantity of each item. then ButtonBase_OnClick15 checks if the list is empty, and if it is it throws message to add item, else it navigates
    //user to shoppinCartPage also passing list ItemsList for that class to use.

    public sealed partial class AddProducts : Page
    {
        private Product _prod = new Product();
        public List<Product> ListItems = new List<Product>();
        MessageDialog added = new MessageDialog($"Item has been Saved.");
        MessageDialog error = new MessageDialog($"Item Quantity Must be an Integer.");
        MessageDialog EmptList = new MessageDialog($"No Items Saved, Add items to proceed");
        public AddProducts()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            try
            {
                //int x = 0;
                //int qty = int.Parse(ItemQuantity1.Text);
                //Product product = new Product
                //{
                //    ItemName = Food.ItemN[x],
                //    ItemPrice = Food.ItemsP[x],
                //    ItemQty = qty
                //};
                //ListItems.Add(product);
                //added.ShowAsync();
                //ItemQuantity1.Text = "Enter Quantity";

                int qty = int.Parse(ItemQuantity1.Text);
                int x = 0;
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
            }
            catch (FormatException)
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
               

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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddFood(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddDrink(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddDrink(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddDrink(x, qty));
                added.ShowAsync();
                
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
                ListItems.Add(_prod.AddDrink(x, qty));
                added.ShowAsync();
                
            }
            catch (FormatException)
            {
                error.ShowAsync();
            }
        }

        private void ButtonBase_OnClick15(object sender, RoutedEventArgs e)
        {
            if (ListItems.Count == 0)
            {
                EmptList.ShowAsync();
            }
            else
                this.Frame.Navigate(typeof(ShoppingCartPage),ListItems);
        }
    }
}
