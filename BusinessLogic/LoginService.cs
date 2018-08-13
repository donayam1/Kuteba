using Databse;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
	public class LoginService : ILoginService
	{
        KutebaDatabase db;
		public LoginService (KutebaDatabase db)
		{
			this.db = db;
		}
		public bool SignIn (User u)
		{
            var user = db.Users. 
                 Where(u1 => u1.UserName == u.UserName && 
                             u1.Password == u.Password).
                             FirstOrDefault();
            if (user == null)
                return false;
            else
                return true;
		}
	}
}