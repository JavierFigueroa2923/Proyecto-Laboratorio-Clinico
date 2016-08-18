using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class frm_act_lab : Form
    {
        public frm_act_lab()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion ManipularDato = new BDconexion();
        String Codigo;
        Boolean Editar;

        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

        public void LimpiarTextBox()
        {
            txt_id_labs.Text = "";
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            txt_busc_lab.Text = "";
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

        public void InhabilitarTexto()
        {
            txt_id_labs.Enabled = false;
            txt_nombre.Enabled = false;
            txt_direccion.Enabled = false;
            txt_telefono.Enabled = false;
            txt_correo.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_id_labs.Enabled = true;
            txt_nombre.Enabled = true;
            txt_direccion.Enabled = true;
            txt_telefono.Enabled = true;
            txt_correo.Enabled = true;
        }

        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            Conexionmysql.ObtenerConexion();
            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();
            //Creamos un nuevo adaptador de datos
            MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "laboratorio");
            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "laboratorio";
            Conexionmysql.Desconectar();
        }

        private void btn_busc_lab_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select distinct L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where nombre_lab like '%" + txt_busc_lab.Text + "%' and L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab ");
            //ManipularDato.Busqueda(Query);
            GridViewActualizar(this.dgv_labs, Query);
            Conexionmysql.Desconectar();
        }

        private void lbl_busca_lab_Click(object sender, EventArgs e)
        {

        }

        private void txt_busc_lab_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridViewActualizar(this.dgv_labs, "select distinct L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
        }

        private void frm_act_lab_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
            GridViewActualizar(this.dgv_labs, "select distinct L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
        }

        private void txt_id_labs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            txt_telefono.MaxLength = 8;
        }

        private void btn_guardar_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_id_labs.Text == "" || txt_nombre.Text == "" || txt_telefono.Text == "" || txt_direccion.Text == "" || txt_correo.Text == "" )
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String Query = "UPDATE laboratorio SET nombre_lab ='" + txt_nombre.Text + "' WHERE pk_id_lab ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(Query);
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'laboratorio'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarTextBox();
                        GridViewActualizar(this.dgv_labs, "select distinct L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        String Query1 = "INSERT INTO laboratorio (pk_id_lab, nombre_lab) VALUES ('" + Convert.ToInt32(txt_id_labs.Text) + "','" + txt_nombre.Text + "')";
                        cl_gridysql.EjecutarMySql(Query1);

                        if (ComprobarFormatoEmail(txt_correo.Text) == false)
                        {
                            MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            String Query2 = "INSERT INTO correo_e (correo_e, pk_id_lab) VALUES ('" + txt_correo.Text + "','" + Convert.ToInt32(txt_id_labs.Text) + "')";
                            cl_gridysql.EjecutarMySql(Query2);
                            MessageBox.Show("!!No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        

                        String Query3 = "INSERT INTO direccion (direccion, pk_id_lab) VALUES ('" + txt_direccion.Text + "','" + Convert.ToInt32(txt_id_labs.Text) + "')";
                        cl_gridysql.EjecutarMySql(Query3);

                        String Query4 = "INSERT INTO telefono (telefono, pk_id_lab) VALUES ('" + txt_telefono.Text + "','" + Convert.ToInt32(txt_id_labs.Text) + "')";
                        cl_gridysql.EjecutarMySql(Query4);

                        GridViewActualizar(this.dgv_labs, "select distinct L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
                        this.LimpiarTextBox();
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Ingreso','" + Usuario + "','" + obtenerIP() + "', 'laboratorio'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        MessageBox.Show("Operación realizada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            InhabilitarTexto();
            
        }

        private void btn_elim_pcnt_Click(object sender, EventArgs e)
        {
            Codigo = this.dgv_labs.CurrentRow.Cells[0].Value.ToString();

            //2. preguntar al usuario si realmente quiere borrar el resgistro

            var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //3.PROCEDER AVALUAR EL RESULTADO
            if (resultado == DialogResult.Yes)// si el usuario hizo click en si
            {
                //procedemos a borrar el registro

                //1. conectar a base de datosx
                Conexionmysql.ObtenerConexion();

                //2. armar la query
                String Query = "delete from laboratorio where pk_id_lab = '" + Codigo + "';";

                //3.ejecutar la query
                cl_gridysql.EjecutarMySql(Query);

                //4.Actualizar grid..
                GridViewActualizar(this.dgv_labs, "select L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
                String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Eliminar','" + Usuario + "','" + obtenerIP() + "', 'laboratorio'," + MiIdUsuario + ") ";
                cl_gridysql.EjecutarMySql(bitacora);

                //5.desconectar en base de datos
                Conexionmysql.Desconectar();


            }//cerrar el if

            else

                //no pasa nada
                return;

            //cerrar else
        }

        private void btn_actlz_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarTexto();
                btn_cancl.Enabled = true;
                Editar = true;
                Codigo = this.dgv_labs.CurrentRow.Cells[0].Value.ToString();
                txt_id_labs.Text = this.dgv_labs.CurrentRow.Cells[1].Value.ToString();
                txt_nombre.Text = this.dgv_labs.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado el registro a actualizar", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_labs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_id_labs_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
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
            LimpiarTextBox();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }

        
    }
}
