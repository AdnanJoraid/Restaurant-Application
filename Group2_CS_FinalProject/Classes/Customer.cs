using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Windows.UI.Xaml.Input;

namespace Group2_CS_FinalProject.Classes
{
    class Customer
    {
        public string Name { get; set; }
        public string Password { get; set; }

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
