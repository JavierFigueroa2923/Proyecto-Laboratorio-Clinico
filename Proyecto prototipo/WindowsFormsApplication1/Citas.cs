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
            try
            {
                if (txt_hora_cita.Text == "" || dtp_fecha.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String query2 = "UPDATE resultado_examen SET descripcion_result_exm='" + txt_descripcion.Text + "' WHERE pk_id_result_exm='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_vista_cita, "SELECT * FROM cita");
                        Editar = false;
                        dtp_fecha.Enabled = true;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        string fecha = dtp_fecha.Value.ToString("yyyy-MM-dd");
                        DateTime fecha2 = Convert.ToDateTime(fecha).Date;
                        if (fecha2 < DateTime.Now.Date)
                        {
                            String Query = "INSERT INTO cita (fecha_cita,hora_cita,pk_id_lab,pk_id_ctl) VALUES ('" + fecha + "','" + txt_descripcion.Text + "','" + Convert.ToDouble(txt_id_exm.Text) + "') ";
                            cl_gridysql.EjecutarMySql(Query);
                            ActualizarGrid(this.dgv_vista_cita, "select * from cita;");
                            this.LimpiarCajasTexto();
                            Conexionmysql.Desconectar();
                        }
                        else
                        {
                            MessageBox.Show("error fecha ..", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
