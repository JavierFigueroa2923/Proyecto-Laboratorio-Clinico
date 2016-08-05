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
            txt_id_clt__eti.Text = "";
            txt_id_eti.Text = "";
            txt_id_mst_eti.Text = "";
            txt_busc_eti.Text = "";
            txt_busc_mst_eti.Text = "";
            txt_descr_eti.Text = "";
        }

        private void btn_elim_eti_Click(object sender, EventArgs e)
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
                    cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra, pk_id_clt as Cliente from etiquetas;");
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


        private void btn_guardar_eti_Click(object sender, EventArgs e)
        {
            if (txt_id_mst_eti.Text == "" || txt_id_clt__eti.Text == "" || txt_descr_eti.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update etiquetas set descripcion_etqt = '" + txt_descr_eti + "', pk_id_mst = '" + txt_id_mst_eti.Text + "', pk_id_clt = '" + txt_id_clt__eti.Text + "'where pk_id_etqt = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra, pk_id_clt as Cliente from etiquetas;");
                    Conexionmysql.ObtenerConexion();
                    this.LimpiarCajaTextoEtiqueta();
                    Editar = false;
                }
                else
                {
                    //Conectarse a base de datos
                    Conexionmysql.ObtenerConexion();
                    //Armar Query
                    String Query = "insert into etiquetas(pk_id_etqt,descripcion_etqt,pk_id_mst,pk_id_clt)values(" + txt_id_eti.Text + ",'" + txt_descr_eti.Text + "'," + txt_id_mst_eti.Text + "," + txt_id_clt__eti.Text + ");";
                    //Ejecutar Query
                    cl_gridysql.EjecutarMySql(Query);
                    //Actualizar el DataGrid
                    cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra, pk_id_clt as Cliente from etiquetas;");
                    //Desconectarse de la Base de Datos
                    Conexionmysql.Desconectar();
                    //Limpiar cajas de texto
                    this.LimpiarCajaTextoEtiqueta();
                }
            }
        }

        private void btn_actlz_eti_Click(object sender, EventArgs e)
        {
            Editar = true;
            codigo = this.dgv_busc_eti.CurrentRow.Cells[0].Value.ToString();
            txt_descr_eti.Text = this.dgv_busc_eti.CurrentRow.Cells[1].Value.ToString();
            txt_id_mst_eti.Text = this.dgv_busc_eti.CurrentRow.Cells[2].Value.ToString();
            txt_id_clt__eti.Text = this.dgv_busc_eti.CurrentRow.Cells[3].Value.ToString();
        }

        private void frm_etiqueta_Load(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra, pk_id_clt as Cliente from etiquetas;");
            cl_gridysql.ActualizarGridMuestra(this.dgv_busc_mst_eti, "select pk_id_mst as Identificador, pk_id_clt as Cliente, descripcion_mst as Descripcion, pk_id_tip_mst as Tipo_Muestra from muestra;");
        }

        private void btn_busc_eti_Click(object sender, EventArgs e)
        {
            if (txt_busc_eti.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra, pk_id_clt as Cliente from etiquetas where pk_id_etqt like '" + txt_busc_eti.Text + "%';");
            }
        }

        private void Txt_busquedaeti_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridEtiqueta(this.dgv_busc_eti, "select pk_id_etqt as Identificador, descripcion_etqt as Descripcion, pk_id_mst as Muestra, pk_id_clt as Cliente from etiquetas where pk_id_etqt like '" + txt_busc_eti.Text + "%';");
        }

        private void btn_busc__mst_eti_Click(object sender, EventArgs e)
        {
            if (txt_busc_mst_eti.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridMuestra(this.dgv_busc_mst_eti, "select pk_id_mst as Identificador, pk_id_clt as Cliente, descripcion_mst as Descripcion, pk_id_tip_mst as Tipo_Muestra from muestra where pk_id_mst like '" + txt_busc_mst_eti.Text + "%';");
            }
        }

        private void Txt_busquedamsteti_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridMuestra(this.dgv_busc_mst_eti, "select pk_id_mst as Identificador, pk_id_clt as Cliente, descripcion_mst as Descripcion, pk_id_tip_mst as Tipo_Muestra from muestra where pk_id_mst like '" + txt_busc_mst_eti.Text + "%';");

        }
    }
}
