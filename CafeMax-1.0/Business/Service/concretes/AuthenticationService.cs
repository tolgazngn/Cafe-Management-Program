using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class AuthenticationService : IAuthenticationService
    {
        public bool LoginUser(string username, string password)
        {
            AuthenticationManager authenticationManager = new AuthenticationManager();

            return authenticationManager.LoginUser(username, password);
        }
    }
}
