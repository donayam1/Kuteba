using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        [Key]        
        public String UserName { get; set; }
        public String Password { get; set; }
        public bool isPendding { get; set; }

        [ForeignKey("UserName")]
        public Employee employe { get; set; }
    }
}
