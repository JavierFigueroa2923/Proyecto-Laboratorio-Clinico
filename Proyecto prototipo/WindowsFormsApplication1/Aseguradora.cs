using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frm_act_aseg : Form
    {
        public frm_act_aseg()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion manipular = new BDconexion();
        String Codigo;
        Boolean Editar;
        public void LimpiarCajasTexto()
        {
            txt_buscar.Text = "";
            txt_desc_aseg.Text = "";
            //txt_id__aseg.Text = "";
            txt_nom_aseg.Text = "";
        }

        public void InhabilitarText()
        {
            txt_nom_aseg.Enabled = false;
            txt_desc_aseg.Enabled = false;
        }

        public void HabilitarText()
        {
            txt_nom_aseg.Enabled = true;
            txt_desc_aseg.Enabled = true;
        }

        private void frm_act_aseg_Load(object sender, EventArgs e)
        {
            btn_acept.Enabled = false;
            btn_cancl.Enabled = false;
            InhabilitarText();
            ActualizarGrid(this.dgv_aseg, "select pk_id_asgd as ID, nombre_aseg as Nombre, descripcion_aseg as Descripcion from aseguradora;");
        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "aseguradora");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "aseguradora";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_busc_aseg_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_aseg, "select pk_id_asgd as ID, nombre_aseg as Nombre, descripcion_aseg as Descripcion from aseguradora where nombre_aseg like '" + txt_buscar.Text + "%'; ");
            txt_buscar.Text = "";
        }


        private void txt_id__aseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_num_aseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_nom_aseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void btn_elim_aseg_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dgv_aseg.CurrentRow.Cells[0].Value.ToString();

                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro
                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();
                    //2. armar la query
                    String Query = "delete from aseguradora where pk_id_asgd= '" + Codigo + "';";
                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);
                    //4.Actualizar grid..
                    ActualizarGrid(this.dgv_aseg, "select pk_id_asgd as ID, nombre_aseg as Nombre, descripcion_aseg as Descripcion from aseguradora;");
                    LimpiarCajasTexto();
                    //5.desconectar en base de datos
                    Conexionmysql.Desconectar();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
        private void btn_guardar_aseg_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_desc_aseg.Text == "" || txt_nom_aseg.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String query2 = "UPDATE aseguradora SET nombre_aseg='" + txt_nom_aseg.Text + "', descripcion_aseg='" + txt_desc_aseg.Text + "' WHERE pk_id_asgd='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_aseg, "select pk_id_asgd as ID, nombre_aseg as Nombre, descripcion_aseg as Descripcion from aseguradora;");
                        Editar = false;
                    }
                    else
                    {

                        Conexionmysql.ObtenerConexion();
                        String query = "INSERT INTO aseguradora (nombre_aseg,descripcion_aseg) VALUES('" + txt_nom_aseg.Text + "', '" + txt_desc_aseg.Text + "') ";
                        cl_gridysql.EjecutarMySql(query);
                        LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_aseg, "select pk_id_asgd as ID, nombre_aseg as Nombre, descripcion_aseg as Descripcion from aseguradora;");
                        this.LimpiarCajasTexto();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InhabilitarText();
        }

        private void btn_actlz_aseg_Click_1(object sender, EventArgs e)
        {
            btn_cancl.Enabled = true;
            HabilitarText();
            try {
                Editar = true;
                Codigo = this.dgv_aseg.CurrentRow.Cells[0].Value.ToString();
                txt_nom_aseg.Text = this.dgv_aseg.CurrentRow.Cells[1].Value.ToString();
                txt_desc_aseg.Text = this.dgv_aseg.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_busca_aseg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_busc_aseg_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_nombre_Click(object sender, EventArgs e)
        {

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

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            ActualizarGrid(this.dgv_aseg, "select pk_id_asgd as ID, nombre_aseg as Nombre, descripcion_aseg as Descripcion from aseguradora where nombre_aseg like '" + txt_buscar.Text+ "%'; ");
        }
    } 
   }