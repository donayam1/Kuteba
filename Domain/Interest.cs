using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
   public class Interest
    {
        [Key]
        public int id { get; set; }
        public String Date { get; set; }
        public float AmountInPer { get; set; }
        public Boolean isActive { get; set; }

    }
}
