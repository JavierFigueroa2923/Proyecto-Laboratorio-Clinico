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
    public partial class reporte_materiales : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;

        public reporte_materiales()
        {
            InitializeComponent();
        }

        private bool OpenConnection()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("No se Pudo Conectar, Contacte a los DBA");
                        break;
                    case 1045:
                        MessageBox.Show("usuario y contrasena incorrectos");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_reportes menu = new Menu_reportes();
            menu.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
            if (changes != null)
            {
                MySqlDataAdapter a = new MySqlDataAdapter();
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(a);
                a.UpdateCommand = mcb.GetUpdateCommand();
                a.Update(changes);
                ((DataTable)dataGridView1.DataSource).AcceptChanges();
            }


        }

        private void reporte_materiales_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "grimpsa";
            uid = "root";
            password = "";
            String cone;
            cone = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            conexion = new MySqlConnection(cone);
            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter a = new MySqlDataAdapter("SELECT * from material", conexion);
                DataSet DS = new DataSet();
                a.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta = "DELETE FROM MATERIAL where cod_material= '" + textBox2.Text + "';";
                MySqlConnection con = new MySqlConnection(Myconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Se ha eliminado el material exitosamente");
                this.Refresh();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";
            MySqlDataAdapter a = new MySqlDataAdapter("SELECT * from material", conexion);
            DataSet DS = new DataSet();
            a.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            this.CloseConnection();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";

                String consulta2 = "UPDATE grimpsa.material set costo= '" + this.textBox1.Text + "' where cod_material ='" + this.textBox3.Text + "';";
                MySqlConnection con2 = new MySqlConnection(Myconexion);
                MySqlCommand men = new MySqlCommand(consulta2, con2);
                MySqlDataReader ra;

                con2.Open();
                ra = men.ExecuteReader();
                MessageBox.Show("Se ha actualizado exitosamente");


                while (ra.Read())
                { }
                con2.Close();

                MySqlDataAdapter a = new MySqlDataAdapter("Select* from material", conexion);
                DataSet DS = new DataSet();
                a.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                this.CloseConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            material mat = new material();
            mat.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



