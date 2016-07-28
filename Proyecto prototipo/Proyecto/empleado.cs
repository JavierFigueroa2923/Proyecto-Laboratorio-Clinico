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
    public partial class empleado : Form
    {
        public empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                    String consulta = "insert into  empleado values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text+ "','" + textBox4.Text+ "','"+ 1+"');";
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
                textBox4.Text = "";

            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            telefono_empleado telfone = new telefono_empleado();
            telfone.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            correo_empleado corrio = new correo_empleado();
            corrio.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporte_empleado er = new Reporte_empleado();
            er.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
