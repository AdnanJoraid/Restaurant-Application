using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_CS_FinalProject.Pages;

namespace Group2_CS_FinalProject.Classes
{
    //Adam Czubernat - Product Class
    //this class holds the properties for the items, method AddFood and AddDrink creates new instance of product class
    //and is called when user wants to add a item to their order. the method gets the item name and price from either class food or drink
    //depending on which method is called, both classes have 2 parameters x for the item postion and qty for the item qty, then it returns
    //the product instance of the item that was added.
    public class Product 
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQty { get; set; }
        public Product AddFood(int x, int qty)
        {
            Product product = new Product
            {
                ItemName = Food.ItemN[x],
                ItemPrice = Food.ItemsP[x],
                ItemQty = qty
            };
            return product;
        }
        public Product AddDrink(int x, int qty)
        {
            Product product = new Product
            {
                ItemName = Drink.DrinkN[x],
                ItemPrice = Drink.DrinkP[x],
                ItemQty = qty
            };
            return product;
        }

        }
}
