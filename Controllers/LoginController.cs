using System;
using System.Collections.Generic;
using System.Linq;
using NetCoreSimpleAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreSimpleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApiContext _context;

        public LoginController(ApiContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<User> GetUser()
        {
            return _context.Users.ToArray();
        }
    }
}