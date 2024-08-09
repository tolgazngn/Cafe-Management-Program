using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IUserService
    {
        bool AddUser(User user);
        bool DeleteUser(int id);

        bool UserValidation(string username, string password);

        bool CheckUsernameAvailability(string username);

        bool ChangeUsername(string username, string newUsername);

        bool ChangePassword(string username, string password);

        List<User> GetAll();
    }
}
