using AvinyaLib.Model;
using AvinyaLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvinyaWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly AccountsInterface _accountsInterface;

        public AccountsController(AccountsInterface accountsInterface)
        {
            _accountsInterface = accountsInterface;
        }

        [HttpGet("GetAllAccounts")]
        public async Task<List<AccountsModel>> GetAllAccounts()
        {
            List<AccountsModel> lstAccountModel = await _accountsInterface.GetAllAccounts();
            return lstAccountModel;

        }
    }
}
