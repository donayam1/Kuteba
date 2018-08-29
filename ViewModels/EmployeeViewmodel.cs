using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViewModels
{
    public class EmployeeViewmodel
    {
        //Viewmodel For Creating and Viewing An employee
        [Required(ErrorMessage = "Employee Name is required.")]//handles or captures The Name Of the Employee
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Employee ID is required.")]//Handles or Captures the Employees ID
        public  String EmployeeID { get; set; }

        [Required(ErrorMessage = "Employee Birthdate is required.")]//Handles/Captures the EMployees Birthday
        [Column (TypeName = "datetime2")]
        public DateTime Birthday{ get; set; }
        
        [Required(ErrorMessage = "Employee Profile Picture is required.")]//Handles/Captures the Location Of the Employee Profile Picture
        public string ProfilePicture{ get; set; }

        [Required(ErrorMessage = "Employee Savings Amount is required.")]//handles/Captures the Initial savings Amount
        public float InitialSavings { get; set; }

        public String SearchByID { get; set; }

    }
}
