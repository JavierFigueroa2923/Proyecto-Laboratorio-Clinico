﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Tipo_de_muestra : Form
    {
        public Tipo_de_muestra()
        {
            InitializeComponent();
        }
        Validaciones validar = new Validaciones();
        BDconexion manipular = new BDconexion();
        String Codigo;
        Boolean Editar;
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }

        private void Tipo_de_muestra_Load(object sender, EventArgs e)
        {
            InhabilitarTexto();
            btn_cancl.Enabled = false;
            btn_acept.Enabled = false;
            /// no real 

            ActualizarGrid(this.dgv_muestras, "select pk_id_tip_mst as Identificador, descripcion_tip_mst as Descripcion, nombre_tipo as Nombre from tipo_de_muestra;");
        }

        public string obtenerIP()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }

        public void LimpiarCajasTexto()
        {
            txt_busc_tip_mst.Text = "";
            txt_descp_muestra.Text = "";
            txt_nombre_tipo.Text = "";
            //txt_tp_muestra.Text = "";


        }

        public void InhabilitarTexto()
        {
            txt_nombre_tipo.Enabled = false;
            txt_descp_muestra.Enabled = false;
        }

        public void HabilitarTexto()
        {
            txt_nombre_tipo.Enabled = true;
            txt_descp_muestra.Enabled = true;
        }

        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "tipo_de_muestra");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "tipo_de_muestra";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }

        private void btn_guardar_tipo_muestra_Click(object sender, EventArgs e)
        {
            try {
                if (txt_descp_muestra.Text == "" || txt_nombre_tipo.Text == "")
                {
                    MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Editar)
                    {
                        Conexionmysql.ObtenerConexion();
                        String query2 = "UPDATE tipo_de_muestra SET descripcion_tip_mst='" + txt_descp_muestra.Text + "', nombre_tipo='" + txt_nombre_tipo.Text + "' WHERE pk_id_tip_mst='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(query2);
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Modificar','" + Usuario + "','" + obtenerIP() + "', 'tipo_de_muestra'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        Conexionmysql.Desconectar();
                        //6.limpiar cajas de texto
                        this.LimpiarCajasTexto();

                        ActualizarGrid(this.dgv_muestras, "select pk_id_tip_mst as Identificador, descripcion_tip_mst as Descripcion, nombre_tipo as Nombre from tipo_de_muestra;");
                        Editar = false;
                    }
                    else
                    {
                        Conexionmysql.ObtenerConexion();
                        String query = "INSERT INTO tipo_de_muestra(descripcion_tip_mst,nombre_tipo) Values('" + txt_nombre_tipo.Text + "','" + txt_descp_muestra.Text + "') ";
                        cl_gridysql.EjecutarMySql(query);
                        String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Insertar','" + Usuario + "','" + obtenerIP() + "', 'tipo_de_muestra'," + MiIdUsuario + ") ";
                        cl_gridysql.EjecutarMySql(bitacora);
                        LimpiarCajasTexto();

                        ActualizarGrid(this.dgv_muestras, "select pk_id_tip_mst as Identificador, descripcion_tip_mst as Descripcion, nombre_tipo as Nombre from tipo_de_muestra;");
                        this.LimpiarCajasTexto();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InhabilitarTexto();
        }

        private void btn_actlz_tipo_muestra_Click(object sender, EventArgs e)
        {
            HabilitarTexto();
            btn_cancl.Enabled = true;
            try {
                manipular.obtener_conexion();
                Editar = true;
                Codigo = this.dgv_muestras.CurrentRow.Cells[0].Value.ToString();
                txt_descp_muestra.Text = this.dgv_muestras.CurrentRow.Cells[1].Value.ToString();
                txt_nombre_tipo.Text = this.dgv_muestras.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btn_elim_tp_muestra_Click(object sender, EventArgs e)
        {
            try
            {
                Codigo = this.dgv_muestras.CurrentRow.Cells[0].Value.ToString();

                //2. preguntar al usuario si realmente quiere borrar el resgistro

                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //3.PROCEDER AVALUAR EL RESULTADO
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    //procedemos a borrar el registro

                    //1. conectar a base de datos
                    Conexionmysql.ObtenerConexion();

                    //2. armar la query
                    String Query = "DELETE FROM tipo_de_muestra WHERE pk_id_tip_mst= '" + Codigo + "';";

                    //3.ejecutar la query
                    cl_gridysql.EjecutarMySql(Query);

                    //4.Actualizar grid..

                    ActualizarGrid(this.dgv_muestras, "select pk_id_tip_mst as Identificador, descripcion_tip_mst as Descripcion, nombre_tipo as Nombre from tipo_de_muestra;");
                    String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Eliminar','" + Usuario + "','" + obtenerIP() + "', 'tipo_de_muestra'," + MiIdUsuario + ") ";
                    cl_gridysql.EjecutarMySql(bitacora);

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

        private void txt_tp_muestra_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void btn_busc_memb_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select * from tipo_muestra where pk_id_tip_mst = '" + txt_busc_tip_mst.Text + "%'; ");

            //ManipularDato.Busqueda(Query);

            ActualizarGrid(this.dgv_muestras, Query);
            Conexionmysql.Desconectar();
            txt_busc_tip_mst.Text = "";
        }

        private void btn_act_datos_Click(object sender, EventArgs e)
        {

            ActualizarGrid(this.dgv_muestras, "select pk_id_tip_mst as Identificador, descripcion_tip_mst as Descripcion, nombre_tipo as Nombre from tipo_de_muestra;");
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

        private void txt_busc_tip_mst_KeyUp(object sender, KeyEventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select pk_id_tip_mst as Identificador, descripcion_tip_mst as Descripcion, nombre_tipo as Nombre from tipo_de_muestra; where pk_id_tip_mst = '" + txt_busc_tip_mst.Text + "%'; ");

            //ManipularDato.Busqueda(Query);

            ActualizarGrid(this.dgv_muestras, Query);
            Conexionmysql.Desconectar();
            txt_busc_tip_mst.Text = "";
        }
    }
}