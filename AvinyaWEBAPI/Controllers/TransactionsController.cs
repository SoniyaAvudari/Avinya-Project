using AvinyaLib.Model;
using AvinyaLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvinyaWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionsInterface _transactionsInterface;

        public TransactionsController(TransactionsInterface transactionsInterface)
        {
            _transactionsInterface = transactionsInterface;
        }

        [HttpGet("GetAllTransactions")]
        public async Task<List<TransactionsModel>> GetAllTransactions()
        {
            List<TransactionsModel> lstTransactions = await _transactionsInterface.GetAllTransactions();
            return lstTransactions;

        }
    }
}

    

