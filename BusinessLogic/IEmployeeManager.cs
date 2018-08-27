using Domain;
using ViewModels;

namespace BusinessLogic
{
    public interface IEmployeeManager
    {
        Employee AddEmployee(EmployeeViewmodel evm);
    }
}
