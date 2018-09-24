using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain
{
   public class LoanForPayments
    {
        [Key]
        [Column(Order = 1)]
        public String PaymentsId { get; set; }
        [Key]
        [Column(Order = 2)]
        public String LoanId { get; set; }
        [Key]
        [Column(Order = 3)]
        public String InterestId { get; set; }

        [ForeignKey("PaymentsId")]
        public Payments Paymets { get; set; }

        [ForeignKey("LoanId")]
        public Loan Loan { get; set; }

        [ForeignKey("InterestId")]
        public Interest Interest { get; set; }
    }
}
