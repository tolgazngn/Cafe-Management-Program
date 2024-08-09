using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.table
{
    interface ITable
    {
        bool AddTable(string tableName);
        bool DeleteTable(string tableName);
        bool ChangeBusyness(string tableName, bool busyness);
        bool ChangeRezervation(string tableName, bool rezervation);
        List<Table> GetAll();

        List<Table> GetEmpties();
        List<Table> GetFulls();

        bool CheckTableNameAvailability(string tableName);

        bool IsRowDeletable(string tableName);
    }
}
