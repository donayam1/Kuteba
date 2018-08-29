using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Database;

namespace BusinessLogic
{
    public class UpdatePendingService : IUpdatePendingService
    {
        KutebaDatabase kdb;
        public UpdatePendingService(KutebaDatabase kdb) {
            this.kdb = kdb;
        }

        public User UpdatePendingStatus(string UserId, bool status) {
            var usr = kdb.Users.Where(u1 => u1.UserName == UserId).FirstOrDefault();
            if (usr != null && usr.isPendding)
            {
                usr.isPendding = !usr.isPendding;
                kdb.SaveChanges();
                return usr;
            }
            else
                return null;
        }
    }
}
