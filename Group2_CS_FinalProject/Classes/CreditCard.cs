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
    public class CreditCard : IPayment
    {
        public string Name { get; set; }

        private Random Balance { get; } //generate a random balance for the user.

        public int TotalBalance { get; set; }

        public int Cvv { get; set; }

        public int  CardNumber { get; set; }

        public string Date { get; set; }


        public bool Pay(double amount) //going to change the parameter to take an argument of type shopping cart (the one that is being currently used by the xaml).
        {
            // check if the amount is less than or equal to the user balance => do for loop to check the total amount in the shopping cart. 
            //int total; 
            //foreach (var item in ShoppingList){
                //total += item.price; 
            //}
            //return total; 
            // bool ableToPay = TotalBalance > total ? true : false; 
            //return ableToPay


                
            return true; 
        }

        public CreditCard()
        {
            Balance = new Random();
        }

        public void GenerateBalance()
        {

            TotalBalance = Balance.Next(0, 270); //generates a random balance between 0 and 270 


        }
    }

}
