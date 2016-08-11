namespace WindowsFormsApplication1
{
    partial class Resultado_examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultado_examen));
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.gpb_vista_result_exm = new System.Windows.Forms.GroupBox();
            this.dgv_vist_result_exam = new System.Windows.Forms.DataGridView();
            this.gpb_tip_exam = new System.Windows.Forms.GroupBox();
            this.Lbl_id_examen = new System.Windows.Forms.Label();
            this.txt_id_exm = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.btn_elim_resl_exam = new System.Windows.Forms.Button();
            this.btn_act_renov = new System.Windows.Forms.Button();
            this.btn_buscar_resl_exam = new System.Windows.Forms.Button();
            this.dtp_fecha_resul = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha_result_exam = new System.Windows.Forms.Label();
            this.cbo_buscar = new System.Windows.Forms.ComboBox();
            this.gpb_vista_result_exm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_result_exam)).BeginInit();
            this.gpb_tip_exam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_busc_tip_exam
            // 
            this.lbl_busc_tip_exam.AutoSize = true;
            this.lbl_busc_tip_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(436, 143);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 137;
            this.lbl_busc_tip_exam.Text = "Buscar:";
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(120, 97);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_aseg.TabIndex = 142;
            this.btn_actlz_aseg.Text = "ACTUALIZAR";
            this.btn_actlz_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_aseg.UseVisualStyleBackColor = true;
            this.btn_actlz_aseg.Click += new System.EventHandler(this.btn_actlz_aseg_Click);
            // 
            // btn_guardar_aseg
            // 
            this.btn_guardar_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_aseg.Location = new System.Drawing.Point(20, 97);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_aseg.TabIndex = 141;
            this.btn_guardar_aseg.Text = "GUARDAR";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            this.btn_guardar_aseg.Click += new System.EventHandler(this.btn_guardar_aseg_Click);
            // 
            // gpb_vista_result_exm
            // 
            this.gpb_vista_result_exm.Controls.Add(this.dgv_vist_result_exam);
            this.gpb_vista_result_exm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_result_exm.Location = new System.Drawing.Point(428, 172);
            this.gpb_vista_result_exm.Name = "gpb_vista_result_exm";
            this.gpb_vista_result_exm.Size = new System.Drawing.Size(459, 250);
            this.gpb_vista_result_exm.TabIndex = 140;
            this.gpb_vista_result_exm.TabStop = false;
            this.gpb_vista_result_exm.Text = "Resultado de Examen";
            // 
            // dgv_vist_result_exam
            // 
            this.dgv_vist_result_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vist_result_exam.Location = new System.Drawing.Point(6, 18);
            this.dgv_vist_result_exam.Name = "dgv_vist_result_exam";
            this.dgv_vist_result_exam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vist_result_exam.Size = new System.Drawing.Size(444, 226);
            this.dgv_vist_result_exam.TabIndex = 0;
            // 
            // gpb_tip_exam
            // 
            this.gpb_tip_exam.Controls.Add(this.lbl_fecha_result_exam);
            this.gpb_tip_exam.Controls.Add(this.dtp_fecha_resul);
            this.gpb_tip_exam.Controls.Add(this.Lbl_id_examen);
            this.gpb_tip_exam.Controls.Add(this.txt_id_exm);
            this.gpb_tip_exam.Controls.Add(this.Lbl_descripcion);
            this.gpb_tip_exam.Controls.Add(this.txt_descripcion);
            this.gpb_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_tip_exam.Location = new System.Drawing.Point(20, 171);
            this.gpb_tip_exam.Name = "gpb_tip_exam";
            this.gpb_tip_exam.Size = new System.Drawing.Size(402, 251);
            this.gpb_tip_exam.TabIndex = 138;
            this.gpb_tip_exam.TabStop = false;
            this.gpb_tip_exam.Text = "Informacion del Examen";
            // 
            // Lbl_id_examen
            // 
            this.Lbl_id_examen.AutoSize = true;
            this.Lbl_id_examen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_examen.Location = new System.Drawing.Point(12, 19);
            this.Lbl_id_examen.Name = "Lbl_id_examen";
            this.Lbl_id_examen.Size = new System.Drawing.Size(91, 20);
            this.Lbl_id_examen.TabIndex = 48;
            this.Lbl_id_examen.Text = "Id examen:";
            // 
            // txt_id_exm
            // 
            this.txt_id_exm.Location = new System.Drawing.Point(118, 19);
            this.txt_id_exm.Name = "txt_id_exm";
            this.txt_id_exm.Size = new System.Drawing.Size(191, 23);
            this.txt_id_exm.TabIndex = 49;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(12, 104);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 46;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(118, 104);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(278, 139);
            this.txt_descripcion.TabIndex = 45;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(778, 1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 101);
            this.PictureBox1.TabIndex = 136;
            this.PictureBox1.TabStop = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(258, 33);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(309, 34);
            this.Lbl_titulo.TabIndex = 135;
            this.Lbl_titulo.Text = "Resultado de Examen";
            // 
            // btn_elim_resl_exam
            // 
            this.btn_elim_resl_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_resl_exam.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_resl_exam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_resl_exam.Location = new System.Drawing.Point(220, 97);
            this.btn_elim_resl_exam.Name = "btn_elim_resl_exam";
            this.btn_elim_resl_exam.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_resl_exam.TabIndex = 152;
            this.btn_elim_resl_exam.Text = "ELIMINAR";
            this.btn_elim_resl_exam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_resl_exam.UseVisualStyleBackColor = true;
            this.btn_elim_resl_exam.Click += new System.EventHandler(this.btn_elim_resl_exam_Click);
            // 
            // btn_act_renov
            // 
            this.btn_act_renov.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act_renov.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_act_renov.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_act_renov.Location = new System.Drawing.Point(813, 119);
            this.btn_act_renov.Name = "btn_act_renov";
            this.btn_act_renov.Size = new System.Drawing.Size(65, 54);
            this.btn_act_renov.TabIndex = 156;
            this.btn_act_renov.Text = "RENOVAR";
            this.btn_act_renov.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_act_renov.UseVisualStyleBackColor = true;
            this.btn_act_renov.Click += new System.EventHandler(this.btn_act_renov_Click);
            // 
            // btn_buscar_resl_exam
            // 
            this.btn_buscar_resl_exam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar_resl_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_resl_exam.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_buscar_resl_exam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar_resl_exam.Location = new System.Drawing.Point(742, 119);
            this.btn_buscar_resl_exam.Name = "btn_buscar_resl_exam";
            this.btn_buscar_resl_exam.Size = new System.Drawing.Size(65, 52);
            this.btn_buscar_resl_exam.TabIndex = 157;
            this.btn_buscar_resl_exam.Text = "BUSCAR";
            this.btn_buscar_resl_exam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar_resl_exam.UseVisualStyleBackColor = true;
            this.btn_buscar_resl_exam.Click += new System.EventHandler(this.btn_buscar_resl_exam_Click);
            // 
            // dtp_fecha_resul
            // 
            this.dtp_fecha_resul.Location = new System.Drawing.Point(118, 68);
            this.dtp_fecha_resul.Name = "dtp_fecha_resul";
            this.dtp_fecha_resul.Size = new System.Drawing.Size(241, 23);
            this.dtp_fecha_resul.TabIndex = 50;
            // 
            // lbl_fecha_result_exam
            // 
            this.lbl_fecha_result_exam.AutoSize = true;
            this.lbl_fecha_result_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_result_exam.Location = new System.Drawing.Point(12, 45);
            this.lbl_fecha_result_exam.Name = "lbl_fecha_result_exam";
            this.lbl_fecha_result_exam.Size = new System.Drawing.Size(241, 20);
            this.lbl_fecha_result_exam.TabIndex = 51;
            this.lbl_fecha_result_exam.Text = "Fecha del resultado de examen";
            // 
            // cbo_buscar
            // 
            this.cbo_buscar.FormattingEnabled = true;
            this.cbo_buscar.Location = new System.Drawing.Point(505, 141);
            this.cbo_buscar.Name = "cbo_buscar";
            this.cbo_buscar.Size = new System.Drawing.Size(217, 21);
            this.cbo_buscar.TabIndex = 158;
            // 
            // Resultado_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 490);
            this.Controls.Add(this.cbo_buscar);
            this.Controls.Add(this.btn_buscar_resl_exam);
            this.Controls.Add(this.btn_act_renov);
            this.Controls.Add(this.btn_elim_resl_exam);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_result_exm);
            this.Controls.Add(this.gpb_tip_exam);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resultado_examen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado_examen";
            this.Load += new System.EventHandler(this.Resultado_examen_Load);
            this.gpb_vista_result_exm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_result_exam)).EndInit();
            this.gpb_tip_exam.ResumeLayout(false);
            this.gpb_tip_exam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.GroupBox gpb_vista_result_exm;
        private System.Windows.Forms.DataGridView dgv_vist_result_exam;
        private System.Windows.Forms.GroupBox gpb_tip_exam;
        internal System.Windows.Forms.Label Lbl_id_examen;
        internal System.Windows.Forms.TextBox txt_id_exm;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_descripcion;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button btn_elim_resl_exam;
        private System.Windows.Forms.Button btn_act_renov;
        private System.Windows.Forms.Button btn_buscar_resl_exam;
        private System.Windows.Forms.Label lbl_fecha_result_exam;
        private System.Windows.Forms.DateTimePicker dtp_fecha_resul;
        private System.Windows.Forms.ComboBox cbo_buscar;
    }
}