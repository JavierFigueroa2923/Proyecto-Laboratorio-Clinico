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
    public partial class frm_act_emp : Form
    {
        public frm_act_emp()
        {
            InitializeComponent();
        }

        BDconexion ManipularDato = new BDconexion();
        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            ManipularDato.obtener_conexion();
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=proyecto_laboratorio; uid=root; pwd=;");

            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();

            //Creamos un nuevo adaptador de datos
            MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(Query, conectar);

            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "Empleado");

            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "Empleado";
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

        private void btn_guardar_emp_Click(object sender, EventArgs e)
        {
            try
            {
                string miconexion = ("server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
                string consulta = "insert into EMPLEADO values ('" + cbo_id_empleado + "','" + cbo_sexo_emp + "','" + txt_nombre + "','" + txt_apellido + "','" + txt_fecha_nacimiento + "');";
                string consulta4 = "insert into DIRECCION values ('" + txt_direccion + "'), pk_id_emp(FK) = '" + cbo_id_empleado + "'";
                string consulta5 = "insert into TELEFONO values ('" + txt_telefono + "'), pk_id_emp(FK) = '" + cbo_id_empleado + "'";
                string consulta6 = "insert into CORREO_E values ('" + txt_email + "'), pk_id_emp(FK) = '" + cbo_id_empleado + "'";
                string consulta7 = "insert into CARGO_EMPLEADO values ('" + cbo_carg_emp + "'), pk_id_emp(FK) = '" + cbo_id_empleado + "'";
                string consulta8 = "insert into TITULO_EMPLEADO values ('" + cbo_titl_emp + "'), pk_idem_emp(FK) = '" + cbo_id_empleado + "'";

                MySqlConnection con = new MySqlConnection(miconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
               MySqlCommand man2 = new MySqlCommand(consulta4, con);
                MySqlCommand man3 = new MySqlCommand(consulta5, con);
                MySqlCommand man4 = new MySqlCommand(consulta6, con);
                MySqlCommand man5 = new MySqlCommand(consulta7, con);
                MySqlCommand man6 = new MySqlCommand(consulta8, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
               
                MessageBox.Show("Los datos han sido insertados exitosamente");
                while (re.Read())
                { }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actlz_emp_Click(object sender, EventArgs e)
        {
            try
            {
                string miconexion = ("server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
                string consulta2 = "update proyecto_laboratorio.EMPLEADO set genero='" + cbo_sexo_emp + "',nombre_emp='" + txt_nombre + "' , apellido_emp= '" + txt_apellido + "', fecha_nacimiento_emp= '" + txt_fecha_nacimiento + "', where pk_id_emp ='" + cbo_id_empleado + "';";
                MySqlConnection con = new MySqlConnection(miconexion);
                MySqlCommand man = new MySqlCommand(consulta2, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido actualizados exitosamente");
                while (re.Read())
                { }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_elim_emp_Click(object sender, EventArgs e)
        {
            try
            {
                string miconexion = ("server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
                string consulta3 = "DELETE from EMPLEADO where pk_id_emp ='" + cbo_id_empleado + "');";
                MySqlConnection con = new MySqlConnection(miconexion);
                MySqlCommand man = new MySqlCommand(consulta3, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido eliminados exitosamente");
                while (re.Read())
                { }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_act_emp_Load(object sender, EventArgs e)
        {

        }

        private void cbo_id_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_busc_emp_Click(object sender, EventArgs e)
        {
            ManipularDato.obtener_conexion();
            String Query = ("select E.nombre_emp, D.direccion, T.telefono,  C.correo_e, CA.nombre_cargo_emp, TI.nombre_titl_emp from empleado E, direccion D, telefono T, correo_e C, cargo_empleaco CA, titulo_empleado TI where nombre_emp like '%" + txt_busc_emp.Text + "%' and E.pk_id_emp = D.pk_id_emp and E.pk_id_emp = T.pk_id_emp and E.pk_id_emp = C.pk_id_emp and E.pk_id_emp = CA.pk_id_emp and E.pk_id_emp = TI.pk_id_emp");

            //ManipularDato.Busqueda(Query);

            GridViewActualizar(this.dgv_empleads, Query);


            ManipularDato.Desconectar();
        }
    }
}
