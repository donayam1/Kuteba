using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Domain;

namespace BusinessLogic
{
    public interface IEmployeeLoanService
    {
        EmployeeLoan AddEmployeeLoan(EmployeeLoanVModel elv);
        List<EmployeeLoan> ListEmployeeLoan();
    }
}
