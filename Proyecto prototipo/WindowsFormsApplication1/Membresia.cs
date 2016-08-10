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
            cbo_buscar.Text = "";
            txt_id_clt.Text = "";
           // txt_membresia.Text = "";
            txt_beneficio.Text = "";
            txt_fecha_exp.Text = "";
            txt_fec_expirar.Text = "";


        }
        private void txt_fecha_expir_Load(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_membresia, "SELECT * FROM membresia");
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
                if (txt_beneficio.Text == "" || txt_id_clt.Text == "" || txt_fec_expirar.Text == "" || txt_fecha_exp.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String query2 = "UPDATE membresia SET beneficios='" + txt_beneficio.Text + "', fecha_expendicion_mem='" + txt_fecha_exp.Text + "', fecha_expiracion_mem = '" + txt_fec_expirar.Text + "' WHERE pk_id_mem='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_membresia, "SELECT * FROM membresia");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        String Query = "INSERT INTO membresia (beneficios,fecha_expendicion_mem,fecha_expiracion_mem,pk_id_clt) VALUES ('" + txt_beneficio.Text + "','" + txt_fecha_exp.Text + "','" + txt_fec_expirar.Text + "', '" + Convert.ToDouble(txt_id_clt.Text) + "') ";
                        cl_gridysql.EjecutarMySql(Query);
                        ActualizarGrid(this.dgv_membresia, "select * from membresia;");
                        this.LimpiarCajasTexto();
                        Conexionmysql.Desconectar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_elim_membresia_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dgv_membresia.CurrentRow.Cells[0].Value.ToString();
                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro

                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();

                    //2. armar la query
                    String Query = "delete from membresia where pk_id_mem= '" + Codigo + "';";

                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);

                    //4.Actualizar grid..
                    ActualizarGrid(this.dgv_membresia, "select * from membresia;");


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
            try {
                Editar = true;
                Codigo = this.dgv_membresia.CurrentRow.Cells[0].Value.ToString();
                txt_beneficio.Text = this.dgv_membresia.CurrentRow.Cells[1].Value.ToString();
                txt_fecha_exp.Text = this.dgv_membresia.CurrentRow.Cells[2].Value.ToString();
                txt_fec_expirar.Text = this.dgv_membresia.CurrentRow.Cells[3].Value.ToString();
                txt_id_clt.Text = this.dgv_membresia.CurrentRow.Cells[4].Value.ToString();
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
            String Query = ("select * from membresia where pk_id_clt = '" + Convert.ToDouble(cbo_buscar.Text) + "%'; ");
            //ManipularDato.Busqueda(Query);
            ActualizarGrid(this.dgv_membresia, Query);
            Conexionmysql.Desconectar();
            cbo_buscar.Text = "";
        }

        private void btn_act_datos_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_membresia, "SELECT * FROM membresia;");
        }

        private void txt_id_clt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
