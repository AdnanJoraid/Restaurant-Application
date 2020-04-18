using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CS_FinalProject.Classes
{
    public class ShoppingCart
    {

        public List<Product> ShoppingList { get; set; } // contains the products selected by the customer


        public ShoppingCart()
        {
            ShoppingList = new List<Product>();
        }


        internal double GetPrice(List<Product> products)
        {
            double price = 0; 
            foreach (Product item in products)
            {
                price += (item.ItemPrice * item.ItemQty);
            }

            return price;
        }

        
    }
}
