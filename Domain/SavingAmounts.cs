using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SavingAmounts
    {
        [Key]
        public String Id { get; set; }
        public int Amount { get; set; }
        //[Column (TypeName = "datetime2")]
        public String ChagedDate { get; set; }
        public bool isActive { get; set; }
        /// <summary>
        /// In Percent, or Birr
        /// </summary>
        public String Uint { get; set; }

    }
}
