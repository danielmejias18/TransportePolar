using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Transporte_Polar.Clases
{
    public class RepositorioCodigos

    {
        public static string filename = "Codigos";
        public static string codigo;
        public static List<Codigo> ListaCodigos()
        {

            string codigo = File.ReadAllText(filename);
            List<Codigo> list = JsonSerializer.Deserialize<List<Codigo>>(codigo);
            return list;
        }

        public static void ListSaveCodigos(List<Codigo> list)
        {
            codigo = JsonSerializer.Serialize(list);
            File.WriteAllText(filename, codigo);
        }

    }
}
