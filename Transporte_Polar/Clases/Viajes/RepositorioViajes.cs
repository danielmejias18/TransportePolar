using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Transporte_Polar.Clases
{
    public  class RepositorioViajes
    {
        public static string fileName = "Viajes";
        public static string viaje;

        public static List<Viajes> ListaViajes()
        {
           
            string viaje = File.ReadAllText(fileName);
            List<Viajes> list = JsonSerializer.Deserialize<List<Viajes>>(viaje);
            return list;
        }

        public static void ListSaveViajes(List<Viajes> list)
        {
            viaje = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, viaje);
        }
    }
}
