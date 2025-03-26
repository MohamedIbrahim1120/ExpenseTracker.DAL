using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DAL.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; } = " ";

        public string Type { get; set; } = "Expense";
    }
}
