using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class See
    {
        [Key]
        [Column(Order = 1)]
        public String GroupId { get; set; }
        [Key]
        [Column(Order = 2)]
        public String AnnouncementsId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }
        [ForeignKey("AnnouncementsId")]
        public virtual Announcemnets Announcemnets { get; set; }
    }
}
