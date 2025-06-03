using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvinyaLib.Model;
using Microsoft.EntityFrameworkCore;


namespace AvinyaLib
{
    public class TransactionsModelClass:TransactionsInterface
    {
      

            private readonly AvinyaContext _avinyaContext;

            public TransactionsModelClass(AvinyaContext avinyaContext)
            {

                _avinyaContext = avinyaContext;

            }

            public async Task<List<TransactionsModel>> GetAllTransactions()
            {
            //LINQ Language Integrated Query

            var Transactionsresult = await _avinyaContext.Transactions.Select(
                 s => new TransactionsModel
                 {
                     TransactionId = s.TransactionId,
                     FromAccount = s.FromAccount,
                     ToAccount = s.ToAccount,
                     Amount = s.Amount,
                     Date = s.Date,
                     Status = s.Status,

                 }
                 ).ToListAsync();
                   return Transactionsresult;





            }


        }
    }

