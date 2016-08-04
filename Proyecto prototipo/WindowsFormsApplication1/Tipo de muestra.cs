using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Tipo_de_muestra : Form
    {
        public Tipo_de_muestra()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion manipular = new BDconexion();
        String Codigo;
        Boolean Editar;
        private void Tipo_de_muestra_Load(object sender, EventArgs e)
        {
            /// no real 
            ActualizarGrid(this.dgv_muestras, "select * from tipo_de_muestra;");
        }

        public void LimpiarCajasTexto()
        {
            txt_descp_muestra.Text = "";
            txt_nombre_tipo.Text = "";
            txt_tp_muestra.Text = "";


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
            MiDataAdapter.Fill(MiDataSet, "tipo_de_muestra");

            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "tipo_de_muestra";

            //nos desconectamos de la base de datos...
            manipular.Desconectar();



        }

        private void btn_guardar_tipo_muestra_Click(object sender, EventArgs e)
        {

            if (txt_descp_muestra.Text == "" || txt_nombre_tipo.Text == "" )
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    manipular.obtener_conexion();
                    String query2 = "UPDATE tipo_de_muestra SET descripcion_tip_mst='" + txt_descp_muestra.Text + "', nombre_tipo='" + txt_nombre_tipo.Text + "' WHERE pk_id_tip_mst='" + Codigo + "';";

                    manipular.EjecutarSql(query2);
                    manipular.Desconectar();

                    //6.limpiar cajas de texto
                    this.LimpiarCajasTexto();
                    ActualizarGrid(this.dgv_muestras, "SELECT * FROM tipo_de_muestra");
                    Editar = false;
                }
                else
                {



                    manipular.obtener_conexion();
                    String query = "INSERT INTO tipo_de_muestra(pk_id_tip_mst,descripcion_tip_mst,nombre_tipo) Values('" + Convert.ToDouble(txt_tp_muestra.Text) + "','" + txt_nombre_tipo.Text + "','" + txt_descp_muestra.Text + "') ";
                    manipular.EjecutarSql(query);
                    LimpiarCajasTexto();
                    ActualizarGrid(this.dgv_muestras, "select * from  tipo_de_muestra");
                    this.LimpiarCajasTexto();
                }
            }

        }

        private void btn_actlz_tipo_muestra_Click(object sender, EventArgs e)
        {
            manipular.obtener_conexion();
            Editar = true;
            Codigo = this.dgv_muestras.CurrentRow.Cells[0].Value.ToString();
            txt_descp_muestra.Text = this.dgv_muestras.CurrentRow.Cells[1].Value.ToString();
            txt_nombre_tipo.Text = this.dgv_muestras.CurrentRow.Cells[2].Value.ToString();

            //String query = "UPDATE tipo_de_muestra SET descripcion_tip_mst='" + txt_descp_muestra.Text + "', nombre_tipo='" + txt_nombre_tipo.Text + "' WHERE pk_id_tip_mst='" + Convert.ToDouble(txt_tp_muestra.Text) + "';";

            //manipular.EjecutarSql(query);
            // manipular.Desconectar();

            //6.limpiar cajas de texto
            //this.LimpiarCajasTexto();
           // ActualizarGrid(this.dataGridView1, "SELECT * FROM tipo_de_muestra");
        }

        private void btn_elim_tp_muestra_Click(object sender, EventArgs e)
        {
            Codigo = this.dgv_muestras.CurrentRow.Cells[0].Value.ToString();

            //2. preguntar al usuario si realmente quiere borrar el resgistro

            var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //3.PROCEDER AVALUAR EL RESULTADO
            if (resultado == DialogResult.Yes)// si el usuario hizo click en si
            {
                //procedemos a borrar el registro

                //1. conectar a base de datos
                manipular.obtener_conexion();

                //2. armar la query
                String Query = "DELETE FROM tipo_de_muestra WHERE pk_id_tip_mst= '" + Codigo + "';";

                //3.ejecutar la query
                manipular.EjecutarSql(Query);

                //4.Actualizar grid..
                ActualizarGrid(this.dgv_muestras, "SELECT * FROM tipo_de_muestra;");


                //5.desconectar en base de datos
                manipular.Desconectar();


            }//cerrar el if

            else

                //no pasa nada
                return;

            //cerrar else
        }

        private void txt_tp_muestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }
    }
}