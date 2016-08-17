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
//using iTextSharp.text.pdf;
//using iTextSharp.text;
using System.IO;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Cotizacion : Form
    {
        Boolean Editar;
        String Codigo;
        public Cotizacion()
        {
            InitializeComponent();
        }

        BDconexion ManipularDato = new BDconexion();
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

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

        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            Conexionmysql.ObtenerConexion();
            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();
            //Creamos un nuevo adaptador de datos
            MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "Cotizacion");
            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "Cotizacion";
            Conexionmysql.Desconectar();
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

        public void llenarCboIdCliente()
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
            cbo_id_clnt.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_clnt.ValueMember = ("pk_id_clt");
            //se indica el valor a desplegar en el combobox
            cbo_id_clnt.DisplayMember = ("nombre_clt");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl_cotz.Enabled = false;
            btn_acept_cotz.Enabled = false;
            llenaridlab();
            llenarCboIdCliente();
            cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_vista_ctzn, "select pk_id_ctzn as Identificador, fecha_de_creacion_ctzn as Creacion, monto_total_ctzn as Monto, descuento_ctzn as Descuento, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cotizacion;");
        }

        public void LimpiarCajasTexto()
        {
            cbo_id_clnt.Text = "";
            cbo_id_lab.Text = "";
            dtp_fec_cotz.Text = "";
            txt_total.Text = "";
            txt_descuento.Text = "";
        }

        public void InhabilitarTexto()
        {
            cbo_id_clnt.Enabled = false;
            cbo_id_lab.Enabled = false;
            dtp_fec_cotz.Enabled = false;
            txt_total.Enabled = false;
            txt_descuento.Enabled = false;
        }

        public void HabilitarTexto()
        {
            cbo_id_clnt.Enabled = true;
            cbo_id_lab.Enabled = true;
            dtp_fec_cotz.Enabled = true;
            txt_total.Enabled = true;
            txt_descuento.Enabled = true;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_busc_cotz_Click(object sender, EventArgs e)

        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select pk_id_ctzn as Identificador, fecha_de_creacion_ctzn as Creacion, monto_total_ctzn as Monto, descuento_ctzn as Descuento, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cotizacion WHERE pk_id_clt like '%" + txt_busc_cotz.Text + "%';");
            //ManipularDato.Busqueda(Query);mp = C.pk_id_e
            GridViewActualizar(this.dgv_vista_ctzn, Query);
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_cotz_Click(object sender, EventArgs e)
        {
            try
            {
                if (Editar)
                {
                    string selectedItem = cbo_id_clnt.SelectedValue.ToString();
                    string selectedItem1 = cbo_id_lab.SelectedValue.ToString();
                    string theDate = dtp_fec_cotz.Value.ToString("yyyy-MM-dd");
                    string consulta2 = "update proyecto_laboratorio.COTIZACION set fecha_de_creacion_ctzn='" + theDate + "',monto_total_ctzn='" + txt_total.Text + "' , descuento_cztn= '" + txt_descuento.Text + "','" + selectedItem1 + "','" + selectedItem + "');";
                    MySqlCommand man = new MySqlCommand(consulta2, Conexionmysql.ObtenerConexion());
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'cotizacion'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    MySqlDataReader re;
                    Conexionmysql.ObtenerConexion();
                    re = man.ExecuteReader();
                    MessageBox.Show("Los datos han sido actualizados exitosamente");
                    while (re.Read())
                    { }
                    Conexionmysql.Desconectar();
                    LimpiarCajasTexto();
                    cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_vista_ctzn, "select pk_id_ctzn as Identificador, fecha_de_creacion_ctzn as Creacion, monto_total_ctzn as Monto, descuento_ctzn as Descuento, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cotizacion;");
                    Editar = false;
                }
                else
                {
                    string selectedItem = cbo_id_clnt.SelectedValue.ToString();
                    string selectedItem1 = cbo_id_lab.SelectedValue.ToString();
                    string theDate = dtp_fec_cotz.Value.ToString("yyyy-MM-dd");
                    string consulta = "insert into COTIZACION (fecha_de_creacion_ctzn,monto_total_ctzn,descuento_ctzn,pk_id_lab,pk_id_clt)values('" + theDate + "','" + txt_total.Text + "','" + txt_descuento.Text + "','" + selectedItem1 + "','" + selectedItem + "');";
                    MySqlCommand man = new MySqlCommand(consulta, Conexionmysql.ObtenerConexion());
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Ingreso','" + Usuario + "','" + obtenerIP() + "', 'cotizacion'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);
                    MySqlDataReader re;
                    Conexionmysql.ObtenerConexion();
                    re = man.ExecuteReader();
                    MessageBox.Show("Los datos han sido insertados exitosamente");
                    while (re.Read())
                    { }
                    Conexionmysql.Desconectar();
                    cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_vista_ctzn, "select pk_id_ctzn as Identificador, fecha_de_creacion_ctzn as Creacion, monto_total_ctzn as Monto, descuento_ctzn as Descuento, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cotizacion;");
                    LimpiarCajasTexto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InhabilitarTexto();
        }

        private void btn_actlz_cotzClick(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl_cotz.Enabled = true;
            Editar = true;
            Codigo = this.dgv_vista_ctzn.CurrentRow.Cells[0].Value.ToString(); 
            dtp_fec_cotz.Text = this.dgv_vista_ctzn.CurrentRow.Cells[1].Value.ToString();
            txt_total.Text = this.dgv_vista_ctzn.CurrentRow.Cells[2].Value.ToString();
            txt_descuento.Text = this.dgv_vista_ctzn.CurrentRow.Cells[3].Value.ToString();
            cbo_id_lab.Text = this.dgv_vista_ctzn.CurrentRow.Cells[4].Value.ToString();
            cbo_id_clnt.Text = this.dgv_vista_ctzn.CurrentRow.Cells[5].Value.ToString();

        }

        private void btn_elim_cotz_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = cbo_id_clnt.SelectedValue.ToString();
                string selectedItem1 = cbo_id_lab.SelectedValue.ToString();
                Codigo = this.dgv_vista_ctzn.CurrentRow.Cells[0].Value.ToString();
                string consulta3 = "DELETE from COTIZACION where pk_id_ctzn ='" + Codigo + "';";
                MySqlCommand man = new MySqlCommand(consulta3, Conexionmysql.ObtenerConexion());
                String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Eliminar','" + Usuario + "','" + obtenerIP() + "', 'cotizacion'," + MiIdUsuario + ") ";
                cl_gridysql.EjecutarMySql(bitacora);
                MySqlDataReader re;
                Conexionmysql.ObtenerConexion();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido eliminados exitosamente");
                while (re.Read())
                { }
                Conexionmysql.Desconectar();
                cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_vista_ctzn, "select pk_id_ctzn as Identificador, fecha_de_creacion_ctzn as Creacion, monto_total_ctzn as Monto, descuento_ctzn as Descuento, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cotizacion;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void cbo_id_lab_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_id_clnt_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

       

        private void btn_nuevo_cotz_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl_cotz.Enabled = true;
        }

        private void btn_cancl_cotz_Click(object sender, EventArgs e)
        {
            LimpiarCajasTexto();
            InhabilitarTexto();
            btn_cancl_cotz.Enabled = false;
        }

        private void btn_acept_cotz_Click(object sender, EventArgs e)
        {

        }

        private void btn_imp_cotz_Click(object sender, EventArgs e)
        {
               /* try
                {
                    SaveFileDialog guardar = new SaveFileDialog();
                    guardar.InitialDirectory = @"‪C:\Users\Otto\Desktop";



                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        String ruta = guardar.FileName;

                        Document nuevo_documento = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                        PdfWriter nombre_doc = PdfWriter.GetInstance(nuevo_documento, new FileStream(ruta + ".pdf", FileMode.Create));
                        nuevo_documento.Open();

                        // ---------------------- logo -------------------
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\ottog\Documents\GitHub\Proyecto-Laboratorio-Clinico\Proyecto prototipo\WindowsFormsApplication1\Resources\Clinica.png");


                        logo.SetAbsolutePosition(30f, 600f);
                        logo.ScaleAbsoluteWidth(550);
                        logo.ScaleAbsoluteHeight(75);

                        nuevo_documento.Add(logo);

                        // ---------------Inicio Encabezado------------------
                        Paragraph encabezado = new Paragraph(new Phrase("\n\n\n\n\nClinica de Laboratorios", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                        //encabezado.IndentationLeft = 250; // la hoja de de PDF tiene un ancho de 600              
                        encabezado.Alignment = Element.ALIGN_CENTER;
                        nuevo_documento.Add(encabezado);




                        //--------------------datos de la empresa----------------------------------------
                        Paragraph datos_Empresa = new Paragraph(new Phrase("\nCalz. Aguilar Batres 8-28, zona 11 - teléfonos:2471-2628 -- 2472-1302 Guatemala, C.A.", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                        datos_Empresa.IndentationLeft = 30;
                        nuevo_documento.Add(datos_Empresa);


                        //------------------------------separacion---------------------------
                        Paragraph linea = new Paragraph(new Phrase("____________________________________________________", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                        //encabezado.IndentationLeft = 250; // la hoja de de PDF tiene un ancho de 600              
                        linea.Alignment = Element.ALIGN_CENTER;
                        nuevo_documento.Add(linea);



                        // ------------------------datos iniciales------------
                        String fecha = txt_fechaentrega.Text;
                        String cliente = txt_ncliente.Text + " " + txt_pcliente.Text;
                        String descripcion = txt_descrip.Text;
                        String marca = txt_marca.Text;
                        String empleado = txt_nempleado.Text + " " + txt_aempleado.Text;
                        String servicio = txt_servicio.Text;
                        String costo = txt_costo.Text;
                        String estado = txt_estado.Text;

                        Paragraph datos_personales = new Paragraph(new Phrase("\n\nDATOS DE LA PROFORMA: \nFECHA DE ENTREGA: " + fecha + "\nNO DE PETICIÓN: " + codigo_id + "\nMARCA: " + marca + "\nEMPLEADO: " + empleado + "\nCLIENTE: " + cliente + "\nDIRECCIÓN: " + descripcion + "\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 11f, iTextSharp.text.Font.ITALIC, iTextSharp.text.BaseColor.BLACK)));
                        datos_personales.IndentationLeft = 30;
                        nuevo_documento.Add(datos_personales);


                        //-------------------------------tabla costos---------------------
                        PdfPTable tabla_costo = new PdfPTable(2);
                        tabla_costo.TotalWidth = 200;

                        tabla_costo.AddCell("Tipo de Servicio");
                        tabla_costo.AddCell("Costo del servicio");
                        tabla_costo.AddCell(servicio);
                        tabla_costo.AddCell(costo);
                        tabla_costo.AddCell("Total");
                        tabla_costo.AddCell(costo);

                        nuevo_documento.Add(tabla_costo);
                        //---------------------------------------------------------------------------
                        //-------------------------tabla---------------------------------------------
                        //PdfPTable tabla = new PdfPTable(2);
                        //tabla.TotalWidth = 1000;

                        //tabla.AddCell("\n                   Costo del vehículo");
                        //tabla.AddCell("\n                             Q. " + txt_costo_vehiculo.Text);

                        //tabla.AddCell("\n                   Embarque y grua");
                        //tabla.AddCell("\n                             Q. " + txt_embarque.Text);

                        //tabla.AddCell("\n                   Impuesto");
                        //tabla.AddCell("\n                             Q. " + txt_impuestos.Text);

                        //tabla.AddCell("\n                   Reparación Aproximada");
                        //tabla.AddCell("\n                             Q. " + txt_reparacion.Text);

                        //tabla.AddCell("\n                  TOTAL");
                        //tabla.AddCell("\n                             Q. " + txt_precio_final.Text);


                        //-----------------------Cerrar coneccion a documento-------------------
                        nuevo_documento.Close();

                        // ------------------Cierre de documento----------------------------

                        MessageBox.Show("Archivo Guardado");
                        System.Diagnostics.Process.Start(ruta + ".pdf");
                    }

                }
                catch
                {
                    MessageBox.Show("error en los datos");
                }
            }*/



            //------------------------------------------------------------obtener datos de la base de datos-----------------------------


            //DataTable dt = new DataTable();
            //String sQuery = "SELECT pk_idsala FROM sala WHERE nomsala= '"+ txt_sala.Text + "'";
            //MySqlCommand comando = new MySqlCommand(sQuery, conect.rutaconectada());
            //MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            //adaptador.Fill(dt);
            //DataRow fila = dt.Rows[0];
            //string sid = Convert.ToString(fila[0]);
            //MessageBox.Show(sid);
        }

        private void txt_busc_cotz_KeyUp(object sender, KeyEventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select pk_id_ctzn as Identificador, fecha_de_creacion_ctzn as Creacion, monto_total_ctzn as Monto, descuento_ctzn as Descuento, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cotizacion WHERE pk_id_clt like '%" + txt_busc_cotz.Text + "%';");
            //ManipularDato.Busqueda(Query);mp = C.pk_id_e
            GridViewActualizar(this.dgv_vista_ctzn, Query);
            Conexionmysql.Desconectar();
        }
    }
}



