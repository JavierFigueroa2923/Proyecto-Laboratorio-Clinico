using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.PowerPacks.Printing;
using Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6;

namespace Proyecto
{

  

    public partial class ordenimpresion : Form
    {
        private string text;
        private object brushes;

        public ordenimpresion()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {
            printForm1.PrinterSettings.DefaultPageSettings.Landscape = true;
            printForm1.PrintAction = PrintAction.PrintToPreview;
                       
            printForm1.Print();

      
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ordenimpresion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
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
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

      

        class ByVal
        {
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
