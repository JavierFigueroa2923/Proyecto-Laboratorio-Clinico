using System;
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

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            try
            {
                string miconexion = "server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
                string consulta = "insert into ASEGURADORA values ('" + txt_id__aseg + "','" + txt_num_aseg + "','" + txt_nom_aseg + "','" + txt_dsc_aseg + "');";
                MySqlConnection con = new MySqlConnection(miconexion);
                MySqlCommand man = new MySqlCommand(consulta, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido insertados exitosamente");
                while (re.Read())
                { }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            try
            {
                string miconexion = "server=localhost; database=proyecto_laboratorio;uid=root;pwd=;");
                string consulta2 = "update proyecto_laboratorio.ASEGURADORA set numero_seguro_asgd='" + txt_num_aseg + "',nombre_asgd='" + txt_nom_aseg + "' , descuento_asgd= '" + txt_dsc_aseg + "' where pk_id_asgd ='" + txt_id__aseg + "';";
                MySqlConnection con = new MySqlConnection(miconexion);
                MySqlCommand man = new MySqlCommand(consulta2, con);
                MySqlDataReader re;
                con.Open();
                re = man.ExecuteReader();
                MessageBox.Show("Los datos han sido actualizados exitosamente");
                while (re.Read())
                { }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_busc_aseg_Click(object sender, EventArgs e)
        {
           
        }

        private bool OpenConnection()
        {
            throw new NotImplementedException();
        }
    }
