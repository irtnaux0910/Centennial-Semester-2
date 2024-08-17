using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Expense
    {
        private decimal amount;
        private string category;
        private string description;
        public Expense(string description, decimal amount, string category)
        {
            this.description = description;
            this.amount = amount;
            this.category = category;
        }

        public string Description
        {
            get { return description; }
        }

        public decimal Amount
        {
            get { return amount; }
        }

        public string Category
        {
            get { return category; }
        }

    }
}
