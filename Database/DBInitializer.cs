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

            };
            context.Employees.Add(e);

            User u = new User()
            {
                UserName = "kuteba",
                Password = "123456",
                isPendding = false
            };

            context.Users.Add(u);
            context.SaveChanges();
            base.Seed(context);
        }

    }
}
