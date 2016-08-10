using MySql.Data.MySqlClient;
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
    public partial class frm_act_examenes : Form
    {
        public frm_act_examenes()
        {
            InitializeComponent();
        }
        string codigo = "";
        Boolean Editar;
        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || txt_direccion.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update tipo_examen set nombre_tp_exm = " + txt_nombre.Text + ", descripcion_tp_exm = " + txt_direccion.Text + " where pk_id_tp_exm = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    grid();
                    Conexionmysql.Desconectar();
                    Editar = false;
                    limipiar();
                }
                else
                {

                    try
                    {
                        String Query = "insert into tipo_examen(pk_id_tp_exm, nombre_tp_exm, descripcion_tp_exm)values(" + txt_id_xmn.Text + "," + txt_nombre.Text + ",'" + txt_direccion.Text + "');";
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, Conexionmysql.ObtenerConexion());
                        MySqlDataReader MyReader2;
                        Conexionmysql.ObtenerConexion();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Registro ingresado exitosamente");
                        Conexionmysql.Desconectar();
                        grid();
                        limipiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void frm_act_examenes_Load(object sender, EventArgs e)
        {
            grid();
        }
        private void grid()
        {
            string query = String.Format("SELECT * FROM {0}", "tipo_examen");
            Conexionmysql.ObtenerConexion();
            MySqlCommand command = new MySqlCommand(query, Conexionmysql.ObtenerConexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); adapter.Fill(data);
            dgv_vist_tips_exam.DataSource = data;
            Conexionmysql.Desconectar();
        }
        private void limipiar() {

            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_id_xmn.Text = "";
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            Editar = true;
            codigo = this.dgv_vist_tips_exam.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[0].Value.ToString();
            txt_direccion.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_busc_tip_exam_Click(object sender, EventArgs e)
        {
            if (txt_busc_tips_exam.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridMuestra(this.dgv_vist_tips_exam, "select * from tipo_examen where pk_id_tp_exm like '" + txt_busc_tips_exam.Text + "%';");
            }
        }
    }
}
