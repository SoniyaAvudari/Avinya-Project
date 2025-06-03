using AvinyaLib.Model;
using AvinyaLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvinyaWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UsersInterface _usersInterface;

        public UsersController(UsersInterface usersInterface)
        {
            _usersInterface = usersInterface;
        }

        [HttpGet("GetAllUsers")]
        public async Task<List<UsersModel>> GetAllUsers()
        {
            List<UsersModel> lstusers = await _usersInterface.GetAllUsers();
            return lstusers;

        }
    }
}
