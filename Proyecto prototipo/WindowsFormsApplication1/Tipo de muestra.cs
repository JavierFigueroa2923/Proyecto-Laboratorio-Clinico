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
            cbo_buscar.Text = "";
            txt_descp_muestra.Text = "";
            txt_nombre_tipo.Text = "";
            //txt_tp_muestra.Text = "";


        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "tipo_de_muestra");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "tipo_de_muestra";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_tipo_muestra_Click(object sender, EventArgs e)
        {
            try {
                if (txt_descp_muestra.Text == "" || txt_nombre_tipo.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String query2 = "UPDATE tipo_de_muestra SET descripcion_tip_mst='" + txt_descp_muestra.Text + "', nombre_tipo='" + txt_nombre_tipo.Text + "' WHERE pk_id_tip_mst='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_muestras, "SELECT * FROM tipo_de_muestra");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        String query = "INSERT INTO tipo_de_muestra(descripcion_tip_mst,nombre_tipo) Values('" + txt_nombre_tipo.Text + "','" + txt_descp_muestra.Text + "') ";
                        cl_gridysql.EjecutarMySql(query);
                        LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_muestras, "select * from  tipo_de_muestra");
                        this.LimpiarCajasTexto();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_actlz_tipo_muestra_Click(object sender, EventArgs e)
        {
            try {
                manipular.obtener_conexion();
                Editar = true;
                Codigo = this.dgv_muestras.CurrentRow.Cells[0].Value.ToString();
                txt_descp_muestra.Text = this.dgv_muestras.CurrentRow.Cells[2].Value.ToString();
                txt_nombre_tipo.Text = this.dgv_muestras.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btn_elim_tp_muestra_Click(object sender, EventArgs e)
        {
            try
            {
                Codigo = this.dgv_muestras.CurrentRow.Cells[0].Value.ToString();

                //2. preguntar al usuario si realmente quiere borrar el resgistro

                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro

                    //1. conectar a base de datos
                    Conexionmysql.ObtenerConexion();

                    //2. armar la query
                    String Query = "DELETE FROM tipo_de_muestra WHERE pk_id_tip_mst= '" + Codigo + "';";

                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);

                    //4.Actualizar grid..
                    ActualizarGrid(this.dgv_muestras, "SELECT * FROM tipo_de_muestra;");


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

        private void txt_tp_muestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void btn_busc_memb_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from membresia where pk_id_tip_mst = '" + Convert.ToDouble(cbo_buscar.Text) + "%'; ");

            //ManipularDato.Busqueda(Query);

            ActualizarGrid(this.dgv_muestras, Query);
            Conexionmysql.Desconectar();
            cbo_buscar.Text = "";
        }

        private void btn_act_datos_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_muestras, "SELECT * FROM tipo_muestra;");
        }

        private void txt_nombre_tipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_descp_muestra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}