using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        Conexionmysql ManipularDato = new Conexionmysql();
        String Codigo;
        Boolean Editar;

        private void Lbl_fecha_cita_Click(object sender, EventArgs e)
        {

        }

        private void txt_fecha_cita_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpb_vista_cita_Enter(object sender, EventArgs e)
        {

        }

        private void btn_guardar_cita_Click(object sender, EventArgs e)
        {
           
        }
    }
}
