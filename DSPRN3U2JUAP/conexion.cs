using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DSPRN3U2JUAP
{
    public class conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
                MySqlConnection conectar = new MySqlConnection("server = localhost; database = act1; user = root; password=12345678");
                conectar.Open();
                return conectar;
        }
    }
}
