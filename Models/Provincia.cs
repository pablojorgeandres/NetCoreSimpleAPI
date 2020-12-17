using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreSimpleAPI.Models
{
    public class Provincia
    {
        public int cantidad { get; set; }
        public int inicio { get; set; }
        public Dictionary<string, string> parametros { get; set; }
        public List<JsonProvincia> provincias { get; set; }
        public int total { get; set; }
    }

    public class JsonProvincia
    {
        public Dictionary<string, float> centroide { get; set; }
        public string id { get; set; }
        public string nombre { get; set; }
    }
}
