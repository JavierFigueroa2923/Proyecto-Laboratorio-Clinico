using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_act_inventario : Form
    {
        public frm_act_inventario()
        {
            InitializeComponent();
        }

        string codigo = "";
        Boolean Editar;
        Validaciones validar = new Validaciones();
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public string obtenerIP()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        public void LimpiarCajaTexto()
        {
            txt_id_inv_sumin.Text = "";
            txt_nombre_sm.Text = "";
            txt_direccion.Text = "";
            txt_cantidad.Text = "";
            txt_prec_comp_inv_sumin.Text = "";
            txt_prec_vent_inv_sumin.Text = "";
            cbo_id_laboratorio.Text = "";
        }

        public void InhabilitarTexto()
        {
            txt_id_inv_sumin.Enabled = false;
            txt_nombre_sm.Enabled = false;
            txt_direccion.Enabled = false;
            txt_cantidad.Enabled = false;
            txt_prec_comp_inv_sumin.Enabled = false;
            txt_prec_vent_inv_sumin.Enabled = false;
            cbo_id_laboratorio.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_id_inv_sumin.Enabled = true;
            txt_nombre_sm.Enabled = true;
            txt_direccion.Enabled = true;
            txt_cantidad.Enabled = true;
            txt_prec_comp_inv_sumin.Enabled = true;
            txt_prec_vent_inv_sumin.Enabled = true;
            cbo_id_laboratorio.Enabled = true;
        }

        private void grid() {
            string query = String.Format("SELECT * FROM {0}", "inventario_suministro");
            Conexionmysql.ObtenerConexion();
            MySqlCommand command = new MySqlCommand(query, Conexionmysql.ObtenerConexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); adapter.Fill(data);
            dgv_vista_inv_sumin.DataSource = data;
            Conexionmysql.Desconectar();
        }
        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            if (txt_nombre_sm.Text == "" || txt_direccion.Text == "" || txt_cantidad.Text == "" || txt_prec_comp_inv_sumin.Text == "" || txt_prec_vent_inv_sumin.Text == "" || cbo_id_laboratorio.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update inventario_suministro set pk_id_simin = " + txt_id_inv_sumin.Text + ", existencia_sumin = " + txt_cantidad.Text + ", nombre_sumin = '" + txt_nombre_sm.Text + "', costo_por_unidad_inv_sumin = " + txt_prec_comp_inv_sumin.Text + ", precio_venta_unidad_inv_sumin = " + txt_prec_vent_inv_sumin.Text + ", detalle_sumin = " + txt_direccion.Text + ", pk_id_lab = " + cbo_id_laboratorio.Text + " where pk_id_simin = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'inventario_suministro'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    grid();
                    Conexionmysql.Desconectar();
                    //this.LimpiarCajaTextoEtiqueta();
                    Editar = false;
                }
                else
                {

                    try
                    {
                        String Query = "insert into inventario_suministro(pk_id_simin, existencia_sumin, nombre_sumin, costo_por_unidad_inv_sumin, precio_venta_unidad_inv_sumin, detalle_sumin, pk_id_lab)values(" + txt_id_inv_sumin.Text + "," + txt_cantidad.Text + ",'" + txt_nombre_sm.Text + "'," + txt_prec_comp_inv_sumin.Text + "," + txt_prec_vent_inv_sumin.Text + "," + txt_direccion.Text + "," + cbo_id_laboratorio.Text + ");";
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, Conexionmysql.ObtenerConexion());
                        MySqlDataReader MyReader2;
                        Conexionmysql.ObtenerConexion();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Registro ingresado exitosamente");
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Insertar','" + Usuario + "','" + obtenerIP() + "', 'inventario_suministro'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        grid();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            LimpiarCajaTexto();
            InhabilitarTexto();
        }

        private void frm_act_inventario_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
            grid();
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            Editar = true;
            codigo = this.dgv_vista_inv_sumin.CurrentRow.Cells[0].Value.ToString();
            txt_id_inv_sumin.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[0].Value.ToString();
            txt_nombre_sm.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[2].Value.ToString();
            txt_direccion.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[5].Value.ToString();
            txt_cantidad.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[1].Value.ToString();
            txt_prec_comp_inv_sumin.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[3].Value.ToString();
            txt_prec_vent_inv_sumin.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[4].Value.ToString();
            cbo_id_laboratorio.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_elim_inv_sumin_Click(object sender, EventArgs e)
        {
            codigo = this.dgv_vista_inv_sumin.CurrentRow.Cells[0].Value.ToString();
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
                    String Query = "delete from inventario_suministro where pk_id_simin = " + NumVal + ";";
                    //ejecutar query
                    cl_gridysql.EjecutarMySql(Query);
                    //Actualize la grid
                    grid();
                    //desconectamos de la base de datos
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Eliminar','" + Usuario + "','" + obtenerIP() + "', 'inventario_suministro'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    Conexionmysql.Desconectar();
                }
                else
                {
                    //no pasa nada
                    return;
                }
            }
        }

        private void btn_busc_tip_exam_Click(object sender, EventArgs e)
        {
            if (txt_busc_tips_exam.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridMuestra(this.dgv_vista_inv_sumin, "select * from inventario_suministro where pk_id_simin like '" + txt_busc_tips_exam.Text + "%';");
            }
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            Editar = false;
            LimpiarCajaTexto();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }
    }
}
