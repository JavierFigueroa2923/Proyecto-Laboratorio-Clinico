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
    public partial class especificaciones : Form
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection conexion;
        public especificaciones()
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

        private void button4_Click(object sender, EventArgs e)
        {
            reporte_hoja_presupuesto j = new reporte_hoja_presupuesto();
            j.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tipografica_Load(object sender, EventArgs e)
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
                MySqlDataAdapter a = new MySqlDataAdapter("SELECT impresion.tipo AS IMPRESION, impresion.precio AS PRECIO, pre_prensa.tipo AS PRE_PRENSA, pre_prensa.precio AS PRECIO , encuadernacion.tipo as ENCUADERNACION , encuadernacion.precio as PRECIO , tipografia.tipo as TIPOGRAFIA, tipografia.precio as PRECIO , acabado.tipo as ACABADO, acabado.precio AS PRECIO ,tipo_de_papel.tipo as TIPO_PAPEL , tipo_de_papel.precio as PRECIO , corte.tipo AS CORTE, corte.precio AS PRECIO , otro.tipo as OTRO , otro.precio as PRECIO FROM impresion LEFT JOIN pre_prensa ON impresion.cod_presupuesto = pre_prensa.cod_presupuesto  LEFT JOIN encuadernacion ON pre_prensa.cod_presupuesto = encuadernacion.cod_presupuesto LEFT JOIN tipografia ON encuadernacion.cod_presupuesto = tipografia.cod_presupuesto LEFT JOIN acabado ON tipografia.cod_presupuesto = acabado.cod_presupuesto LEFT JOIN tipo_de_papel ON acabado.cod_presupuesto  = tipo_de_papel.cod_presupuesto  LEFT JOIN corte ON tipo_de_papel.cod_presupuesto = corte.cod_presupuesto LEFT JOIN otro ON corte.cod_presupuesto = otro.cod_presupuesto", conexion);
                DataSet DS = new DataSet();
                a.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_reportes repo = new Menu_reportes();
            repo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }
    }
}
