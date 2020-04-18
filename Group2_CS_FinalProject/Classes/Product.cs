using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CS_FinalProject.Classes
{
    public class Product 
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public void AddFood(int x)
        {
            Product product = new Product
            {
                ItemName = Food.ItemN[x],
                ItemPrice = Food.ItemsP[x]
            };
            ShoppingCart shop = new ShoppingCart();
            shop.ShoppingList.Add(product);
        }

        public void AddDrink(int x)
        {
            Product product = new Product
            {
                ItemName = Drink.DrinkN[x],
                ItemPrice = Drink.DrinkP[x]
            };
            ShoppingCart shop = new ShoppingCart();
            shop.ShoppingList.Add(product);
        }

        }
}
