namespace WindowsFormsApplication1
{
    partial class frm_act_pago
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_pago));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpb_datos_frm_pg = new System.Windows.Forms.GroupBox();
            this.btn_renovar = new System.Windows.Forms.Button();
            this.btn_busc_lab = new System.Windows.Forms.Button();
            this.lbl_busca_lab = new System.Windows.Forms.Label();
            this.btn_elim_pcnt = new System.Windows.Forms.Button();
            this.btn_actlz_pcnt = new System.Windows.Forms.Button();
            this.btn_guardar_pcnt = new System.Windows.Forms.Button();
            this.gpb_vista_labs = new System.Windows.Forms.GroupBox();
            this.dgv_for_pag = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_nuevo_pcnt = new System.Windows.Forms.Button();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_busc = new System.Windows.Forms.TextBox();
            this.gpb_datos_frm_pg.SuspendLayout();
            this.gpb_vista_labs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_for_pag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(340, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 34);
            this.label4.TabIndex = 58;
            this.label4.Text = "Formas de Pago";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(107, 80);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(246, 134);
            this.txt_descripcion.TabIndex = 55;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 50);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(246, 23);
            this.txt_nombre.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre:";
            // 
            // gpb_datos_frm_pg
            // 
            this.gpb_datos_frm_pg.Controls.Add(this.txt_descripcion);
            this.gpb_datos_frm_pg.Controls.Add(this.label2);
            this.gpb_datos_frm_pg.Controls.Add(this.label3);
            this.gpb_datos_frm_pg.Controls.Add(this.txt_nombre);
            this.gpb_datos_frm_pg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_frm_pg.Location = new System.Drawing.Point(5, 169);
            this.gpb_datos_frm_pg.Name = "gpb_datos_frm_pg";
            this.gpb_datos_frm_pg.Size = new System.Drawing.Size(361, 224);
            this.gpb_datos_frm_pg.TabIndex = 59;
            this.gpb_datos_frm_pg.TabStop = false;
            this.gpb_datos_frm_pg.Text = "Datos Generales";
            // 
            // btn_renovar
            // 
            this.btn_renovar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_renovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_renovar.FlatAppearance.BorderSize = 0;
            this.btn_renovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renovar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_renovar.Location = new System.Drawing.Point(502, 61);
            this.btn_renovar.Name = "btn_renovar";
            this.btn_renovar.Size = new System.Drawing.Size(65, 65);
            this.btn_renovar.TabIndex = 154;
            this.btn_renovar.Text = " ";
            this.btn_renovar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip8.SetToolTip(this.btn_renovar, "Actualizar");
            this.btn_renovar.UseVisualStyleBackColor = true;
            this.btn_renovar.Click += new System.EventHandler(this.btn_rnv_Click);
            // 
            // btn_busc_lab
            // 
            this.btn_busc_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_lab.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_lab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_lab.FlatAppearance.BorderSize = 0;
            this.btn_busc_lab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_lab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_lab.Location = new System.Drawing.Point(289, 61);
            this.btn_busc_lab.Name = "btn_busc_lab";
            this.btn_busc_lab.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_lab.TabIndex = 153;
            this.btn_busc_lab.Text = " ";
            this.btn_busc_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_lab, "Buscar");
            this.btn_busc_lab.UseVisualStyleBackColor = true;
            this.btn_busc_lab.Click += new System.EventHandler(this.btn_busc_lab_Click);
            // 
            // lbl_busca_lab
            // 
            this.lbl_busca_lab.AutoSize = true;
            this.lbl_busca_lab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_lab.Location = new System.Drawing.Point(393, 143);
            this.lbl_busca_lab.Name = "lbl_busca_lab";
            this.lbl_busca_lab.Size = new System.Drawing.Size(161, 20);
            this.lbl_busca_lab.TabIndex = 151;
            this.lbl_busca_lab.Text = "Buscar Tipo de Pago:";
            // 
            // btn_elim_pcnt
            // 
            this.btn_elim_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_elim_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_pcnt.Location = new System.Drawing.Point(218, 61);
            this.btn_elim_pcnt.Name = "btn_elim_pcnt";
            this.btn_elim_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_pcnt.TabIndex = 150;
            this.btn_elim_pcnt.Text = " ";
            this.btn_elim_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_pcnt, "Eliminar");
            this.btn_elim_pcnt.UseVisualStyleBackColor = true;
            this.btn_elim_pcnt.Click += new System.EventHandler(this.btn_elim_pcnt_Click);
            // 
            // btn_actlz_pcnt
            // 
            this.btn_actlz_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_actlz_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_pcnt.Location = new System.Drawing.Point(147, 61);
            this.btn_actlz_pcnt.Name = "btn_actlz_pcnt";
            this.btn_actlz_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_pcnt.TabIndex = 149;
            this.btn_actlz_pcnt.Text = " ";
            this.btn_actlz_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_pcnt, "Modificar");
            this.btn_actlz_pcnt.UseVisualStyleBackColor = true;
            this.btn_actlz_pcnt.Click += new System.EventHandler(this.btn_actlz_pcnt_Click);
            // 
            // btn_guardar_pcnt
            // 
            this.btn_guardar_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_guardar_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_pcnt.Location = new System.Drawing.Point(76, 61);
            this.btn_guardar_pcnt.Name = "btn_guardar_pcnt";
            this.btn_guardar_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_pcnt.TabIndex = 148;
            this.btn_guardar_pcnt.Text = " ";
            this.btn_guardar_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_pcnt, "Guardar");
            this.btn_guardar_pcnt.UseVisualStyleBackColor = true;
            this.btn_guardar_pcnt.Click += new System.EventHandler(this.btn_guardar_pcnt_Click);
            // 
            // gpb_vista_labs
            // 
            this.gpb_vista_labs.Controls.Add(this.dgv_for_pag);
            this.gpb_vista_labs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_labs.Location = new System.Drawing.Point(372, 169);
            this.gpb_vista_labs.Name = "gpb_vista_labs";
            this.gpb_vista_labs.Size = new System.Drawing.Size(505, 224);
            this.gpb_vista_labs.TabIndex = 147;
            this.gpb_vista_labs.TabStop = false;
            this.gpb_vista_labs.Text = "Formas de realizar pagos";
            // 
            // dgv_for_pag
            // 
            this.dgv_for_pag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_for_pag.Location = new System.Drawing.Point(6, 22);
            this.dgv_for_pag.Name = "dgv_for_pag";
            this.dgv_for_pag.Size = new System.Drawing.Size(493, 192);
            this.dgv_for_pag.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(766, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 118);
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(5, 61);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 156;
            this.toolTip1.SetToolTip(this.btn_nuevo_pcnt, "Nuevo");
            this.btn_nuevo_pcnt.UseVisualStyleBackColor = true;
            this.btn_nuevo_pcnt.Click += new System.EventHandler(this.btn_nuevo_pcnt_Click);
            // 
            // btn_acept
            // 
            this.btn_acept.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.check_icon;
            this.btn_acept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acept.Enabled = false;
            this.btn_acept.FlatAppearance.BorderSize = 0;
            this.btn_acept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acept.Location = new System.Drawing.Point(431, 61);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 158;
            this.toolTip7.SetToolTip(this.btn_acept, "Aceptar");
            this.btn_acept.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete_icon;
            this.btn_cancl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancl.Enabled = false;
            this.btn_cancl.FlatAppearance.BorderSize = 0;
            this.btn_cancl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancl.Location = new System.Drawing.Point(360, 61);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 157;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // txt_busc
            // 
            this.txt_busc.Location = new System.Drawing.Point(560, 143);
            this.txt_busc.Name = "txt_busc";
            this.txt_busc.Size = new System.Drawing.Size(311, 20);
            this.txt_busc.TabIndex = 159;
            this.txt_busc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_KeyUp);
            // 
            // frm_act_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 405);
            this.Controls.Add(this.txt_busc);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.btn_renovar);
            this.Controls.Add(this.btn_busc_lab);
            this.Controls.Add(this.lbl_busca_lab);
            this.Controls.Add(this.btn_elim_pcnt);
            this.Controls.Add(this.btn_actlz_pcnt);
            this.Controls.Add(this.btn_guardar_pcnt);
            this.Controls.Add(this.gpb_vista_labs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpb_datos_frm_pg);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_act_pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de Pagos";
            this.Load += new System.EventHandler(this.frm_act_pago_Load);
            this.gpb_datos_frm_pg.ResumeLayout(false);
            this.gpb_datos_frm_pg.PerformLayout();
            this.gpb_vista_labs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_for_pag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpb_datos_frm_pg;
        private System.Windows.Forms.Button btn_renovar;
        private System.Windows.Forms.Button btn_busc_lab;
        internal System.Windows.Forms.Label lbl_busca_lab;
        private System.Windows.Forms.Button btn_elim_pcnt;
        private System.Windows.Forms.Button btn_actlz_pcnt;
        private System.Windows.Forms.Button btn_guardar_pcnt;
        private System.Windows.Forms.GroupBox gpb_vista_labs;
        private System.Windows.Forms.DataGridView dgv_for_pag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.TextBox txt_busc;
    }
}