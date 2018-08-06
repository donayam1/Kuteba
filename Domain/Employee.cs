using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        [Key]
        public String EmployeeId { get; set; }
        public String Name { get; set; }
       
    }
}
