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
    public partial class Membresia : Form
    {
        Validaciones validar = new Validaciones();
        BDconexion manipular = new BDconexion();
        String Codigo;
        Boolean Editar;

        public Membresia()
        {
            InitializeComponent();
        }
        public void LimpiarCajasTexto()
        {
            txt_busc_mem.Text = "";
            cbo_id_clt_mem.Text = "";
           // txt_membresia.Text = "";
            txt_beneficio_mem.Text = "";
            dtp_fec_crea_mem.Text = "";
            dtp_fec_expir_mem.Text = "";
    
        }

        public void InhabilitarTexto()
        {
            cbo_id_clt_mem.Enabled = false;
            txt_beneficio_mem.Enabled = false;
            dtp_fec_crea_mem.Enabled = false;
            dtp_fec_expir_mem.Enabled = false;
        }

        public void HabilitarTexto()
        {
            cbo_id_clt_mem.Enabled = true;
            txt_beneficio_mem.Enabled = true;
            dtp_fec_crea_mem.Enabled = true;
            dtp_fec_expir_mem.Enabled = true;
        }

        private void txt_fecha_expir_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
            ActualizarGrid(this.dgv_busc_membresia, "SELECT pk_id_mem as Identificador, beneficios as Beneficios, fecha_expendicion_mem as Fecha_Creacion, fecha_expiracion_mem as Fecha_Expiracion, pk_id_clt as ID_Cliente FROM membresia");
            llenarCboClienteMembresia();
        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "membresia");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "membresia";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }
        private void txt_membresia_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_id_clt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void btn_guardar_membresia_Click(object sender, EventArgs e)
        {
            try {
                if (txt_beneficio_mem.Text == "" || cbo_id_clt_mem.Text == "" || dtp_fec_crea_mem.Text == "" || dtp_fec_expir_mem.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        string selectedItem = cbo_id_clt_mem.SelectedValue.ToString();
                        string theDate = dtp_fec_crea_mem.Value.ToString("yyyy-MM-dd");
                        string theDate2 = dtp_fec_expir_mem.Value.ToString("yyyy-MM-dd");
                        String query2 = "UPDATE membresia SET beneficios='" + txt_beneficio_mem.Text + "', fecha_expendicion_mem='" + theDate + "', fecha_expiracion_mem = '" + theDate2 + "', pk_id_clt = '" + selectedItem + "' WHERE pk_id_mem ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_busc_membresia, "SELECT pk_id_mem as Identificador, beneficios as Beneficios, fecha_expendicion_mem as Fecha_Creacion, fecha_expiracion_mem as Fecha_Expiracion, pk_id_clt as ID_Cliente FROM membresia");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        string selectedItem = cbo_id_clt_mem.SelectedValue.ToString();
                        string theDate = dtp_fec_crea_mem.Value.ToString("yyyy-MM-dd");
                        string theDate2 = dtp_fec_expir_mem.Value.ToString("yyyy-MM-dd");
                        String Query = "INSERT INTO membresia (beneficios,fecha_expendicion_mem,fecha_expiracion_mem,pk_id_clt) VALUES ('" + txt_beneficio_mem.Text + "','" + theDate + "','" + theDate2 + "', '" + Convert.ToDouble(selectedItem) + "') ";
                        cl_gridysql.EjecutarMySql(Query);
                        ActualizarGrid(this.dgv_busc_membresia, "SELECT pk_id_mem as Identificador, beneficios as Beneficios, fecha_expendicion_mem as Fecha_Creacion, fecha_expiracion_mem as Fecha_Expiracion, pk_id_clt as ID_Cliente FROM membresia");
                        this.LimpiarCajasTexto();
                        Conexionmysql.Desconectar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InhabilitarTexto();
        }

        private void btn_elim_membresia_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dgv_busc_membresia.CurrentRow.Cells[0].Value.ToString();
                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro

                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();

                    //2. armar la query
                    String Query = "delete from membresia where pk_id_mem = '" + Codigo + "';";

                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);

                    //4.Actualizar grid..
                    ActualizarGrid(this.dgv_busc_membresia, "SELECT pk_id_mem as Identificador, beneficios as Beneficios, fecha_expendicion_mem as Fecha_Creacion, fecha_expiracion_mem as Fecha_Expiracion, pk_id_clt as ID_Cliente FROM membresia");


                    //5.desconectar en base de datos
                    Conexionmysql.Desconectar();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_actlz_membresia_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            try {
                Editar = true;
                Codigo = this.dgv_busc_membresia.CurrentRow.Cells[0].Value.ToString();
                txt_beneficio_mem.Text = this.dgv_busc_membresia.CurrentRow.Cells[1].Value.ToString();
                dtp_fec_crea_mem.Enabled = false;
                dtp_fec_expir_mem.Enabled = true;
                dtp_fec_crea_mem.Text = this.dgv_busc_membresia.CurrentRow.Cells[2].Value.ToString();
                dtp_fec_expir_mem.Text = this.dgv_busc_membresia.CurrentRow.Cells[3].Value.ToString();
                cbo_id_clt_mem.Text = this.dgv_busc_membresia.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_buscar_clt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_busc_memb_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select SELECT pk_id_mem as Identificador, beneficios as Beneficios, fecha_expendicion_mem as Fecha_Creacion, fecha_expiracion_mem as Fecha_Expiracion, pk_id_clt as ID_Cliente from membresia where pk_id_clt = '" + Convert.ToDouble(txt_busc_mem.Text) + "%'; ");
            //ManipularDato.Busqueda(Query);
            ActualizarGrid(this.dgv_busc_membresia, Query);
            Conexionmysql.Desconectar();
        }

        private void btn_act_datos_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_busc_membresia, "SELECT pk_id_mem as Identificador, beneficios as Beneficios, fecha_expendicion_mem as Fecha_Creacion, fecha_expiracion_mem as Fecha_Expiracion, pk_id_clt as ID_Cliente FROM membresia");
        }

        private void txt_id_clt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpb_ingreso_datos_Enter(object sender, EventArgs e)
        {

        }

        private void cbo_id_clt_mem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenarCboClienteMembresia()
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
            cbo_id_clt_mem.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_clt_mem.ValueMember = ("pk_id_clt");
            //se indica el valor a desplegar en el combobox
            cbo_id_clt_mem.DisplayMember = ("nombre_clt");
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;

        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            Editar = false;
            LimpiarCajasTexto();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }

        private void txt_busc_mem_KeyUp(object sender, KeyEventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("SELECT pk_id_mem as Identificador, beneficios as Beneficios, fecha_expendicion_mem as Fecha_Creacion, fecha_expiracion_mem as Fecha_Expiracion, pk_id_clt as ID_Cliente from membresia where pk_id_clt like '" + txt_busc_mem.Text + "%'; ");
            //ManipularDato.Busqueda(Query);
            ActualizarGrid(this.dgv_busc_membresia, Query);
            Conexionmysql.Desconectar();
        }
    }
}
