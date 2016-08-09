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
    public partial class Titulo_de_empleado : Form
    {
        public Titulo_de_empleado()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion manipular = new BDconexion();
        String Codigo;
        Boolean Editar;
        public void LimpiarCajasTexto()
        {
            cbo_buscar.Text = "";
            txt_id_emp.Text = "";
            txt_id_lab.Text = "";
            //txt_id_titulo_emp.Text = "";
            txt_nom_titulo.Text = "";
            txt_decrip_titulo_emp.Text = "";
            txt_fecha_obt_titulo.Text = "";

        }
        private void actualizar_titulo_emp_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_busqueda_datos_empleado, "select * from titulo_empleado;");
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
            MiDataAdapter.Fill(MiDataSet, "membresia");

            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "membresia";

            //nos desconectamos de la base de datos...
            manipular.Desconectar();

        }

        private void txt_id_titulo_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_id_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_id_lab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_nom_titulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void btn_guardar_titulo_emp_Click(object sender, EventArgs e)
        {
            try {
                if (txt_decrip_titulo_emp.Text == "" || txt_id_lab.Text == "" || txt_nom_titulo.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        manipular.obtener_conexion();
                        String query2 = "UPDATE titulo_empleado SET descripcion_titl_emp='" + txt_decrip_titulo_emp.Text + "', nombre_titl_emp='" + txt_nom_titulo.Text + "', pk_id_lab ='" + Convert.ToDouble(txt_id_lab.Text) + "' WHERE pk_id_titl_emp='" + Codigo + "';";
                        //String query2 = "UPDATE titulo_empleado SET descripcion_titl_emp='" + txt_decrip_titulo_emp.Text + "', nombre_titl_emp ='" + txt_nom_titulo.Text + "', fecha_obten_titl_emp = '" + txt_fecha_obt_titulo.Text + "', pk_id_lab = '" +Convert.ToDouble(txt_id_lab.Text) + "' WHERE pk_id_titl_emp='" + Codigo + "';";

                        manipular.EjecutarSql(query2);
                        manipular.Desconectar();

                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_busqueda_datos_empleado, "SELECT * FROM titulo_empleado");
                        Editar = false;
                    }
                    else
                    {



                        manipular.obtener_conexion();
                        String Query = "INSERT INTO titulo_empleado (descripcion_titl_emp,nombre_titl_emp,fecha_obten_titl_emp, pk_id_emp, pk_id_lab) VALUES ('" + txt_decrip_titulo_emp.Text + "','" + txt_nom_titulo.Text + "','" + txt_fecha_obt_titulo.Text + "', '" + Convert.ToDouble(txt_id_emp.Text) + "', '" + Convert.ToDouble(txt_id_lab.Text) + "') ";

                        manipular.EjecutarSql(Query);

                        ActualizarGrid(this.dgv_busqueda_datos_empleado, "select * from titulo_empleado;");

                        this.LimpiarCajasTexto();
                        manipular.Desconectar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_elim_titulo_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[0].Value.ToString();

                //2. preguntar al usuario si realmente quiere borrar el resgistro

                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro

                    //1. conectar a base de datosx
                    manipular.obtener_conexion();

                    //2. armar la query
                    String Query = "delete from titulo_empleado where pk_id_titl_emp= '" + Codigo + "';";

                    //3.ejecutar la query
                    manipular.EjecutarSql(Query);

                    //4.Actualizar grid..
                    ActualizarGrid(this.dgv_busqueda_datos_empleado, "select * from titulo_empleado;");


                    //5.desconectar en base de datos
                    manipular.Desconectar();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_actlz_titulo_emp_Click(object sender, EventArgs e)
        {
            try {
                Editar = true;
                Codigo = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[0].Value.ToString();
                txt_decrip_titulo_emp.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[1].Value.ToString();
                txt_nom_titulo.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[2].Value.ToString();
                //txt_fecha_obt_titulo.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[3].Value.ToString();
                txt_id_emp.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[4].Value.ToString();
                txt_id_lab.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_busc_emp_Click(object sender, EventArgs e)
        {
            manipular.obtener_conexion();
            String Query = ("select * from titulo_empleado where pk_id_titl_emp = '" + Convert.ToDouble(cbo_buscar.Text) + "%'; ");

            //ManipularDato.Busqueda(Query);

            ActualizarGrid(this.dgv_busqueda_datos_empleado, Query);


            manipular.Desconectar();
            cbo_buscar.Text = "";
        }

        
    }
 }
