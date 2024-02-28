
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Transporte_Polar.Login
{
    public static class Repository
    {
        public static string fileName = "example1.json";
        public static string usuario;


        public static List<Usuarios> UsuariosList()
        {

            string usuario = File.ReadAllText(fileName);
            List<Usuarios> list = JsonSerializer.Deserialize<List<Usuarios>>(usuario);
            return list;


        }

       


    }
}
