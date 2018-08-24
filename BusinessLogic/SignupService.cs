<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Database;
using ViewModels;

namespace BusinessLogic
{
    public class SignupService : ISignupService
    {
        KutebaDatabase kdb;

        public SignupService(KutebaDatabase db)
        {
            //set Database
            kdb = db;
        }

        public User Signup(UserViewModel_Signup u)
        {
            User usr = new User();
            usr.UserName = u.Username;
            usr.Password = u.password;
            usr.isPendding = true;

            kdb.Users.Add(usr);
            return usr;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Database;
using ViewModels;

namespace BusinessLogic
{
    public class SignupService : ISignupService
    {
        KutebaDatabase kdb;

        public SignupService(KutebaDatabase db)
        {
            kdb = db;
        }

        public User Signup(UserViewModelSignup u)
        {

            
            var us = kdb.Employees.Where(e1 => e1.EmployeeId == u.employeeID).FirstOrDefault();

            var user = kdb.Users.Where(u1 => u1.UserName == u.employeeID).FirstOrDefault();

            if (us == null && user == null)
            {
                Employee emp = new Employee();
                emp.EmployeeId = u.employeeID;
                kdb.Employees.Add(emp);
                
                User usr = new User();
                usr.UserName = u.employeeID;
                usr.Password = u.password;
                usr.isPendding = true;

                kdb.Users.Add(usr);
                kdb.SaveChanges();
                return usr;
             }
            else {
                return null;
            }
        }
    }
}
>>>>>>> f924cfd60f1b468cf4ae590f7cf6b752061afbc3
