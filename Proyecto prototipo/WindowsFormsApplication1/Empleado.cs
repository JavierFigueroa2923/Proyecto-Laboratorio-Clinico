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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class frm_act_emp : Form
    {
        public frm_act_emp()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        String Codigo;
        Boolean Editar;
        BDconexion ManipularDato = new BDconexion();
        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            Conexionmysql.ObtenerConexion();
            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();
            //Creamos un nuevo adaptador de datos
            MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "Empleado");
            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "Empleado";
            Conexionmysql.Desconectar();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_telefono_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        public void llenarCbocargoemp()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_cargo_emp, nombre_cargo_emp from cargo_empleado;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cargo_empleado");
            cbo_carg_emp.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_carg_emp.ValueMember = ("pk_id_cargo_emp");
            //se indica el valor a desplegar en el combobox
            cbo_carg_emp.DisplayMember = ("nombre_cargo_emp");
        }


        public void LimpiarTextBox()
        {

            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            txt_buscar.Text = "";
        }

        private void btn_guardar_emp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text == "" || txt_telefono.Text == "" || txt_direccion.Text == "" || txt_correo.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String Query = "UPDATE empleado SET nombre_emp ='" + txt_nombre.Text + "' WHERE pk_id_emp ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(Query);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarTextBox();
                        GridViewActualizar(this.dgv_empleads, "select E.nombre_emp, D.direccion, T.telefono, C.correo_e from empleado E, direccion D, telefono T, correo_e C where E.pk_id_emp = D.pk_id_emp and E.pk_id_emp = T.pk_id_emp and E.pk_id_emp = C.pk_id_emp;");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        String Query1 = "INSERT INTO empleado (genero,nombre_emp,apellido_emp,usuario,contrasenia,fecha_nacimiento_emp ) VALUES ('" + cbo_sexo_emp.Text + "','" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_usuario.Text + "', '" + txt_contraseña.Text + "','" + txt_fecha_nacimiento.Text + "')";
                        cl_gridysql.EjecutarMySql(Query1);

                        //  if (ComprobarFormatoEmail(txt_correo.Text) == false)
                        //   {
                        //     MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // }
                        // else
                        //  {
                        String Query2 = "INSERT INTO correo_e (correo_e) VALUES ('" + txt_correo.Text + "')";
                        cl_gridysql.EjecutarMySql(Query2);
                        MessageBox.Show("!!No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //  }


                        String Query3 = "INSERT INTO direccion (direccion) VALUES ('" + txt_direccion.Text + "',)";
                        cl_gridysql.EjecutarMySql(Query3);

                        String Query4 = "INSERT INTO telefono (telefono) VALUES ('" + txt_telefono.Text + "')";
                        cl_gridysql.EjecutarMySql(Query4);

                        string selectedItem2 = cbo_carg_emp.SelectedValue.ToString();
                        String Query5 = "INSERT INTO cargo_empleado (Nombre_cargo_empleado) VALUES ('" + selectedItem2 + "')";
                        cl_gridysql.EjecutarMySql(Query5);

                        GridViewActualizar(this.dgv_empleads, "select E.nombre_emp, D.direccion, T.telefono, C.correo_e from empleado E, direccion D, telefono T, correo_e C where E.pk_id_emp = D.pk_id_emp and E.pk_id_emp = T.pk_id_emp and E.pk_id_emp = C.pk_id_emp;");
                        this.LimpiarTextBox();
                        Conexionmysql.Desconectar();
                        MessageBox.Show("Operación realizada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }






        private void btn_actlz_emp_Click(object sender, EventArgs e)
        {
            Editar = true;
            Codigo = this.dgv_empleads.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = this.dgv_empleads.CurrentRow.Cells[1].Value.ToString();
            txt_apellido.Text = this.dgv_empleads.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_elim_emp_Click(object sender, EventArgs e)
        {
            Codigo = this.dgv_empleads.CurrentRow.Cells[0].Value.ToString();

            //2. preguntar al usuario si realmente quiere borrar el resgistro

            var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //3.PROCEDER AVALUAR EL RESULTADO
            if (resultado == DialogResult.Yes)// si el usuario hizo click en si
            {
                //procedemos a borrar el registro

                //1. conectar a base de datosx
                Conexionmysql.ObtenerConexion();

                //2. armar la query
                String Query = "delete from empleado where pk_id_emp = '" + Codigo + "';";

                //3.ejecutar la query
                cl_gridysql.EjecutarMySql(Query);

                //4.Actualizar grid..
                GridViewActualizar(this.dgv_empleads, "select L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");


                //5.desconectar en base de datos
                Conexionmysql.Desconectar();


            }//cerrar el if

            else

                //no pasa nada
                return;

            //cerrar else
        }

        private void btn_busc_emp_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select E.nombre_emp, D.direccion, T.telefono, C.correo_e from empleado E, direccion D, telefono T, correo_e C where nombre_lab like '%" + txt_buscar.Text + "%' and E.pk_id_emp = D.pk_id_emp and E.pk_id_emp = T.pk_id_emp and E.pk_id_emp = C.pk_id_emp ");
            //ManipularDato.Busqueda(Query);
            GridViewActualizar(this.dgv_empleads, Query);
            Conexionmysql.Desconectar();
        }

        private void cbo_sexo_emp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public static bool valida (string seMailAComprobar)
    {
        String sFormato;
        sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        if (Regex.IsMatch(seMailAComprobar, sFormato))
        {
            if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }




    }

}