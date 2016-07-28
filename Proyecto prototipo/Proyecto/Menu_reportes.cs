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
    public partial class Menu_reportes : Form
    {
        public Menu_reportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reporte_clientes re = new reporte_clientes();
            re.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reporte_empleado em = new Reporte_empleado();
            em.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reporte_materiales repor = new reporte_materiales();
            repor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reporte_proveedores reporte = new reporte_proveedores();
            reporte.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reporte_hoja_presupuesto hoja = new reporte_hoja_presupuesto();
            hoja.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reporte_factura factura = new reporte_factura();
            factura.Show();
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }

        }


















