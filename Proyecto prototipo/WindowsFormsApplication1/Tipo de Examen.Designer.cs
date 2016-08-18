namespace WindowsFormsApplication1
{
    partial class frm_act_examenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_examenes));
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_tip_exam = new System.Windows.Forms.GroupBox();
            this.gpb_vista_tips_exam = new System.Windows.Forms.GroupBox();
            this.dgv_vist_tips_exam = new System.Windows.Forms.DataGridView();
            this.btn_busc_tip_exam = new System.Windows.Forms.Button();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.txt_busc_tips_exam = new System.Windows.Forms.TextBox();
            this.btn_nuevo_pcnt = new System.Windows.Forms.Button();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_renov_pcnt = new System.Windows.Forms.Button();
            this.btn_elim_pcnt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.gpb_tip_exam.SuspendLayout();
            this.gpb_vista_tips_exam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_tips_exam)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(12, 77);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 46;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(118, 77);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(278, 166);
            this.txt_descripcion.TabIndex = 45;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(40, 31);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 44;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(118, 31);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(278, 23);
            this.txt_nombre.TabIndex = 43;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(384, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(232, 34);
            this.Lbl_titulo.TabIndex = 41;
            this.Lbl_titulo.Text = "Tipo de Examen";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(842, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 101);
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // gpb_tip_exam
            // 
            this.gpb_tip_exam.Controls.Add(this.txt_nombre);
            this.gpb_tip_exam.Controls.Add(this.Lbl_nombre);
            this.gpb_tip_exam.Controls.Add(this.Lbl_descripcion);
            this.gpb_tip_exam.Controls.Add(this.txt_descripcion);
            this.gpb_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_tip_exam.Location = new System.Drawing.Point(12, 160);
            this.gpb_tip_exam.Name = "gpb_tip_exam";
            this.gpb_tip_exam.Size = new System.Drawing.Size(402, 251);
            this.gpb_tip_exam.TabIndex = 50;
            this.gpb_tip_exam.TabStop = false;
            this.gpb_tip_exam.Text = "Informacion del Examen";
            // 
            // gpb_vista_tips_exam
            // 
            this.gpb_vista_tips_exam.Controls.Add(this.dgv_vist_tips_exam);
            this.gpb_vista_tips_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_tips_exam.Location = new System.Drawing.Point(420, 161);
            this.gpb_vista_tips_exam.Name = "gpb_vista_tips_exam";
            this.gpb_vista_tips_exam.Size = new System.Drawing.Size(522, 250);
            this.gpb_vista_tips_exam.TabIndex = 51;
            this.gpb_vista_tips_exam.TabStop = false;
            this.gpb_vista_tips_exam.Text = "Tipos de Examenes";
            // 
            // dgv_vist_tips_exam
            // 
            this.dgv_vist_tips_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vist_tips_exam.Location = new System.Drawing.Point(6, 18);
            this.dgv_vist_tips_exam.Name = "dgv_vist_tips_exam";
            this.dgv_vist_tips_exam.Size = new System.Drawing.Size(510, 226);
            this.dgv_vist_tips_exam.TabIndex = 0;
            // 
            // btn_busc_tip_exam
            // 
            this.btn_busc_tip_exam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_tip_exam.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_tip_exam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_tip_exam.FlatAppearance.BorderSize = 0;
            this.btn_busc_tip_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_tip_exam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_tip_exam.Location = new System.Drawing.Point(296, 58);
            this.btn_busc_tip_exam.Name = "btn_busc_tip_exam";
            this.btn_busc_tip_exam.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_tip_exam.TabIndex = 134;
            this.btn_busc_tip_exam.Text = " ";
            this.btn_busc_tip_exam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip5.SetToolTip(this.btn_busc_tip_exam, "Buscar");
            this.btn_busc_tip_exam.UseVisualStyleBackColor = true;
            this.btn_busc_tip_exam.Click += new System.EventHandler(this.btn_busc_tip_exam_Click);
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_aseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_aseg.FlatAppearance.BorderSize = 0;
            this.btn_actlz_aseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(154, 57);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_aseg.TabIndex = 133;
            this.btn_actlz_aseg.Text = " ";
            this.btn_actlz_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_aseg, "Modificar");
            this.btn_actlz_aseg.UseVisualStyleBackColor = true;
            this.btn_actlz_aseg.Click += new System.EventHandler(this.btn_actlz_aseg_Click);
            // 
            // btn_guardar_aseg
            // 
            this.btn_guardar_aseg.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_aseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_aseg.FlatAppearance.BorderSize = 0;
            this.btn_guardar_aseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_aseg.Location = new System.Drawing.Point(83, 57);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_aseg.TabIndex = 132;
            this.btn_guardar_aseg.Text = " ";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_aseg, "Guardar");
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            this.btn_guardar_aseg.Click += new System.EventHandler(this.btn_guardar_aseg_Click);
            // 
            // lbl_busc_tip_exam
            // 
            this.lbl_busc_tip_exam.AutoSize = true;
            this.lbl_busc_tip_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(428, 135);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 50;
            this.lbl_busc_tip_exam.Text = "Buscar:";
            // 
            // txt_busc_tips_exam
            // 
            this.txt_busc_tips_exam.Location = new System.Drawing.Point(496, 135);
            this.txt_busc_tips_exam.Name = "txt_busc_tips_exam";
            this.txt_busc_tips_exam.Size = new System.Drawing.Size(220, 20);
            this.txt_busc_tips_exam.TabIndex = 51;
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(12, 57);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 141;
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
            this.btn_acept.Location = new System.Drawing.Point(442, 57);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 146;
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
            this.btn_cancl.Location = new System.Drawing.Point(367, 57);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 145;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // btn_renov_pcnt
            // 
            this.btn_renov_pcnt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_renov_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_renov_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_renov_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_renov_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_renov_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renov_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renov_pcnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_renov_pcnt.Location = new System.Drawing.Point(513, 57);
            this.btn_renov_pcnt.Name = "btn_renov_pcnt";
            this.btn_renov_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_renov_pcnt.TabIndex = 144;
            this.btn_renov_pcnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip8.SetToolTip(this.btn_renov_pcnt, "Actualizar");
            this.btn_renov_pcnt.UseVisualStyleBackColor = true;
            // 
            // btn_elim_pcnt
            // 
            this.btn_elim_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elim_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_elim_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_pcnt.Location = new System.Drawing.Point(225, 58);
            this.btn_elim_pcnt.Name = "btn_elim_pcnt";
            this.btn_elim_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_pcnt.TabIndex = 143;
            this.btn_elim_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_pcnt, "Eliminar");
            this.btn_elim_pcnt.UseVisualStyleBackColor = true;
            // 
            // frm_act_examenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 423);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_renov_pcnt);
            this.Controls.Add(this.btn_elim_pcnt);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_tip_exam);
            this.Controls.Add(this.txt_busc_tips_exam);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_tips_exam);
            this.Controls.Add(this.gpb_tip_exam);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_act_examenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Examenes";
            this.Load += new System.EventHandler(this.frm_act_examenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.gpb_tip_exam.ResumeLayout(false);
            this.gpb_tip_exam.PerformLayout();
            this.gpb_vista_tips_exam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_tips_exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_descripcion;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox gpb_tip_exam;
        private System.Windows.Forms.GroupBox gpb_vista_tips_exam;
        private System.Windows.Forms.DataGridView dgv_vist_tips_exam;
        private System.Windows.Forms.Button btn_busc_tip_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        internal System.Windows.Forms.TextBox txt_busc_tips_exam;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_renov_pcnt;
        private System.Windows.Forms.Button btn_elim_pcnt;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}