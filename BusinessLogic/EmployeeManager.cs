using Domain;
using ViewModels;
using Database;
using System.Linq;
using ObjectMapper;

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
            Employee emp = evm.ToDomainModel();
            kdb.Employees.Add(emp);
            return emp;
        }

        public EmployeeViewmodel ViewEmployee(string SearchID)
        {
            //this Functio helps Display An Employee on the Website
            Employee emp = kdb.Employees.Find(SearchID);//Searching The Database For Employee Object With Search ID Value
            return emp.ToViewModel();

        }

        public void DeActivateEmployee(EmployeeViewmodel evm)
        {
            //This Function Removes an Employee from The system
            //Find Employee With Given Parameters
            Employee emp = kdb.Employees.Where(e1 => e1.Name == evm.EmployeeName && e1.EmployeeId == evm.EmployeeID).FirstOrDefault();
            kdb.Employees.Remove(emp);//Remove Said Employee With Said Parameters
        }
    }
}
