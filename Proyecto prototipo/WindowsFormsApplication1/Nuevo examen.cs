using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frm_nuevo_examen : Form
    {
        public frm_nuevo_examen()
        {
            InitializeComponent();

        }
        BDconexion ManipularDato = new BDconexion();
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }
        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            Conexionmysql.ObtenerConexion();
            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();
            //Creamos un nuevo adaptador de datos
            MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "Examen");
            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "Examen";
            Conexionmysql.Desconectar();
        }

        private void frm_nuevo_examen_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_mst_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "insert into Examen values ='" + txt_fecha.Text + "','"  + txt_observacion.Text + "','" + txt_precio + "');";

                MySqlCommand man = new MySqlCommand(consulta, Conexionmysql.ObtenerConexion());
                MySqlDataReader re;
                Conexionmysql.ObtenerConexion();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido insertados exitosamente");
                while (re.Read())
                { }
                Conexionmysql.Desconectar();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_id_exm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}








