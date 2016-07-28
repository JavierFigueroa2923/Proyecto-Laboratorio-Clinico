using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            presupuesto pres = new presupuesto();
            pres.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente c = new cliente();
            c.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proveedor d = new proveedor();
            d.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            empleado emp = new empleado();
            emp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu_reportes m = new Menu_reportes();
            m.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Reporte_empleado repo = new Reporte_empleado();
            repo.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reporte_proveedores repoo = new reporte_proveedores();
            repoo.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cliente cli = new cliente();
            cli.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ordenimpresion ord = new ordenimpresion();
            ord.Show();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            reporte_materiales rep = new reporte_materiales();
            rep.Show();
            this.Hide();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            material mate = new material();
            mate.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Menu_reportes mr = new Menu_reportes();
            mr.Show();
            this.Hide();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
