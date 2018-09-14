using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Database;
using Domain;

namespace BusinessLogic
{
    public class EmployeeLoanService:IEmployeeLoanService
    {
        KutebaDatabase Kdb;
        
        public EmployeeLoanService()
        {
            Kdb = new KutebaDatabase();
        }

       public EmployeeLoan AddEmployeeLoan(EmployeeLoanVModel elv)
        {
            var temp = Kdb.EmployeeLoan.Where(x => x.EmployeeID == elv.EmployeeID).FirstOrDefault();
            if(temp == null)
            {
                //a mapper can be used
                EmployeeLoan empLoan = new EmployeeLoan();
                empLoan.Id = Guid.NewGuid().ToString();
                empLoan.interest = elv.interest;
                empLoan.LoanAmount = elv.LoanAmount;
                empLoan.LoanDate = elv.LoanDate.ToString();
                empLoan.ImageURL = elv.PictureURL;
                empLoan.EmployeeID = elv.EmployeeID;

                Kdb.EmployeeLoan.Add(empLoan);
                Kdb.SaveChanges();

                return empLoan;
            }
            return temp;
        }

       public List<EmployeeLoan> ListEmployeeLoan()
        {
            List<EmployeeLoan> empLoan = new List<EmployeeLoan>();
            empLoan = Kdb.EmployeeLoan.Where(x => true).ToList();
            // need to add some logic that checks if the employee is done with paying the loan 
            // otherwise it will be displayed even if it completed the  payment
            return empLoan;
        }
    }
}
