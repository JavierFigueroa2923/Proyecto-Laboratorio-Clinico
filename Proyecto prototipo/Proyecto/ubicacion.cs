using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class ubicacion : Form
    {
        public ubicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                    String consulta = "insert into  direccion(cod_cliente,direcion_entrega,direccion_fiscal) values ('" + cliente.Text + "','" + textBox2.Text + "','"+textBox3.Text+"');";
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
                cliente.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente c = new cliente();
            c.Show();
            this.Hide();
        }
    }
}
