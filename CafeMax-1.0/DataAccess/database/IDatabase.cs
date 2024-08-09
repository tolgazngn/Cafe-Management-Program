using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CafeMax.DataAccess.database
{
    interface IDatabase
    {
        void OpenConnection();
        void CloseConnection();
        SqlConnection GetConnection();
    }
}
