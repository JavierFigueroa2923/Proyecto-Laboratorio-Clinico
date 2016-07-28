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
    public partial class reporte_hoja_presupuesto : Form
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;
        public reporte_hoja_presupuesto()
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

        private void reporte_hoja_presupuesto_Load(object sender, EventArgs e)
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
                MySqlDataAdapter a = new MySqlDataAdapter("select * from hoja_de_presupuesto ", conexion);
                DataSet DS = new DataSet();
                a.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.Refresh();
                this.CloseConnection();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            especificaciones t = new especificaciones();
            t.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            especificaciones espe = new especificaciones();
            espe.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_reportes menu = new Menu_reportes();
            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}




