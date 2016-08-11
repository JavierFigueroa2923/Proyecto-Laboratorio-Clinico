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
                        cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_empleads, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, usuario as Usuario, contrasenia as Password, fecha_nacimiento_emp as Fecha_nacimiento from empleado");
                        Editar = false;
                    }
                    else
                    {
                        if (txt_contraseña.Text == txt_contraseña2.Text)
                        {
                            Conexionmysql.ObtenerConexion();
                            String Query1 = "INSERT INTO empleado (pk_id_lab,genero,nombre_emp,apellido_emp,usuario,contrasenia,fecha_nacimiento_emp ) VALUES (" + cbo_id_lab.SelectedValue + ",'" + cbo_sexo_emp.Text + "','" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_usuario.Text + "', '" + txt_contraseña.Text + "','" + txt_fecha_nacimiento.Text + "')";
                            cl_gridysql.EjecutarMySql(Query1);

                            String Query2 = "INSERT INTO correo_e (correo_e,pk_id_emp) VALUES ('" + txt_correo.Text + "',(select MAX(pk_id_emp) FROM empleado))";
                            cl_gridysql.EjecutarMySql(Query2);


                            String Query3 = "INSERT INTO direccion (direccion,pk_id_emp) VALUES ('" + txt_direccion.Text + "',(select MAX(pk_id_emp) FROM empleado))";
                            cl_gridysql.EjecutarMySql(Query3);

                            String Query4 = "INSERT INTO telefono (telefono,pk_id_emp) VALUES ('" + txt_telefono.Text + "',(select MAX(pk_id_emp) FROM empleado))";
                            cl_gridysql.EjecutarMySql(Query4);
                            this.LimpiarTextBox();
                            Conexionmysql.Desconectar();
                            cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_empleads, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, usuario as Usuario, contrasenia as Password, fecha_nacimiento_emp as Fecha_nacimiento from empleado");
                            /*
                            string selectedItem2 = cbo_carg_emp.SelectedValue.ToString();
                            String Query5 = "INSERT INTO cargo_empleado (Nombre_cargo_empleado) VALUES ('" + selectedItem2 + "')";
                            cl_gridysql.EjecutarMySql(Query5);

                            GridViewActualizar(this.dgv_empleads, "select E.nombre_emp, D.direccion, T.telefono, C.correo_e from empleado E, direccion D, telefono T, correo_e C where E.pk_id_emp = D.pk_id_emp and E.pk_id_emp = T.pk_id_emp and E.pk_id_emp = C.pk_id_emp;");
                            this.LimpiarTextBox();
                            Conexionmysql.Desconectar();
                            MessageBox.Show("Operación realizada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                        }
                        else {
                            MessageBox.Show("Contraseñas ingresadas no coinciden.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
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
            cbo_id_lab.Text = this.dgv_empleads.CurrentRow.Cells[1].Value.ToString();
            cbo_sexo_emp.Text = this.dgv_empleads.CurrentRow.Cells[2].Value.ToString();
            txt_nombre.Text = this.dgv_empleads.CurrentRow.Cells[3].Value.ToString();
            txt_apellido.Text = this.dgv_empleads.CurrentRow.Cells[4].Value.ToString();
            txt_usuario.Text = this.dgv_empleads.CurrentRow.Cells[5].Value.ToString();
            txt_contraseña.Text = this.dgv_empleads.CurrentRow.Cells[6].Value.ToString();
            txt_contraseña2.Text = this.dgv_empleads.CurrentRow.Cells[6].Value.ToString();
            txt_fecha_nacimiento.Text = this.dgv_empleads.CurrentRow.Cells[7].Value.ToString();
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
                cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_empleads, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, usuario as Usuario, contrasenia as Password, fecha_nacimiento_emp as Fecha_nacimiento from empleado");


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
            String Query = ("select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, usuario as Usuario, contrasenia as Password, fecha_nacimiento_emp as Fecha_nacimiento from empleado WHERE empleado.nombre_emp like '%" + txt_buscar.Text + "%'");
            
            //ManipularDato.Busqueda(Query);
            GridViewActualizar(this.dgv_empleads, Query);
            Conexionmysql.Desconectar();
        }

        private void cbo_sexo_emp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_act_emp_Load(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_empleads, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, usuario as Usuario, contrasenia as Password, fecha_nacimiento_emp as Fecha_nacimiento from empleado");
            llenarCboIdCargo();
            llenarCboIdLab();
        }

        public void llenarCboIdCargo()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select DISTINCT cargo_empleado.pk_id_cargo_emp, cargo_empleado.nombre_cargo_emp, empleado.nombre_emp from cargo_empleado, empleado WHERE cargo_empleado.pk_id_emp = empleado.pk_id_emp";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cargo_empleado");
            cbo_carg_emp.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_carg_emp.ValueMember = ("pk_id_cargo_emp");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_cargo_emp, nombre_cargo_emp";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_cargo_emp"] = dr["pk_id_cargo_emp"].ToString() + " " + dr["nombre_cargo_emp"].ToString();
            }
            cbo_carg_emp.DataSource = dt;


            cbo_carg_emp.DisplayMember = "nombre_cargo_emp";
        }

        public void llenarCboIdLab()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            //String Query = "select DISTINCT cargo_empleado.pk_id_cargo_emp, cargo_empleado.nombre_cargo_emp, empleado.nombre_emp from cargo_empleado, empleado WHERE cargo_empleado.pk_id_emp = empleado.pk_id_emp";
            String Query = "select DISTINCT pk_id_lab, nombre_lab from laboratorio";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "laboratorio");
            cbo_id_lab.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_lab.ValueMember = ("pk_id_lab");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_lab, nombre_lab";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_lab"] = dr["pk_id_lab"].ToString() + " " + dr["nombre_lab"].ToString();
            }
            cbo_id_lab.DataSource = dt;


            cbo_id_lab.DisplayMember = "nombre_lab";
        }
    }

    /*public static bool valida (string seMailAComprobar)
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




    }*/

}