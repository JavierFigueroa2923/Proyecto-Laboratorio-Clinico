using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Titulo_de_empleado : Form
    {
        public Titulo_de_empleado()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion manipular = new BDconexion();
        String Codigo;
        Boolean Editar;
        public void LimpiarCajasTexto()
        {
            cbo_buscar.Text = "";
            txt_id_emp.Text = "";
            txt_id_lab.Text = "";
            //txt_id_titulo_emp.Text = "";
            txt_nom_titulo.Text = "";
            txt_decrip_titulo_emp.Text = "";

        }

        public void InhabilitarTexto()
        {
            txt_id_emp.Enabled = false;
            txt_id_lab.Enabled = false;
            txt_nom_titulo.Enabled = false;
            dtp_fecha_title.Enabled = false;
            txt_decrip_titulo_emp.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_id_emp.Enabled = true;
            txt_id_lab.Enabled = true;
            txt_nom_titulo.Enabled = true;
            dtp_fecha_title.Enabled = true;
            txt_decrip_titulo_emp.Enabled = true;
        }

        private void actualizar_titulo_emp_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_busqueda_datos_empleado, "select * from titulo_empleado;");
        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "membresia");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "membresia";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();

        }

        private void txt_id_titulo_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_id_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_id_lab_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_nom_titulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void btn_guardar_titulo_emp_Click(object sender, EventArgs e)
        {
            dtp_fecha_title.Enabled = true;
            try
            {
                if (txt_decrip_titulo_emp.Text == "" || txt_id_lab.Text == "" || txt_nom_titulo.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String query2 = "UPDATE titulo_empleado SET descripcion_titl_emp='" + txt_decrip_titulo_emp.Text + "', nombre_titl_emp='" + txt_nom_titulo.Text + "', pk_id_lab ='" + Convert.ToDouble(txt_id_lab.Text) + "' WHERE pk_id_titl_emp='" + Codigo + "';";
                        //String query2 = "UPDATE titulo_empleado SET descripcion_titl_emp='" + txt_decrip_titulo_emp.Text + "', nombre_titl_emp ='" + txt_nom_titulo.Text + "', fecha_obten_titl_emp = '" + txt_fecha_obt_titulo.Text + "', pk_id_lab = '" +Convert.ToDouble(txt_id_lab.Text) + "' WHERE pk_id_titl_emp='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        Conexionmysql.ObtenerConexion();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_busqueda_datos_empleado, "SELECT * FROM titulo_empleado");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        string fecha = dtp_fecha_title.Value.ToString("yyyy-MM-dd");
                        String Query = "INSERT INTO titulo_empleado (descripcion_titl_emp,nombre_titl_emp,fecha_obten_titl_emp, pk_id_emp, pk_id_lab) VALUES ('" + txt_decrip_titulo_emp.Text + "','" + txt_nom_titulo.Text + "','" + fecha + "', '" + Convert.ToDouble(txt_id_emp.Text) + "', '" + Convert.ToDouble(txt_id_lab.Text) + "') ";
                        cl_gridysql.EjecutarMySql(Query);
                        ActualizarGrid(this.dgv_busqueda_datos_empleado, "select * from titulo_empleado;");
                        this.LimpiarCajasTexto();
                        Conexionmysql.Desconectar();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InhabilitarTexto();
        }

        private void btn_elim_titulo_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[0].Value.ToString();
                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro

                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();
                    //2. armar la query
                    String Query = "delete from titulo_empleado where pk_id_titl_emp= '" + Codigo + "';";

                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);
                    //4.Actualizar grid..
                    ActualizarGrid(this.dgv_busqueda_datos_empleado, "select * from titulo_empleado;");
                    //5.desconectar en base de datos
                    Conexionmysql.Desconectar();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_actlz_titulo_emp_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            try {
                Editar = true;
                Codigo = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[0].Value.ToString();
                txt_decrip_titulo_emp.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[1].Value.ToString();
                txt_nom_titulo.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[2].Value.ToString();
                //txt_fecha_obt_titulo.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[3].Value.ToString();
                txt_id_emp.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[4].Value.ToString();
                txt_id_lab.Text = this.dgv_busqueda_datos_empleado.CurrentRow.Cells[5].Value.ToString();
                dtp_fecha_title.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_busc_emp_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from titulo_empleado where pk_id_titl_emp = '" + Convert.ToDouble(cbo_buscar.Text) + "%'; ");

            //ManipularDato.Busqueda(Query);

            ActualizarGrid(this.dgv_busqueda_datos_empleado, Query);


            Conexionmysql.Desconectar();
            cbo_buscar.Text = "";
        }

        private void txt_id_lab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_nom_titulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_decrip_titulo_emp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void Titulo_de_empleado_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
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
