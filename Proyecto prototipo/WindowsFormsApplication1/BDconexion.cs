using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class BDconexion
    {
        MySqlConnection conectar;
        public void obtener_conexion()
        {
            conectar = new MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");
            conectar.Open();

        }
        public void Desconectar()
        {
            conectar.Close();
        }
        public void EjecutarSql(String Query)
        {
            MySqlCommand MiComando = new MySqlCommand(Query, conectar);

            //ejecutamos la consulta (query) sql...
            int FilasAfectadas = MiComando.ExecuteNonQuery();

            if (FilasAfectadas > 0)
                MessageBox.Show("Operación realizada exitosamente", "la base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Busqueda(String Query)
        {
            MySqlCommand MiComando = new MySqlCommand(Query,conectar);

            //ejecutamos la consulta (query) sql...
            int FilasAfectadas = MiComando.ExecuteNonQuery();

            if (FilasAfectadas > 0)
                MessageBox.Show("No se Encontro el Registro", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else

                MessageBox.Show("Busqueda Realizada", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
