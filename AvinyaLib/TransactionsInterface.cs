using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvinyaLib.Model;

namespace AvinyaLib
{
    public interface TransactionsInterface
    {
        public Task<List<TransactionsModel>> GetAllTransactions();
    }
}
