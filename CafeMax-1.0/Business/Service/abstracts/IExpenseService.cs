using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.Business.Service.abstracts
{
    internal interface IExpenseService
    {
        bool AddExpense(Expense expense);
        List<Expense> GetAll();
        List<Expense> GetExpensesByDate(DateTime firstDate, DateTime secondDate);
    }
}
