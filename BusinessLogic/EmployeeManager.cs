using Domain;
using ViewModels;

namespace BusinessLogic
{
    public class EmployeeManager : IEmployeeManager
    {
        Employee emp;
        public EmployeeManager(Employee emp)
        {
            this.emp = emp;
        }

        public Employee AddEmployee(EmployeeViewmodel evm)
        {
            emp.Name = evm.EmploeeName;
            emp.EmployeeId = evm.EmployeeID;
            return emp;
        }
    }
}
