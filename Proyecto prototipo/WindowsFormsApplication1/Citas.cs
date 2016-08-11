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
    public partial class Citas : Form
    {
        String Codigo;
        Boolean Editar;
        public Citas()
        {
            InitializeComponent();
        }

        private void Lbl_fecha_cita_Click(object sender, EventArgs e)
        {

        }

        private void txt_fecha_cita_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpb_vista_cita_Enter(object sender, EventArgs e)
        {

        }

        private void Lbl_hora_cit_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCajasTexto()
        {
            cbo_hora1_cit.Text = "";
            // txt_membresia.Text = "";
            cbo_id_clt_cit.Text = "";
            cbo_id_lab_cit.Text = "";
        }

        private void btn_guardar_cita_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (cbo_hora1_cit.Text == "" || cbo_id_clt_cit.Text == "" || cbo_id_lab_cit.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        string selectedItem = cbo_id_clt_cit.SelectedValue.ToString();
                        string selectedItem1 = cbo_id_lab_cit.SelectedValue.ToString();
                        string theDate = dtp_fec_cit.Value.ToString("yyyy-MM-dd");
                        DateTime fecha = Convert.ToDateTime(theDate).Date;
                        String query3 = "SELECT COUNT(pk_id_cita) from cita where fecha_cita ='" + theDate + "' and hora_cita = '" + cbo_hora1_cit.Text + "' and pk_id_lab = '" + selectedItem1+ "';";
                        int cuenta = Conexionmysql.EjecutarMySql2(query3);
                        if (cuenta == 0)
                        {
                            if (fecha >= DateTime.Now.Date)
                            {
                                String query2 = "UPDATE cita SET fecha_cita='" + theDate + "', hora_cita ='" + cbo_hora1_cit.Text + "', pk_id_lab = '" + selectedItem1 + "', pk_id_clt = '" + selectedItem + "' WHERE pk_id_cita ='" + Codigo + "';";
                                cl_gridysql.EjecutarMySql(query2);
                                Conexionmysql.Desconectar();
                                //6.limpiar cajas de texto
                                this.LimpiarCajasTexto();
                                cl_gridysql.ActualizarGridBusquedaIdCita(this.dgv_vista_cita, "select pk_id_cita as Identificador, fecha_cita as Fecha, hora_cita as Hora, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cita;");
                                Editar = false;
                            }
                            else
                            {
                                MessageBox.Show("No se permite una fecha anterior", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fecha, Hora o laboratorio no disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        string selectedItem = cbo_id_clt_cit.SelectedValue.ToString();
                        string selectedItem1 = cbo_id_lab_cit.SelectedValue.ToString();
                        string theDate = dtp_fec_cit.Value.ToString("yyyy-MM-dd");
                        DateTime fecha = Convert.ToDateTime(theDate).Date;
                        String query3 = "SELECT COUNT(pk_id_cita) from cita where fecha_cita ='" + theDate + "' and hora_cita = '" + cbo_hora1_cit.Text + "' and pk_id_lab = '" + selectedItem1 + "';";
                        int cuenta = Conexionmysql.EjecutarMySql2(query3);
                        if (cuenta == 0)
                        {
                            if (fecha >= DateTime.Now.Date)
                            {
                                String Query = "INSERT INTO cita (fecha_cita,hora_cita,pk_id_lab,pk_id_clt) VALUES ('" + theDate + "','" + cbo_hora1_cit.Text + "','" + Convert.ToDouble(selectedItem1) + "', '" + Convert.ToDouble(selectedItem) + "');";
                                cl_gridysql.EjecutarMySql(Query);
                                cl_gridysql.ActualizarGridBusquedaIdCita(this.dgv_vista_cita, "select pk_id_cita as Identificador, fecha_cita as Fecha, hora_cita as Hora, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cita;");
                                this.LimpiarCajasTexto();
                                Conexionmysql.Desconectar();
                            }
                            else
                            {
                                MessageBox.Show("No se permite una fecha anterior", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Fecha, Hora o laboratorio no disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                   }
                }
            //}
           /* catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        public void llenarCboCitaIdCliente()
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
            cbo_id_clt_cit.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_clt_cit.ValueMember = ("pk_id_clt");
            //se indica el valor a desplegar en el combobox
            cbo_id_clt_cit.DisplayMember = ("nombre_clt");
        }

        public void llenarCboCitaIdLaboratorio()
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
            cbo_id_lab_cit.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_lab_cit.ValueMember = ("pk_id_lab");
            //se indica el valor a desplegar en el combobox
            cbo_id_lab_cit.DisplayMember = ("nombre_lab");
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaIdCita(this.dgv_vista_cita, "select pk_id_cita as Identificador, fecha_cita as Fecha, hora_cita as Hora, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cita;");
            llenarCboCitaIdCliente();
            llenarCboCitaIdLaboratorio();
        }

        private void btn_actlz_cita_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                Codigo = this.dgv_vista_cita.CurrentRow.Cells[0].Value.ToString();
                dtp_fec_cit.Text = this.dgv_vista_cita.CurrentRow.Cells[1].Value.ToString();
                cbo_id_lab_cit.Text = this.dgv_vista_cita.CurrentRow.Cells[3].Value.ToString();
                cbo_id_clt_cit.Text = this.dgv_vista_cita.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_elim_cita_Click(object sender, EventArgs e)
        {
            try
            {
                Codigo = this.dgv_vista_cita.CurrentRow.Cells[0].Value.ToString();
                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro

                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();

                    //2. armar la query
                    String Query = "delete from cita where pk_id_cita = '" + Codigo + "';";

                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);

                    //4.Actualizar grid..
                    cl_gridysql.ActualizarGridBusquedaIdCita(this.dgv_vista_cita, "select pk_id_cita as Identificador, fecha_cita as Fecha, hora_cita as Hora, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cita;");


                    //5.desconectar en base de datos
                    Conexionmysql.Desconectar();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_rnv_cita_Click(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaIdCita(this.dgv_vista_cita, "select pk_id_cita as Identificador, fecha_cita as Fecha, hora_cita as Hora, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cita;");
        }

        private void btn_busc_cita_Click(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaIdCita(this.dgv_vista_cita, "select pk_id_cita as Identificador, fecha_cita as Fecha, hora_cita as Hora, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cita where pk_id_cita like '" + txt_busc_cit.Text + "%'; ");
            LimpiarCajasTexto();
        }

        private void Txt_busquedacita_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaIdCita(this.dgv_vista_cita, "select pk_id_cita as Identificador, fecha_cita as Fecha, hora_cita as Hora, pk_id_lab as Laboratorio, pk_id_clt as Cliente from cita where pk_id_cita like '" + txt_busc_cit.Text + "%'; ");
        }
    }
}
