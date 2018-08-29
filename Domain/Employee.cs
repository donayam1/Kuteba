using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Employee
    {

        [Key]
        public String EmployeeId { get; set; }
        public String Name { get; set; }
        public String ProfilePicture { get; set; }
        [Column (TypeName = "datetime2")]
        public DateTime Birthday { get; set; }
        public float InitialSavings { get; set; }


    }
}
