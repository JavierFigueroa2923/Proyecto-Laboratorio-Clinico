using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frm_act_cliente : Form
    {
        public frm_act_cliente()
        {
            InitializeComponent();
            ActualizarGrid(this.dgv_list_pcnt, Selecionar_pacientes);
        }

        Validaciones validar = new Validaciones();
        BDconexion ManipularDato = new BDconexion();
        String Codigo;
        Boolean Editar;
        String Selecionar_pacientes = "select C.pk_id_clt as ID, C.nombre_clt as Nombre, C.apellido_clt as Apellido, C.sexo_clt as Sexo, C.dpi as DPI, C.edad_clt as Edad, C.tipo_sangre_clt as Tipo_de_Sangre, C.altura_clt as Altura, C.peso_clt as Peso, D.direccion as Direccion, T.telefono as Telefono, E.correo_e as Correo, C.nit AS NIT, C.referido_clt as Referencia, L.pk_id_lab as Laboratorio from cliente C, direccion D, telefono T, correo_e E, laboratorio L where C.pk_id_clt = D.pk_id_clt and C.pk_id_clt = T.pk_id_clt and C.pk_id_clt = E.pk_id_clt and C.pk_id_lab = L.pk_id_lab";
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void frm_act_cliente_Load(object sender, EventArgs e)
        {
            cbo_lab_pcnt.DataSource = Cargar();
            cbo_lab_pcnt.DisplayMember = "pk_id_lab";
            cbo_lab_pcnt.ValueMember = "pk_id_lab";
        }
        public void LimpiarCajasTexto()
        {
            txt_altura.Text = "";
            txt_apellido.Text = "";
            txt_busc_pcnt.Text = "";
            txt_direccion.Text = "";
            txt_dpi.Text = "";
            txt_email.Text = "";
            txt_fecha_nacimiento.Text = "";
            txt_nit.Text = "";
            txt_nombre.Text = "";
            txt_peso_pcnt.Text = "";
            txt_referido.Text = "";
            txt_telefono.Text = "";


        }
        public void ActualizarGrid(DataGridView dg, String Query)
        {
            Conexionmysql.ObtenerConexion();
            //crear DataSet
            System.Data.DataSet MiDataSet = new System.Data.DataSet();
            //Crear Adaptador de datos
            MySqlDataAdapter MiDataAdapter = new MySqlDataAdapter(Query, Conexionmysql.ObtenerConexion());
            //LLenar el DataSet
            MiDataAdapter.Fill(MiDataSet, "cliente");
            //Asignarle el valor adecuado a las propiedades del DataGrid
            dg.DataSource = MiDataSet;
            dg.DataMember = "cliente";
            //nos desconectamos de la base de datos...
            Conexionmysql.Desconectar();
        }
        private void btn_guardar_pcnt_Click(object sender, EventArgs e)
        {
            if (txt_altura.Text == "" || txt_apellido.Text == "" || txt_direccion.Text == "" || txt_email.Text == "" || txt_fecha_nacimiento.Text == "" ||
               txt_nit.Text == "" || txt_nombre.Text == "" || txt_peso_pcnt.Text == "" || txt_telefono.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    try
                    {
                        Conexionmysql.ObtenerConexion();
                        String Query1 = "UPDATE cliente SET nombre_clt ='" + txt_nombre.Text + "', apellido_clt='"+ txt_apellido.Text + "', nit='"+ txt_nit.Text + "', referido_clt='"+ txt_referido.Text + "', dpi='"+ txt_dpi.Text + "', edad_clt='"+ txt_fecha_nacimiento.Text + "', tipo_sangre_clt='"+ cbo_tip_sang_pcnt.Text + "', sexo_clt='"+ cbo_sexo_pcnt.Text + "', altura_clt= '"+ txt_altura.Text + "', peso_clt='"+ txt_peso_pcnt.Text +"' WHERE pk_id_clt ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(Query1);
                        String Query2 = "UPDATE correo_e SET correo_e ='" + txt_email.Text + "' WHERE pk_id_clt ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(Query2);
                        String Query3 = "UPDATE direccion SET direccion ='" + txt_direccion.Text + "' WHERE pk_id_clt ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(Query3);
                        String Query4 = "UPDATE telefono SET telefono ='" + txt_telefono.Text + "' WHERE pk_id_clt ='" + Codigo + "';";
                        cl_gridysql.EjecutarMySql(Query4);
                        Conexionmysql.Desconectar();
                        MessageBox.Show("Operación Realizada Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LimpiarCajasTexto();
                        ActualizarGrid(this.dgv_list_pcnt, Selecionar_pacientes);
                        Editar = false;
                    }catch { MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else
                {
                    try
                    {
                        Conexionmysql.ObtenerConexion();
                        String Query1 = "INSERT INTO cliente (nombre_clt, apellido_clt, nit, edad_clt, dpi, altura_clt, peso_clt, sexo_clt, tipo_sangre_clt, referido_clt, pk_id_lab) VALUES ('" + txt_nombre.Text + "','" + txt_apellido.Text + "','" + txt_nit.Text + "','" + txt_fecha_nacimiento.Text + "','" + txt_dpi.Text + "','" + txt_altura.Text + "','" + txt_peso_pcnt.Text + "','" + cbo_sexo_pcnt.Text + "','" + cbo_tip_sang_pcnt.Text + "','" + txt_referido.Text + "', "+cbo_lab_pcnt.Text +" )";
                        cl_gridysql.EjecutarMySql(Query1);

                        if (ComprobarFormatoEmail(txt_email.Text) == false)
                        {
                            MessageBox.Show("No se pudo realizar la modificación de la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            String Query2 = "INSERT INTO correo_e (correo_e, pk_id_clt) VALUES ('" + txt_email.Text + "',(select MAX(pk_id_clt) FROM cliente))";
                            cl_gridysql.EjecutarMySql(Query2);
                            String Query3 = "INSERT INTO direccion (direccion, pk_id_clt) VALUES ('" + txt_direccion.Text + "',(select MAX(pk_id_clt) FROM cliente))";
                            cl_gridysql.EjecutarMySql(Query3);
                            String Query4 = "INSERT INTO telefono (telefono, pk_id_clt) VALUES ('" + txt_telefono.Text + "',(select MAX(pk_id_clt) FROM cliente))";
                            cl_gridysql.EjecutarMySql(Query4);
                            ActualizarGrid(this.dgv_list_pcnt, Selecionar_pacientes);
                            this.LimpiarCajasTexto();
                            Conexionmysql.Desconectar();
                            MessageBox.Show("Operación Realizada Exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error en la Ejecucion...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_sololetras(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_nit_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_fecha_nacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);

        }

        private void txt_dpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validacion_solonumeros(e);
        }

        private void txt_altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            for (int i = 0; i < txt_altura.Text.Length; i++)
            {
                if (txt_altura.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txt_peso_pcnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            for (int i = 0; i < txt_peso_pcnt.Text.Length; i++)
            {
                if (txt_peso_pcnt.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }

            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txt_nombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_apellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_direccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_telefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_nit_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_fecha_nacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_dpi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_altura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_altura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_peso_pcnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btn_guardar_pcnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_referido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void cbo_expediente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_busc_pcnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btn_busc_pcnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_busc_pcnt.PerformClick();
            }
        }

        private void btn_renov_pcnt_Click(object sender, EventArgs e)
        {
            ActualizarGrid(this.dgv_list_pcnt, Selecionar_pacientes);
        }

        private void btn_busc_pcnt_Click(object sender, EventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select C.pk_id_clt as ID, C.nombre_clt as Nombre, C.apellido_clt as Apellido, C.sexo_clt as Sexo, C.dpi as DPI, C.edad_clt as Edad, C.tipo_sangre_clt as Tipo_de_Sangre, C.altura_clt as Altura, C.peso_clt as Peso, D.direccion as Direccion, T.telefono as Telefono, E.correo_e as Correo,  C.nit AS NIT, C.referido_clt as Referencia, L.pk_id_lab as Laboratorio from cliente C, direccion D, telefono T, correo_e E, laboratorio L where nombre_clt like '%" + txt_busc_pcnt.Text + "%' and C.pk_id_clt = D.pk_id_clt and C.pk_id_clt = T.pk_id_clt and C.pk_id_clt = E.pk_id_clt and C.pk_id_lab = L.pk_id_lab");
            ActualizarGrid(this.dgv_list_pcnt, Query);
            Conexionmysql.Desconectar();
        }

        private void btn_elim_pcnt_Click(object sender, EventArgs e)
        {
            try {
                Codigo = this.dgv_list_pcnt.CurrentRow.Cells[0].Value.ToString();
                var resultado = MessageBox.Show("DESEA BORRAR EL REGISTRO SELECCIONADO", "CONFIRME SU ACCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)// si el usuario hizo click en si
                {
                    Conexionmysql.ObtenerConexion();
                    String Query = "delete from cliente where pk_id_clt = '" + Codigo + "';";
                    cl_gridysql.EjecutarMySql(Query);
                    String Query2 = "delete from telefono where pk_id_clt = '" + Codigo + "';";
                    cl_gridysql.EjecutarMySql(Query2);
                    String Query3 = "delete from correo_e where pk_id_clt = '" + Codigo + "';";
                    cl_gridysql.EjecutarMySql(Query3);
                    String Query4 = "delete from direccion where pk_id_clt = '" + Codigo + "';";
                    cl_gridysql.EjecutarMySql(Query4);

                    ActualizarGrid(this.dgv_list_pcnt, Selecionar_pacientes);
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

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_actlz_pcnt_Click(object sender, EventArgs e)
        {
            try
            {
                Editar = true;
                Codigo = this.dgv_list_pcnt.CurrentRow.Cells[0].Value.ToString();
                txt_nombre.Text = this.dgv_list_pcnt.CurrentRow.Cells[1].Value.ToString();
                txt_apellido.Text = this.dgv_list_pcnt.CurrentRow.Cells[2].Value.ToString();
                cbo_sexo_pcnt.Text = this.dgv_list_pcnt.CurrentRow.Cells[3].Value.ToString();
                txt_dpi.Text = this.dgv_list_pcnt.CurrentRow.Cells[4].Value.ToString();
                txt_fecha_nacimiento.Text = this.dgv_list_pcnt.CurrentRow.Cells[5].Value.ToString();
                cbo_tip_sang_pcnt.Text = this.dgv_list_pcnt.CurrentRow.Cells[6].Value.ToString();
                txt_altura.Text = this.dgv_list_pcnt.CurrentRow.Cells[7].Value.ToString();
                txt_peso_pcnt.Text = this.dgv_list_pcnt.CurrentRow.Cells[8].Value.ToString();
                txt_direccion.Text = this.dgv_list_pcnt.CurrentRow.Cells[9].Value.ToString();
                txt_telefono.Text = this.dgv_list_pcnt.CurrentRow.Cells[10].Value.ToString();
                txt_email.Text = this.dgv_list_pcnt.CurrentRow.Cells[11].Value.ToString();
                txt_nit.Text = this.dgv_list_pcnt.CurrentRow.Cells[12].Value.ToString();
                txt_referido.Text = this.dgv_list_pcnt.CurrentRow.Cells[13].Value.ToString();
                cbo_lab_pcnt.Text = this.dgv_list_pcnt.CurrentRow.Cells[14].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione el Dato a Actualizar, Gracias", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_busc_pcnt_KeyUp(object sender, KeyEventArgs e)
        {
            Conexionmysql.ObtenerConexion();
            String Query = ("select C.pk_id_clt as ID, C.nombre_clt as Nombre, C.apellido_clt as Apellido, C.sexo_clt as Sexo, C.dpi as DPI, C.edad_clt as Edad, C.tipo_sangre_clt as Tipo_de_Sangre, C.altura_clt as Altura, C.peso_clt as Peso, D.direccion as Direccion, T.telefono as Telefono, E.correo_e as Correo,  C.nit AS NIT, C.referido_clt as Referencia, L.pk_id_lab as Laboratorio from cliente C, direccion D, telefono T, correo_e E, laboratorio L where nombre_clt like '%" + txt_busc_pcnt.Text + "%' and C.pk_id_clt = D.pk_id_clt and C.pk_id_clt = T.pk_id_clt and C.pk_id_clt = E.pk_id_clt and C.pk_id_lab = L.pk_id_lab");
            ActualizarGrid(this.dgv_list_pcnt, Query);
           Conexionmysql.Desconectar();
        }

        private DataTable Cargar()
        {
                Conexionmysql.ObtenerConexion();
                DataTable dt = new DataTable();
                string query = "SELECT pk_id_lab, nombre_lab FROM laboratorio";
                MySqlCommand cmd = new MySqlCommand(query, Conexionmysql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
        }

    }
} 
    

