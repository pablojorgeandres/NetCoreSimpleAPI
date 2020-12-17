using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreSimpleAPI.Models;
using NetCoreSimpleAPI.Services.Interfaces;

namespace NetCoreSimpleAPI.Services
{
    public class LoginService : ILoginService
    {
        IDictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "User1", "1234567" },
            { "User2", "7891011" }
        };

        public async Task<bool> auth(User user)
        {
            if (!usuarios.Any(u => u.Key == user.UserName && u.Value == user.Password))
            {
                return false;
            }
            return true;
        }
    }
}
