using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Loan
    {
        [Key]
        public int id { get; set; }
        public String Date { get; set; }
        public float Amount { get; set; }
        public Boolean Closed { get; set; }
        public Boolean InterestFree { get; set; }
        public float ReturnRate { get; set; }


    }
}
