using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvinyaLib.Model;
using Microsoft.EntityFrameworkCore;

namespace AvinyaLib
{
    public class UsersModelClass : UsersInterface
    {
        
             private readonly AvinyaContext _avinyaContext;

        public UsersModelClass(AvinyaContext avinyaContext)
        {

            _avinyaContext = avinyaContext;

        }

        public async Task<List<UsersModel>> GetAllUsers()
        {
            //LINQ Language Integrated Query

            var Usersresult = await _avinyaContext.Users.Select(
                 s => new UsersModel
                 {
                     UserId=s.UserId,
                     Name=s.Name,
                     Email=s.Email,
                     PasswordHash=s.PasswordHash,
                     Role=s.Role,
                 }
                 ).ToListAsync();
            return Usersresult;





        }


    }
}


        
    

