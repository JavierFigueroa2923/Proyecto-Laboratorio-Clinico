﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frm_act_aseg : Form
    {
        public frm_act_aseg()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        Conexionmysql manipular = new Conexionmysql();
        String Codigo;
        Boolean Editar;
        public void LimpiarCajasTexto()
        {
            cbo_buscar.Text = "";
           
            //txt_id__aseg.Text = "";
            txt_nom_aseg.Text = "";
            txt_desc_aseg.Text = "";
            


        }
        private void frm_act_aseg_Load(object sender, EventArgs e)
        {
            ActualizarGrid(this.dataGridView1, "select * from aseguradora;");
        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "aseguradora");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "aseguradora";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_busc_aseg_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from aseguradora where nombre_aseg = '" + Convert.ToDouble(cbo_buscar) + "%'; ");
            //ManipularDato.Busqueda(Query);
            ActualizarGrid(this.dataGridView1, Query);
            Conexionmysql.Desconectar();
            cbo_buscar.Text = "";
        }

        private void txt_id__aseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_num_aseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txt_nom_aseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void btn_elim_aseg_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                //2. preguntar al usuario si realmente quiere borrar el resgistro
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro
                    //1. conectar a base de datosx
                    Conexionmysql.ObtenerConexion();
                    //2. armar la query
                    String Query = "delete from aseguradora where pk_id_asgd= '" + Codigo + "';";
                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);
                    //4.Actualizar grid..
                    ActualizarGrid(this.dataGridView1, "select * from aseguradora;");
                    //5.desconectar en base de datos
                    Conexionmysql.Desconectar();
                }
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Eliminar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void btn_guardar_aseg_Click_1(object sender, EventArgs e)
        {
            try {
                if (txt_desc_aseg.Text == "" || txt_desc_aseg.Text == "" )
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String query2 = "UPDATE aseguradora SET descripcion_aseg='" + txt_desc_aseg.Text + "', nombre_aseg='" + txt_nom_aseg.Text + "' WHERE pk_id_asgd='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dataGridView1, "SELECT * FROM aseguradora");
                        Editar = false;
                    }
                    else
                    {

                        Conexionmysql.ObtenerConexion();
                        String query = "INSERT INTO aseguradora (nombre_aseg,descripcion_aseg) VALUES('" + txt_nom_aseg.Text + "', '" + txt_desc_aseg.Text + "') ";
                        cl_gridysql.EjecutarMySql(query);
                        LimpiarCajasTexto();
                        ActualizarGrid(this.dataGridView1, "select * from  aseguradora");
                        this.LimpiarCajasTexto();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_actlz_aseg_Click_1(object sender, EventArgs e)
        {
            try {
                Editar = true;
                Codigo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_desc_aseg.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_nom_aseg.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_busca_aseg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_busc_aseg_Click(object sender, EventArgs e)
        {

        }

        private void txt_nom_aseg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_desc_aseg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    } 
   }