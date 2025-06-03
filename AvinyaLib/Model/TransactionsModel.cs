using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvinyaLib.Entities;

namespace AvinyaLib.Model
{
    public class TransactionsModel
    {
        public int TransactionId { get; set; }

        public int? FromAccountId { get; set; }

        public int? ToAccountId { get; set; }

        public string? Amount { get; set; }

        public string? Date { get; set; }

        public string? Status { get; set; }

        public virtual Account? FromAccount { get; set; }

        public virtual Account? ToAccount { get; set; }
    }
}
