using Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExpenseTracker expenseTracker = new ExpenseTracker();
            expenseTracker.RecordExpense("Dinner", 50.25m, "Food");
            expenseTracker.RecordExpense("Gasoline", 30.50m, "Travel");

            expenseTracker.CategorizeExpense("Dinner", "Restaurant");
            expenseTracker.CategorizeExpense("Groceries", "Food");

            expenseTracker.GenerateReport();

            Console.ReadKey();
        }
    }
}
