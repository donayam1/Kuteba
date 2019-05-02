﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ViewModels
{
    public class UserSignUpViewModel
    {

        //EmployeeViewmodel EmployeeViewModel { get; set; }
        [Required(ErrorMessage = "Employee ID is required.")]
        public string employeeID { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        public int phoneNum { get; set; }
        public string email { get; set; }
        [Column (TypeName = "datetime2")]
        public DateTime birthDate { get; set; }
        [Required(ErrorMessage = "Bond value is required.")]
        public int bond { get; set; }
        [Required(ErrorMessage = "Installment is required.")]
        public float install { get; set; }
    }
}