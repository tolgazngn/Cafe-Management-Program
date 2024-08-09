using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{
    internal class MenuService : IMenuService
    {
        public MenuService() {}

        public List<Menu> GetAll()
        {
            MenuManager menuManager = new MenuManager();

            return menuManager.GetAll();
        }
    }
}
