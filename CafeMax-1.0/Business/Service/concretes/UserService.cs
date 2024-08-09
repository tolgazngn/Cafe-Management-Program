using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CafeMax.Business.Service.concretes
{
    internal class UserService : IUserService
    {
        public UserService() {  }

        public bool AddUser(User user)
        {
            UserManager userManager = new UserManager();

            return userManager.AddUser(user);
        }

        public bool ChangePassword(string username, string password)
        {
            UserManager userManager = new UserManager();

            return userManager.ChangePassword(username, password);
        }

        public bool ChangeUsername(string username, string newUsername)
        {
            UserManager userManager = new UserManager();

            return userManager.ChangeUsername(username, newUsername);
        }

        public bool CheckUsernameAvailability(string username)
        {
            UserManager userManager = new UserManager();

            return userManager.CheckUsernameAvailability(username);
        }

        public bool DeleteUser(int id)
        {
            UserManager userManager = new UserManager();

            return userManager.DeleteUser(id);
        }

        public List<User> GetAll()
        {
            UserManager userManager = new UserManager();

            return userManager.GetAll();
        }

        public bool UserValidation(string username, string password)
        {
            UserManager userManager = new UserManager();

            string userPassword = userManager.GetPasswordByUsername(username);

            if (userPassword != null) 
            {
                if (password == userPassword) { return true; }
                else { return false; }
            }
            else { return false; }
        }
    }
}
