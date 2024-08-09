using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IValidationService
    {
        bool isValidUsername(string username);
        bool isValidPassword(string password);
    }
}
