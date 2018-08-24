using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class EmployeeSalary
    {
        [Key]
        [Column(Order = 1)]
        public String EmployeeId { get; set; }
        [Key]
        [Column(Order = 2)]
        public String SalaryId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("SalaryId")]
        public virtual Salary Savings { get; set; }
    }
}
