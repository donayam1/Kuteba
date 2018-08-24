using System;
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
