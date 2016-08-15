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
        String Codigo;
        Boolean Editar;
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
            txt_descripcion.Text = "";
            txt_nombre.Text = "";
        }

        public void InhabilitarTexto()
        {
            txt_descripcion.Enabled = false;
            txt_nombre.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_descripcion.Enabled = true;
            txt_nombre.Enabled = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_rnv_Click(object sender, EventArgs e)
        {
            GridViewActualizar(this.dgv_for_pag, "select pk_id_fm_pg as Identificador, nombre_fm_pago as Nombre, descripcion_fm_pg as Descripcion from forma_de_pago where nombre_fm_pago like '%" + txt_busc.Text + "%' ");
        }

        private void btn_guardar_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                if(Editar)
                {
                    string consulta2 = "update proyecto_laboratorio.FORMA_DE_PAGO set nombre_fm_pago='" + txt_nombre.Text + "',descripcion_fm_pg='" + txt_descripcion + "' where pk_id_fm_pg ='" + Codigo + "';";
                    MySqlCommand man = new MySqlCommand(consulta2, Conexionmysql.ObtenerConexion());
                    MySqlDataReader re;
                    Conexionmysql.ObtenerConexion();
                    re = man.ExecuteReader();
                    MessageBox.Show("Los datos han sido actualizados exitosamente");
                    while (re.Read())
                    { }
                    Conexionmysql.Desconectar();
                    GridViewActualizar(this.dgv_for_pag, "select pk_id_fm_pg as Identificador, nombre_fm_pago as Nombre, descripcion_fm_pg as Descripcion from forma_de_pago where nombre_fm_pago like '%" + txt_busc.Text + "%' ");
                    Editar = false;
                }
                else
                {
                    string consulta = "insert into forma_de_pago(nombre_fm_pago,descripcion_fm_pg)values ('" + txt_nombre.Text + "','" + txt_descripcion.Text + "');";
                    MySqlCommand man = new MySqlCommand(consulta, Conexionmysql.ObtenerConexion());
                    MySqlDataReader re;
                    Conexionmysql.ObtenerConexion();
                    re = man.ExecuteReader();
                    MessageBox.Show("Los datos han sido insertados exitosamente");
                    while (re.Read())
                    { }
                    Conexionmysql.Desconectar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LimpiarCajasTexto();
            GridViewActualizar(this.dgv_for_pag, "select pk_id_fm_pg as Identificador, nombre_fm_pago as Nombre, descripcion_fm_pg as Descripcion from forma_de_pago where nombre_fm_pago like '%" + txt_busc.Text + "%' ");
            InhabilitarTexto();
        }

        private void btn_actlz_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            Editar = true;
            Codigo = this.dgv_for_pag.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = this.dgv_for_pag.CurrentRow.Cells[1].Value.ToString();
            txt_descripcion.Text = this.dgv_for_pag.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_elim_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                Codigo = this.dgv_for_pag.CurrentRow.Cells[0].Value.ToString();
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    string consulta3 = "DELETE from forma_de_pago where pk_id_fm_pg ='" + Codigo + "';";
                    MySqlCommand man = new MySqlCommand(consulta3, Conexionmysql.ObtenerConexion());
                    MySqlDataReader re;
                    Conexionmysql.ObtenerConexion();
                    re = man.ExecuteReader();
                    MessageBox.Show("Los datos han sido eliminados exitosamente");
                    while (re.Read())
                    { }
                    Conexionmysql.Desconectar();
                    GridViewActualizar(this.dgv_for_pag, "select pk_id_fm_pg as Identificador, nombre_fm_pago as Nombre, descripcion_fm_pg as Descripcion from forma_de_pago where nombre_fm_pago like '%" + txt_busc.Text + "%' ");

                }
                else
                //no pasa nada
                 return;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_busc_lab_Click(object sender, EventArgs e)
        {
            GridViewActualizar(this.dgv_for_pag, "select pk_id_fm_pg as Identificador, nombre_fm_pago as Nombre, descripcion_fm_pg as Descripcion from forma_de_pago where nombre_fm_pago like '%" + txt_busc.Text + "%' ");
        }

        private void frm_act_pago_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
            GridViewActualizar(this.dgv_for_pag, "select pk_id_fm_pg as Identificador, nombre_fm_pago as Nombre, descripcion_fm_pg as Descripcion from forma_de_pago where nombre_fm_pago like '%" + txt_busc.Text + "%' ");
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

        private void txt_busc_KeyUp(object sender, KeyEventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select pk_id_fm_pg as Identificador, nombre_fm_pago as Nombre, descripcion_fm_pg as Descripcion from forma_de_pago where nombre_fm_pago like '%" + txt_busc.Text + "%' ");
            // ManipularDato.Busqueda(Query);
            GridViewActualizar(this.dgv_for_pag, Query);
            Conexionmysql.Desconectar();
        }
    }
}
