using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ViewModels;

namespace BusinessLogic
{
    public interface ISignupService
    {
        User Signup(UserViewModelSignup u);
    }
}
