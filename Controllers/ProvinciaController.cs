using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreSimpleAPI.Models;
using NetCoreSimpleAPI.Services.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreSimpleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private IProvinciaService _provinciaService;

        public ProvinciaController(IProvinciaService provinciaService)
        {
            _provinciaService = provinciaService;
        }

        [HttpGet("{provName}")]
        public async Task<Provincia> getLatLon(string provName)
        {
            var result = await _provinciaService.latLong(provName);
            return result;
        }
    }
}
