using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvinyaLib.Model;
using Microsoft.EntityFrameworkCore;

namespace AvinyaLib
{
    public class AccountsModelClass : AccountsInterface
    {


        private readonly AvinyaContext _avinyaContext;

        public AccountsModelClass(AvinyaContext avinyaContext)
        {

            _avinyaContext = avinyaContext;

        }

        public async Task<List<AccountsModel>> GetAllAccounts()
        {
            //LINQ Language Integrated Query

            var Accountsresult = await _avinyaContext.Accounts.Select(
                 s => new AccountsModel
                 {
                     AccountId = s.AccountId,
                     UserId = s.UserId,
                     AccountNumber = s.AccountNumber,
                     Balance = s.Balance,
                 }
                 ).ToListAsync();
            return Accountsresult;





        }

        
    }
}
    

