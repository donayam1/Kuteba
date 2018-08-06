using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GroupPrevilage
    {
        [Key]
        [Column(Order = 1)]
        public String GroupId { get; set; }
        [Key]
        [Column(Order = 2)]
        public String PrevilageId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }
        [ForeignKey("PrevilageId")]
        public virtual Previlage Previlage { get; set; }
    }
}
