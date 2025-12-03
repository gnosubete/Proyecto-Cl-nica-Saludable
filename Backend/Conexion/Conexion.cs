using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_de_salud
{
    public class Conexion
    {
        private static string connectionString = "Server=localhost;Database=clinica_saludable;Uid=root;Pwd=;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
