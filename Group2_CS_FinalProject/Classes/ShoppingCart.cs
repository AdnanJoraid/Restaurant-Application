using System;
using System.Collections.Generic;
using System.Linq;
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

        // list of products selected by the user. 
        //displays the total amount 
        //asks for the credit info and balance 
        //uses the CreditCard class 
        //moves the cart to the receipt class in which the total price will be displayed
        //initialize the list in the constructor 

    }
}
