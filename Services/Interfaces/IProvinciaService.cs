using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreSimpleAPI.Models;

namespace NetCoreSimpleAPI.Services.Interfaces
{
    public interface IProvinciaService
    {
        Task<Provincia> latLong(String provName);
    }
}
