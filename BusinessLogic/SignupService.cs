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
        User usr;

        public SignupService(User u)
        {
            usr = u;
        }

        public User _signup(UserViewModel_Signup u)
        {
            usr.UserName = u.Username;
            usr.Password = u.password;
            usr.isPendding = true;
            return usr;
        }
    }
}
