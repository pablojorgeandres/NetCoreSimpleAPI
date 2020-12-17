using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreSimpleAPI.Models;

namespace NetCoreSimpleAPI.Services.Interfaces
{
    public interface ILoginService
    {
        Task<bool> auth(User user);
    }
}
