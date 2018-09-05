using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class AnnouncementEditViewModel
    {
        [Required(ErrorMessage = "Title field is void.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Poster picture is missing.")]
        public string PictureUrl { get; set; }
        [Required(ErrorMessage = "Active start date is not set.")]
        public DateTime VisibleDate { get; set; }
        [Required(ErrorMessage = "Expiration date is not set.")]
        public DateTime ExpiaryDate { get; set; }
        public string ContentDescription { get; set; }
    }
}
