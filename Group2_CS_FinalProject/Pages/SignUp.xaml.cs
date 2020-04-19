using Group2_CS_FinalProject.Classes;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Group2_CS_FinalProject.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignUp : Page
    {
        List<string> UsernameList = new List<string>();
        List<string> PasswordList = new List<string>();

        public SignUp()
        {
            this.InitializeComponent();
        }

        public int CheckList()
        {
            for (int i = 0; i < UsernameList.Count; i++)
            {
                if (NewUsername.Text == UsernameList[i] || NewPassword.Text == PasswordList[1])
                {
                    return 1;
                }
            }
            return 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NewUsername.Text == "" || NewPassword.Text == "")
            {
                MessageDialog Empty = new MessageDialog($"Enter Username and Password");
                Empty.ShowAsync();
            }
            else if (CheckList() == 1)
            {
                MessageDialog Empty = new MessageDialog($"Username or Password Already Taken Please Enter Another One");
                Empty.ShowAsync();
            }
            else
            {

                CustCreate customer = new CustCreate();
                customer.Name = (NewUsername.Text);
                customer.Password = (NewPassword.Text);
                UsernameList.Add(customer.Name);
                PasswordList.Add(customer.Password);
                Frame.Navigate(typeof(MainPage));
            }
        }
    }
}
