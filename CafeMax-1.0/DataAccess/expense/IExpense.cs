using CafeMax.Business.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMax.DataAccess.expense
{
    interface IExpense
    {
        bool AddExpense(Expense expense);
        List<Expense> GetAll();
        List<Expense> GetExpensesByDate(DateTime firstDate, DateTime secondDate);
    }
}
