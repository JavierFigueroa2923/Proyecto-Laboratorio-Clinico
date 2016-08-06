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
    public partial class Cargo_Empleado : Form
    {
        public Cargo_Empleado()
        {
            InitializeComponent();
        }

        string codigo = "";
        Boolean Editar;
        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void cbo_titl_emp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pl_lab_cargo_emp_Click(object sender, EventArgs e)
        {

        }

        private void Cargo_Empleado_Load(object sender, EventArgs e)
        {
            grid_cargos();
            grid_empleados();
            grid_labs();
        }
        private void grid_empleados()
        {
            string config = "server=localhost; database=proyecto_laboratorio; uid=root; pwd=;";
            string query = String.Format("SELECT * FROM {0}", "empleado");
            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open(); MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); adapter.Fill(data);
            dgv_emps_cargo_emp.DataSource = data;

        }
        private void grid_labs()
        {
            string config = "server=localhost; database=proyecto_laboratorio; uid=root; pwd=;";
            string query = String.Format("SELECT * FROM {0}", "laboratorio");
            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open(); MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); adapter.Fill(data);
            dgv_labs_cargo_emp.DataSource = data;

        }
        private void grid_cargos()
        {
            string config = "server=localhost; database=proyecto_laboratorio; uid=root; pwd=;";
            string query = String.Format("SELECT * FROM {0}", "cargo_emleado");
            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open(); MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); adapter.Fill(data);
            dgv_cargo_emp.DataSource = data;

        }

        private void btn_guardar_cargo_emp_Click(object sender, EventArgs e)
        {
            if (txt_nombre_cargo_emp.Text == "" || txt_descp_cargo_emp.Text == "" || txt_fecha_contrat_cargo_emp.Text == "" || txt_id_emp_cargo_emp.Text == "" || txt_dpi.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update cargo_emleado set pk_id_emp = " + txt_id_emp_cargo_emp.Text + ", pk_id_lab = '" + txt_dpi.Text + "', nombre_cargo_emp = " + txt_nombre_cargo_emp.Text + ", descripcion_cargo_emp = " + txt_descp_cargo_emp.Text + ", fecha_contratacion = " + txt_fecha_contrat_cargo_emp.Text + " where pk_id_cargo_emp = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    grid_cargos();
                    grid_empleados();
                    grid_labs();
                    Conexionmysql.ObtenerConexion();
                    Editar = false;
                    limpiar();
                }
                else
                {

                    try
                    {
                        string MyConnection2 = "server=localhost; database=proyecto_laboratorio; uid=root; pwd=;";
                        String Query = "insert into cargo_emleado(pk_id_cargo_emp, pk_id_emp, pk_id_lab, nombre_cargo_emp, descripcion_cargo_emp, fecha_contratacion)values(" + txt_id_cargo_emp.Text + "," + txt_id_emp_cargo_emp.Text + "," + txt_dpi.Text + ",'" + txt_nombre_cargo_emp.Text + "','" + txt_descp_cargo_emp.Text + "','" + txt_fecha_contrat_cargo_emp.Text + "');";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Registro ingresado exitosamente");
                        MyConn2.Close();
                        grid_cargos();
                        limpiar();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btn_actlz_cargo_emp_Click(object sender, EventArgs e)
        {
            Editar = true;
            codigo = this.dgv_cargo_emp.CurrentRow.Cells[0].Value.ToString();
            txt_nombre_cargo_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[3].Value.ToString();
            txt_descp_cargo_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[4].Value.ToString();
            txt_fecha_contrat_cargo_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[5].Value.ToString();
            txt_id_emp_cargo_emp.Text = this.dgv_cargo_emp.CurrentRow.Cells[1].Value.ToString();
            txt_dpi.Text = this.dgv_cargo_emp.CurrentRow.Cells[2].Value.ToString();
            
        }
        private void limpiar() {
            txt_id_cargo_emp.Text = "";
            txt_nombre_cargo_emp.Text = "";
            txt_descp_cargo_emp.Text = "";
            txt_fecha_contrat_cargo_emp.Text = "";
            txt_id_emp_cargo_emp.Text = "";
            txt_dpi.Text = "";
        }

        private void btn_elim_cargo_emp_Click(object sender, EventArgs e)
        {
            codigo = this.dgv_cargo_emp.CurrentRow.Cells[0].Value.ToString();
            if (codigo == "")
            {
                MessageBox.Show("No se ha seleccionado nada para realizar la eliminacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //preguntamos al usuario si desea eliminar el registro por completo
                var resultado = MessageBox.Show("¿Realmente desea eliminar el registro?", "confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Proceder a evaluar el resultado
                if (resultado == DialogResult.Yes)//si el usuario hizo click en el boton yes
                {
                    //procedo a hacer el borrado
                    //me conecto a la base de datos
                    Conexionmysql.ObtenerConexion();
                    //armar query...
                    int NumVal = Int32.Parse(codigo);
                    String Query = "delete from cargo_emleado where pk_id_cargo_emp = " + NumVal + ";";
                    //ejecutar query
                    cl_gridysql.EjecutarMySql(Query);
                    grid_cargos();
                    limpiar();
                    //desconectamos de la base de datos
                    Conexionmysql.Desconectar();
                }
                else
                {
                    //no pasa nada
                    return;
                }
            }
        }

        private void btn_busc_cargo_emp_Click(object sender, EventArgs e)
        {
            if (txt_busc_cargo_emp.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridMuestra(this.dgv_cargo_emp, "select * from cargo_emleado where pk_id_cargo_emp like '" + txt_busc_cargo_emp.Text + "%';");
            }
        }

        private void btn_rnv_cargo_emp_Click(object sender, EventArgs e)
        {
            grid_cargos();
        }
    }
}
