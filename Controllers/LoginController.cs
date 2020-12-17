using System;
using System.Collections.Generic;
using System.Linq;
using NetCoreSimpleAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using NetCoreSimpleAPI.Services;
using NetCoreSimpleAPI.Services.Interfaces;

namespace NetCoreSimpleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok();
        }

        [HttpPost("auth")]
        public async Task<ActionResult> UserLogin([FromBody] User user)
        {
            var result = await _loginService.auth(user);
            if(result)
            {
                return Ok(result);
            } 
            else
            {
                return Unauthorized();
            }
        }
    }
}