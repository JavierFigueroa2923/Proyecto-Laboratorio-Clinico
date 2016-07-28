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
namespace Proyecto
{
    public partial class login : Form
    {
        private String conn;
        private MySqlConnection connect;


        public login()
        {
            InitializeComponent();
        }

        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;database=grimpsa;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;

            }
        }

        private bool validate_login(string user, string contraseña)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = " Select * from usuario where usuario=@user and contraseña=@contraseña";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Estan vacios los campos, llenelos ");
                return;
            }

            bool r = validate_login(user, pass);
            if (r)
            {

                
                inicio ini = new inicio();
                ini.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos");
            }

            textBox1.Text = "";
            textBox2.Text = "";









        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String user = textBox1.Text;
                String pass = textBox2.Text;
                if (user == "" || pass == "")
                {
                    MessageBox.Show("Estan vacios los campos, llenelos ");
                    return;
                }

                bool r = validate_login(user, pass);
                if (r)
                {


                    inicio ini = new inicio();
                    ini.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                }

                textBox1.Text = "";
                textBox2.Text = "";



            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}



