using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.authentication
{
    interface IAuthentication
    {
        bool LoginUser(string username, string password);
    }
}
