using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using ViewModels;
using Database;

namespace BusinessLogic
{
    public interface IListUserService
    {
        
        List<User> ListUsers();
    }
}
