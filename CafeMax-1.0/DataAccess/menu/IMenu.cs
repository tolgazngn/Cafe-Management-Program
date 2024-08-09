using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Entity;

namespace CafeMax.DataAccess.menu
{
    interface IMenu
    {
        bool AddMenu(string menu);
        bool DeleteMenu(string menu);
        List<Menu> GetAll();
    }
}
