using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Manejo_Usuarios : Form
    {
        string codigo = "";
        Boolean Editar;
        public Manejo_Usuarios()
        {
            InitializeComponent();
        }

        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

        public void LimpiarCajaTextoUsuario()
        {
            txt_id_user.Text = "";
            txt_nombre_user.Text = "";
            txt_id_lab_user.Text = "";
            txt_id_emp_user.Text = "";
            txt_contr_emp.Text = "";
            txt_busc_user.Text = "";
            txt_busc_lab_user.Text = "";
            txt_busc_emp_user.Text = "";
        }

        public void InhabilitarTexto()
        {
            txt_id_user.Text = "";
            txt_nombre_user.Text = "";
            txt_id_lab_user.Text = "";
            txt_id_emp_user.Text = "";
            txt_contr_emp.Text = "";
        }

        public void HabilitarTexto()
        {

        }

        private void btn_busc_emp_user_click(object sender, EventArgs e)
        {
            if (txt_busc_emp_user.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_emps_user, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, fecha_nacimiento_emp as Fecha_nac from empleado where nombre_emp like '" + txt_busc_emp_user.Text + "%';");
            }
        }

        private void Txt_busquedaempleadouser_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_emps_user, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, fecha_nacimiento_emp as Fecha_nac from empleado where nombre_emp like '" + txt_busc_emp_user.Text + "%';");
        }

        private void btn_elim_user_Click(object sender, EventArgs e)
        {
            codigo = this.dgv_user.CurrentRow.Cells[0].Value.ToString();
            if (codigo == "")
            {
                MessageBox.Show("No se ha seleccionado nada para realizar la eliminacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //preguntamos al usuario si desea eliminar el registro por completo
                var resultado = MessageBox.Show("¿Realmente desea eliminar el registro?", "confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Proceder a evaluar el resultado
                if (resultado == DialogResult.Yes)//si el usuario hizo click en el boton yes
                {
                    //procedo a hacer el borrado
                    //me conecto a la base de datos
                    Conexionmysql.ObtenerConexion();
                    //armar query...
                    int NumVal = Int32.Parse(codigo);
                    String Query = "delete from usuario where pk_id_usur = " + NumVal + ";";
                    //ejecutar query
                    cl_gridysql.EjecutarMySql(Query);
                    //Actualize la grid
                    cl_gridysql.ActualizarGridUsuario(this.dgv_user, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario;");
                    //desconectamos de la base de datos
                    Conexionmysql.Desconectar();
                }
                else
                {
                    //no pasa nada
                    return;
                }
            }
            LimpiarCajaTextoUsuario();
        }

        private void btn_busc_user_Click(object sender, EventArgs e)
        {
            if (txt_busc_user.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridUsuario(this.dgv_user, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario where usuario like '" + txt_busc_user.Text + "%';");
            }
        }

        private void Txt_busquedauser_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridUsuario(this.dgv_user, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario where usuario like '" + txt_busc_user.Text + "%';");
        }

        private void btn_busc_lab_user_Click(object sender, EventArgs e)
        {
            if (txt_busc_lab_user.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridLaboratorioUsuario(this.dgv_labs_user, "select pk_id_lab as Identificador, ubicacion_lab as Ubicacion, nombre_lab as Nombre from laboratorio where nombre like '" + txt_busc_lab_user.Text + "%';");
            }
        }

        private void Txt_busquedalaboratoriouser_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridLaboratorioUsuario(this.dgv_labs_user, "select pk_id_lab as Identificador, ubicacion_lab as Ubicacion, nombre_lab as Nombre from laboratorio where nombre like '" + txt_busc_lab_user.Text + "%';");
        }

        private void Manejo_Usuarios_Load(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_emps_user, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, fecha_nacimiento_emp as Fecha_nac from empleado;");
            cl_gridysql.ActualizarGridLaboratorioUsuario(this.dgv_labs_user, "select pk_id_lab as Identificador, ubicacion_lab as Ubicacion, nombre_lab as Nombre from laboratorio;");
            cl_gridysql.ActualizarGridUsuario(this.dgv_user, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario;");
            llenarCboPermiso();
        }

        private void btn_rnv_user_Click(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridEmpleadoUsuario(this.dgv_emps_user, "select pk_id_emp as Identificador, pk_id_lab as Laboratorio, genero as Genero, nombre_emp as Nombre, apellido_emp as Apellido, fecha_nacimiento_emp as Fecha_nac from empleado;");
            cl_gridysql.ActualizarGridLaboratorioUsuario(this.dgv_labs_user, "select pk_id_lab as Identificador, ubicacion_lab as Ubicacion, nombre_lab as Nombre from laboratorio;");
            cl_gridysql.ActualizarGridUsuario(this.dgv_user, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario;");
        }

        private void cbo_per_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void llenarCboPermiso()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_perm, nombre_prm from permiso;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query,Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds,"permiso");
            cbo_per_user.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_per_user.ValueMember = ("pk_id_perm");
            //se indica el valor a desplegar en el combobox
            cbo_per_user.DisplayMember = ("nombre_prm");
        }

       /* private void btn_agr_emp_user_Click(object sender, EventArgs e)
        {
            
                txt_id_emp_user.Text = this.dgv_emps_user.CurrentRow.Cells[0].Value.ToString();

        }

        private void btn_agr_lab_user_Click(object sender, EventArgs e)
        {
            txt_id_lab_user.Text = this.dgv_labs_user.CurrentRow.Cells[0].Value.ToString();
        }*/

        private void btn_guardar_user_Click(object sender, EventArgs e)
        {
            if (txt_nombre_user.Text == ""|| txt_id_lab_user.Text == "" || txt_id_emp_user.Text == "" || txt_contr_emp.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    string selectedItem = cbo_per_user.SelectedValue.ToString();
                    String Query = "update usuario set pk_id_perm = '" + selectedItem + "', usuario = '" + txt_nombre_user.Text + "', contrasenia_usur = '" + txt_contr_emp.Text + "', pk_id_emp = '" + txt_id_emp_user.Text + "', pk_id_lab = '" + txt_id_lab_user.Text + "'where pk_id_usur = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    cl_gridysql.ActualizarGridUsuario(this.dgv_user, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario;");
                    Conexionmysql.ObtenerConexion();
                    this.LimpiarCajaTextoUsuario();
                    Editar = false;
                }
                else
                {
                    string selectedItem = cbo_per_user.SelectedValue.ToString();
                    //Conectarse a base de datos
                    Conexionmysql.ObtenerConexion();
                    //Armar Query
                    String Query = "insert into Usuario(pk_id_usur,pk_id_perm,usuario,contrasenia_usur,pk_id_emp,pk_id_lab)values(" + txt_id_user.Text + "," + selectedItem + ",'" + txt_nombre_user.Text + "','" + txt_contr_emp.Text + "'," + txt_id_emp_user.Text + "," + txt_id_lab_user.Text + ");";
                    //Ejecutar Query
                    cl_gridysql.EjecutarMySql(Query);
                    //Actualizar el DataGrid
                    cl_gridysql.ActualizarGridUsuario(this.dgv_user, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario;");
                    //Desconectarse de la Base de Datos
                    Conexionmysql.Desconectar();
                    //Limpiar cajas de texto
                    this.LimpiarCajaTextoUsuario();
                }
            }
        }

        private void btn_actlz_user_Click(object sender, EventArgs e)
        {
            Editar = true;
            codigo = this.dgv_user.CurrentRow.Cells[0].Value.ToString();
            txt_nombre_user.Text = this.dgv_user.CurrentRow.Cells[2].Value.ToString();
            txt_contr_emp.Text = this.dgv_user.CurrentRow.Cells[3].Value.ToString();
            txt_id_emp_user.Text = this.dgv_user.CurrentRow.Cells[4].Value.ToString();
            txt_id_lab_user.Text = this.dgv_user.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
