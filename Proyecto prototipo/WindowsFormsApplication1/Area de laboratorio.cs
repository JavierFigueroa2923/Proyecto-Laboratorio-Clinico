using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Area_de_laboratorio : Form
    {
        public Area_de_laboratorio()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion ManipularDato = new BDconexion();
        String Codigo;
        Boolean Editar;
        private void Area_de_laboratorio_Load(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_area_labs, "SELECT * FROM area_laboratorio;");
        }
        private void txt_id_area_lab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }


        private void txt_id_lab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }
        public void LimpiarCajasTexto()
        {
            txt_buscar_lab.Text = "";
            txt_descrip_area.Text = "";
            txt_id_area_lab.Text = "";
            txt_id_lab.Text = "";
            txt_ubicacion.Text = "";

        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            ManipularDato.obtener_conexion();
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=proyecto_laboratorio; uid=root; pwd=;");
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();

            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, conectar);

            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "area_laboratorio");

            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "area_laboratorio";

            //nos desconectamos de la base de datos...
            ManipularDato.Desconectar();



        }

        private void btn_guardar_area_Click(object sender, EventArgs e)
        {
            if (txt_ubicacion.Text == "" || txt_descrip_area.Text == "" || txt_id_lab.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    ManipularDato.obtener_conexion();
                    String query2 = "UPDATE area_laboratorio SET ubicacion='" + txt_ubicacion.Text + "', des='" + txt_descrip_area.Text + "' WHERE pk_id_area_lab='" + Codigo + "';";

                    ManipularDato.EjecutarSql(query2);
                    ManipularDato.Desconectar();

                    //6.limpiar cajas de texto
                    this.LimpiarCajasTexto();
                    ActualizarGrid(this.dgv_area_labs, "SELECT * FROM area_laboratorio");
                    Editar = false;
                }
                else
                {



                    ManipularDato.obtener_conexion();
                    String Query = "INSERT INTO area_laboratorio (pk_id_area_lab,pk_id_lab,ubicacion,des) VALUES ('" + Convert.ToDouble(txt_id_area_lab.Text) + "','" + Convert.ToDouble(txt_id_lab.Text) + "','" + txt_ubicacion.Text + "','" + txt_descrip_area.Text + "') ";

                    ManipularDato.EjecutarSql(Query);

                    ActualizarGrid(this.dgv_area_labs, "select * from area_laboratorio;");

                    this.LimpiarCajasTexto();
                    ManipularDato.Desconectar();
                }
            }
        }

        private void btn_elim_area_Click(object sender, EventArgs e)
        {
            Codigo = this.dgv_area_labs.CurrentRow.Cells[0].Value.ToString();

            //2. preguntar al usuario si realmente quiere borrar el resgistro

            var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //3.PROCEDER AVALUAR EL RESULTADO
            if (resultado == DialogResult.Yes)// si el usuario hizo click en si
            {
                //procedemos a borrar el registro

                //1. conectar a base de datosx
                ManipularDato.obtener_conexion();

                //2. armar la query
                String Query = "delete from area_laboratorio where pk_id_area_lab= '" + Codigo + "';";

                //3.ejecutar la query
                ManipularDato.EjecutarSql(Query);

                //4.Actualizar grid..
                ActualizarGrid(this.dgv_area_labs, "select * from area_laboratorio;");
                

                //5.desconectar en base de datos
                ManipularDato.Desconectar();


            }//cerrar el if

            else

                //no pasa nada
                return;

            //cerrar else
        }

        private void btn_buscar_lab_Click(object sender, EventArgs e)
        {
            ManipularDato.obtener_conexion();
            String Query = ("select * from area_laboratorio where ubicacion = '" + txt_buscar_lab.Text + "%'; ");

            ManipularDato.Busqueda(Query);

            ActualizarGrid(this.dgv_area_labs, Query);


            ManipularDato.Desconectar();
        }

        private void btn_actlz_area_Click(object sender, EventArgs e)
        {
            Editar = true;
            Codigo = this.dgv_area_labs.CurrentRow.Cells[0].Value.ToString();
            txt_id_lab.Text = this.dgv_area_labs.CurrentRow.Cells[1].Value.ToString();
            txt_ubicacion.Text = this.dgv_area_labs.CurrentRow.Cells[2].Value.ToString();
            txt_descrip_area.Text = this.dgv_area_labs.CurrentRow.Cells[3].Value.ToString();
           
        }
    }
}
