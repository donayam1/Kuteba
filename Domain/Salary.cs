using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public class Salary
    {
        [Key]
        public String id { get; set; }
        public int Amount { get; set; }
        public String ChanngeDate { get; set; }
        public bool isActive { get; set; }



    }
}
