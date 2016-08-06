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
    public partial class frm_act_cliente : Form
    {
        public frm_act_cliente()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();
        BDconexion manipular = new BDconexion();
        String Codigo;
        Boolean Editar;
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void frm_act_cliente_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCajasTexto()
        {

            txt_altura.Text = "";
            txt_apellido.Text = "";
            txt_busc_pcnt.Text = "";
            txt_direccion.Text = "";
            txt_dpi.Text = "";
            txt_email.Text = "";
            txt_fecha_nacimiento.Text = "";
            txt_nit.Text = "";
            txt_nombre.Text = "";
            txt_peso_pcnt.Text = "";
            txt_referido.Text = "";
            txt_telefono.Text = "";


        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            manipular.obtener_conexion();
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=proyecto_laboratorio; uid=root; pwd=;");
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, conectar);

            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "cliente");

            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "cliente";

            //nos desconectamos de la base de datos...
            manipular.Desconectar();



        }
        private void btn_guardar_pcnt_Click(object sender, EventArgs e)
        {
            if (txt_altura.Text == "" || txt_apellido.Text == "" || txt_busc_pcnt.Text == "" || txt_direccion.Text == "" || txt_email.Text == "" || txt_fecha_nacimiento.Text == "" ||
               txt_nit.Text == "" || txt_nombre.Text == "" || txt_nombre.Text == "" || txt_peso_pcnt.Text == "" || txt_telefono.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    manipular.obtener_conexion();
                    //String query2 = "UPDATE tipo_de_muestra SET descripcion_tip_mst='" + txt_descp_muestra.Text + "', nombre_tipo='" + txt_nombre_tipo.Text + "' WHERE pk_id_tip_mst='" + Codigo + "';";

                    //manipular.EjecutarSql(query2);
                    manipular.Desconectar();

                    //6.limpiar cajas de texto
                    this.LimpiarCajasTexto();
                    ActualizarGrid(this.dataGridView1, "SELECT * FROM cliente");
                    Editar = false;
                }
                else
                {



                    manipular.obtener_conexion();
                    //String query = "INSERT INTO tipo_de_muestra(pk_id_tip_mst,descripcion_tip_mst,nombre_tipo) Values('" + Convert.ToDouble(txt_tp_muestra.Text) + "','" + txt_nombre_tipo.Text + "','" + txt_descp_muestra.Text + "') ";
                    //manipular.EjecutarSql(query);
                    LimpiarCajasTexto();
                    ActualizarGrid(this.dataGridView1, "select * from  tipo_de_muestra");
                    this.LimpiarCajasTexto();
                }
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_fecha_nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            for (int i = 0; i < txt_altura.Text.Length; i++)
            {
                if (txt_altura.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txt_peso_pcnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            for (int i = 0; i < txt_peso_pcnt.Text.Length; i++)
            {
                if (txt_peso_pcnt.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
    }
}
