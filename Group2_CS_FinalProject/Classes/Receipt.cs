using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CS_FinalProject.Classes
{
    class Receipt
    {
        private List<Product> _prod = new List<Product>();
        public string ReceiptNumber { get; set; }
        public DateTime date { get; set; }



        public double CalculateReceipt(List<Product> prod)
        {
            double TotalPrice = 0;
            foreach (var item in prod)
            {
                TotalPrice += (item.ItemPrice * item.ItemQty);
            }

            return TotalPrice;
        }
    }
}
