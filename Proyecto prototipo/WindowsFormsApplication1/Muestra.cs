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
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class frm_muestra : Form
    {
        String Codigo;
        Boolean Editar; 
        public frm_muestra()
        {
            InitializeComponent();
        
        }
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

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
            newDataAdapter.Fill(newDataSet, "muestra");
            //Asignando valores al DataGrid
            dgv_busc_mst.DataSource = newDataSet;
            dgv_busc_mst.DataMember = "muestra";
            Conexionmysql.Desconectar();
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

        public void LimpiarCajasTexto()
        {
            cbo_id_cliente.Text = "";
            txt_cant_mst.Text = "";
            txt_descr_mst.Text = "";
            cbo_tipo_mst.Text = "";

        }

        public void InhabilitarTexto()
        {
            cbo_id_cliente.Enabled = false;
            txt_cant_mst.Enabled = false;
            txt_descr_mst.Enabled = false;
            cbo_tipo_mst.Enabled = false;
        }

        public void HabilitarTexto()
        {
            cbo_id_cliente.Enabled = true;
            txt_cant_mst.Enabled = true;
            txt_descr_mst.Enabled = true;
            cbo_tipo_mst.Enabled = true;
        }

        private void btn_guardar_mst_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cant_mst.Text == "" || txt_descr_mst.Text == "" || cbo_id_cliente.Text == "" || cbo_tipo_mst.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        string selectedItem1 = cbo_id_cliente.SelectedValue.ToString();
                        string selectedItem2 = cbo_tipo_mst.SelectedValue.ToString();
                        string consulta2 = "update muestra set cantidad_de_mst = '" + txt_cant_mst.Text + "',descripcion_mst = '" + txt_descr_mst.Text + "',pk_id_tip_mst ='" + selectedItem2 + "',pk_id_clt ='" + selectedItem1 + "' WHERE pk_id_mst ='" + Codigo + "';";
                        MySqlCommand man = new MySqlCommand(consulta2, Conexionmysql.ObtenerConexion());
                        MySqlDataReader re;
                        Conexionmysql.ObtenerConexion();
                        re = man.ExecuteReader();
                        MessageBox.Show("Los datos han sido actualizados exitosamente");
                        while (re.Read())
                        { }
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'muestra'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        LimpiarCajasTexto();
                        GridViewActualizar(this.dgv_busc_mst, "select pk_id_mst as Identificador, cantidad_de_mst as Cantidad, descripcion_mst as Descripcion,pk_id_tip_mst as Tipo_Muestra,pk_id_clt as Cliente from muestra;");
                    }
                    else
                    {
                        string selectedItem1 = cbo_id_cliente.SelectedValue.ToString();
                        string selectedItem2 = cbo_tipo_mst.SelectedValue.ToString();
                        string consulta = "insert into MUESTRA (cantidad_de_mst,descripcion_mst,pk_id_tip_mst,pk_id_clt)values('" + txt_cant_mst.Text + "','" + txt_descr_mst.Text + "','" + selectedItem2 + "','" + selectedItem1 + "');";
                        MySqlCommand man = new MySqlCommand(consulta, Conexionmysql.ObtenerConexion());
                        MySqlDataReader re;
                        Conexionmysql.ObtenerConexion();
                        re = man.ExecuteReader();
                        MessageBox.Show("Los datos han sido insertados exitosamente");
                        while (re.Read())
                        { }
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Insertar','" + Usuario + "','" + obtenerIP() + "', 'muestra'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        LimpiarCajasTexto();
                        GridViewActualizar(this.dgv_busc_mst, "select pk_id_mst as Identificador, cantidad_de_mst as Cantidad, descripcion_mst as Descripcion,pk_id_tip_mst as Tipo_Muestra,pk_id_clt as Cliente from muestra;");
                    }
                }
             }
            catch
            {
                MessageBox.Show("Existe algun error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            InhabilitarTexto();
        }

        private void btn_actlz_mst_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            try
            {
                
                Editar = true;
                Codigo = this.dgv_busc_mst.CurrentRow.Cells[0].Value.ToString();
                txt_cant_mst.Text = this.dgv_busc_mst.CurrentRow.Cells[1].Value.ToString();
                txt_descr_mst.Text = this.dgv_busc_mst.CurrentRow.Cells[2].Value.ToString();
                cbo_tipo_mst.Text = this.dgv_busc_mst.CurrentRow.Cells[3].Value.ToString();
                cbo_id_cliente.Text = this.dgv_busc_mst.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado el registro a actualizar", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_elim_mst_Click(object sender, EventArgs e)
        {
            Codigo = this.dgv_busc_mst.CurrentRow.Cells[0].Value.ToString();
            try
            {
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    string consulta3 = "DELETE from MUESTRA where pk_id_mst ='" + Codigo + "';";
                    MySqlCommand man = new MySqlCommand(consulta3, Conexionmysql.ObtenerConexion());
                    MySqlDataReader re;
                    Conexionmysql.ObtenerConexion();
                    re = man.ExecuteReader();
                    MessageBox.Show("Los datos han sido eliminados exitosamente");
                    while (re.Read())
                    { }
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Eliminar','" + Usuario + "','" + obtenerIP() + "', 'muestra'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    Conexionmysql.Desconectar();
                    GridViewActualizar(this.dgv_busc_mst, "select pk_id_mst as Identificador, cantidad_de_mst as Cantidad, descripcion_mst as Descripcion,pk_id_tip_mst as Tipo_Muestra,pk_id_clt as Cliente from muestra;");
                }
                else
                    return ;
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
        }

        private void btn_busc_id_mst_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select pk_id_mst as Identificador, cantidad_de_mst as Cantidad, descripcion_mst as Descripcion,pk_id_tip_mst as Tipo_Muestra,pk_id_clt as Cliente from muestra where pk_id_mst like '" + txt_busc_id_mst.Text + "%';");
            //ManipularDato.Busqueda(Query);mp = C.pk_id_e
            GridViewActualizar(this.dgv_busc_mst, Query);
            Conexionmysql.Desconectar();
        }

        private void cbo_id_muestra_SelectedIndexChanged(object sender, EventArgs e)
        {    
        }

        private void Lllenarcbo_id_cliente()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_clt, nombre_clt from cliente;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cliente");
            cbo_id_cliente.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_cliente.ValueMember = ("pk_id_clt");
            //se indica el valor a desplegar en el combobox
            cbo_id_cliente.DisplayMember = ("nombre_clt");
        }

        private void dgv_busc_mst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_acept_Click(object sender, EventArgs e)
        {

        }

        private void btn_renov_pcnt_Click(object sender, EventArgs e)
        {
            GridViewActualizar(this.dgv_busc_mst, "select pk_id_mst as Identificador, cantidad_de_mst as Cantidad, descripcion_mst as Descripcion,pk_id_tip_mst as Tipo_Muestra,pk_id_clt as Cliente from muestra;");
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            LimpiarCajasTexto();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            Editar = false;
        }

        private void frm_muestra_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_acept.Enabled = false;
            btn_cancl.Enabled = false;
            Lllenarcbo_id_cliente();
            Lllenarcbo_id_tipo_muestra();
            GridViewActualizar(this.dgv_busc_mst, "select pk_id_mst as Identificador, cantidad_de_mst as Cantidad, descripcion_mst as Descripcion,pk_id_tip_mst as Tipo_Muestra,pk_id_clt as Cliente from muestra;");
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

        private void cbo_id_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lllenarcbo_id_tipo_muestra()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_tip_mst, nombre_tipo from tipo_de_muestra;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "tipo_de_muestra");
            cbo_tipo_mst.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_tipo_mst.ValueMember = ("pk_id_tip_mst");
            //se indica el valor a desplegar en el combobox
            cbo_tipo_mst.DisplayMember = ("nombre_tipo");
        }

        private void txt_busc_id_mst_KeyUp(object sender, KeyEventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select pk_id_mst as Identificador, cantidad_de_mst as Cantidad, descripcion_mst as Descripcion,pk_id_tip_mst as Tipo_Muestra,pk_id_clt as Cliente from muestra where pk_id_mst like '" + txt_busc_id_mst.Text + "%';");
            //ManipularDato.Busqueda(Query);mp = C.pk_id_e
            GridViewActualizar(this.dgv_busc_mst, Query);
            Conexionmysql.Desconectar();
        }
    }
}

