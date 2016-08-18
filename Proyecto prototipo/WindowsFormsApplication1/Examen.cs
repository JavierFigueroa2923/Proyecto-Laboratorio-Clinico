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
    public partial class frm_examen : Form
    {
        public frm_examen()
        {
            InitializeComponent();
        }
        string codigo = "";
        Boolean Editar;
        String tipos_de_examenes = "select pk_id_exm as ID, fecha_realizacion_exm as Fecha, observacion as Observaciones, pk_id_tp_exm as Id_tipo_examen,pk_id_clt as Id_cliente from examen";

        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        public void LimpiarCajasTexto()
        {
           
            txt_descripcion.Text = "";
        }


        public void InhabilitarTexto()
        {
            dtp.Enabled = false;
            cbo_cliente.Enabled = false;
            cbo_tp_exm.Enabled = false;
            txt_descripcion.Enabled = false;
        }

        public void HabilitarTexto()
        {
            dtp.Enabled = true;
            cbo_tp_exm.Enabled = true;
            cbo_cliente.Enabled = true;
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
            MiDataAdapter.Fill(MiDataSet, "examen");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "examen";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            if (cbo_cliente.SelectedValue == "" || cbo_tp_exm.SelectedValue == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    string theDate = dtp.Value.ToString("yyyy-MM-dd");
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update examen set fecha_realizacion_exm = '" + theDate + "', observacion = '" + txt_descripcion.Text + "', pk_id_tp_exm = " + cbo_tp_exm.SelectedIndex + ", pk_id_clt = " + cbo_cliente.SelectedIndex + " where pk_id_exm = " + NumVal + ";";
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
                        string theDate = dtp.Value.ToString("yyyy-MM-dd");
                        Conexionmysql.ObtenerConexion();
                        String Query1 = "INSERT INTO examen(fecha_realizacion_exm, observacion, pk_id_tp_exm, pk_id_clt) values('" + theDate + "','" + txt_descripcion.Text + "', " + cbo_tp_exm.SelectedValue + ", "+ cbo_cliente.SelectedValue +");";
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
            string query = String.Format("SELECT pk_id_exm as ID, fecha_realizacion_exm as Fecha, observacion as Observaciones, pk_id_tp_exm as Id_tipo_examen, pk_id_clt as Id_Cliente FROM {0}", "examen");
            Conexionmysql.ObtenerConexion();
            MySqlCommand command = new MySqlCommand(query, Conexionmysql.ObtenerConexion());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); adapter.Fill(data);
            dgv_vist_tips_exam.DataSource = data;
            Conexionmysql.Desconectar();
        }
        private void limipiar() {

            cbo_cliente.Text = "";
            cbo_tp_exm.Text = "";
            txt_descripcion.Text = "";
            
        }

        public void llenarCboIdCliente()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select DISTINCT pk_id_clt, nombre_clt, apellido_clt, nit from Cliente";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "cliente");
            cbo_cliente.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_cliente.ValueMember = ("pk_id_clt");
            //se indica el valor a desplegar en el combobox
            string cb = "nombre_clt, nombre_clt";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_clt"] = dr["nombre_clt"].ToString();

            }
            cbo_cliente.DataSource = dt;


            cbo_cliente.DisplayMember = "nombre_clt";
        }

        public void llenarCboIdTExamen()
        {
            //se realiza la conexión a la base de datos
            Conexionmysql.ObtenerConexion();
            //se inicia un DataSet
            DataSet ds = new DataSet();
            //se indica la consulta en sql
            String Query = "select DISTINCT pk_id_tp_exm, nombre_tp_exm, descripcion_tp_exm, precio_tp_exm from tipo_examen";
            MySqlDataAdapter dad = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //se indica con quu tabla se llena
            dad.Fill(ds, "tipo_examen");
            cbo_tp_exm.DataSource = ds.Tables[0].DefaultView;
            //indicamos el valor de los miembros
            cbo_tp_exm.ValueMember = ("pk_id_tp_exm");
            //se indica el valor a desplegar en el combobox
            string cb = "pk_id_tp_exm, pk_id_tp_exm";

            DataTable dt = ds.Tables[0];
            dt.Columns.Add("NewColumn", typeof(string));

            foreach (DataRow dr in dt.Rows)
            {
                dr["nombre_tp_exm"] = dr["pk_id_tp_exm"].ToString() + " " + dr["nombre_tp_exm"].ToString() + " " + dr["precio_tp_exm"].ToString();

            }
            cbo_tp_exm.DataSource = dt;


            cbo_tp_exm.DisplayMember = "nombre_tp_exm";
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            Editar = true;
            codigo = this.dgv_vist_tips_exam.CurrentRow.Cells[0].Value.ToString();
            dtp.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[1].Value.ToString();
            txt_descripcion.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[2].Value.ToString();
            cbo_tp_exm.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[3].Value.ToString();
            cbo_cliente.Text = this.dgv_vist_tips_exam.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_busc_tip_exam_Click(object sender, EventArgs e)
        {
            if (txt_busc_tips_exam.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridMuestra(this.dgv_vist_tips_exam, "select * from examen where pk_id_exm like '" + txt_busc_tips_exam.Text + "%';");
            }
        }

        private void btn_nuevo_pcnt_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            llenarCboIdCliente();
            llenarCboIdTExamen();
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            Editar = false;
            LimpiarCajasTexto();
            InhabilitarTexto();
            btn_cancl.Enabled = false;
        }

        private void btn_elim_pcnt_Click(object sender, EventArgs e)
        {
            codigo = this.dgv_vist_tips_exam.CurrentRow.Cells[0].Value.ToString();
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
                    String Query = "delete from examen where pk_id_exm = " + NumVal + ";";
                    //ejecutar query
                    cl_gridysql.EjecutarMySql(Query);
                    //Actualize la grid
                    //cl_gridysql.ActualizarGridUsuario(this.dgv_vist_tips_exam, "select pk_id_usur as Identificador, pk_id_perm as Permiso, usuario as Usuario, contrasenia_usur as contrasenia, pk_id_emp as id_empleado, pk_id_lab as id_laboratorio from usuario;");
                    //desconectamos de la base de datos
                    grid();
                    Conexionmysql.Desconectar();
                }
                else
                {
                    //no pasa nada
                    return;
                }
            }
            LimpiarCajasTexto();
        }
    }
}
