using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Polar.Clases
{
    public class Viajes
    {
        public Viajes() { } 

        public string PlacaCamion {  get; set; }
        public string ViajeCodigo {  get; set; }
        public string NumeroGuia { get; set; }

        public string Estado {  get; set; }
    }
}
