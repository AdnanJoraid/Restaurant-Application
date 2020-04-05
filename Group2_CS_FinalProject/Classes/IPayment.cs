using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CS_FinalProject.Classes
{
    interface IPayment //if we add a new method of payment, this interface will be able to extend on it
    {

        bool Pay(double amount); //check if the user has enough balance
    }
}
