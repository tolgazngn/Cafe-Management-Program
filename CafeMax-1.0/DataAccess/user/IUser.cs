using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.user
{
    interface IUser
    {
        bool AddUser(User user);
        bool DeleteUser(int id);
        bool ChangeUsername(string username, string newUsername);
        bool ChangePassword(string username, string newPassword);
        bool DeleteUser(string username);

        string GetPasswordByUsername(string username);
        List<User> GetAll();

        bool CheckUsernameAvailability(string username);

    }
}
