using System;
using System.ComponentModel.DataAnnotations;

namespace ViewModels
{
    public class EmployeeViewmodel
    {
        [Required(ErrorMessage = "Employee Name is required.")]//handles or captures The Name Of the Employee
        public string EmploeeName { get; set; }

        [Required(ErrorMessage = "Employee ID is required.")]//Handles or Captures the Employees ID
        public  String EmployeeID { get; set; }

        //Code after this To Be Added After Edit of Domain

        /*
          [Required(ErrorMessage = "Employee Birthdate is required.")]
          public string Birthday{ get; set; }

          [Required(ErrorMessage = "Employee Picture is required.")]
          public string  ID_Picture{ get; set; }

         */

    }
}
