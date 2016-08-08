using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    String Query = "update etiquetas set descripcion_etqt = '" + txt_descr_eti.Text + "', pk_id_mst = '" + cbo_id_mst_busc_eti.Text + "'where pk_id_etqt = " + NumVal + ";";
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
                    String Query = "insert into etiquetas(descripcion_etqt,pk_id_mst)values('" + txt_descr_eti.Text + "'," + cbo_id_mst_busc_eti.Text + ");";
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
        }

        private void btn_actlz_eti_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                codigo = this.dgv_busc_eti.CurrentRow.Cells[0].Value.ToString();
                txt_descr_eti.Text = this.dgv_busc_eti.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frm_etiqueta_Load(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas");
        }

        private void btn_busc_eti_Click(object sender, EventArgs e)
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

        private void Txt_busquedaeti_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra from etiquetas where pk_id_etqt like '" + txt_busc_eti.Text + "%';");
        }

       
        private void btn_id_mst_busc_eti_Click(object sender, EventArgs e)
        {
            Busqueda_id_muestra ini = new Busqueda_id_muestra();
            ini.MdiParent = this.MdiParent;
            ini.Show();
            this.Hide();
        }
    }
}
