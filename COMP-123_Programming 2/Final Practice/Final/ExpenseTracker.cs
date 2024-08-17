using System;
using System.Collections.Generic;

namespace Final
{
    public class ExpenseTracker
    {
        private List<Expense> expenses;
        public ExpenseTracker()
        {
            expenses = new List<Expense>();
        }
        public void CategorizeExpense(string description,string category)
        {
            foreach (Expense expense in expenses)
            {
                if(expense.Description==description)
                {
                    Console.WriteLine($"Expense '{description}' categorized as '{category}'.");
                }
                else 
                {
                    Console.WriteLine($"Expense '{description}' not found.");
                }
                return;
            }         
        }
        public void RecordExpense(string description, decimal amount, string category)
        {
            try
            {
                Expense expense = new Expense(description, amount, category);
                expenses.Add(expense);
                Console.WriteLine($"Expenses recorded successfully");
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void GenerateReport()
        {
            Console.WriteLine("Expense Report:");
            foreach (Expense expense in expenses)
            {
                Console.WriteLine($"Description: {expense.Description}, Amount: {expense.Amount}, Category: {expense.Category}");
            }
        }
    }
}
