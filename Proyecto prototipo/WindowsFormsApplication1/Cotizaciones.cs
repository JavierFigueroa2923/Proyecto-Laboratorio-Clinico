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
    public partial class Cotizacion : Form
    {
        public Cotizacion()
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
            newDataAdapter.Fill(newDataSet, "Cotizacion");
            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "Cotizacion";
            Conexionmysql.Desconectar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_busc_tip_exam_Click(object sender, EventArgs e)

        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from COTIZACION");
            //ManipularDato.Busqueda(Query);mp = C.pk_id_e
            GridViewActualizar(this.dgv_vista_ctzn, Query);
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_id_clnt.SelectedValue.ToString();
                string selectedItem1 = cbo_id_lab.SelectedValue.ToString();
                string consulta = "insert into COTIZACION values ='" + txt_fecha.Text + "','" + txt_total.Text + "','" + txt_descuento.Text + "','" + selectedItem1 + "','" + selectedItem +  "');";
                
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

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_id_clnt.SelectedValue.ToString();
                string selectedItem1 = cbo_id_lab.SelectedValue.ToString();
                string consulta2 = "update proyecto_laboratorio.COTIZACION set fecha_de_creacion_ctzn='" + txt_fecha.Text + "',monto_total_ctzn='" + txt_total.Text+ "' , descuento_cztn= '" + txt_descuento.Text + "','" + selectedItem1 + "','" + selectedItem + "');";
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

        private void btn_elim_inv_sumin_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_id_clnt.SelectedValue.ToString();
                string selectedItem1 = cbo_id_lab.SelectedValue.ToString();
                string consulta3 = "DELETE from COTIZACION where pk_id_clt ='" + selectedItem1 + "','" + selectedItem + "');";
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

        private void cbo_id_lab_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_lab, nombre_lab from COTIZACION;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "permiso");
            cbo_id_lab.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_lab.ValueMember = ("pk_id_lab");
            //se indica el valor a desplegar en el combobox
            cbo_id_lab.DisplayMember = ("nombre_lab");
        }

        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_id_clnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_clt, nombre_lab from COTIZACION;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "permiso");
            cbo_id_lab.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_lab.ValueMember = ("pk_id_clt");
            //se indica el valor a desplegar en el combobox
            cbo_id_lab.DisplayMember = ("nombre_clt");
        }
    }
}



