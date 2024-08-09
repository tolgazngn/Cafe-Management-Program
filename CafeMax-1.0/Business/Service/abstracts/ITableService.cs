using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface ITableService
    {
        bool AddTable(string tableName);

        bool DeleteTable(string tableName);
        List<Table> GetAll();
        List<Table> GetEmpties();
        List<Table> GetFulls();

        bool ChangeBusyness(string tableName, bool busyness);

        bool IsRowDeletable(string tableName);
        bool CheckTableNameAvailability(string tableName);
    }
}
