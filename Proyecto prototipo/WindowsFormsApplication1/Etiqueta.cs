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

    public partial class frm_etiqueta : Form
    {
        string codigo = "";
        Boolean Editar;
        public frm_etiqueta()
        {
            InitializeComponent();
        }

        private void txt_busc_mst_eti_TextChanged(object sender, EventArgs e)
        {

        }

        public void LimpiarCajaTextoEtiqueta()
        {
            txt_busc_eti.Text = "";
            txt_descr_eti.Text = "";
            txt_busc_eti.Text = "";
            cbo_id_mst_busc_eti.Text = "";
        }

        public void InhabilitarTexto()
        {
            cbo_id_mst_busc_eti.Enabled = false;
            txt_descr_eti.Enabled = false;
        }

        public void HabilitarTexto()
        {
            cbo_id_mst_busc_eti.Enabled = true;
            txt_descr_eti.Enabled = true;
        }

        private void btn_elim_eti_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = this.dgv_busc_eti.CurrentRow.Cells[0].Value.ToString();
                if (codigo == "")
                {
                    MessageBox.Show("No se ha seleccionado nada para realizar la eliminacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //preguntamos al usuario si desea eliminar el registro por completo
                    var resultado = MessageBox.Show("¿Realmente desea eliminar el registro?", "confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Proceder a evaluar el resultado
                    if (resultado == DialogResult.Yes)//si el usuario hizo click en el boton yes
                    {
                        //procedo a hacer el borrado
                        //me conecto a la base de datos
                        Conexionmysql.ObtenerConexion();
                        //armar query...
                        int NumVal = Int32.Parse(codigo);
                        String Query = "delete from etiquetas where pk_id_etqt = " + NumVal + ";";
                        //ejecutar query
                        cl_gridysql.EjecutarMySql(Query);
                        //Actualize la grid
                        cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas;");
                        //desconectamos de la base de datos
                        Conexionmysql.Desconectar();
                    }
                    else
                    {
                        //no pasa nada
                        return;
                    }
                }
                LimpiarCajaTextoEtiqueta();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado nada para realizar la eliminacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_guardar_eti_Click(object sender, EventArgs e)
        {
            try
            {
            if (cbo_id_mst_busc_eti.Text == "" || txt_descr_eti.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update etiquetas set descripcion_etqt = '" + txt_descr_eti.Text + "', pk_id_mst = '" + cbo_id_mst_busc_eti.SelectedValue + "'where pk_id_etqt = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas;");
                    Conexionmysql.ObtenerConexion();
                    this.LimpiarCajaTextoEtiqueta();
                    Editar = false;
                }
                else
                {
                    //Conectarse a base de datos
                    Conexionmysql.ObtenerConexion();
                    //Armar Query
                    String Query = "insert into etiquetas(descripcion_etqt,pk_id_mst)values('" + txt_descr_eti.Text + "'," + cbo_id_mst_busc_eti.SelectedValue + ");";
                    //Ejecutar Query
                    cl_gridysql.EjecutarMySql(Query);
                    //Actualizar el DataGrid
                    cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas;");
                    //Desconectarse de la Base de Datos
                    Conexionmysql.Desconectar();
                    //Limpiar cajas de texto
                    this.LimpiarCajaTextoEtiqueta();
                }
            }
            }
            catch
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InhabilitarTexto();
        }

        private void btn_actlz_eti_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            try
            {
                Editar = true;
                codigo = this.dgv_busc_eti.CurrentRow.Cells[0].Value.ToString();
                txt_descr_eti.Text = this.dgv_busc_eti.CurrentRow.Cells[1].Value.ToString();
                cbo_id_mst_busc_eti.Text = this.dgv_busc_eti.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frm_etiqueta_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_acept.Enabled = false;
            btn_cancl.Enabled = false;
            cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas");
            llenarCboMuestraEtiqueta();
            btn_id_mst_busc_eti.Visible = false;
        }

        private void btn_busc_eti_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_busc_eti.Text == "")
                {
                    MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas where pk_id_etqt like '" + txt_busc_eti.Text + "%';");
                }
            }
            catch
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_busquedaeti_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas where pk_id_etqt like '" + txt_busc_eti.Text + "%';");
        }

       
        private void btn_id_mst_busc_eti_Click(object sender, EventArgs e)
        {
            //Busqueda_id_muestra ini = new Busqueda_id_muestra();
            //ini.MdiParent = this.MdiParent;
            //ini.Show();
            //this.Hide();
        }

        private void cbo_id_mst_busc_eti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenarCboMuestraEtiqueta()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select DISTINCT muestra.pk_id_mst, muestra.cantidad_de_mst, cliente.nombre_clt, cliente.apellido_clt from muestra, cliente WHERE muestra.pk_id_clt = cliente.pk_id_clt";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "muestra");
            cbo_id_mst_busc_eti.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_mst_busc_eti.ValueMember = ("pk_id_mst");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_clt, nombre_clt";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_clt"] = dr["pk_id_mst"].ToString() + " " + dr["cantidad_de_mst"].ToString() + " " + dr["nombre_clt"].ToString() + " " + dr["apellido_clt"].ToString();
            }
            cbo_id_mst_busc_eti.DataSource = dt;
            cbo_id_mst_busc_eti.DisplayMember = "nombre_clt";
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            Editar = false;
            LimpiarCajaTextoEtiqueta();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }
    }
}
