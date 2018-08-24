using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EmployeeSavingAmount
    {
        [Key]
        [Column(Order = 1)]
        public String EmployeeId { get; set; }
        [Key]
        [Column(Order = 2)]
        public String SavingAmountId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Emplyee { get; set; }

        [ForeignKey("SavingAmountId")]
        public SavingAmounts SavingAmounts { get; set; }

    }
}
