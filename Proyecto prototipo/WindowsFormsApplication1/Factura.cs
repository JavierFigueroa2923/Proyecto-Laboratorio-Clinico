using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }
        public void LimpiarCajasTexto()
        {
            txt_id_clt.Text = "";
            txt_cliente.Text = "";
            txt_nit.Text = "";
            txt_direccion.Text = "";
            txt_fecha.Text = "";
            txt_id_fm_pg.Text = "";
        }

        public string obtenerIP()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        public void InhabilitarTexto()
        {
            txt_id_clt.Enabled = false;
            txt_cliente.Enabled = false;
            txt_nit.Enabled = false;
            txt_direccion.Enabled = false;
            txt_fecha.Enabled = false;
            txt_id_fm_pg.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_id_clt.Enabled = true;
            txt_cliente.Enabled = true;
            txt_nit.Enabled = true;
            txt_direccion.Enabled = true;
            txt_fecha.Enabled = true;
            txt_id_fm_pg.Enabled = true;
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
        }

        private void txt_nit_TextChanged(object sender, EventArgs e)
        {
            txt_nit.MaxLength = 9;
        }

        private void txt_id_clt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_id_clt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {

        }

        private void btn_elim_inv_sumin_Click(object sender, EventArgs e)
        {

        }
    }
}
