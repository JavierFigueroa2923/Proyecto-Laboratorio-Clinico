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
    public partial class frm_act_pago : Form
    {
        public frm_act_pago()
        {
            InitializeComponent();
        }
        BDconexion ManipularDato = new BDconexion();
        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            Conexionmysql.ObtenerConexion();
            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();
            //Creamos un nuevo adaptador de datos
            MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "Forma de Pago");
            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "Forma de Pago";
            Conexionmysql.Desconectar();
        }

        public void LimpiarCajasTexto()
        {
            txt_id_fm_pg.Text = "";
            txt_descripcion.Text = "";
            txt_nombre.Text = "";
        }

        public void InhabilitarTexto()
        {
            txt_id_fm_pg.Enabled = false;
            txt_descripcion.Enabled = false;
            txt_nombre.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_id_fm_pg.Enabled = true;
            txt_descripcion.Enabled = true;
            txt_nombre.Enabled = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "insert into FORMA_DE_PAGO values ('" + txt_id_fm_pg + "','" + txt_nombre + "','" + txt_descripcion + "');";
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
            LimpiarCajasTexto();
            InhabilitarTexto();
        }

        private void btn_actlz_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            try
            {
                string consulta2 = "update proyecto_laboratorio.FORMA_DE_PAGO set nombre_fm_pago='" + txt_nombre + "',descripcion_fm_pg='" + txt_descripcion + "' where pk_id_fm_pg ='" + txt_id_fm_pg + "';";
                MySqlCommand man = new MySqlCommand(consulta2, Conexionmysql.ObtenerConexion());
                MySqlDataReader re;
                Conexionmysql.ObtenerConexion();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido actualizados exitosamente");
                while (re.Read())
                { }
                Conexionmysql.Desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InhabilitarTexto();
        }

        private void btn_elim_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta3 = "DELETE from FORMA_DE_PAGO where pk_id_fm_pg ='" + txt_id_fm_pg + "');";
                MySqlCommand man = new MySqlCommand(consulta3, Conexionmysql.ObtenerConexion());
                MySqlDataReader re;
                Conexionmysql.ObtenerConexion();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido eliminados exitosamente");
                while (re.Read())
                { }
                Conexionmysql.Desconectar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_busc_lab_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from forma_de_pago where nombre_fm_pago like '%" + cbo_buscar + "%' ");
           // ManipularDato.Busqueda(Query);
            GridViewActualizar(this.dataGridView1, Query);
            Conexionmysql.Desconectar();
        }

        private void frm_act_pago_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            LimpiarCajasTexto();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }
    }
}
