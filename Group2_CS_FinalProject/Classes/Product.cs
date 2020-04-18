using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2_CS_FinalProject.Pages;

namespace Group2_CS_FinalProject.Classes
{
    public class Product 
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int ItemQty { get; set; }
        List<Product> Item = new List<Product>();
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
