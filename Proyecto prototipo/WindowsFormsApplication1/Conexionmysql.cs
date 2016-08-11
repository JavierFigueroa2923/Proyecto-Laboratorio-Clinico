using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public static int EjecutarMySql2(String Query)
        {
            MySql.Data.MySqlClient.MySqlConnection conectar = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");
            MySqlCommand cmd1 = conectar.CreateCommand();
            cmd1.CommandText = Query;
            try
            {
                conectar.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Error" + erro);
            }
            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                int contadors = reader.GetInt32(0);

            }
            int contador = reader.GetInt32(0);
            return contador;
        }
    }
}
