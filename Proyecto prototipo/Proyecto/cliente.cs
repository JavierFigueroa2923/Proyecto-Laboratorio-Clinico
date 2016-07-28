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
    public partial class cliente : Form
    {
        string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
        public cliente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {

            {
                try
                {
                   
                    String consulta = "insert into cliente values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text+"','"+1+"');";
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
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
               
            }
        }

        private void direccion_fiscal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            telefono_cliente tel = new telefono_cliente();
            tel.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            correo correo = new correo();
            correo.Show();
            this.Hide();
        }

        private void cliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inicio init = new inicio();
            init.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ubicacion ub = new ubicacion();
            ub.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            reporte_clientes c = new reporte_clientes();
            c.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new
            System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new
            System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            doc.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Panel pane = new Panel();
            Bitmap bmp2 = Properties.Resources.Grimpsa_FFCC_A_150602__3_;
            Image newImage = bmp2;
            Bitmap bmp = new 
 
            Bitmap(pane.Width, pane.Height,
            pane.CreateGraphics());
            pane.DrawToBitmap(bmp, new Rectangle(0, 0, pane.Width, pane.Height));
            RectangleF bounds =
                e.PageSettings.PrintableArea;
            float factor =
                ((float)bmp.Height /
                (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top,
                bounds.Width, factor *
                bounds.Width);




           


        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            

            

        }

        private void Nit_Click(object sender, EventArgs e)
        {

        }
    }
}
