using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CS_FinalProject.Classes
{
    class Receipt
    {
        public string ReceiptNumber { get; set; }
        public DateTime date { get; set; }

        public double CalculateReceipt(List<Product> prod)
        {
            double total = 0;
            foreach (var item in prod)
            {
                total += (item.ItemPrice * item.ItemQty);
            }

            return total;
        }


    }
}
