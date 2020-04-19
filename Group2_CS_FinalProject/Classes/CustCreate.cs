using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2_CS_FinalProject.Classes
{
    /// <summary>
    /// Creator: Haashim Chouhdry
    /// creates a customer 
    /// </summary>
    class CustCreate
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public bool DoesExsist(string name, List<CustCreate> ListCust)
        {
            for (int i = 0; i < ListCust.Count; i++)
            {
                if (name == ListCust[i].Name)
                    return true;
            }

            return false;
        }

    }
}
