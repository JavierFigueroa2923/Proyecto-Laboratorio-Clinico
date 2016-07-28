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
    public partial class Reporte_empleado : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;
        public Reporte_empleado()
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

        private void Reporte_empleado_Load(object sender, EventArgs e)
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
                MySqlDataAdapter a = new MySqlDataAdapter("SELECT empleado.cod_empleado AS codigo, nombre, apellido, direccion, correo_electronico, no_telefono FROM empleado LEFT JOIN correo_electronico ON empleado.cod_empleado = correo_electronico.cod_empleado LEFT JOIN telefono ON correo_electronico.cod_empleado = telefono.cod_empleado WHERE correo_electronico.cod_empleado BETWEEN 500  AND 599 ", conexion);
                DataSet DS = new DataSet();
                a.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.CloseConnection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_reportes m = new Menu_reportes();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio n = new inicio();
            n.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            empleado ee = new empleado();
            ee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta = "DELETE FROM empleado where COD_EMPLEADO= '" + textBox1.Text + "';";
                MySqlConnection con = new MySqlConnection(Myconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Se ha eliminado el empleado exitosamente");
                this.Refresh();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";

            MySqlDataAdapter a = new MySqlDataAdapter("SELECT empleado.cod_empleado AS codigo, nombre, apellido, direccion, correo_electronico, no_telefono FROM empleado LEFT JOIN correo_electronico ON empleado.cod_empleado = correo_electronico.cod_empleado LEFT JOIN telefono ON correo_electronico.cod_empleado = telefono.cod_empleado WHERE correo_electronico.cod_empleado BETWEEN 500 AND 599 ", conexion);
            DataSet DS = new DataSet();
            a.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            this.CloseConnection();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
