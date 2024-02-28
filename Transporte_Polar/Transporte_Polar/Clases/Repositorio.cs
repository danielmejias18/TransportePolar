using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Transporte_Polar.Clases
{
    public static class Repositorio
    {
        public static string filename = "Camion";
        public static string camion;

        public static List<Camion> ListaCamiones()
        {
            string camion = File.ReadAllText(filename);
            List<Camion> list = JsonSerializer.Deserialize<List<Camion>>(camion);
            return list;
        }

        public static void ListSave(List<Camion> list)
        {
            camion = JsonSerializer.Serialize(list);
            File.WriteAllText(filename, camion);
        }

    }
}
        
    

   