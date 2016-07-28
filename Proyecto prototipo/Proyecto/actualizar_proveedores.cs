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
    public partial class actualizar_proveedores : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;
        public actualizar_proveedores()
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
                        MessageBox.Show("No se Pudo Conectar, Contacte a los DBA(Cristobal O Gabriela)");
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

        }

        private void actualizar_proveedores_Load(object sender, EventArgs e)
        {
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
                  
                   
                    MySqlDataAdapter a = new MySqlDataAdapter("SELECT proveedor.cod_proveedor AS codigo, nombre, direccion, no_telefono, correo_electronico FROM proveedor LEFT JOIN telefono ON proveedor.cod_proveedor = telefono.cod_proveedor LEFT JOIN correo_electronico ON telefono.cod_proveedor = correo_electronico.cod_proveedor ", conexion);
                    DataSet DS = new DataSet();
                    a.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];

                    
                    this.CloseConnection();
                    
                  

                }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";

                String consulta2 = "UPDATE grimpsa.telefono set no_telefono= '" + this.textBox3.Text + "' where cod_proveedor ='" + this.textBox1.Text + "';";
                MySqlConnection con2 = new MySqlConnection(Myconexion);
                MySqlCommand men = new MySqlCommand(consulta2, con2);
                MySqlDataReader ra;

                con2.Open();
                ra = men.ExecuteReader();
                MessageBox.Show("Se ha actualizado exitosamente");


                while (ra.Read())
                { }
                con2.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox3.Text = ""; textBox1.Text = "";
                    MySqlDataAdapter a = new MySqlDataAdapter("SELECT proveedor.cod_proveedor AS codigo, nombre, direccion, no_telefono, correo_electronico FROM proveedor LEFT JOIN telefono ON proveedor.cod_proveedor = telefono.cod_proveedor LEFT JOIN correo_electronico ON telefono.cod_proveedor = correo_electronico.cod_proveedor ", conexion);
                    DataSet DS = new DataSet();
                    a.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];
                    this.OpenConnection();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";

                String consulta3 = "UPDATE grimpsa.correo_electronico set correo_electronico= '" + this.textBox4.Text + "' where cod_proveedor ='" + this.textBox1.Text + "';";
                MySqlConnection con3 = new MySqlConnection(Myconexion);
                MySqlCommand min = new MySqlCommand(consulta3, con3);


                MySqlDataReader ri;




                con3.Open();
                ri = min.ExecuteReader();
                MessageBox.Show("Se ha actualizado exitosamente");


                while (ri.Read())
                { }
                con3.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox4.Text = "";
            textBox1.Text = "";
            MySqlDataAdapter a = new MySqlDataAdapter("SELECT proveedor.cod_proveedor AS codigo, nombre, direccion, no_telefono, correo_electronico FROM proveedor LEFT JOIN telefono ON proveedor.cod_proveedor = telefono.cod_proveedor LEFT JOIN correo_electronico ON telefono.cod_proveedor = correo_electronico.cod_proveedor ", conexion);
            DataSet DS = new DataSet();
            a.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            this.OpenConnection();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            reporte_proveedores provee = new reporte_proveedores();
            provee.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
