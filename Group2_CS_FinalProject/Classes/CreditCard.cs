using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CS_FinalProject.Classes
{
    public class CreditCard : IPayment
    {
        public string Name { get; set; }

        private Random Balance; //generate a random balance for the user.

        public int Cvv { get; set; }

        public int  CardNumber { get; set; }

        public int Date { get; set; }


        public bool Pay(double amount)
        {
            // check if the amount is less than or equal to the user balance
            return true; 
        }
    }
}
