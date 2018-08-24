using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Domain;
using ViewModels;

namespace BusinessLogic
{
   public  class ListUserService: IListUserService
    {

        KutebaDatabase Db;
         
        public ListUserService(KutebaDatabase Db)
        {
            this.Db = Db;
        }
       
       public List<User> ListUsers()
        {
            List<User> users = new List<User>();

            users = Db.Users.Where(x=>true).ToList();
            

            return users; 
        }
    }
}
