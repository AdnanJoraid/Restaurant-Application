﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Group2_CS_FinalProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReceiptPage : Page
    {
        private List<Product> _prod = new List<Product>();
        public ReceiptPage()
        {
            this.InitializeComponent();
        }
        public double TotalCost()
        {
            double total = 0;
            foreach (var item in _prod)
            {
                total += (item.ItemPrice * item.ItemQty);
            }

            return total;
        }
        private void BackToShopping_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoForward();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is List<Product> products)           
            {
                foreach (var item in products) 
                {
                    _prod.Add(item);

                }
            }
        }
    
    }
    
}
