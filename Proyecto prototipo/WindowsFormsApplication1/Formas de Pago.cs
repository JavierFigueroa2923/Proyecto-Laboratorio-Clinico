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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_tipo_precio_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_descuento_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_referencia_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_direccion_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_telefono_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_nit_Click(object sender, EventArgs e)
        {

        }

        private void lbl_paciente_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        }

        private void btn_actlz_pcnt_Click(object sender, EventArgs e)
        {
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
    }
}
