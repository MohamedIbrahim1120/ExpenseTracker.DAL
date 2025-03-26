using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DAL.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        // CategotyId
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int Amount { get; set; }

        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;


    }
}
