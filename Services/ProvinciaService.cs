using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using NetCoreSimpleAPI.Models;
using NetCoreSimpleAPI.Services.Interfaces;
using Newtonsoft.Json;

namespace NetCoreSimpleAPI.Services
{
    public class ProvinciaService : IProvinciaService
    {
        public async Task<Provincia> latLong(String provName)
        {
            Provincia provincia = new Provincia();
            using (var httpClient = new HttpClient())
            {
                using (var resp = await httpClient.GetAsync("https://apis.datos.gob.ar/georef/api/provincias?nombre=" + provName))
                {
                    string apiResponse = await resp.Content.ReadAsStringAsync();
                    provincia = JsonConvert.DeserializeObject<Provincia>(apiResponse);
                }
            }
            return provincia;
        }
    }
}
