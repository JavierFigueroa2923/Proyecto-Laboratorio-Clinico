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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pre1, pre2, pre3, pre4;
            pre1 = Convert.ToDouble(valor1.Text);
            pre2 = Convert.ToDouble(valor2.Text);
            pre3 = Convert.ToDouble(valor3.Text);
            pre4 = Convert.ToDouble(valor4.Text);

            double suma = pre1 + pre2 + pre3 + pre4;
            Total.Text = suma.ToString();
        }

        private void FECHA_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void nit_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string valo = valor1.Text + ',' + valor2.Text + ',' + valor3.Text + ',' + valor4.Text;
                valo = valo.ToString();
                string conce = concepto1.Text + ',' + concepto2.Text + concepto3.Text + ',' + concepto4.Text;
                conce = conce.ToString();
                string canti = cantidad1.Text + ',' + cantidad2.Text + ',' +cantidad3.Text + ',' + cantidad4.Text;
                canti = canti.ToString();

                string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                String consulta1 = "insert into grimpsa.detalle_factura values ('"+valo+"','" + conce +"','" + Total.Text +  "','" + total_en_letras.Text + "','" + canti + "','" + observaciones.Text + "','"+12+ "','"+factura.Text+"');";
                String consulta = "insert into factura values('" + factura.Text + "','" + FECHA.Text + "','" + nombre.Text + "','" + direccion.Text + "','" + nit.Text + "','" + vendedor.Text + "','" + condicion.Text +"','"+ "');";
                MySqlConnection con1 = new MySqlConnection(Myconexion);
                MySqlConnection con2 = new MySqlConnection(Myconexion);
                MySqlCommand mun1 = new MySqlCommand(consulta1, con1);
                MySqlCommand mpn2 = new MySqlCommand(consulta, con2);
                MySqlDataReader ka1;
                MySqlDataReader ke1;

                con2.Open();
                ka1 = mpn2.ExecuteReader();
                while (ka1.Read())
                { }

                con1.Open();
                ke1= mun1.ExecuteReader();
                MessageBox.Show("Se han insertado exitosamente");
                while (ke1.Read())
                { }
                con1.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            valor1.Text = "0"; valor2.Text = "0"; valor3.Text = "0"; valor4.Text = "0";
            concepto1.Text = ""; concepto2.Text = ""; concepto3.Text = ""; concepto4.Text = "";
            cantidad1.Text = ""; cantidad2.Text = ""; cantidad3.Text = ""; cantidad4.Text = "";
            total_en_letras.Text = ""; Total.Text = ""; condicion.Text = ""; factura.Text = "";
            vendedor.Text = ""; nit.Text = ""; nombre.Text = ""; FECHA.Text = ""; direccion.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

    

        
        private void total_en_letras_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            // printForm1.PrinterSettings.PrintRange.CompareTo(System.Drawing.Printing.panel1);
            // printForm1.PrintAction = System.Drawing.Printing.PrintDocument.Equals.panel1;
            //printDocument1.Print();

            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

        }
    }
}
