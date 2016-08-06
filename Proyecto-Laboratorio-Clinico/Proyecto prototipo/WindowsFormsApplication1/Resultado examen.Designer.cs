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
            this.btn_busc_tip_exam = new System.Windows.Forms.Button();
            this.txt_busc_tips_exam = new System.Windows.Forms.TextBox();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.gpb_vista_result_exm = new System.Windows.Forms.GroupBox();
            this.dgv_vist_result_exam = new System.Windows.Forms.DataGridView();
            this.gpb_tip_exam = new System.Windows.Forms.GroupBox();
            this.Lbl_id_examen = new System.Windows.Forms.Label();
            this.txt_id_exm = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
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
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(436, 151);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 137;
            this.lbl_busc_tip_exam.Text = "Buscar:";
            // 
            // btn_busc_tip_exam
            // 
            this.btn_busc_tip_exam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_tip_exam.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_tip_exam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_tip_exam.Location = new System.Drawing.Point(730, 134);
            this.btn_busc_tip_exam.Name = "btn_busc_tip_exam";
            this.btn_busc_tip_exam.Size = new System.Drawing.Size(114, 40);
            this.btn_busc_tip_exam.TabIndex = 143;
            this.btn_busc_tip_exam.Text = "BUSCAR";
            this.btn_busc_tip_exam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_tip_exam.UseVisualStyleBackColor = true;
            // 
            // txt_busc_tips_exam
            // 
            this.txt_busc_tips_exam.Location = new System.Drawing.Point(504, 151);
            this.txt_busc_tips_exam.Name = "txt_busc_tips_exam";
            this.txt_busc_tips_exam.Size = new System.Drawing.Size(220, 20);
            this.txt_busc_tips_exam.TabIndex = 139;
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(120, 111);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_aseg.TabIndex = 142;
            this.btn_actlz_aseg.Text = "ACTUALIZAR";
            this.btn_actlz_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_aseg.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_aseg
            // 
            this.btn_guardar_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_aseg.Location = new System.Drawing.Point(20, 111);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_aseg.TabIndex = 141;
            this.btn_guardar_aseg.Text = "GUARDAR";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            // 
            // gpb_vista_result_exm
            // 
            this.gpb_vista_result_exm.Controls.Add(this.dgv_vist_result_exam);
            this.gpb_vista_result_exm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_result_exm.Location = new System.Drawing.Point(428, 172);
            this.gpb_vista_result_exm.Name = "gpb_vista_result_exm";
            this.gpb_vista_result_exm.Size = new System.Drawing.Size(522, 250);
            this.gpb_vista_result_exm.TabIndex = 140;
            this.gpb_vista_result_exm.TabStop = false;
            this.gpb_vista_result_exm.Text = "Resultado de Examen";
            // 
            // dgv_vist_result_exam
            // 
            this.dgv_vist_result_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vist_result_exam.Location = new System.Drawing.Point(6, 18);
            this.dgv_vist_result_exam.Name = "dgv_vist_result_exam";
            this.dgv_vist_result_exam.Size = new System.Drawing.Size(510, 226);
            this.dgv_vist_result_exam.TabIndex = 0;
            // 
            // gpb_tip_exam
            // 
            this.gpb_tip_exam.Controls.Add(this.Lbl_id_examen);
            this.gpb_tip_exam.Controls.Add(this.txt_id_exm);
            this.gpb_tip_exam.Controls.Add(this.txt_nombre);
            this.gpb_tip_exam.Controls.Add(this.Lbl_nombre);
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
            this.Lbl_id_examen.Location = new System.Drawing.Point(21, 19);
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
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(118, 48);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(278, 23);
            this.txt_nombre.TabIndex = 43;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(40, 48);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 44;
            this.Lbl_nombre.Text = "Nombre:";
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
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(850, 68);
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
            this.Lbl_titulo.Location = new System.Drawing.Point(299, 68);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(309, 34);
            this.Lbl_titulo.TabIndex = 135;
            this.Lbl_titulo.Text = "Resultado de Examen";
            // 
            // Resultado_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 490);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_tip_exam);
            this.Controls.Add(this.txt_busc_tips_exam);
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
        private System.Windows.Forms.Button btn_busc_tip_exam;
        internal System.Windows.Forms.TextBox txt_busc_tips_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.GroupBox gpb_vista_result_exm;
        private System.Windows.Forms.DataGridView dgv_vist_result_exam;
        private System.Windows.Forms.GroupBox gpb_tip_exam;
        internal System.Windows.Forms.Label Lbl_id_examen;
        internal System.Windows.Forms.TextBox txt_id_exm;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_descripcion;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
    }
}