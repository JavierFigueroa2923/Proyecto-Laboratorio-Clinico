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
    public partial class reporte_proveedores : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;


        public reporte_proveedores()
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

        private void reporte_proveedores_Load(object sender, EventArgs e)
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
                    MySqlDataAdapter a = new MySqlDataAdapter("SELECT proveedor.cod_proveedor AS codigo, nombre, direccion, no_telefono, correo_electronico FROM proveedor left JOIN telefono ON proveedor.cod_proveedor = telefono.cod_proveedor left JOIN correo_electronico ON telefono.cod_proveedor = correo_electronico.cod_proveedor", conexion);
                    DataSet DS = new DataSet();
                    a.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    this.CloseConnection();
                }

            
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

        private void button2_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proveedor provee = new proveedor();
            provee.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta = "DELETE FROM PROVEEDOR where COD_PROVEEDOR= '" + textBox1.Text + "';";
                MySqlConnection con = new MySqlConnection(Myconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Se ha eliminado el proveedor exitosamente");


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";
            MySqlDataAdapter a = new MySqlDataAdapter("SELECT proveedor.cod_proveedor AS codigo, nombre, direccion, no_telefono, correo_electronico FROM proveedor left JOIN telefono ON proveedor.cod_proveedor = telefono.cod_proveedor left JOIN correo_electronico ON telefono.cod_proveedor = correo_electronico.cod_proveedor", conexion);
            DataSet DS = new DataSet();
            a.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            this.CloseConnection();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            actualizar_proveedores ap = new actualizar_proveedores();
            ap.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

