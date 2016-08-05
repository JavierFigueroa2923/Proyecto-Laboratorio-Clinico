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
    public partial class Bienvenido : Form
    {
        public Bienvenido()
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

                MySqlCommand cmd = dbConn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(usuario.usuario) as conteo, permiso.nombre_prm, usuario.usuario FROM usuario,permiso WHERE usuario='" + usuario + "' AND contrasena_usur = '" + pass + "'";

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
                if (contador > 0)
                {
                    permisos = reader.GetString(1);
                    us = reader.GetString(2);
                }



                switch (contador)
                {
                    case 0:
                        MessageBox.Show("Usuario o contraseña incorrecta, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarCajaTexto();
                        break;
                    case 1:
                        MessageBox.Show("Bienvenido " + us+ ", usted posee permisos de " + permisos, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MDIParent1 frm2 = new MDIParent1();
                        frm2.MiPropiedad = us;
                        frm2.Show();
                        this.Hide();
                        break;
                    default:
                        throw new InvalidOperationException("Error intentelo de nuevo");
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

    }
}
