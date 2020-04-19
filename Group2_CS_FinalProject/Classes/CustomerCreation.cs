using Group2_CS_FinalProject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD:Group2_CS_FinalProject/Classes/Customer.cs
using System.Xml.Schema;
using Windows.UI.Xaml.Input;
using Group2_CS_FinalProject.Pages;

namespace Group2_CS_FinalProject.Classes
{
    public class Customer
=======

namespace Group2_CS_FinalProject.Classes
{
    class CustomerCreation
>>>>>>> 1628d12f9f18c21a92df39a3d03f732f4a57718c:Group2_CS_FinalProject/Classes/CustomerCreation.cs
    {

        public string Name { get; set; }
        internal string Password { get; set; }

        public bool DoesExsist(string name, List<Customer> ListCust)
        {
            for (int i = 0; i < ListCust.Count; i++)
            {
                if (name == ListCust[i].Name)
                    return true;
            }

            return false;
        }

    }
}
