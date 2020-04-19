using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace Group2_CS_FinalProject.Classes
{
    public enum CreditCardStatus //check the status of a creditcard, if notfound it means the user didnt add his/her creditcard
    {
        Approved, 
        Declined,
        NotFound
    }
    public class CreditCard : IPayment //uses the IPayment interface
    {

        

        public string Name { get; set; } 

        public CreditCardStatus CardStatus { get; set; }
        private readonly Random Random; //generate a random balance for the user.

        public int TotalBalance { get; set; }

        public int Cvv { get; set; }

        public string CardNumber { get; set; }

        public string Date { get; set; }


        public bool Pay(double total, double balance) //uses the Interface IPayment bool to check if the user is able to calculate
        {
            return balance > total;
        }

        public CreditCard()
        {
            Random = new Random();
        }

        public void GenerateBalance() //generate a random balance for the user
        {
            TotalBalance = Random.Next(100, 270);
        }

        
    }

}
