using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{

    public partial class MDIParent1 : Form
    {
        Reporte_Ganancias_Mensuales rep_gan_men;
        Reporte_Examenes_Cliente reg_ex_clt;
        Reporte_Clientes rep_clt;
        Reporte_Ganancias_Semanales rep_gan;
        Reporte_Resultado_Examen reg_resut_ex;
        Reporte_Facturas rep_fact;
        Cotizacion cot;
        frm_act_cliente act_cliente;
        frm_act_emp act_emp;
        frm_act_examenes act_exam;
        frm_act_aseg act_aseg;
        frm_act_pago act_pago;
        frm_act_inventario act_inv;
        frm_nuevo_examen frm_nexam;
        Nuevo_Laboratorio frm_nlab;
        frm_act_lab frm_actlab;
        Cargo_Empleado frm_cargoemp;
        Manejo_Usuarios frm_users;
        Citas frm_citas;
        frm_permiso frm_per;
        frm_etiqueta frm_etiquet;
        Area_de_laboratorio frm_area_lab;
        Membresia frm_mem;
        Titulo_de_empleado frm_tit_emp;
        Cargo_Empleado frm_cargo_emp;
        Tipo_de_muestra frm_tip_must;
        frm_muestra frm_muestras;
        Factura frm_fact;
        Resultado_examen frm_rest_exam;
        Cotizacion frm_cotiz;
        frm_act_inventario frm_act_inventarios;
        frm_act_examenes frm_act_exameness;
        frm_bitacora frm_bitacora;
        frm_examen frm_examen;

        private int childFormNumber = 0;

        public String MiPropiedad { get; set; }
        public int MiIdUsuario { get; set; }
        public String Usuario { get; set; }


        public MDIParent1()
        {
            InitializeComponent();
        }

        private const string ayudaCHM = "Ayuda-Sistema-Laboratorio-Clínico.chm";
        private const string indiceCHM = "ndice.html";
        private const string acercasistema = "acercadelsistema.html";

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
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


        private void MDIParent1_Load(object sender, EventArgs e)
        {
            lbl_usuario.Text = MiPropiedad;

            actualizarClienteToolStripMenuItem.Visible = false;
            actualizarToolStripMenuItem.Visible = false;
            actualizarExamenesToolStripMenuItem.Visible = false;
            actualizarPagosToolStripMenuItem.Visible = false;
            actualizarAseguradoraToolStripMenuItem.Visible = false;
            actualizarLaboratorioToolStripMenuItem.Visible = false;
            actualizarInventarioToolStripMenuItem.Visible = false;
            citasToolStripMenuItem.Visible = false;
            permisoToolStripMenuItem.Visible = false;
            etiquetasToolStripMenuItem.Visible = false;
            areaLaboratorioToolStripMenuItem.Visible = false;
            membreciaToolStripMenuItem.Visible = false;
            cargoEmpleadoToolStripMenuItem1.Visible = false;
            inventarioDeSuministrosToolStripMenuItem.Visible = false;
            tipoDeExamenToolStripMenuItem.Visible = false;

            
            facturasToolStripMenuItem.Visible = false;
            resultadoExamenesToolStripMenuItem.Visible = false;

            tituloEmpleadoToolStripMenuItem.Visible = false;
            tipoMuestraToolStripMenuItem.Visible = false;
            muestraToolStripMenuItem.Visible = false;
            cotizacionToolStripMenuItem.Visible = false;


            MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost; database=proyecto_laboratorio; uid=root; pwd=;");
            //MySql.Data.MySqlClient.MySqlConnection dbConn = new MySql.Data.MySqlClient.MySqlConnection("server=192.168.30.10; database=proyecto_laboratorio; uid=Otto; pwd=090113290;");

            MySqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT permiso.nombre_prm, empleado.usuario FROM cargo_empleado, empleado, permiso WHERE empleado.pk_id_emp = cargo_empleado.pk_id_emp AND cargo_empleado.pk_id_cargo_emp = permiso.pk_id_cargo_emp AND empleado.pk_id_emp = "+ MiIdUsuario +"";

            try
            {
                dbConn.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro" + erro);
                this.Close();
            }
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nilson = reader.GetString(0);
                switch (nilson) {
                    case "Actualizar Cliente":
                        actualizarClienteToolStripMenuItem.Visible = true;
                        break;
                    case "Actualizar Empleado":
                        actualizarToolStripMenuItem.Visible = true;
                        break;
                    case "Actualizar Examenes":
                        actualizarExamenesToolStripMenuItem.Visible = true;
                        break;
                    case "Actualizar Pagos":
                        actualizarPagosToolStripMenuItem.Visible = true;
                        break;
                    case "Actualizar Aseguradora":
                        actualizarAseguradoraToolStripMenuItem.Visible = true;
                        break;
                    case "Actualizar Laboratorio":
                        actualizarLaboratorioToolStripMenuItem.Visible = true;
                        break;
                    case "Actualizar Inventario":
                        actualizarInventarioToolStripMenuItem.Visible = true;
                        break;
                    case "Citas":
                        citasToolStripMenuItem.Visible = true;
                        break;
                    case "Roles":
                        permisoToolStripMenuItem.Visible = true;
                        break;
                    case "Etiquetas":
                        etiquetasToolStripMenuItem.Visible = true;
                        break;
                    case "Area Laboratorio":
                        areaLaboratorioToolStripMenuItem.Visible = true;
                        break;
                    case "Membrecia":
                        membreciaToolStripMenuItem.Visible = true;
                        break;
                    case "Cargo Empleado":
                        cargoEmpleadoToolStripMenuItem1.Visible = true;
                        break;
                    case "Inventario De Suministros":
                        inventarioDeSuministrosToolStripMenuItem.Visible = true;
                        break;
                    case "Tipo De Examen":
                        tipoDeExamenToolStripMenuItem.Visible = true;
                        break;

                   
                    case "Reporte de facturas":
                        facturasToolStripMenuItem.Visible = true;
                        break;
                    case "Reporte de resultado de examenes":
                        resultadoExamenesToolStripMenuItem.Visible = true;
                        break;
                        
                    case "Creacion titulo empleado":
                        tituloEmpleadoToolStripMenuItem.Visible = true;
                        break;
                    case "Creacion tipo de muestra":
                        tipoMuestraToolStripMenuItem.Visible = true;
                        break;
                    case "Creacion de muestra":
                        muestraToolStripMenuItem.Visible = true;
                        break;
                    case "Creacion de cotizacion":
                        cotizacionToolStripMenuItem.Visible = true;
                        break;
                    case "Todo":
                        actualizarClienteToolStripMenuItem.Visible = true;
                        actualizarToolStripMenuItem.Visible = true;
                        actualizarExamenesToolStripMenuItem.Visible = true;
                        actualizarPagosToolStripMenuItem.Visible = true;
                        actualizarAseguradoraToolStripMenuItem.Visible = true;
                        actualizarLaboratorioToolStripMenuItem.Visible = true;
                        actualizarInventarioToolStripMenuItem.Visible = true;
                        citasToolStripMenuItem.Visible = true;
                        permisoToolStripMenuItem.Visible = true;
                        etiquetasToolStripMenuItem.Visible = true;
                        areaLaboratorioToolStripMenuItem.Visible = true;
                        membreciaToolStripMenuItem.Visible = true;
                        cargoEmpleadoToolStripMenuItem1.Visible = true;
                        inventarioDeSuministrosToolStripMenuItem.Visible = true;
                        tipoDeExamenToolStripMenuItem.Visible = true;

                        
                        facturasToolStripMenuItem.Visible = true;
                        resultadoExamenesToolStripMenuItem.Visible = true;

                        tituloEmpleadoToolStripMenuItem.Visible = true;
                        tipoMuestraToolStripMenuItem.Visible = true;
                        muestraToolStripMenuItem.Visible = true;
                        cotizacionToolStripMenuItem.Visible = true;
                        break;
                    default:
                        
                        break;
                }

            }
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        

      
        

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
    





        private void nuevaCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cot == null)
            {
                cot = new Cotizacion();
                cot.MdiParent = this;
                cot.FormClosed += new FormClosedEventHandler(cotizacion_FormClosed);
                cot.Show();
            }
        }
        void cotizacion_FormClosed(object sender, EventArgs e)
        {
            cot = null;
        }


        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (act_cliente == null)
            {
                act_cliente = new frm_act_cliente();
                act_cliente.Usuario = Usuario;
                act_cliente.MiIdUsuario = MiIdUsuario;
                act_cliente.MdiParent = this;
                act_cliente.FormClosed += new FormClosedEventHandler(rep_act_cliente_FormClosed);
                act_cliente.Show();
            }
        }
        void rep_act_cliente_FormClosed(object sender, EventArgs e)
        {
            act_cliente = null;
        }




        private void actualizarExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_examen == null)
            {
                frm_examen = new frm_examen();
                frm_examen.Usuario = Usuario;
                frm_examen.MiIdUsuario = MiIdUsuario;
                frm_examen.MdiParent = this;
                frm_examen.FormClosed += new FormClosedEventHandler(act_exam_FormClosed);
                frm_examen.Show();
            }
        }
        void act_exam_FormClosed(object sender, EventArgs e)
        {
            frm_examen = null;
        }



        private void actualizarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( act_pago == null)
            {
                act_pago = new frm_act_pago();
                act_pago.Usuario = Usuario;
                act_pago.MiIdUsuario = MiIdUsuario;
                act_pago.MdiParent = this;
                act_pago.FormClosed += new FormClosedEventHandler(act_pago_FormClosed);
                act_pago.Show();
            }
        }
        void act_pago_FormClosed(object sender, EventArgs e)
        {
            act_pago = null;
        }



        private void actualizarAseguradoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (act_aseg == null)
            {
                act_aseg = new frm_act_aseg();
                act_aseg.Usuario = Usuario;
                act_aseg.MiIdUsuario = MiIdUsuario;
                act_aseg.MdiParent = this;
                act_aseg.FormClosed += new FormClosedEventHandler(act_aseg_FormClosed);
                act_aseg.Show();
            }
        }
        void act_aseg_FormClosed(object sender, EventArgs e)
        {
            act_aseg = null;
        }

        private void actualizarLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_actlab == null)
            {
                frm_actlab = new frm_act_lab();
                frm_actlab.Usuario = Usuario;
                frm_actlab.MiIdUsuario = MiIdUsuario;
                frm_actlab.MdiParent = this;
                frm_actlab.FormClosed += new FormClosedEventHandler(frm_actlab_FormClosed);
                frm_actlab.Show();
            }
        }
        void frm_actlab_FormClosed(object sender, EventArgs e)
        {
            frm_actlab = null;
        }




        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (act_emp == null)
            {
                act_emp = new frm_act_emp();
                act_emp.Usuario = Usuario;
                act_emp.MiIdUsuario = MiIdUsuario;
                act_emp.MdiParent = this;
                act_emp.FormClosed += new FormClosedEventHandler(act_emp_FormClosed);
                act_emp.Show();
            }
        }
        void act_emp_FormClosed(object sender, EventArgs e)
        {
            act_emp = null;
        }

        private void nuevoExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_nexam == null)
            {
                frm_nexam = new frm_nuevo_examen();
                frm_nexam.MdiParent = this;
                frm_nexam.FormClosed += new FormClosedEventHandler(nexam_FormClosed);
                frm_nexam.Show();
            }
        }
        void nexam_FormClosed(object sender, EventArgs e)
        {
            act_emp = null;
        }


       

        private void actualizarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (act_inv == null)
            {
                act_inv = new frm_act_inventario();
                act_inv.Usuario = Usuario;
                act_inv.MiIdUsuario = MiIdUsuario;
                act_inv.MdiParent = this;
                act_inv.FormClosed += new FormClosedEventHandler(act_inv_FormClosed);
                act_inv.Show();
            }
        }
        void act_inv_FormClosed(object sender, EventArgs e)
        {
            act_inv = null;
        }

        private void nuevoLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_nlab == null)
            {
                frm_nlab = new Nuevo_Laboratorio();
                frm_nlab.MdiParent = this;
                frm_nlab.FormClosed += new FormClosedEventHandler(frm_nlab_FormClosed);
                frm_nlab.Show();
            }
        }
        void frm_nlab_FormClosed(object sender, EventArgs e)
        {
            frm_nlab = null;
        }

        private void actualizarSuministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void cargoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm_cargoemp == null)
            {
                frm_cargoemp = new Cargo_Empleado();
                frm_cargoemp.MdiParent = this;
                frm_cargoemp.FormClosed += new FormClosedEventHandler(frm_cargoemp_FormClosed);
                frm_cargoemp.Show();
            }
        }
        void frm_cargoemp_FormClosed(object sender, EventArgs e)
        {
            frm_cargoemp = null;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm_users == null)
            {
                frm_users = new Manejo_Usuarios();
                frm_users.MdiParent = this;
                frm_users.FormClosed += new FormClosedEventHandler(frm_user_FormClosed);
                frm_users.Show();
            }
        }
        void frm_user_FormClosed(object sender, EventArgs e)
        {
            frm_users = null;
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_citas == null)
            {
                frm_citas = new Citas();
                frm_citas.Usuario = Usuario;
                frm_citas.MiIdUsuario = MiIdUsuario;
                frm_citas.MdiParent = this;
                frm_citas.FormClosed += new FormClosedEventHandler(frm_citas_FormClosed);
                frm_citas.Show();
            }
        }
        void frm_citas_FormClosed(object sender, EventArgs e)
        {
            frm_citas = null;
        }

        private void permisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm_per == null)
            {
                frm_per = new frm_permiso();
                frm_per.Usuario = Usuario;
                frm_per.MiIdUsuario = MiIdUsuario;
                frm_per.MdiParent = this;
                frm_per.FormClosed += new FormClosedEventHandler(frm_per_FormClosed);
                frm_per.Show();
            }
        }
        void frm_per_FormClosed(object sender, EventArgs e)
        {
            frm_per = null;
        }

        private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frm_etiquet == null)
            {
                frm_etiquet = new frm_etiqueta();
                frm_etiquet.Usuario = Usuario;
                frm_etiquet.MiIdUsuario = MiIdUsuario;
                frm_etiquet.MdiParent = this;
                frm_etiquet.FormClosed += new FormClosedEventHandler(frm_etiquet_FormClosed);
                frm_etiquet.Show();
            }

        }
        void frm_etiquet_FormClosed(object sender, EventArgs e)
        {
            frm_etiquet = null;
        }

        private void areaLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_area_lab == null)
            {
                frm_area_lab = new Area_de_laboratorio();
                frm_area_lab.Usuario = Usuario;
                frm_area_lab.MiIdUsuario = MiIdUsuario;
                frm_area_lab.MdiParent = this;
                frm_area_lab.FormClosed += new FormClosedEventHandler(frm_area_lab_FormClosed);
                frm_area_lab.Show();
            }
        }
        void frm_area_lab_FormClosed(object sender, EventArgs e)
        {
            frm_area_lab = null;
        }

        private void membreciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_mem == null)
            {
                frm_mem = new Membresia();
                frm_mem.Usuario = Usuario;
                frm_mem.MiIdUsuario = MiIdUsuario;
                frm_mem.MdiParent = this;
                frm_mem.FormClosed += new FormClosedEventHandler(frm_mem_lab_FormClosed);
                frm_mem.Show();
            }
            
        }
        void frm_mem_lab_FormClosed(object sender, EventArgs e)
        {
            frm_mem = null;
        }

        private void tituloEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_tit_emp == null)
            {
                frm_tit_emp = new Titulo_de_empleado();
                frm_tit_emp.Usuario = Usuario;
                frm_tit_emp.MiIdUsuario = MiIdUsuario;
                frm_tit_emp.MdiParent = this;
                frm_tit_emp.FormClosed += new FormClosedEventHandler(frm_tit_emp_lab_FormClosed);
                frm_tit_emp.Show();
            }
        }
        void frm_tit_emp_lab_FormClosed(object sender, EventArgs e)
        {
            frm_tit_emp = null;
        }

        private void cargoEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frm_cargo_emp == null)
            {
                frm_cargo_emp = new Cargo_Empleado();
                frm_cargo_emp.Usuario = Usuario;
                frm_cargo_emp.MiIdUsuario = MiIdUsuario;
                frm_cargo_emp.MdiParent = this;
                frm_cargo_emp.FormClosed += new FormClosedEventHandler(frm_cargo_emp_lab_FormClosed);
                frm_cargo_emp.Show();
            }
        }
        void frm_cargo_emp_lab_FormClosed(object sender, EventArgs e)
        {
            frm_cargo_emp = null;
        }

        private void tipoMuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_tip_must == null)
            {
                frm_tip_must = new Tipo_de_muestra();
                frm_tip_must.Usuario = Usuario;
                frm_tip_must.MiIdUsuario = MiIdUsuario;
                frm_tip_must.MdiParent = this;
                frm_tip_must.FormClosed += new FormClosedEventHandler(frm_tip_must_lab_FormClosed);
                frm_tip_must.Show();
            }
        }
        void frm_tip_must_lab_FormClosed(object sender, EventArgs e)
        {
            frm_tip_must = null;
        }

        private void muestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_muestras == null)
            {
                frm_muestras = new frm_muestra();
                frm_muestras.Usuario = Usuario;
                frm_muestras.MiIdUsuario = MiIdUsuario;
                frm_muestras.MdiParent = this;
                frm_muestras.FormClosed += new FormClosedEventHandler(frm_muestras_FormClosed);
                frm_muestras.Show();
            }
        }
        void frm_muestras_FormClosed(object sender, EventArgs e)
        {
            frm_muestras = null;
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_fact == null)
            {
                rep_fact = new Reporte_Facturas();
                rep_fact.MdiParent = this;
                rep_fact.FormClosed += new FormClosedEventHandler(reg_factClosed);
                rep_fact.Show();
            }
        }
        void reg_factClosed(object sender, EventArgs e)
        {
            rep_fact = null;
        }

        private void resultadoExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_rest_exam == null)
            {
                frm_rest_exam = new Resultado_examen();
                frm_rest_exam.Usuario = Usuario;
                frm_rest_exam.MiIdUsuario = MiIdUsuario;
                frm_rest_exam.MdiParent = this;
                frm_rest_exam.FormClosed += new FormClosedEventHandler(frm_rest_exam_FormClosed);
                frm_rest_exam.Show();
            }
        }
        void frm_rest_exam_FormClosed(object sender, EventArgs e)
        {
            frm_rest_exam = null;
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_cotiz == null)
            {
                frm_cotiz = new Cotizacion();
                frm_cotiz.Usuario = Usuario;
                frm_cotiz.MiIdUsuario = MiIdUsuario;
                frm_cotiz.MdiParent = this;
                frm_cotiz.FormClosed += new FormClosedEventHandler(frm_cotiz_FormClosed);
                frm_cotiz.Show();
            }
        }
        void frm_cotiz_FormClosed(object sender, EventArgs e)
        {
            frm_cotiz = null;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Login frm2 = new Login();
            String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc, tabla_modif_bitc,id_usuario_activo) VALUE (NOW(), 'Logout','" + Usuario + "','" + obtenerIP() + "', 'area_laboratorio'," + MiIdUsuario + ") ";
            cl_gridysql.EjecutarMySql(bitacora);
            frm2.Show();
            this.Hide();
        }

        private void inventarioDeSuministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_act_inventarios == null)
            {
                frm_act_inventarios = new frm_act_inventario();
                frm_act_inventarios.Usuario = Usuario;
                frm_act_inventarios.MiIdUsuario = MiIdUsuario;
                frm_act_inventarios.MdiParent = this;
                frm_act_inventarios.FormClosed += new FormClosedEventHandler(frm_act_inventariosClosed);
                frm_act_inventarios.Show();
            }
        }
        void frm_act_inventariosClosed(object sender, EventArgs e)
        {
            frm_act_inventarios = null;
        }

        private void tipoDeExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_act_exameness == null)
            {
                frm_act_exameness = new frm_act_examenes();
                frm_act_exameness.Usuario = Usuario;
                frm_act_exameness.MiIdUsuario = MiIdUsuario;
                frm_act_exameness.MdiParent = this;
                frm_act_exameness.FormClosed += new FormClosedEventHandler(frm_act_examenessClosed);
                frm_act_exameness.Show();
            }
        }
        void frm_act_examenessClosed(object sender, EventArgs e)
        {
            frm_act_exameness = null;
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, Application.StartupPath + @"\" + ayudaCHM);
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayudaCHM, HelpNavigator.Topic, indiceCHM);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayudaCHM, HelpNavigator.Find, "");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayudaCHM, HelpNavigator.Topic, acercasistema);
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            String bitacora = "INSERT INTO bitacora_de_control (fecha_accion_bitc, accion_bitc, usuario_conn_bitc, ip_usuario_bitc,id_usuario_activo) VALUE (NOW(), 'Logout','" + Usuario + "','" + obtenerIP() + "'," + MiIdUsuario + ") ";
            cl_gridysql.EjecutarMySql(bitacora);
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_bitacora == null)
            {
                frm_bitacora = new frm_bitacora();
                frm_bitacora.MdiParent = this;
                frm_bitacora.FormClosed += new FormClosedEventHandler(frm_bitacoraClosed);
                frm_bitacora.Show();
            }
        }

        void frm_bitacoraClosed(object sender, EventArgs e)
        {
            frm_bitacora = null;
        }

        private void reporteGananciaMensualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_gan_men == null)
            {
                rep_gan_men = new Reporte_Ganancias_Mensuales();
                rep_gan_men.MdiParent = this;
                rep_gan_men.FormClosed += new FormClosedEventHandler(rep_gan_menClosed);
                rep_gan_men.Show();
            }
        }
        void rep_gan_menClosed(object sender, EventArgs e)
        {
            rep_gan_men = null;
        }

        private void reporteGananciaSemanalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_gan == null)
            {
                rep_gan = new Reporte_Ganancias_Semanales();
                rep_gan.MdiParent = this;
                rep_gan.FormClosed += new FormClosedEventHandler(rep_ganClosed);
                rep_gan.Show();
            }
        }
        void rep_ganClosed(object sender, EventArgs e)
        {
            rep_gan = null;
        }

        private void reporteExamenesClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reg_ex_clt == null)
            {
                reg_ex_clt = new Reporte_Examenes_Cliente();
                reg_ex_clt.MdiParent = this;
                reg_ex_clt.FormClosed += new FormClosedEventHandler(rep_ex_cltClosed);
                reg_ex_clt.Show();
            }
        }
        void rep_ex_cltClosed(object sender, EventArgs e)
        {
            reg_ex_clt = null;
        }

        private void reporteResultadoExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reg_resut_ex == null)
            {
                reg_resut_ex = new Reporte_Resultado_Examen();
                reg_resut_ex.MdiParent = this;
                reg_resut_ex.FormClosed += new FormClosedEventHandler(rep_resultClosed);
                reg_resut_ex.Show();
            }
        }
        void rep_resultClosed(object sender, EventArgs e)
        {
            reg_resut_ex = null;
        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_clt == null)
            {
                rep_clt = new Reporte_Clientes();
                rep_clt.MdiParent = this;
                rep_clt.FormClosed += new FormClosedEventHandler(rep_cltClosed);
                rep_clt.Show();
            }
        }
        void rep_cltClosed(object sender, EventArgs e)
        {
            rep_clt = null;
        }
    }
}
