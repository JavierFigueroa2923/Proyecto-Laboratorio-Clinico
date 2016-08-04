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
    public partial class frm_act_lab : Form
    {
        public frm_act_lab()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion ManipularDato = new BDconexion();
        String Codigo;
        Boolean Editar;

        public void LimpiarTextBox()
        {
            txt_id_labs.Text = "";
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_correo.Text = "";
            txt_busc_lab.Text = "";
        }

        public void GridViewActualizar(DataGridView dgv, String Query)
        {
            //Establecemos la conexion
            ManipularDato.obtener_conexion();
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=proyecto_laboratorio; uid=root; pwd=;");
            
            //creamos el DataSet a utilizar
            System.Data.DataSet newDataSet = new System.Data.DataSet();
            
            //Creamos un nuevo adaptador de datos
            MySqlDataAdapter newDataAdapter = new MySqlDataAdapter(Query, conectar);

            //LLenamos el DataSet
            newDataAdapter.Fill(newDataSet, "laboratorio");

            //Asignando valores al DataGrid
            dgv.DataSource = newDataSet;
            dgv.DataMember = "laboratorio";
        }

        private void btn_busc_lab_Click(object sender, EventArgs e)
        {
            ManipularDato.obtener_conexion();
            String Query = ("select L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where nombre_lab like '%" + txt_busc_lab.Text + "%' and L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab ");

            ManipularDato.Busqueda(Query);

            GridViewActualizar(this.dgv_labs, Query);


            ManipularDato.Desconectar();
        }

        private void lbl_busca_lab_Click(object sender, EventArgs e)
        {

        }

        private void txt_busc_lab_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridViewActualizar(this.dgv_labs, "select L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
        }

        private void frm_act_lab_Load(object sender, EventArgs e)
        {

        }

        private void txt_id_labs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_id_labs.Text == "" || txt_nombre.Text == "" || txt_telefono.Text == "" || txt_direccion.Text == "" || txt_correo.Text == "" )
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(Editar)
                    {
                        ManipularDato.obtener_conexion();
                        String Query = "UPDATE laboratorio SET nombre_lab ='" + txt_nombre.Text + "' WHERE pk_id_lab ='" + Codigo + "';";

                        ManipularDato.EjecutarSql(Query);
                        ManipularDato.Desconectar();

                        //6.limpiar cajas de texto
                        this.LimpiarTextBox();
                        GridViewActualizar(this.dgv_labs, "select L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
                        Editar = false;
                    }
                    else
                    {
                        ManipularDato.obtener_conexion();
                        String Query1 = "INSERT INTO laboratorio (pk_id_lab, nombre_lab) VALUES ('" + Convert.ToInt32(txt_id_labs.Text) + "','" + txt_nombre.Text + "')";
                        ManipularDato.EjecutarSql(Query1);

                        String Query2 = "INSERT INTO correo_e (correo_e, pk_id_lab) VALUES ('" + txt_correo.Text + "','" + Convert.ToInt32(txt_id_labs.Text) + "')";
                        ManipularDato.EjecutarSql(Query2);

                        String Query3 = "INSERT INTO direccion (direccion, pk_id_lab) VALUES ('" + txt_direccion.Text + "','" + Convert.ToInt32(txt_id_labs.Text) + "')";
                        ManipularDato.EjecutarSql(Query3);

                        String Query4 = "INSERT INTO telefono (telefono, pk_id_lab) VALUES ('" + txt_telefono.Text + "','" + Convert.ToInt32(txt_id_labs.Text) + "')";
                        ManipularDato.EjecutarSql(Query4);

                        GridViewActualizar(this.dgv_labs, "select L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");
                        this.LimpiarTextBox();
                        ManipularDato.Desconectar();
                        MessageBox.Show("Operación realizada exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_elim_pcnt_Click(object sender, EventArgs e)
        {
            Codigo = this.dgv_labs.CurrentRow.Cells[0].Value.ToString();

            //2. preguntar al usuario si realmente quiere borrar el resgistro

            var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //3.PROCEDER AVALUAR EL RESULTADO
            if (resultado == DialogResult.Yes)// si el usuario hizo click en si
            {
                //procedemos a borrar el registro

                //1. conectar a base de datosx
                ManipularDato.obtener_conexion();

                //2. armar la query
                String Query = "delete from laboratorio where pk_id_lab = '" + Codigo + "';";

                //3.ejecutar la query
                ManipularDato.EjecutarSql(Query);

                //4.Actualizar grid..
                GridViewActualizar(this.dgv_labs, "select L.nombre_lab, D.direccion, T.telefono, C.correo_e from laboratorio L, direccion D, telefono T, correo_e C where L.pk_id_lab = D.pk_id_lab and L.pk_id_lab = T.pk_id_lab and L.pk_id_lab = C.pk_id_lab;");


                //5.desconectar en base de datos
                ManipularDato.Desconectar();


            }//cerrar el if

            else

                //no pasa nada
                return;

            //cerrar else
        }

        private void btn_actlz_pcnt_Click(object sender, EventArgs e)
        {
            Editar = true;
            Codigo = this.dgv_labs.CurrentRow.Cells[0].Value.ToString();
            txt_id_labs.Text = this.dgv_labs.CurrentRow.Cells[1].Value.ToString();
            txt_nombre.Text = this.dgv_labs.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgv_labs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
