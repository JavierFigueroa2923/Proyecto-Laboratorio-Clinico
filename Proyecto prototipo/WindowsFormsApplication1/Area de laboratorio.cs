using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Area_de_laboratorio : Form
    {
        public Area_de_laboratorio()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion ManipularDato = new BDconexion();
        String Codigo;
        Boolean Editar;

        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

        private void Area_de_laboratorio_Load(object sender, EventArgs e)
        {
            btn_acept.Enabled = false;
            btn_cancl.Enabled = false;
            ActualizarGrid(this.dgv_area_labs, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio;");
            llenaridlab();
            InhabilitarText();
        }
        private void txt_id_area_lab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
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


        private void txt_id_lab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }
        public void LimpiarCajasTexto()
        {

            txt_descrip_area.Text = "";
            //txt_id_area_lab.Text = "";
           cbo_id_lab.Text = "";

        }

        public void InhabilitarText()
        {
            cbo_id_lab.Enabled = false;
            txt_descrip_area.Enabled = false;
        }

        public void HabilitarText()
        {
            cbo_id_lab.Enabled = true;
            txt_descrip_area.Enabled = true;
        }

        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "area_laboratorio");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "area_laboratorio";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_area_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_descrip_area.Text == "" || cbo_id_lab.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        string selectedItem = cbo_id_lab.SelectedValue.ToString();
                        String query2 = "UPDATE area_laboratorio SET descripcion_ar_lab='" + txt_descrip_area.Text + "', pk_id_lab = '" + selectedItem + "' WHERE pk_id_area_lab='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'area_laboratorio'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_area_labs, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        string selectedItem = cbo_id_lab.SelectedValue.ToString();
                        String Query = "INSERT INTO area_laboratorio (pk_id_lab,descripcion_ar_lab) VALUES ('" + selectedItem + "','" + txt_descrip_area.Text + "') ";
                        cl_gridysql.EjecutarMySql(Query);
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Ingresar','" + Usuario + "','" + obtenerIP() + "', 'area_laboratorio'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        ActualizarGrid(this.dgv_area_labs, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio");
                        this.LimpiarCajasTexto();
                        Conexionmysql.Desconectar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InhabilitarText();
        }

        private void btn_elim_area_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dgv_area_labs.CurrentRow.Cells[0].Value.ToString();
                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro
                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();
                    //2. armar la query
                    String Query = "delete from area_laboratorio where pk_id_area_lab= '" + Codigo + "';";
                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);
                    //4.Actualizar grid..
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Eliminar','" + Usuario + "','" + obtenerIP() + "', 'area_laboratorio'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    ActualizarGrid(this.dgv_area_labs, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio;");
                    //5.desconectar en base de datos
                    Conexionmysql.Desconectar();
                }//cerrar el if
                else
                    //no pasa nada
                    return;
                //cerrar else
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_buscar_lab_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio where pk_id_area_lab like '" + txt_busc_are_lab.Text + "%'; ");
            //ManipularDato.Busqueda(Query);
            ActualizarGrid(this.dgv_area_labs, Query);
            Conexionmysql.Desconectar();
        }


        private void btn_actlz_area_Click(object sender, EventArgs e)
        {
            btn_cancl.Enabled = true;
            HabilitarText();
            try {
                Editar = true;
                Codigo = this.dgv_area_labs.CurrentRow.Cells[0].Value.ToString();
                cbo_id_lab.Text = this.dgv_area_labs.CurrentRow.Cells[2].Value.ToString();
                txt_descrip_area.Text = this.dgv_area_labs.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarText();
            btn_cancl.Enabled = true;
        }

        private void btn_cancl_pcnt_Click(object sender, EventArgs e)
        {
            Editar = false;
            LimpiarCajasTexto();
            InhabilitarText();
            btn_cancl.Enabled = false;
        }

        private void llenaridlab()
        {

            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
           //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_lab, nombre_lab from laboratorio;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "laboratorio");
            cbo_id_lab.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_lab.ValueMember = ("pk_id_lab");
            //se indica el valor a desplegar en el combobox
            cbo_id_lab.DisplayMember = ("nombre_lab");
        }

        private void txt_busc_are_lab_KeyUp(object sender, KeyEventArgs e)
        {
            ActualizarGrid(this.dgv_area_labs, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio where pk_id_area_lab like '" + txt_busc_are_lab.Text + "%'; ");
        }

        private void btn_act_data_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_area_labs, "select pk_id_area_lab as ID_Area, descripcion_ar_lab as Descripcion, pk_id_lab as ID_Laboratorio from area_laboratorio;");
        }


    }
}
