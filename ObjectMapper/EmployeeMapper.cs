using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace ObjectMapper
{
    public static class EmployeeMapper
    {
        public static Employee ToDomainModel(this EmployeeViewmodel evm)
        {
            //This Function Adds An employee TO The Databas Kuteba Database
            Employee emp = evm.ToDomainModel();
            emp.Name = evm.EmployeeName;
            emp.EmployeeId = evm.EmployeeID;
            emp.Birthday = evm.Birthday.ToString();
            emp.ProfilePicture = evm.ProfilePicture.FullName;
            return emp;
        }
        public static EmployeeViewmodel ToViewModel(this Employee emp)
        {
            //this Functio helps Display An Employee on the Website
            EmployeeViewmodel evm = new EmployeeViewmodel();
           
          
            //We Then Assign Extracted Database values To The View Model
            evm.EmployeeName = emp.Name;
            evm.EmployeeID = emp.EmployeeId;
            evm.Birthday = System.DateTime.Parse(emp.Birthday);
            evm.ProfilePicture = evm.ProfilePicture;
            return evm;//Return The View Model To Html
        }

    }
}
