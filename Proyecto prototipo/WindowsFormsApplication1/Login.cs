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
using System.Web;
using System.Security.Cryptography;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Inicio_secion_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Ingrese datos validos por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string usuario = txt_user.Text;
                string pass = txt_pass.Text;
                MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");
                //MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=192.168.30.10; database=proyecto_laboratorio; uid=Otto; pwd=090113290;");

                MySqlCommand cmd = dbConn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(empleado.usuario) as conteo FROM empleado WHERE empleado.usuario='"+usuario+"' AND empleado.contrasenia = '"+pass+"'";

                try
                {
                    dbConn.Open();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro" + erro);
                    this.Close();
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int contadors = reader.GetInt32(0);

                }
                //MessageBox.Show("asdf "+reader.GetInt32(0), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int contador = reader.GetInt32(0);
                string us = "";
                string permisos = "";
                int id_empleado = 0;
                int cant_permisos = 0;
                
                if (contador == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrecta, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarCajaTexto();
                }
                else
                if(contador>0)
                {
                    MySql.Data.MySqlClient.MySqlConnection dbConn1 = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");
                    //MySql.Data.MySqlClient.MySqlConnection dbConn1 = new MySql.Data.MySqlClient.MySqlConnection("server=192.168.30.10; database=proyecto_laboratorio; uid=Otto; pwd=090113290;");
                    MySqlCommand cmd1 = dbConn1.CreateCommand();
                    cmd1.CommandText = "SELECT COUNT(permiso.pk_id_perm),empleado.usuario, empleado.pk_id_emp FROM cargo_empleado, empleado,permiso WHERE empleado.usuario='" + usuario + "' AND empleado.contrasenia = '" + pass + "' AND empleado.pk_id_emp = cargo_empleado.pk_id_emp AND permiso.pk_id_cargo_emp = cargo_empleado.pk_id_cargo_emp";
                            try
                            {
                                dbConn1.Open();
                            }
                            catch (Exception erro)
                            {
                                MessageBox.Show("Erro" + erro);
                                this.Close();
                            }

                            MySqlDataReader reader1 = cmd1.ExecuteReader();

                            while (reader1.Read())
                            {
                                cant_permisos = reader1.GetInt32(0);
                               

                            }
                            cant_permisos = reader1.GetInt32(0);
                            if (cant_permisos == 0)
                            {
                                MessageBox.Show("Su usuario no posee permisos, comuníquese con el administrador para solucionar este problema.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                LimpiarCajaTexto();
                            }
                            else
                            
                            if (cant_permisos > 0)
                            {
                                string a1 = reader1.GetString(1);
                                int b2 = reader1.GetInt32(2);
                                MessageBox.Show("Bienvenido " + a1, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MDIParent1 frm2 = new MDIParent1();
                                frm2.MiPropiedad = "Bienvenido " + a1;
                                frm2.MiIdUsuario = b2;
                                frm2.Show();
                                this.Hide();
                            }
                                
                            
                }
            }
        }
        public void LimpiarCajaTexto()
        {
            txt_user.Text = "";
            txt_pass.Text = "";
            
        }
        private void Bienvenido_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {

        }

    }
}
