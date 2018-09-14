using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class EmployeeLoan
    {
        [Key]
        public string Id { get; set; }
        public double LoanAmount { get; set; }

        public string EmployeeID { get; set; }

        public string LoanDate { get; set; }

        public string ImageURL { get; set; }

        public double interest { get; set; }

    }
}
