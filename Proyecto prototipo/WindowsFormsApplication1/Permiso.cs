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
    public partial class frm_permiso : Form
    {
        Boolean Editar;
        BDconexion conectar = new BDconexion();
        string codigo = "";

        public frm_permiso()
        {
            InitializeComponent();
        }

        Validaciones validar = new Validaciones();

        //VENTANA PERMISO

        public void LimpiarCajaTextoPermiso()
        {
            txt_descr_per.Text = "";
            txt_nombre_per.Text = "";
        }

        

        private void btn_guardar_per_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txt_descr_per.Text == "" || txt_nombre_per.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        int NumVal = Int32.Parse(codigo);
                        String Query = "update permiso set nombre_prm = '" + txt_nombre_per.Text + "', descripcion_perm = '" + txt_descr_per.Text + "',  pk_id_cargo_emp = " + cbo_id_carg_emp_per.Text + " where pk_id_perm = '" + NumVal + "';";
                        cl_gridysql.EjecutarMySql(Query);
                        cl_gridysql.ActualizarGridPermiso(this.dgv_busc_per, "select pk_id_perm as Identificador, nombre_prm as Nombre, descripcion_perm as Descripcion, pk_id_cargo_emp as id_cargo_empleado from permiso;");
                        Conexionmysql.Desconectar();
                        this.LimpiarCajaTextoPermiso();
                        Editar = false;
                    }
                    else
                    {
                        //Conectarse a base de datos
                        Conexionmysql.ObtenerConexion();
                        //Armar Query
                        String Query = "insert into permiso(nombre_prm,descripcion_perm,pk_id_cargo_emp)values('" + txt_nombre_per.Text + "','" + txt_descr_per.Text + "'," + cbo_id_carg_emp_per.Text + ");";
                        //Ejecutar Query
                        cl_gridysql.EjecutarMySql(Query);
                        //Actualizar el DataGrid
                        cl_gridysql.ActualizarGridPermiso(this.dgv_busc_per, "select pk_id_perm as Identificador, nombre_prm as Nombre, descripcion_perm as Descripcion, pk_id_cargo_emp as id_cargo_empleado from permiso;");
                        //Desconectarse de la Base de Datos
                        Conexionmysql.Desconectar();
                        //Limpiar cajas de texto
                        this.LimpiarCajaTextoPermiso();
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_actlz_per_Click(object sender, EventArgs e)
        {
            Editar = true;
            try
            {
                codigo = this.dgv_busc_per.CurrentRow.Cells[0].Value.ToString();
                txt_nombre_per.Text = this.dgv_busc_per.CurrentRow.Cells[1].Value.ToString();
                txt_descr_per.Text = this.dgv_busc_per.CurrentRow.Cells[2].Value.ToString();
                cbo_id_carg_emp_per.Text = this.dgv_busc_per.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado el dato a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private void btn_elim_per_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = this.dgv_busc_per.CurrentRow.Cells[0].Value.ToString();
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
                        String Query = "delete from permiso where pk_id_perm = " + NumVal + ";";
                        //ejecutar query
                        cl_gridysql.EjecutarMySql(Query);
                        //Actualize la grid
                        cl_gridysql.ActualizarGridPermiso(this.dgv_busc_per, "select pk_id_perm as Identificador, nombre_prm as Nombre, descripcion_perm as Descripcion, pk_id_cargo_emp as id_cargo_empleado from permiso;");
                        //desconectamos de la base de datos
                        Conexionmysql.Desconectar();
                    }
                    else
                    {
                        //no pasa nada
                        return;
                    }
                }
                LimpiarCajaTextoPermiso();
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado nada para realizar la eliminacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_busc_id_per_Click(object sender, EventArgs e)
        {
            if (txt_busc_id_per.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridPermiso(this.dgv_busc_per, "select pk_id_perm as Identificador, nombre_prm as Nombre, descripcion_perm as Descripcion from permiso where nombre_prm like '" + txt_busc_id_per.Text + "%';");
            }
        }

        private void Txt_busquedapermiso_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridPermiso(this.dgv_busc_per, "select pk_id_perm as Identificador, nombre_prm as Nombre, descripcion_perm as Descripcion, pk_id_cargo_emp as id_cargo_empleado from permiso where nombre_prm like '" + txt_busc_id_per.Text + "%';");
        }

        private void btn_rnv_per_Click(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridPermiso(this.dgv_busc_per, "select pk_id_perm as Identificador, nombre_prm as Nombre, descripcion_perm as Descripcion, pk_id_cargo_emp as id_cargo_empleado from permiso;");
        }


        private void frm_permiso_Load(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridPermiso(this.dgv_busc_per, "select pk_id_perm as Identificador, nombre_prm as Nombre, descripcion_perm as Descripcion, pk_id_cargo_emp as id_cargo_empleado from permiso;");
            //llenarCboIdCargo();
        }

        private void txt_id_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_nombre_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void txt_busc_id_per_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        public void llenarCboIdCargo()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select pk_id_cargo_emp, nombre_cargo_emp from cargo_emleado;";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cargo_emleado");
            cbo_id_carg_emp_per.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_id_carg_emp_per.ValueMember = ("pk_id_cargo_emp");
            //se indica el valor a desplegar en el combobox
            cbo_id_carg_emp_per.DisplayMember = ("pk_id_cargo_emp");
        }

        private void btn_busc_id_carg_emp_per_Click(object sender, EventArgs e)
        {
            Busqueda_cargo_empleado ini = new Busqueda_cargo_empleado();
            ini.MdiParent = this.MdiParent;
            ini.Show();
            this.Hide();
        }

        private void Lbl_permiso_Click(object sender, EventArgs e)
        {

        }

        private void cbo_id_carg_emp_per_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_per_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_descr_per_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void cbo_id_carg_emp_per_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_busc_id_per_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
