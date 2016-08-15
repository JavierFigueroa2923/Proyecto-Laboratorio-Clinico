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
    public partial class frm_muestra : Form
    {
        public frm_muestra()
        {
            InitializeComponent();
        
}
        Validaciones validar = new Validaciones();
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

        public void LimpiarCajasTexto()
        {
            cbo_id_cliente.Text = "";
            cbo_id_muestra.Text = "";
            txt_cant_mst.Text = "";
            txt_descr_mst.Text = "";
            cbo_tipo_mst.Text = "";

        }

        public void InhabilitarTexto()
        {
            cbo_id_cliente.Enabled = false;
            cbo_id_muestra.Enabled = false;
            txt_cant_mst.Enabled = false;
            txt_descr_mst.Enabled = false;
            cbo_tipo_mst.Enabled = false;
        }

        public void HabilitarTexto()
        {
            cbo_id_cliente.Enabled = true;
            cbo_id_muestra.Enabled = true;
            txt_cant_mst.Enabled = true;
            txt_descr_mst.Enabled = true;
            cbo_tipo_mst.Enabled = true;
        }

        private void btn_guardar_mst_Click(object sender, EventArgs e)
        {
            try          
        {
             string selectedItem = cbo_id_muestra.SelectedValue.ToString();
            string selectedItem1 = cbo_id_cliente.SelectedValue.ToString();
                string selectedItem2 = cbo_tipo_mst.SelectedValue.ToString();           
            string consulta = "insert into MUESTRA values ='" + txt_cant_mst.Text + "','" + txt_descr_mst.Text + "','" + selectedItem1 + "','" + selectedItem + "','" + selectedItem2 + "');";

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
            InhabilitarTexto();
        }

        private void btn_actlz_mst_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            try
            {
                string selectedItem = cbo_id_muestra.SelectedValue.ToString();
                string selectedItem1 = cbo_id_cliente.SelectedValue.ToString();
                string selectedItem2 = cbo_tipo_mst.SelectedValue.ToString();
                string consulta2 = "update proyecto_laboratorio.MUESTRA set cant_de_mst = '" + txt_cant_mst.Text + "',descripcion_mst = '" + txt_descr_mst.Text + "',tipo'" + selectedItem1 + "','" + selectedItem + "','" + selectedItem2 + "');";
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

        private void btn_elim_mst_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_id_muestra.SelectedValue.ToString();
                string selectedItem1 = cbo_id_cliente.SelectedValue.ToString();
                string selectedItem2= cbo_tipo_mst.SelectedValue.ToString();
                string consulta3 = "DELETE from MUESTRA where pk_id_clt ='" + selectedItem2 + "','" + selectedItem1 + "','" + selectedItem + "');";
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

        private void dgv_id_clt_mst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_busc_id_clt_mst_Click(object sender, EventArgs e)
        {
            
                Conexionmysql.ObtenerConexion();
                String Query = ("select * from MUESTRA = pk_id_clt");
            //ManipularDato.Busqueda(Query);mp = C.pk_id_e
            GridViewActualizar(this.dgv_id_clt_mst, Query);
            Conexionmysql.Desconectar();
            
        }

        private void btn_busc_id_mst_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from MUESTRA = pk_id_clt");
            //ManipularDato.Busqueda(Query);mp = C.pk_id_e
            GridViewActualizar(this.dgv_busc_mst, Query);
            Conexionmysql.Desconectar();
        }

        private void cbo_id_muestra_SelectedIndexChanged(object sender, EventArgs e)
        {           
                //se realiza la conexión a la base de datos
                Conexionmysql.ObtenerConexion();
                //se inicia un DataSet
                DataSet ds = new DataSet();
                //se indica la consulta en sql
                String Query = "select pk_id_tip_mst, nombre_clt from MUESTRA;";
                MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
                //se indica con quu tabla se llena
                dad.Fill(ds, "permiso");
                cbo_id_muestra.DataSource = ds.Tables[0].DefaultView;
                //indicamos el valor de los miembros
                cbo_id_muestra.ValueMember = ("pk_id_tip_mst");
                //se indica el valor a desplegar en el combobox
                cbo_id_muestra.DisplayMember = ("nombre_clt");
            
        }

        private void dgv_busc_mst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_acept_Click(object sender, EventArgs e)
        {

        }

        private void btn_renov_pcnt_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            LimpiarCajasTexto();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }

        private void frm_muestra_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_acept.Enabled = false;
            btn_cancl.Enabled = false;
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
        }

        private void txt_cant_mst_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_cant_mst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_descr_mst_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}

