using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IAuthenticationService
    {
        bool LoginUser(string username, string password);
    }
}
