using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreSimpleAPI.Models
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
    }
}
