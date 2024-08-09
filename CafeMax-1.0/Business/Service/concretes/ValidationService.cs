using CafeMax.Business.Service.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class ValidationService : IValidationService
    {
        public bool isValidPassword(string password)
        {
            if (password == null || password.Length < 6  || password.Length > 20) { return false; }
            return true;
        }

        public bool isValidUsername(string username)
        {
            if (username == null || username.Length < 3 || username.Length > 20) { return false; }
            return true;
        }
    }
}
