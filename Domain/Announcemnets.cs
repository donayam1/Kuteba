using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Domain
{
    public class Announcemnets
    {
        [Key]
        public String Id { get; set; }
        public String PictureUrl { get; set; }
        public String Title { get; set; }
        public String Text { get; set; }
        public String ExpDate { get; set; }
        public String CreatedDate { get; set; }
        public String VisibleDate { get; set; }
    }
}
