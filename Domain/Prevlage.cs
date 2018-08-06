using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Previlage
    {
        [Key]
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
