using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Employee
    {

        [Key]
        public String EmployeeId { get; set; }
        public String Name { get; set; }
        public String ProfilePicture { get; set; }
        public DateTime Birthday { get; set; }
        public float InitialSavings { get; set; }


    }
}
