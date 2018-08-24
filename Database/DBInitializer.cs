using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DBInitializer: DropCreateDatabaseIfModelChanges<KutebaDatabase>
    {

        protected override void Seed(KutebaDatabase context)
        {
            Group g = new Group()
            {
                Name = "Admin",
                Description = "Adminstrators user group"
            };
            context.Groups.Add(g);

            Employee e = new Employee()
            {
                Name = "Kuteba admin",
                EmployeeId = "kuteba",
                ProfilePicture = "~/content/images/img_someone.jpg"

            };
            context.Employees.Add(e);

            User u = new User()
            {
                UserName = "kuteba",
                Password = "123456",
                isPendding = false
            };

            context.Users.Add(u);


            Salary s = new Salary() {
                 Amount = 1000,
                 ChanngeDate = "5/5/2015",
                  isActive = true,
                  id = Guid.NewGuid().ToString()

            };

            context.Salaries.Add(s);

            EmployeeSalary es = new EmployeeSalary()
            {
                 EmployeeId = e.EmployeeId,
                  SalaryId = s.id
            };
            context.EmployeeSalaries.Add(es);


            SavingAmounts sa = new SavingAmounts()
            {
                Amount = 10,
                Id = Guid.NewGuid().ToString(),
                Uint = "%",
                isActive = true,
                ChagedDate = DateTime.Now
            };
            context.SavingAmounts.Add(sa);


            EmployeeSavingAmount esa = new EmployeeSavingAmount()
            {
                 EmployeeId = e.EmployeeId,
                 SavingAmountId = sa.Id
            };
            context.EmployeeSavingAmounts.Add(esa);

            context.SaveChanges();
            base.Seed(context);
        }

    }
}
