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
    public partial class correoproveedor : Form
    {
        public correoproveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta = "insert into correo_electronico(cod_proveedor,correo_electronico) values ('" + textBox1.Text + "','" + textBox2.Text + "');";
                MySqlConnection con = new MySqlConnection(Myconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Se han insertado exitosamente");
                while (re.Read())
                { }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proveedor prove = new proveedor();
            prove.Show();
            this.Hide();
        }
    }
}