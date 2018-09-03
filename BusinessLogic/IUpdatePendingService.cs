using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace BusinessLogic
{
    public interface IUpdatePendingService
    {
        User UpdatePendingStatus(string UserId, bool status);
    }
}
