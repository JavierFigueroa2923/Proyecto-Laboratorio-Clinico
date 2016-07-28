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
    public partial class reporte_factura : Form
    {
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;
        public reporte_factura()
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

        private void reporte_factura_Load(object sender, EventArgs e)
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
                MySqlDataAdapter a = new MySqlDataAdapter("SELECT factura.cod_factura AS NO_FACTURA, fecha AS FECHA, nombre AS NOMBRE, direccion AS DIRECCION, nit AS NIT, vendedor AS VENDEDOR, condiciones_de_venta AS CONDICIONES, valor AS VALOR, descripcion AS DESCRIPCION, total AS TOTAL, cantidad AS CANTIDAD FROM factura LEFT JOIN detalle_factura ON factura.cod_factura = detalle_factura.cod_factura", conexion);
                DataSet DS = new DataSet();
                a.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.Refresh();
                this.CloseConnection();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta = "DELETE FROM factura  where cod_factura= '" + textBox2.Text + "';";
                MySqlConnection con = new MySqlConnection(Myconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Se ha eliminado la factura  exitosamente");
                this.Refresh();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox2.Text = "";
            MySqlDataAdapter a = new MySqlDataAdapter("SELECT factura.cod_factura AS NO_FACTURA, fecha AS FECHA, nombre AS NOMBRE, direccion AS DIRECCION, nit AS NIT, vendedor AS VENDEDOR, condiciones_de_venta AS CONDICIONES, valor AS VALOR, descripcion AS DESCRIPCION, total AS TOTAL, cantidad AS CANTIDAD FROM factura LEFT JOIN detalle_factura ON factura.cod_factura = detalle_factura.cod_factura ", conexion);
            DataSet DS = new DataSet();
            a.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
            this.Refresh();
            this.CloseConnection();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_reportes rep = new Menu_reportes();
            rep.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            material mate = new material();
            mate.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

