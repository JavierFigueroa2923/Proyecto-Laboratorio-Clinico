using MySql.Data.MySqlClient;
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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        Boolean Editar;
        Validaciones validar = new Validaciones();
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }
        public void LimpiarCajasTexto()
        {
            cbo_id_cliente.Text = "";
            txt_cantidad.Text = "";
            cbo_id_examen.Text = "";
            cbo_id_fp.Text = "";
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
            cbo_id_cliente.Enabled = false;
            txt_cantidad.Enabled = false;
            cbo_id_examen.Enabled = false;
            cbo_id_fp.Enabled = false;
        }

        public void HabilitarTexto()
        {
            cbo_id_cliente.Enabled = true;
            txt_cantidad.Enabled = true;
            cbo_id_examen.Enabled = true;
            cbo_id_fp.Enabled = true;
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            dtp_factura.Enabled = true;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            dtp_factura.Enabled = false;
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
            llenarCboIdCliente();
            llenarCboIdFPago();
            llenarCboIdTExamen();
        }

        public void llenarCboIdCliente()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select DISTINCT pk_id_clt, nombre_clt, apellido_clt, nit from Cliente";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cliente");
            cbo_id_cliente.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_cliente.ValueMember = ("pk_id_clt");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_clt, nombre_clt";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_clt"] = dr["pk_id_clt"].ToString() + " " + dr["nombre_clt"].ToString() + " " + dr["apellido_clt"].ToString() + " " + dr["nit"].ToString();
               
            }
            cbo_id_cliente.DataSource = dt;


            cbo_id_cliente.DisplayMember = "nombre_clt";
        }

        public void llenarCboIdFPago()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select DISTINCT pk_id_fm_pg, nombre_fm_pago from forma_de_pago";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "forma_de_pago");
            cbo_id_fp.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_fp.ValueMember = ("pk_id_fm_pg");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_fm_pago, nombre_fm_pago";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_fm_pago"] = dr["pk_id_fm_pg"].ToString() + " " + dr["nombre_fm_pago"].ToString();
            }
            cbo_id_fp.DataSource = dt;


            cbo_id_fp.DisplayMember = "nombre_fm_pago";
        }
        public void llenarCboIdTExamen()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select DISTINCT pk_id_tp_exm, nombre_tp_exm, precio_tp_exm from tipo_examen";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "tipo_examen");
            cbo_id_examen.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_examen.ValueMember = ("pk_id_tp_exm");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_clt, nombre_clt";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_tp_exm"] = dr["pk_id_tp_exm"].ToString() + " " + dr["nombre_tp_exm"].ToString() + " " + dr["precio_tp_exm"].ToString();

            }
            cbo_id_examen.DataSource = dt;


            cbo_id_examen.DisplayMember = "nombre_tp_exm";
        }
        
        private void txt_id_clt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_id_clt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void cbo_id_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbo_id_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            string idc = cbo_id_cliente.SelectedValue.ToString();

        }

        private void gpb_vista_fct_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgv_vista_fct.Rows[0].Cells[0].Value == null )
                {
                    dgv_vista_fct.Rows.Add(1);
                    dgv_vista_fct.Rows[0].Cells[0].Value = txt_cantidad.Text;
                    MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");

                    MySqlCommand cmd = dbConn.CreateCommand();
                    cmd.CommandText = "SELECT pk_id_tp_exm, nombre_tp_exm, precio_tp_exm FROM tipo_examen WHERE pk_id_tp_exm = "+ cbo_id_examen.SelectedValue +"";

                    try
                    {
                        dbConn.Open();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro" + erro);
                        this.Close();
                    }

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int tipo_examen = reader.GetInt32(0);

                    }
                    //MessageBox.Show("asdf "+reader.GetInt32(0), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string nombre_examen = reader.GetString(1);
                    int precio = reader.GetInt32(2);
                    
                    dgv_vista_fct.Rows[0].Cells[1].Value = nombre_examen;
                    dgv_vista_fct.Rows[0].Cells[2].Value = precio;

                    dgv_vista_fct.Rows[1].Cells[1].Value = "Total:";
                    int cant = Int32.Parse(txt_cantidad.Text);
                    int total = cant * precio;
                    dgv_vista_fct.Rows[1].Cells[2].Value = total;
                    dgv_vista_fct.Rows[0].Cells[3].Value = cbo_id_examen.SelectedValue;
                    dbConn.Close();
                }
                else
                if (dgv_vista_fct.Rows[1].Cells[0].Value == null)
                {
                    dgv_vista_fct.Rows.Add(1);
                    dgv_vista_fct.Rows[1].Cells[0].Value = txt_cantidad.Text;
                    MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");

                    MySqlCommand cmd = dbConn.CreateCommand();
                    cmd.CommandText = "SELECT tipo_examen.pk_id_tp_exm, tipo_examen.nombre_tp_exm, tipo_examen.precio_tp_exm FROM tipo_examen WHERE tipo_examen.pk_id_tp_exm = " + cbo_id_examen.SelectedValue + "";

                    try
                    {
                        dbConn.Open();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro" + erro);
                        this.Close();
                    }

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int tipo_examen = reader.GetInt32(0);

                    }
                    //MessageBox.Show("asdf "+reader.GetInt32(0), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string nombre_examen = reader.GetString(1);
                    string precio = reader.GetString(2);
                    dgv_vista_fct.Rows[1].Cells[1].Value = nombre_examen;
                    dgv_vista_fct.Rows[1].Cells[2].Value = precio;

                    dgv_vista_fct.Rows[2].Cells[1].Value = "Total:";
                    int cant1 = Convert.ToInt32(dgv_vista_fct[0, 0].Value);
                    int cant2 = Convert.ToInt32(txt_cantidad.Text);
                    int precio1 = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[2].Value);
                    int precio2 = reader.GetInt32(2);
                    int sub1 = cant1 * precio1;
                    int sub2 = cant2 * precio2;
                    int total = sub1 + sub2;

                    dgv_vista_fct.Rows[2].Cells[2].Value = total;
                    dgv_vista_fct.Rows[1].Cells[3].Value = cbo_id_examen.SelectedValue;
                    dbConn.Close();
                }
                else
                if (dgv_vista_fct.Rows[2].Cells[0].Value == null)
                {
                    dgv_vista_fct.Rows.Add(1);
                    dgv_vista_fct.Rows[2].Cells[0].Value = txt_cantidad.Text;
                    MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");

                    MySqlCommand cmd = dbConn.CreateCommand();
                    cmd.CommandText = "SELECT tipo_examen.pk_id_tp_exm, tipo_examen.nombre_tp_exm, tipo_examen.precio_tp_exm FROM tipo_examen WHERE tipo_examen.pk_id_tp_exm = " + cbo_id_examen.SelectedValue + "";

                    try
                    {
                        dbConn.Open();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro" + erro);
                        this.Close();
                    }

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int tipo_examen = reader.GetInt32(0);

                    }
                    //MessageBox.Show("asdf "+reader.GetInt32(0), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string nombre_examen = reader.GetString(1);
                    string precio = reader.GetString(2);
                    dgv_vista_fct.Rows[2].Cells[1].Value = nombre_examen;
                    dgv_vista_fct.Rows[2].Cells[2].Value = precio;

                    dgv_vista_fct.Rows[3].Cells[1].Value = "Total:";
                    int cant1 = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[0].Value);
                    int cant2 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[0].Value);
                    int cant3 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[0].Value);
                    int precio1 = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[2].Value);
                    int precio2 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[2].Value);
                    int precio3 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[2].Value);
                    int sub1 = cant1 * precio1;
                    int sub2 = cant2 * precio2;
                    int sub3 = cant3 * precio3;
                    int total = sub1 + sub2 + sub3;

                    dgv_vista_fct.Rows[3].Cells[2].Value = total;
                    dgv_vista_fct.Rows[2].Cells[3].Value = cbo_id_examen.SelectedValue;
                    dbConn.Close();
                }
                else
                    if (dgv_vista_fct.Rows[3].Cells[0].Value == null)
                    {
                        dgv_vista_fct.Rows.Add(1);
                        dgv_vista_fct.Rows[3].Cells[0].Value = txt_cantidad.Text;
                        MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");

                        MySqlCommand cmd = dbConn.CreateCommand();
                        cmd.CommandText = "SELECT tipo_examen.pk_id_tp_exm, tipo_examen.nombre_tp_exm, tipo_examen.precio_tp_exm FROM tipo_examen WHERE tipo_examen.pk_id_tp_exm = " + cbo_id_examen.SelectedValue + "";

                        try
                        {
                            dbConn.Open();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro" + erro);
                            this.Close();
                        }

                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            int tipo_examen = reader.GetInt32(0);

                        }
                        //MessageBox.Show("asdf "+reader.GetInt32(0), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        string nombre_examen = reader.GetString(1);
                        string precio = reader.GetString(2);
                        dgv_vista_fct.Rows[3].Cells[1].Value = nombre_examen;
                        dgv_vista_fct.Rows[3].Cells[2].Value = precio;

                        dgv_vista_fct.Rows[4].Cells[1].Value = "Total:";
                        int cant1 = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[0].Value);
                        int cant2 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[0].Value);
                        int cant3 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[0].Value);
                        int cant4 = Convert.ToInt32(dgv_vista_fct.Rows[3].Cells[0].Value);
                        int precio1 = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[2].Value);
                        int precio2 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[2].Value);
                        int precio3 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[2].Value);
                        int precio4 = Convert.ToInt32(dgv_vista_fct.Rows[3].Cells[2].Value);
                        int sub1 = cant1 * precio1;
                        int sub2 = cant2 * precio2;
                        int sub3 = cant3 * precio3;
                        int sub4 = cant4 * precio4;
                        int total = sub1 + sub2 + sub3 + sub4;

                        dgv_vista_fct.Rows[4].Cells[2].Value = total;
                        dgv_vista_fct.Rows[3].Cells[3].Value = cbo_id_examen.SelectedValue;
                        dbConn.Close();
                    }
                    else
                        if (dgv_vista_fct.Rows[4].Cells[0].Value == null)
                        {
                            dgv_vista_fct.Rows.Add(1);
                            dgv_vista_fct.Rows[4].Cells[0].Value = txt_cantidad.Text;
                            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");

                            MySqlCommand cmd = dbConn.CreateCommand();
                            cmd.CommandText = "SELECT tipo_examen.pk_id_tp_exm, tipo_examen.nombre_tp_exm, tipo_examen.precio_tp_exm FROM tipo_examen WHERE tipo_examen.pk_id_tp_exm = " + cbo_id_examen.SelectedValue + "";

                            try
                            {
                                dbConn.Open();
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show("Erro" + erro);
                                this.Close();
                            }

                            MySqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                int tipo_examen = reader.GetInt32(0);

                            }
                            //MessageBox.Show("asdf "+reader.GetInt32(0), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            string nombre_examen = reader.GetString(1);
                            string precio = reader.GetString(2);
                            dgv_vista_fct.Rows[4].Cells[1].Value = nombre_examen;
                            dgv_vista_fct.Rows[4].Cells[2].Value = precio;

                            dgv_vista_fct.Rows[5].Cells[1].Value = "Total:";
                            int cant1 = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[0].Value);
                            int cant2 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[0].Value);
                            int cant3 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[0].Value);
                            int cant4 = Convert.ToInt32(dgv_vista_fct.Rows[3].Cells[0].Value);
                            int cant5 = Convert.ToInt32(dgv_vista_fct.Rows[4].Cells[0].Value);
                            int precio1 = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[2].Value);
                            int precio2 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[2].Value);
                            int precio3 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[2].Value);
                            int precio4 = Convert.ToInt32(dgv_vista_fct.Rows[3].Cells[2].Value);
                            int precio5 = Convert.ToInt32(dgv_vista_fct.Rows[4].Cells[2].Value);
                            int sub1 = cant1 * precio1;
                            int sub2 = cant2 * precio2;
                            int sub3 = cant3 * precio3;
                            int sub4 = cant4 * precio4;
                            int sub5 = cant5 * precio5;
                            int total = sub1 + sub2 + sub3 + sub4 + sub5;

                            dgv_vista_fct.Rows[5].Cells[2].Value = total;

                            dgv_vista_fct.Rows[4].Cells[3].Value = cbo_id_examen.SelectedValue;
                            dbConn.Close();
                        }
                
                
            }
        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_id_cliente.SelectedValue == "" || cbo_id_fp.SelectedValue == "" || dgv_vista_fct.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        /*Conexionmysql.ObtenerConexion();
                        String Query = "UPDATE empleado SET nombre_emp ='" + txt_nombre.Text + "' WHERE pk_id_emp ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(Query);
                        Conexionmysql.Desconectar();
                        MessageBox.Show("Operacion Realizada Exitosamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        //cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_empleads, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, usuario as Usuario, contrasenia as Password, fecha_nacimiento_emp as Fecha_nacimiento from empleado");
                        Editar = false;*/
                    }
                    else
                    {

                        int total = 0;
                        Conexionmysql.ObtenerConexion();
                        string theDate = dtp_factura.Value.ToString("yyyy-MM-dd");
                        String Query1 = "INSERT INTO factura (pk_id_fm_pg, fecha_generacion_fact, pk_id_clt, total_id_exm) VALUES (" + cbo_id_fp.SelectedValue + ",'" + theDate + "'," + cbo_id_cliente.SelectedValue + "," + total + ")";
                        cl_gridysql.EjecutarMySql(Query1);
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Insertar','" + Usuario + "','" + obtenerIP() + "', 'factura'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);

                            if (dgv_vista_fct.Rows[0].Cells[0].Value != null)
                            {
                                int cantidad = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[0].Value);
                                int id_examen = Convert.ToInt32(dgv_vista_fct.Rows[0].Cells[3].Value);
                                String Query2 = "INSERT INTO detalle_factura (cantidad_dtll_fact, pk_id_fact, pk_id_exm) VALUES (" + cantidad + ", (select MAX(pk_id_fact) FROM factura), " + id_examen + ")";
                                cl_gridysql.EjecutarMySql(Query2);
                                total = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[2].Value);
                                if (dgv_vista_fct.Rows[1].Cells[0].Value != null)
                                {
                                    int cantidad1 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[0].Value);
                                    int id_examen1 = Convert.ToInt32(dgv_vista_fct.Rows[1].Cells[3].Value);
                                    String Query3 = "INSERT INTO detalle_factura (cantidad_dtll_fact, pk_id_fact, pk_id_exm) VALUES (" + cantidad1 + ", (select MAX(pk_id_fact) FROM factura), " + id_examen1 + ")";
                                    cl_gridysql.EjecutarMySql(Query3);
                                    total = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[2].Value);
                                    if (dgv_vista_fct.Rows[2].Cells[0].Value != null)
                                    {
                                        int cantidad2 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[0].Value);
                                        int id_examen2 = Convert.ToInt32(dgv_vista_fct.Rows[2].Cells[3].Value);
                                        String Query4 = "INSERT INTO detalle_factura (cantidad_dtll_fact, pk_id_fact, pk_id_exm) VALUES (" + cantidad2 + ", (select MAX(pk_id_fact) FROM factura), " + id_examen2 + ")";
                                        cl_gridysql.EjecutarMySql(Query4);
                                        total = Convert.ToInt32(dgv_vista_fct.Rows[3].Cells[2].Value);
                                        if (dgv_vista_fct.Rows[3].Cells[0].Value != null)
                                        {
                                            int cantidad3 = Convert.ToInt32(dgv_vista_fct.Rows[3].Cells[0].Value);
                                            int id_examen3 = Convert.ToInt32(dgv_vista_fct.Rows[3].Cells[3].Value);
                                            String Query5 = "INSERT INTO detalle_factura (cantidad_dtll_fact, pk_id_fact, pk_id_exm) VALUES (" + cantidad3 + ", (select MAX(pk_id_fact) FROM factura), " + id_examen3 + ")";
                                            cl_gridysql.EjecutarMySql(Query5);
                                            total = Convert.ToInt32(dgv_vista_fct.Rows[4].Cells[2].Value);
                                            if (dgv_vista_fct.Rows[4].Cells[0].Value != null)
                                            {
                                                int cantidad4 = Convert.ToInt32(dgv_vista_fct.Rows[4].Cells[0].Value);
                                                int id_examen4 = Convert.ToInt32(dgv_vista_fct.Rows[4].Cells[3].Value);
                                                String Query6 = "INSERT INTO detalle_factura (cantidad_dtll_fact, pk_id_fact, pk_id_exm) VALUES (" + cantidad4 + ", (select MAX(pk_id_fact) FROM factura), " + id_examen4 + ")";
                                                cl_gridysql.EjecutarMySql(Query6);
                                                total = Convert.ToInt32(dgv_vista_fct.Rows[5].Cells[2].Value);
                                            }
                                        }
                                    }
                                }

                                
                            }


                            Conexionmysql.ObtenerConexion();
                            String Query10 = "select MAX(factura.pk_id_fact) FROM factura";
                            int id_facturamax = Conexionmysql.EjecutarMySql2(Query10);
                            //MessageBox.Show(" " + id_facturamax + " " + total, "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            Conexionmysql.ObtenerConexion();
                            String Query11 = "UPDATE factura set factura.total_id_exm = " + total + " where pk_id_fact = " + id_facturamax + "";
                            cl_gridysql.EjecutarMySql(Query11);
                            String bitacora2 = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'factura'," + MiIdUsuario + ") ";
                            cl_gridysql.EjecutarMySql(bitacora2);
                            
                            this.LimpiarCajasTexto();
                            Conexionmysql.Desconectar();
                            
                            //cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_empleads, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, usuario as Usuario, contrasenia as Password, fecha_nacimiento_emp as Fecha_nacimiento from empleado");
                            MessageBox.Show("Operacion Realizada Exitosamente", "La base de datos ha sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        

                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            InhabilitarTexto();
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            Editar = true;
            //Codigo = this.dgv_empleads.CurrentRow.Cells[0].Value.ToString();
            //cbo_id_lab.Text = this.dgv_empleads.CurrentRow.Cells[1].Value.ToString();
            //cbo_sexo_emp.Text = this.dgv_empleads.CurrentRow.Cells[2].Value.ToString();
            //txt_nombre.Text = this.dgv_empleads.CurrentRow.Cells[3].Value.ToString();
            //txt_apellido.Text = this.dgv_empleads.CurrentRow.Cells[4].Value.ToString();
            //txt_usuario.Text = this.dgv_empleads.CurrentRow.Cells[5].Value.ToString();
            //txt_contraseña.Text = this.dgv_empleads.CurrentRow.Cells[6].Value.ToString();
            //txt_contraseña2.Text = this.dgv_empleads.CurrentRow.Cells[6].Value.ToString();
            //dtp_fec_nac_emp.Text = this.dgv_empleads.CurrentRow.Cells[7].Value.ToString();
        }
    }
}
