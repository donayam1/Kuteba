using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class EmployeeTakesLoan
    {
        [Key]
        [Column(Order = 1)]
        public String EmployeeId { get; set; }
        [Key]
        [Column(Order = 2)]
        public String LoanId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Emplyee { get; set; }

        [ForeignKey("LoanId")]
        public Loan Loan { get; set; }
    }
}
