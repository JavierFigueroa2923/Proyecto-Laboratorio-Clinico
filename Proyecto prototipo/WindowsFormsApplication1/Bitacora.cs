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
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
        }

        private void txt_busc_usuario_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaBitacora(this.dgv_bitacora, "select pk_bitc as Identificador, fecha_accion_bitc as Fecha, accion_bitc as Accion, usuario_conn_bitc as Usuario_Conectado, ip_usuario_bitc as IP, tabla_modif_bitc as Tabla, id_usuario_activo as Usuario_Activo from bitacora_de_control where id_usuario_activo like '" + txt_busc_usuario.Text + "%';");
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            btn_acept_bitacora.Enabled = false;
            btn_actlz_bitacora.Enabled = false;
            btn_cancl_bitacora.Enabled = false;
            btn_elim_bitacora.Enabled = false;
            btn_guardar_bitacora.Enabled = false;
            btn_nuevo_bitacora.Enabled = false;
            cl_gridysql.ActualizarGridBusquedaBitacora(this.dgv_bitacora, "select pk_bitc as Identificador, fecha_accion_bitc as Fecha, accion_bitc as Accion, usuario_conn_bitc as Usuario_Conectado, ip_usuario_bitc as IP, tabla_modif_bitc as Tabla, id_usuario_activo as Usuario_Activo from bitacora_de_control;");
        }

        private void btn_buscar_bitacora_Click(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaBitacora(this.dgv_bitacora, "select pk_bitc as Identificador, fecha_accion_bitc as Fecha, accion_bitc as Accion, usuario_conn_bitc as Usuario_Conectado, ip_usuario_bitc as IP, tabla_modif_bitc as Tabla, id_usuario_activo as Usuario_Activo from bitacora_de_control where id_usuario_activo like '" + txt_busc_usuario.Text + "%' and accion_bitc like '" + txt_accion_bitacora.Text + "%'; ");
            txt_busc_usuario.Text = "";
            txt_accion_bitacora.Text = "";
        }

        private void txt_accion_bitacora_KeyUp(object sender, KeyEventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaBitacora(this.dgv_bitacora, "select pk_bitc as Identificador, fecha_accion_bitc as Fecha, accion_bitc as Accion, usuario_conn_bitc as Usuario_Conectado, ip_usuario_bitc as IP, tabla_modif_bitc as Tabla, id_usuario_activo as Usuario_Activo from bitacora_de_control where accion_bitc like '" + txt_accion_bitacora.Text + "%';");
        }

        private void btn_act_bitacora_Click(object sender, EventArgs e)
        {
            cl_gridysql.ActualizarGridBusquedaBitacora(this.dgv_bitacora, "select pk_bitc as Identificador, fecha_accion_bitc as Fecha, accion_bitc as Accion, usuario_conn_bitc as Usuario_Conectado, ip_usuario_bitc as IP, tabla_modif_bitc as Tabla, id_usuario_activo as Usuario_Activo from bitacora_de_control;");
        }
    }
}
