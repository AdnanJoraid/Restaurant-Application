﻿using Group2_CS_FinalProject.Classes;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Group2_CS_FinalProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class Receipt : Page
    {
        private List<Product> _prod = new List<Product>();
        public Receipt()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var products = e.Parameter as List<Product>;

            foreach (var prod in products)
            {
                    _prod.Add(prod);
                    ReceiptListViews.Items.Add(prod);
            }

            CalculateReceipt(_prod);
        }


        private void BackToShopping_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoForward();
        }
        public double CalculateReceipt(List<Product> prod)
        {
            double Total = 0;
            foreach (var item in prod)
            {
                Total += (item.ItemPrice * item.ItemQty);
            }
            TotalPrice.Text = $"Your total is {Total}";
            return Total;

           

        }
    }
}
