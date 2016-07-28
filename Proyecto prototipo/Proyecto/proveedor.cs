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
    public partial class proveedor : Form
    {
        public proveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta = "insert into proveedor values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+1+"');";
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
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telefono_proveedor tel = new telefono_proveedor();
            tel.Show();
            this.Hide();







        }

        private void button3_Click(object sender, EventArgs e)
        {
            correoproveedor correo = new correoproveedor();
            correo.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reporte_proveedores repo = new reporte_proveedores();
            repo.Show();
            this.Hide();
        }

        private void proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}