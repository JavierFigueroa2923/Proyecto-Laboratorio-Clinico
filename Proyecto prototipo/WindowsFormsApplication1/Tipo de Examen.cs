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
        String tipos_de_examenes = "select pk_id_tp_exm as ID, nombre_tp_exm as Nombre, descripcion_tp_exm as Descripcion from tipo_examen";
        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCajasTexto()
        {
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
        }


        public void InhabilitarTexto()
        {
            txt_nombre.Enabled = false;
            txt_descripcion.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_nombre.Enabled = true;
            txt_descripcion.Enabled = true;
        }

        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "tipo_examen");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "tipo_examen";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || txt_descripcion.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update tipo_examen set nombre_tp_exm = " + txt_nombre.Text + ", descripcion_tp_exm = " + txt_descripcion.Text + " where pk_id_tp_exm = " + NumVal + ";";
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
                        Conexionmysql.ObtenerConexion();
                        String Query1 = "INSERT INTO tipo_examen(nombre_tp_exm, descripcion_tp_exm) values('"+ txt_nombre.Text + "','" + txt_descripcion.Text + "');";
                        cl_gridysql.EjecutarMySql(Query1);

                            ActualizarGrid(this.dgv_vist_tips_exam, tipos_de_examenes);
                            this.LimpiarCajasTexto();
                            Conexionmysql.Desconectar();
                            MessageBox.Show("Operación Realizada Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch
                   {
                        MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            InhabilitarTexto();
        }

        private void frm_act_examenes_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
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
            txt_descripcion.Text = "";
            
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            Editar = true;
            codigo = this.dgv_vist_tips_exam.CurrentRow.Cells[0].Value.ToString();
            txt_nombre.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[0].Value.ToString();
            txt_descripcion.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[2].Value.ToString();
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

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            Editar = false;
            LimpiarCajasTexto();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }
    }
}
