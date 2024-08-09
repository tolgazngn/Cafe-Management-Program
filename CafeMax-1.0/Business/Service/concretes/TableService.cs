using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.concretes
{

    internal class TableService : ITableService
    {
        public TableService() {  }

        public bool AddTable(string tableName)
        {
            TableManager tableManager = new TableManager();

            return tableManager.AddTable(tableName);
        }

        public bool ChangeBusyness(string tableName, bool busyness)
        {
            TableManager tableManager = new TableManager();

            return tableManager.ChangeBusyness(tableName, busyness);
        }

        public bool CheckTableNameAvailability(string tableName)
        {
            TableManager tableManager = new TableManager();

            if (tableManager.CheckTableNameAvailability(tableName)) { return false; }
            else { return true; }
        }

        public bool DeleteTable(string tableName)
        {
            TableManager tableManager = new TableManager();

            return tableManager.DeleteTable(tableName);
        }

        public List<Table> GetAll()
        {
            TableManager tableManager = new TableManager();

            return tableManager.GetAll();
        }

        public List<Table> GetEmpties()
        {
            TableManager tableManager = new TableManager();

            return tableManager.GetEmpties();
        }

        public List<Table> GetFulls()
        {
            TableManager tableManager = new TableManager();

            return tableManager.GetFulls();
        }

        public bool IsRowDeletable(string tableName)
        {
            TableManager tableManager = new TableManager();

            if (tableManager.IsRowDeletable(tableName)) { return false; }
            else { return true; }

        }
    }
}
