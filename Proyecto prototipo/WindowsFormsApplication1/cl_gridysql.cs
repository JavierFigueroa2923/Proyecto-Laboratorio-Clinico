using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class cl_gridysql
    {
        public static void EjecutarMySql(String Query)
        {
            MySqlCommand MiComando = new MySqlCommand(Query, Conexionmysql.ObtenerConexion());
            int FilasAfectadas = MiComando.ExecuteNonQuery();
            if (FilasAfectadas > 0)
            {
                MessageBox.Show("Operacion Realizada Exitosamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la modificacion de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ActualizarGridPermiso(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "permiso");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "permiso";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }

        public static void ActualizarGridUsuario(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "usuario");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "usuario";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }

        public static void ActualizarGridEmpleadoUsuario(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "empleado");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "empleado";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }

        public static void ActualizarGridLaboratorioUsuario(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "laboratorio");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "laboratorio";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }

        public static void ActualizarGridEtiqueta(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "etiquetas");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "etiquetas";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }
        public static void ActualizarGridMuestra(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "muestra");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "muestra";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }

        public static void ActualizarGridBusquedaCargoEmpleado(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "cargo_emleado");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "cargo_emleado";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }

        public static void ActualizarGridBusquedaIdMuestra(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "muestra");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "muestra";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }

        public static void ActualizarGridBusquedaIdCita(DataGridView dg, String Query)
        {
            //Conectarnos a la base de datos
            Conexionmysql.ObtenerConexion();
            //Crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //Llenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "cita");
            //Asignarle el valor al cuadro a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "cita";
            //Nos desconectamos de la base de datos....
            Conexionmysql.Desconectar();
        }
    }
}
