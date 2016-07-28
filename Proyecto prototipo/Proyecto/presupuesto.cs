using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data;
using MySql.Data.MySqlClient;


namespace Proyecto
{

    public partial class presupuesto : Form
    {
        OracleConnection loca = new OracleConnection("DATA SOURCE=; PASSWORD=olap; USER ID=olap_cubo");

        public presupuesto()
        {
            InitializeComponent();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }


        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void especificaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seleccion = string.Empty;
            foreach (Object item in pre_prensa.CheckedItems)
            {
                seleccion = item.ToString() + "," + seleccion;
            }
            string seleccion2 = string.Empty;
            foreach (Object item in acabados.CheckedItems)
            {
                seleccion2 = item.ToString() + "," + seleccion2;
            }
            string seleccion3 = string.Empty;
            foreach (Object item in tipografia.CheckedItems)
            {
                seleccion3 = item.ToString() + "," + seleccion3;
            }
            string seleccion4 = string.Empty;
            foreach (Object item in impresion.CheckedItems)
            {
                seleccion4 = item.ToString() + "," + seleccion4;
            }
            string seleccion5 = string.Empty;
            foreach (Object item in encuadernacion.CheckedItems)
            {
                seleccion5 = item.ToString() + "," + seleccion5;
            }
            string seleccion6 = string.Empty;
            foreach (Object item in cortes.CheckedItems)
            {
                seleccion6 = item.ToString() + "," + seleccion6;
            }


            double numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, suma2, iva2, suma, total2;
            numero1 = Convert.ToDouble(preciopre.Text);
            numero2 = Convert.ToDouble(precioacabados.Text);
            numero3 = Convert.ToDouble(preciotipografia.Text);
            numero4 = Convert.ToDouble(precioimpresion.Text);
            numero5 = Convert.ToDouble(precioencuadernacion.Text);
            numero6 = Convert.ToDouble(cantidad_cortes.Text);
            numero7 = Convert.ToDouble(valor_otros.Text);
            numero8 = Convert.ToDouble(precio.Text);



            suma = numero1 + numero2 + numero3 + numero4 + numero5 + numero6 + numero7 + numero8;
            suma2 = (suma * 100) / 80;
            iva2 = suma2 * .12;
            suma_de_Costos.Text = suma.ToString();
            utilidad.Text = suma2.ToString();
            iva.Text = iva2.ToString();
            total2 = suma2 + iva2;
            total.Text = total2.ToString();

            
                
            
            {
                try
                {
                    string Myconexion = "server=localhost; database=grimpsa; uid=root;pwd=";
                    String consulta = "insert into pre_prensa values ('" + null + "','" + seleccion + "','" + preciopre.Text + "','" + codigo_hoja_presupuesto.Text + "');";
                    String consulta2 = "insert into acabado values ('" + null + "','" + seleccion2 + "','" + precioacabados.Text + "','" + codigo_hoja_presupuesto.Text + "');";
                    String consulta3 = "insert into tipografia values ('" + null + "','" + seleccion3 + "','" + preciotipografia.Text + "','" + codigo_hoja_presupuesto.Text + "');";
                    String consulta4 = "insert into impresion values ('" + null + "','" + seleccion4 + "','" + precioimpresion.Text + "','" +codigo_hoja_presupuesto.Text+ "');";
                    String consulta5 = "insert into encuadernacion values ('" + null + "','" + seleccion5 + "','" + precioencuadernacion.Text + "','" + codigo_hoja_presupuesto.Text + "');";
                    String consulta6 = "insert into corte values('" + null + "','" + seleccion6 + "','" + cantidad_cortes.Text + "','" + codigo_hoja_presupuesto.Text + "');";
                    String consulta7 = "insert into otro values('" + null + "','" + otros_varios.Text + "','" + valor_otros.Text + "','" + codigo_hoja_presupuesto.Text + "');";
                    String consulta8 = "insert into tipo_de_papel values('" + null + "','" + Tipo_de_papel.Text + "','" + precio.Text + "','" + codigo_hoja_presupuesto.Text + "');";
                    String consulta9 = "insert into hoja_de_presupuesto values ('" + codigo_hoja_presupuesto.Text + "','" + trabajo_cotizar.Text + "','" + especificaciones.Text + "','" + pliegos_enteros.Text + "','" + pliegos_prensa.Text + "','" + maquina_destino.Text + "','" + cantidad.Text + "','" + suma_de_Costos.Text + "','" + utilidad.Text + "','" + iva.Text + "','" + total.Text +"','" + Codigo_Cliente.Text + "');";

                    MySqlConnection con = new MySqlConnection(Myconexion);
                    MySqlConnection con2 = new MySqlConnection(Myconexion);
                    MySqlConnection con3 = new MySqlConnection(Myconexion);
                    MySqlConnection con4 = new MySqlConnection(Myconexion);
                    MySqlConnection con5 = new MySqlConnection(Myconexion);
                    MySqlConnection con6 = new MySqlConnection(Myconexion);
                    MySqlConnection con7 = new MySqlConnection(Myconexion);
                    MySqlConnection con8 = new MySqlConnection(Myconexion);
                    MySqlConnection con9 = new MySqlConnection(Myconexion);
           
                    MySqlCommand man = new MySqlCommand(consulta, con);
                    MySqlCommand men = new MySqlCommand(consulta2, con2);
                    MySqlCommand min = new MySqlCommand(consulta3, con3);
                    MySqlCommand mon = new MySqlCommand(consulta4, con4);
                    MySqlCommand mun = new MySqlCommand(consulta5, con5);
                    MySqlCommand lan = new MySqlCommand(consulta6, con6);
                    MySqlCommand len = new MySqlCommand(consulta7, con7);
                    MySqlCommand lin = new MySqlCommand(consulta8, con8);
                    MySqlCommand lon = new MySqlCommand(consulta9, con9);

                    MySqlDataReader re;
                    MySqlDataReader ra;
                    MySqlDataReader ri;
                    MySqlDataReader ro;
                    MySqlDataReader ru;
                    MySqlDataReader la;
                    MySqlDataReader le;
                    MySqlDataReader li;
                    MySqlDataReader lo;


                    con6.Open();
                    la = lan.ExecuteReader();
                    while (la.Read())

                    { }

                    con7.Open();
                    le = len.ExecuteReader();
                    while (le.Read())

                    { }

                    con8.Open();
                    li = lin.ExecuteReader();
                    while (li.Read())

                    { }

                    con9.Open();
                    lo = lon.ExecuteReader();
                    while (lo.Read())

                    { }


                    con.Open();
                    re = man.ExecuteReader();
                    MessageBox.Show("Se han insertado exitosamente");
                    while (re.Read())

                    { }


                    con2.Open();
                    ra = men.ExecuteReader();
                    while (ra.Read())

                    { }

                    con3.Open();
                    ri = min.ExecuteReader();
                    while (ri.Read())

                    { }

                    con4.Open();
                    ro = mon.ExecuteReader();
                    while (ro.Read())

                    { }

                    con5.Open();
                    ru = mun.ExecuteReader();
                    while (ru.Read())

                    { }

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                suma_de_Costos.Text = ""; total.Text = ""; codigo_hoja_presupuesto.Text = ""; trabajo_cotizar.Text = "";
                utilidad.Text = ""; especificaciones.Text = ""; pliegos_enteros.Text = ""; pliegos_prensa.Text = "";
                cantidad.Text = ""; precioacabados.Text = "0"; precio.Text = "0"; precioencuadernacion.Text = "0"; preciopre.Text = "0"; preciotipografia.Text = "0";
                precioimpresion.Text = "0"; valor_otros.Text = "0"; cantidad_cortes.Text = "0"; Codigo_Cliente.Text = "" ;

                

            }
        }

        private void Tipo_de_papel_TextChanged(object sender, EventArgs e)
        {

        }

        private void impresion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Calcular_Click(object sender, EventArgs e)
        {

            double numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, suma2,iva2,suma,total2;
            numero1 = Convert.ToDouble(preciopre.Text);
            numero2 = Convert.ToDouble(precioacabados.Text);
            numero3 = Convert.ToDouble(preciotipografia.Text);
            numero4 = Convert.ToDouble(precioimpresion.Text);
            numero5 = Convert.ToDouble(precioencuadernacion.Text);
            numero6 = Convert.ToDouble(cantidad_cortes.Text);
            numero7 = Convert.ToDouble(valor_otros.Text);
            numero8 = Convert.ToDouble(precio.Text);


           
            suma = numero1 + numero2 + numero3 + numero4 + numero5 + numero6 + numero7 + numero8;
            suma2 = (suma * 100) / 80;
            iva2 = suma2 * .12;
            suma_de_Costos.Text = suma.ToString();
            utilidad.Text = suma2.ToString();
            iva.Text = iva2.ToString();
            total2 = suma2 + iva2;
            total.Text = total2.ToString();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inicio ini = new inicio();
            ini.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reporte_hoja_presupuesto rep = new reporte_hoja_presupuesto();
            rep.Show();
            this.Hide();
        }
    }
}


        

    

