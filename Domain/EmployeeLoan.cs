using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class EmployeeLoan
    {
        
        public double LoanAmount { get; set; }

        public string EmployeeID { get; set; }

        public string LoanDate { get; set; }

        public string ImageURL { get; set; }

        public double interest { get; set; }

    }
}
