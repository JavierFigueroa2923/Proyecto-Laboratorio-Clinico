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
    public partial class Resultado_examen : Form
    {
        public Resultado_examen()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        Conexionmysql ManipularDato = new Conexionmysql();
        String Codigo;
        Boolean Editar;
        private void Resultado_examen_Load(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_vist_result_exam, "SELECT * FROM resultado_examen;");
        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "resultado_examen");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "resultado_examen";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }
        public void LimpiarCajasTexto()
        {

            txt_descripcion.Text = "";
            //txt_id_area_lab.Text = "";
            txt_id_exm.Text = "";
            

        }
        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
           try
            {
                if (dtp_fecha_resul.Text == "" || txt_descripcion.Text == "")
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
                        ActualizarGrid(this.dgv_vist_result_exam, "SELECT * FROM resultado_examen");
                        Editar = false;
                        dtp_fecha_resul.Enabled = true;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        string fecha = dtp_fecha_resul.Value.ToString("yyyy-MM-dd");
                        DateTime fecha2 = Convert.ToDateTime(fecha).Date;
                        if (fecha2 == DateTime.Now.Date)
                        {
                            String Query = "INSERT INTO resultado_examen (fecha_entrega_result_exm,descripcion_result_exm, pk_id_exm) VALUES ('" + fecha + "','" + txt_descripcion.Text + "','" + Convert.ToDouble(txt_id_exm.Text) + "') ";
                            cl_gridysql.EjecutarMySql(Query);
                            ActualizarGrid(this.dgv_vist_result_exam, "select * from resultado_examen;");
                            this.LimpiarCajasTexto();
                            Conexionmysql.Desconectar();
                        } else
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

        private void btn_elim_resl_exam_Click(object sender, EventArgs e)
        {
            dtp_fecha_resul.Enabled = true;
            try
            {
                Codigo = this.dgv_vist_result_exam.CurrentRow.Cells[0].Value.ToString();
                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro
                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();
                    //2. armar la query
                    String Query = "delete from resultado_examen where pk_id_result_exm= '" + Codigo + "';";
                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);
                    //4.Actualizar grid..
                    ActualizarGrid(this.dgv_vist_result_exam, "select * from resulta_examen;");
                    //5.desconectar en base de datos
                    Conexionmysql.Desconectar();
                }//cerrar el if
                else
                    //no pasa nada
                    return;
                //cerrar else
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_buscar_resl_exam_Click(object sender, EventArgs e)
        {
            dtp_fecha_resul.Enabled = true;
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from resultado_examen where  pk_id_exm= '" + cbo_buscar.Text + "%'; ");
            //ManipularDato.Busqueda(Query);
            ActualizarGrid(this.dgv_vist_result_exam, Query);
            Conexionmysql.Desconectar();
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                Codigo = this.dgv_vist_result_exam.CurrentRow.Cells[0].Value.ToString();
                txt_descripcion.Text = this.dgv_vist_result_exam.CurrentRow.Cells[2].Value.ToString();
                txt_id_exm.Text = this.dgv_vist_result_exam.CurrentRow.Cells[3].Value.ToString();
                dtp_fecha_resul.Enabled = false;
                //txt_descrip_area.Text = this.dgv_area_labs.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_act_renov_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_vist_result_exam, "SELECT * FROM resultado_examen;");
        }
    }
}
