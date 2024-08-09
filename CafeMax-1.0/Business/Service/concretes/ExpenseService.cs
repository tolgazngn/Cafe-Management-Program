using CafeMax.Business.Entity;
using CafeMax.Business.Service.abstracts;
using CafeMax.DataAccess.expense;
using CafeMax.Forms.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeMax.Business.Util;

namespace CafeMax.Business.Service.concretes
{
    internal class ExpenseService : IExpenseService
    {
        public bool AddExpense(Expense expense)
        {
            ExpenseManager expenseManager = new ExpenseManager();

            return expenseManager.AddExpense(expense);
        }

        public List<Expense> GetAll()
        {
            ExpenseManager expenseManager = new ExpenseManager();

            return expenseManager.GetAll();
        }

        public List<Expense> GetExpensesByDate(DateTime firstDate, DateTime secondDate)
        {
            ExpenseManager expenseManager = new ExpenseManager();

            //gelen datetime verilerinin saat bilgilerini düzenliyerek dataaccess'e gönderiyoruz
            return expenseManager.GetExpensesByDate(Helper.EditDateForSearch(firstDate, 0,0,0), Helper.EditDateForSearch(secondDate, 23,59,59));
        }
    }
}
