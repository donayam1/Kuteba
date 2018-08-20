using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UserGroup
    {
        [Key]
        [Column(Order = 1)]
        public String UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public String GroupId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }
    }
}
