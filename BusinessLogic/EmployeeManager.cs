using Domain;
using ViewModels;
using Database;
using System.Linq;

namespace BusinessLogic
{
    public class EmployeeManager : IEmployeeManager
    {
        KutebaDatabase kdb;//Creating Database object


        public EmployeeManager(KutebaDatabase db)
        {
            //Initiation Of Database
            kdb = db;
        }

        public Employee AddEmployee(EmployeeViewmodel evm)
        {
            //This Function Adds An employee TO The Databas Kuteba Database
            Employee emp = new Employee();
            emp.Name = evm.EmployeeName;
            emp.EmployeeId = evm.EmployeeID;
            emp.Birthday = evm.Birthday;
            emp.ProfilePicture = evm.ProfilePicture;
            kdb.Employees.Add(emp);
            return emp;
        }

        public EmployeeViewmodel ViewEmployee(EmployeeViewmodel SearchV)
        {
            //this Functio helps Display An Employee on the Website
            EmployeeViewmodel evm = new EmployeeViewmodel();
            var ID = SearchV.EmployeeID;//Extracting Empoyee's ID Value From A Search View model
            Employee emp = kdb.Employees.Find(ID);//Searching The Database For Employee Object With Search ID Value
            //We Then Assign Extracted Database values To The View Model
            evm.EmployeeName = emp.Name;
            evm.EmployeeID = emp.EmployeeId;
            evm.Birthday = emp.Birthday;
            evm.ProfilePicture = evm.ProfilePicture;
            return evm;//Return The View Model To Html
        }

        public void RemoveEmployee(EmployeeViewmodel evm)
        {
            //This Function Removes an Employee from The system
            //Find Employee With Given Parameters
            Employee emp = kdb.Employees.Where(e1 => e1.Name == evm.EmployeeName && e1.EmployeeId == evm.EmployeeID).FirstOrDefault();
            kdb.Employees.Remove(emp);//Remove Said Employee With Said Parameters
        }
    }
}
