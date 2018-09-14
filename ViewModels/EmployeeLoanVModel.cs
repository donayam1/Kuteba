using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ViewModels
{
   public class EmployeeLoanVModel
    {
        [Required(ErrorMessage ="Required")]
        public double LoanAmount { get; set; }

        [Required(ErrorMessage = "Required")]
        public string EmployeeID { get; set; }

        [Required(ErrorMessage ="Required")]
        public DateTime LoanDate { get; set; }

        [Required(ErrorMessage ="Required")]
        public string PictureURL { get; set; }

        [Required(ErrorMessage ="Required")]
        public double interest { get; set; }
    }
}
