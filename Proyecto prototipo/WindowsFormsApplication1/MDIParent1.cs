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
    public partial class MDIParent1 : Form
    {
        Reporte_Examen_Paciente rep_examenp;
        Reporte_examenes rep_examen;
        Reporte_Ganancias rep_gan;
        Reporte_pagos rep_pag;
        Reporte_de_suministros rep_sum;
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

        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

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

       

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_examen == null)
            {
                rep_examen = new Reporte_examenes();
                rep_examen.MdiParent = this;
                rep_examen.FormClosed += new FormClosedEventHandler(rep_examen_FormClosed);
                rep_examen.Show();
            }

        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_pag == null)
            {
                rep_pag = new Reporte_pagos();
                rep_pag.MdiParent = this;
                rep_pag.FormClosed += new FormClosedEventHandler(rep_pago_FormClosed);
                rep_pag.Show();
            }
        }

        private void examenDePacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_examenp == null)
            {
                rep_examenp = new Reporte_Examen_Paciente();
                rep_examenp.MdiParent = this;
                rep_examenp.FormClosed += new FormClosedEventHandler(rep_examenp_FormClosed);
                rep_examenp.Show();
            }
        }
        void rep_examenp_FormClosed(object sender, EventArgs e)
        {
            rep_examenp = null;
        }
        void rep_examen_FormClosed(object sender, EventArgs e)
        {
            rep_examen = null;
        }
        void rep_pago_FormClosed(object sender, EventArgs e)
        {
            rep_pag = null;
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
                act_cliente.MdiParent = this;
                act_cliente.FormClosed += new FormClosedEventHandler(rep_act_cliente_FormClosed);
                act_cliente.Show();
            }
        }
        void rep_act_cliente_FormClosed(object sender, EventArgs e)
        {
            act_cliente = null;
        }

         //   77777777777777777777777777777777777777777777777777777777777777777777777777777



        private void actualizarExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (act_exam == null)
            {
                act_exam = new frm_act_examenes();
                act_exam.MdiParent = this;
                act_exam.FormClosed += new FormClosedEventHandler(act_exam_FormClosed);
                act_exam.Show();
            }
        }
        void act_exam_FormClosed(object sender, EventArgs e)
        {
            act_exam = null;
        }



        private void actualizarPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( act_pago == null)
            {
                act_pago = new frm_act_pago();
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


        private void reporteDeSuministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rep_sum == null)
            {
                rep_sum = new Reporte_de_suministros();
                rep_sum.MdiParent = this;
                rep_sum.FormClosed += new FormClosedEventHandler(rep_sum_FormClosed);
                rep_sum.Show();
            }
        }
        void rep_sum_FormClosed(object sender, EventArgs e)
        {
            rep_sum = null;
        }

        private void actualizarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (act_inv == null)
            {
                act_inv = new frm_act_inventario();
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
                frm_citas.MdiParent = this;
                frm_citas.FormClosed += new FormClosedEventHandler(frm_citas_FormClosed);
                frm_citas.Show();
            }
        }
        void frm_citas_FormClosed(object sender, EventArgs e)
        {
            frm_citas = null;
        }
    }
}
