using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class Conexionmysql
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection miconexion = new MySqlConnection("server=127.0.0.1; database=proyecto_laboratorio; uid=root; pwd=;");
            miconexion.Open();
            return miconexion;
        }
        public static MySqlConnection Desconectar()
        {
            MySqlConnection miconexion = new MySqlConnection("server=127.0.0.1; database=proyecto_laboratorio; uid=root; pwd=;");
            miconexion.Close();
            return miconexion;
        }
    }
}
