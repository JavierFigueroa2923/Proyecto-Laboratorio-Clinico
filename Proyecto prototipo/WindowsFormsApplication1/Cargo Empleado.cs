﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Cargo_Empleado : Form
    {
        public Cargo_Empleado()
        {
            InitializeComponent();
        }

        string codigo = "";
        Boolean Editar;

        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void cbo_titl_emp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pl_lab_cargo_emp_Click(object sender, EventArgs e)
        {

        }

        private void Cargo_Empleado_Load(object sender, EventArgs e)
        {
            InhabilitarText();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
            grid_cargos();
            llenarCboIdLab();
            llenarCboIdEmp();
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


        public void llenarCboIdLab()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            //String Query = "select DISTINCT cargo_empleado.pk_id_cargo_emp, cargo_empleado.nombre_cargo_emp, empleado.nombre_emp from cargo_empleado, empleado WHERE cargo_empleado.pk_id_emp = empleado.pk_id_emp";
            String Query = "select DISTINCT pk_id_lab, nombre_lab from laboratorio";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "laboratorio");
            cbo_id_lab.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_lab.ValueMember = ("pk_id_lab");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_lab, nombre_lab";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_lab"] = dr["pk_id_lab"].ToString() + " " + dr["nombre_lab"].ToString();
            }
            cbo_id_lab.DataSource = dt;


            cbo_id_lab.DisplayMember = "nombre_lab";
        }
        public void llenarCboIdEmp()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            //String Query = "select DISTINCT cargo_empleado.pk_id_cargo_emp, cargo_empleado.nombre_cargo_emp, empleado.nombre_emp from cargo_empleado, empleado WHERE cargo_empleado.pk_id_emp = empleado.pk_id_emp";
            String Query = "select DISTINCT pk_id_emp, nombre_emp from empleado";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "empleado");
            cbo_id_emp.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_emp.ValueMember = ("pk_id_emp");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_emp, nombre_emp";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_emp"] = dr["pk_id_emp"].ToString() + " " + dr["nombre_emp"].ToString();
            }
            cbo_id_emp.DataSource = dt;


            cbo_id_emp.DisplayMember = "nombre_emp";
        }
        private void grid_cargos()
        {
            string query = String.Format("SELECT pk_id_cargo_emp as identificador, nombre_cargo_emp as nombre, descripcion_cargo_emp as Descripcion, fecha_contratacion as contratacion, pk_id_emp as empleado, pk_id_lab as laboratorio FROM {0}", "cargo_empleado");
            Conexionmysql.ObtenerConexion();
            MySqlCommand command = new MySqlCommand(query, Conexionmysql.ObtenerConexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); 
            adapter.Fill(data);
            dgv_cargo_emp.DataSource = data;
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_cargo_emp_Click(object sender, EventArgs e)
        {
            if (txt_nombre_cargo_emp.Text == "" || txt_descp_cargo_emp.Text == "" || dtp_fec_contr_carg_emp.Text == "" )
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    string theDate = dtp_fec_contr_carg_emp.Value.ToString("yyyy-MM-dd");
                    String Query = "update cargo_empleado set nombre_cargo_emp = '" + txt_nombre_cargo_emp.Text + "', descripcion_cargo_emp = '" + txt_descp_cargo_emp.Text + "', fecha_contratacion = '" + theDate+ "', pk_id_emp = " + cbo_id_emp.SelectedValue + ", pk_id_lab = " + cbo_id_lab.SelectedValue + " where pk_id_cargo_emp = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'cargo_empleado'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    grid_cargos();
                    Conexionmysql.Desconectar();
                    Editar = false;
                    limpiar();
                }
                else
                {

                    try
                    {
                        string theDate = dtp_fec_contr_carg_emp.Value.ToString("yyyy-MM-dd");
                        String Query = "insert into cargo_empleado(nombre_cargo_emp, descripcion_cargo_emp, fecha_contratacion,pk_id_emp,pk_id_lab)values('" + txt_nombre_cargo_emp.Text + "','" + txt_descp_cargo_emp.Text + "','" + theDate + "'," + cbo_id_emp.SelectedValue + "," + cbo_id_lab.SelectedValue + ");";
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, Conexionmysql.ObtenerConexion());
                        MySqlDataReader MyReader2;
                        Conexionmysql.ObtenerConexion();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Registro ingresado exitosamente");
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Ingresar','" + Usuario + "','" + obtenerIP() + "', 'cargo_empleado'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        grid_cargos();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            InhabilitarText();
        }

        private void btn_actlz_cargo_emp_Click(object sender, EventArgs e)
        {
            HabilitarText();
            btn_cancl.Enabled = true;
            Editar = true;
            codigo = this.dgv_cargo_emp.CurrentRow.Cells[0].Value.ToString();
            txt_nombre_cargo_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[1].Value.ToString();
            txt_descp_cargo_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[2].Value.ToString();
            dtp_fec_contr_carg_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[3].Value.ToString();
            //string theDate = dgv_cargo_emp.CurrentRow.Cells[3].Value.ToString("yyyy-MM-dd");
            cbo_id_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[4].Value.ToString();
            cbo_id_lab.Text = this.dgv_cargo_emp.CurrentRow.Cells[5].Value.ToString();
            
        }
        private void limpiar() {
            txt_nombre_cargo_emp.Text = "";
            txt_descp_cargo_emp.Text = "";
            dtp_fec_contr_carg_emp.Text = "";
            cbo_id_emp.Text = "";
            cbo_id_lab.Text = "";
        }

        public void InhabilitarText()
        {
            txt_nombre_cargo_emp.Enabled = false;
            txt_descp_cargo_emp.Enabled = false;
            dtp_fec_contr_carg_emp.Enabled = false;
            cbo_id_emp.Enabled = false;
            cbo_id_lab.Enabled = false;
        }

        public void HabilitarText()
        {
            txt_nombre_cargo_emp.Enabled = true;
            txt_descp_cargo_emp.Enabled = true;
            dtp_fec_contr_carg_emp.Enabled = true;
            cbo_id_emp.Enabled = true;
            cbo_id_lab.Enabled = true;
        }

        private void btn_elim_cargo_emp_Click(object sender, EventArgs e)
        {
            codigo = this.dgv_cargo_emp.CurrentRow.Cells[0].Value.ToString();
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
                    String Query = "delete from cargo_empleado where pk_id_cargo_emp = " + NumVal + ";";
                    //ejecutar query
                    cl_gridysql.EjecutarMySql(Query);
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Eliminar','" + Usuario + "','" + obtenerIP() + "', 'cargo_empleado'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    grid_cargos();
                    limpiar();
                    //desconectamos de la base de datos
                    Conexionmysql.Desconectar();
                }
                else
                {
                    //no pasa nada
                    return;
                }
            }
        }

        private void btn_busc_cargo_emp_Click(object sender, EventArgs e)
        {
            if (txt_busc_cargo_emp.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridMuestra(this.dgv_cargo_emp, "SELECT pk_id_cargo_emp as identificador, nombre_cargo_emp as nombre, descripcion_cargo_emp as Descripcion, fecha_contratacion as contratacion, pk_id_emp as empleado, pk_id_lab as laboratorio from cargo_empleado where pk_id_cargo_emp like '" + txt_busc_cargo_emp.Text + "%';");
            }
        }

        private void btn_rnv_cargo_emp_Click(object sender, EventArgs e)
        {
            grid_cargos();
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarText();
            btn_cancl.Enabled = true;
        }

        private void btn_cancl_pcnt_Click(object sender, EventArgs e)
        {
            Editar = false;
            limpiar();
            InhabilitarText();
            btn_cancl.Enabled = false;
        }

        private void txt_busc_cargo_emp_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridMuestra(this.dgv_cargo_emp, "SELECT pk_id_cargo_emp as identificador, nombre_cargo_emp as nombre, descripcion_cargo_emp as Descripcion, fecha_contratacion as contratacion, pk_id_emp as empleado, pk_id_lab as laboratorio from cargo_empleado where pk_id_cargo_emp like '" + txt_busc_cargo_emp.Text + "%';");
        }
    }
}
