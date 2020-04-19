using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
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
    public sealed partial class MainPage : Page
    {
        //Adam Czubernat - MainPage.xaml.cs
        //ButtonBase_OnClick:
        //when user press the top taskbar button, if the panel is closed, it will change it to open
        // and add names for each button, and if user press this button and the panel is open, it will close the panel
        //and get rid of the names of each button.
        //ButtonBase_OnClick1:
        //navigates to the main Page when button click
        //ButtonBase_OnClick2:
        //navigates to the AddProducts page when button click
        public MainPage()
        {
            this.InitializeComponent();
            frame.Navigate(typeof(Main));
        }


        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (mSplit.IsPaneOpen == false)
            {

                mSplit.IsPaneOpen = true;
                TextBlock1.Text = "Home";
                TextBlock2.Text = "Add Items";
                TextBlock3.Text = "Shopping Cart";
                TextBlock4.Text = "Customer";
                TextBlock5.Text = "Settings";
                TextBlock6.Text = "Receipt";

            }
            else if (mSplit.IsPaneOpen == true)
            {
                mSplit.IsPaneOpen = false;
                TextBlock1.Text = "";
                TextBlock2.Text = "";
                TextBlock3.Text = "";
                TextBlock4.Text = "";
                TextBlock5.Text = "";
                TextBlock6.Text = "";
            }
        }

        private void ButtonBase_OnClick1(Object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Main));
        }
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {

            frame.Navigate(typeof(AddProducts));
        }
        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(ShoppingCartPage));
        }
        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Customer));
        }
        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            frame.Navigate(typeof(Receipt));
        }
    }
}
