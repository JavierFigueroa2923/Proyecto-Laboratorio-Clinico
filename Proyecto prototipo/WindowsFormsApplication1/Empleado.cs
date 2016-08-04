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
                string miconexion = "server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
                string consulta = "insert into EMPLEADO values ('" + cbo_id_empleado + "','" + cbo_sexo_emp + "','" + txt_nombre + "','" + txt_apellido + "','" + txt_fecha_nacimiento + "');";
                MySqlConnection con = new MySqlConnection(miconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
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
                string miconexion = "server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
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
                string miconexion = "server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
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
    }
}
