using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.Common;


namespace Proyecto
{
    public partial class reporte_clientes : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;
        public reporte_clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void reporte_clientes_Load(object sender, EventArgs e)
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
                MySqlDataAdapter a = new MySqlDataAdapter("SELECT  cliente.cod_cliente as codigo, nit, apellido, no_telefono , correo_electronico FROM cliente left JOIN telefono ON cliente.cod_cliente = telefono.cod_cliente left JOIN correo_electronico  ON telefono.cod_cliente = correo_electronico.cod_cliente ", conexion);
                DataSet DS = new DataSet();
                a.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.Refresh();
                this.CloseConnection();
            }
        }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_reportes me = new Menu_reportes();
            me.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio i = new inicio();
            i.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente c = new cliente();
            c.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta = "DELETE FROM CLIENTE where COD_CLIENTE= '" + textBox1.Text + "';";
                MySqlConnection con = new MySqlConnection(Myconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Se ha eliminado el cliente exitosamente");
                this.Refresh();
               
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = "";
            MySqlDataAdapter a = new MySqlDataAdapter("SELECT  cliente.cod_cliente as código, nit, apellido, no_telefono , correo_electronico FROM cliente left JOIN telefono ON cliente.cod_cliente = telefono.cod_cliente left JOIN correo_electronico  ON telefono.cod_cliente = correo_electronico.cod_cliente ", conexion);
            DataSet DS = new DataSet();
            a.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            this.Refresh();
            this.CloseConnection();
           

        }

      
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
