namespace WindowsFormsApplication1
{
    partial class Citas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.gpb_vista_cita = new System.Windows.Forms.GroupBox();
            this.dgv_vista_cita = new System.Windows.Forms.DataGridView();
            this.gpb_datos_cita = new System.Windows.Forms.GroupBox();
            this.cbo_estado_cita = new System.Windows.Forms.ComboBox();
            this.lbl_estado_cita = new System.Windows.Forms.Label();
            this.txt_hora_cita = new System.Windows.Forms.TextBox();
            this.lbl_id_cita = new System.Windows.Forms.Label();
            this.Lbl_id_lab_user = new System.Windows.Forms.Label();
            this.Lbl_fecha_cita = new System.Windows.Forms.Label();
            this.lbl_hora_cita = new System.Windows.Forms.Label();
            this.Lbl_id_emp_user = new System.Windows.Forms.Label();
            this.btn_rnv_cita = new System.Windows.Forms.Button();
            this.btn_busc_cita = new System.Windows.Forms.Button();
            this.txt_busc_cita = new System.Windows.Forms.TextBox();
            this.lbl_busca_cita = new System.Windows.Forms.Label();
            this.pl_lab_cita = new System.Windows.Forms.PictureBox();
            this.btn_elim_cita = new System.Windows.Forms.Button();
            this.btn_actlz_cita = new System.Windows.Forms.Button();
            this.btn_guardar_cita = new System.Windows.Forms.Button();
            this.lbl_cita = new System.Windows.Forms.Label();
            this.cbo_id_emp = new System.Windows.Forms.ComboBox();
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.gpb_vista_cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_cita)).BeginInit();
            this.gpb_datos_cita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_cita)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_vista_cita
            // 
            this.gpb_vista_cita.Controls.Add(this.dgv_vista_cita);
            this.gpb_vista_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_cita.Location = new System.Drawing.Point(353, 123);
            this.gpb_vista_cita.Name = "gpb_vista_cita";
            this.gpb_vista_cita.Size = new System.Drawing.Size(436, 198);
            this.gpb_vista_cita.TabIndex = 171;
            this.gpb_vista_cita.TabStop = false;
            this.gpb_vista_cita.Text = "Citas";
            this.gpb_vista_cita.Enter += new System.EventHandler(this.gpb_vista_cita_Enter);
            // 
            // dgv_vista_cita
            // 
            this.dgv_vista_cita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_cita.Location = new System.Drawing.Point(7, 19);
            this.dgv_vista_cita.Name = "dgv_vista_cita";
            this.dgv_vista_cita.Size = new System.Drawing.Size(423, 173);
            this.dgv_vista_cita.TabIndex = 0;
            // 
            // gpb_datos_cita
            // 
            this.gpb_datos_cita.Controls.Add(this.dtp_fecha);
            this.gpb_datos_cita.Controls.Add(this.cbo_id_lab);
            this.gpb_datos_cita.Controls.Add(this.cbo_id_emp);
            this.gpb_datos_cita.Controls.Add(this.cbo_estado_cita);
            this.gpb_datos_cita.Controls.Add(this.lbl_estado_cita);
            this.gpb_datos_cita.Controls.Add(this.txt_hora_cita);
            this.gpb_datos_cita.Controls.Add(this.lbl_id_cita);
            this.gpb_datos_cita.Controls.Add(this.Lbl_id_lab_user);
            this.gpb_datos_cita.Controls.Add(this.Lbl_fecha_cita);
            this.gpb_datos_cita.Controls.Add(this.lbl_hora_cita);
            this.gpb_datos_cita.Controls.Add(this.Lbl_id_emp_user);
            this.gpb_datos_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_cita.Location = new System.Drawing.Point(12, 123);
            this.gpb_datos_cita.Name = "gpb_datos_cita";
            this.gpb_datos_cita.Size = new System.Drawing.Size(335, 206);
            this.gpb_datos_cita.TabIndex = 170;
            this.gpb_datos_cita.TabStop = false;
            this.gpb_datos_cita.Text = "Informacion General";
            // 
            // cbo_estado_cita
            // 
            this.cbo_estado_cita.FormattingEnabled = true;
            this.cbo_estado_cita.Location = new System.Drawing.Point(147, 172);
            this.cbo_estado_cita.Name = "cbo_estado_cita";
            this.cbo_estado_cita.Size = new System.Drawing.Size(171, 24);
            this.cbo_estado_cita.TabIndex = 158;
            // 
            // lbl_estado_cita
            // 
            this.lbl_estado_cita.AutoSize = true;
            this.lbl_estado_cita.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_estado_cita.Location = new System.Drawing.Point(9, 172);
            this.lbl_estado_cita.Name = "lbl_estado_cita";
            this.lbl_estado_cita.Size = new System.Drawing.Size(62, 20);
            this.lbl_estado_cita.TabIndex = 156;
            this.lbl_estado_cita.Text = "Estado:";
            // 
            // txt_hora_cita
            // 
            this.txt_hora_cita.Location = new System.Drawing.Point(81, 53);
            this.txt_hora_cita.Name = "txt_hora_cita";
            this.txt_hora_cita.PasswordChar = '*';
            this.txt_hora_cita.Size = new System.Drawing.Size(237, 23);
            this.txt_hora_cita.TabIndex = 145;
            // 
            // lbl_id_cita
            // 
            this.lbl_id_cita.AutoSize = true;
            this.lbl_id_cita.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_cita.Location = new System.Drawing.Point(9, 19);
            this.lbl_id_cita.Name = "lbl_id_cita";
            this.lbl_id_cita.Size = new System.Drawing.Size(0, 20);
            this.lbl_id_cita.TabIndex = 152;
            // 
            // Lbl_id_lab_user
            // 
            this.Lbl_id_lab_user.AutoSize = true;
            this.Lbl_id_lab_user.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_lab_user.Location = new System.Drawing.Point(9, 133);
            this.Lbl_id_lab_user.Name = "Lbl_id_lab_user";
            this.Lbl_id_lab_user.Size = new System.Drawing.Size(141, 20);
            this.Lbl_id_lab_user.TabIndex = 149;
            this.Lbl_id_lab_user.Text = "Id de Laboratorio:";
            // 
            // Lbl_fecha_cita
            // 
            this.Lbl_fecha_cita.AutoSize = true;
            this.Lbl_fecha_cita.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_fecha_cita.Location = new System.Drawing.Point(9, 19);
            this.Lbl_fecha_cita.Name = "Lbl_fecha_cita";
            this.Lbl_fecha_cita.Size = new System.Drawing.Size(59, 20);
            this.Lbl_fecha_cita.TabIndex = 144;
            this.Lbl_fecha_cita.Text = "Fecha:";
            this.Lbl_fecha_cita.Click += new System.EventHandler(this.Lbl_fecha_cita_Click);
            // 
            // lbl_hora_cita
            // 
            this.lbl_hora_cita.AutoSize = true;
            this.lbl_hora_cita.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_hora_cita.Location = new System.Drawing.Point(9, 53);
            this.lbl_hora_cita.Name = "lbl_hora_cita";
            this.lbl_hora_cita.Size = new System.Drawing.Size(66, 20);
            this.lbl_hora_cita.TabIndex = 146;
            this.lbl_hora_cita.Text = "Horario:";
            // 
            // Lbl_id_emp_user
            // 
            this.Lbl_id_emp_user.AutoSize = true;
            this.Lbl_id_emp_user.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_emp_user.Location = new System.Drawing.Point(9, 91);
            this.Lbl_id_emp_user.Name = "Lbl_id_emp_user";
            this.Lbl_id_emp_user.Size = new System.Drawing.Size(130, 20);
            this.Lbl_id_emp_user.TabIndex = 146;
            this.Lbl_id_emp_user.Text = "Id de Empleado:";
            // 
            // btn_rnv_cita
            // 
            this.btn_rnv_cita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rnv_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rnv_cita.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_rnv_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rnv_cita.Location = new System.Drawing.Point(617, 67);
            this.btn_rnv_cita.Name = "btn_rnv_cita";
            this.btn_rnv_cita.Size = new System.Drawing.Size(65, 54);
            this.btn_rnv_cita.TabIndex = 169;
            this.btn_rnv_cita.Text = "RENOVAR";
            this.btn_rnv_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rnv_cita.UseVisualStyleBackColor = true;
            // 
            // btn_busc_cita
            // 
            this.btn_busc_cita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_busc_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_cita.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_cita.Location = new System.Drawing.Point(546, 67);
            this.btn_busc_cita.Name = "btn_busc_cita";
            this.btn_busc_cita.Size = new System.Drawing.Size(65, 52);
            this.btn_busc_cita.TabIndex = 168;
            this.btn_busc_cita.Text = "BUSCAR";
            this.btn_busc_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_cita.UseVisualStyleBackColor = true;
            // 
            // txt_busc_cita
            // 
            this.txt_busc_cita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busc_cita.Location = new System.Drawing.Point(415, 97);
            this.txt_busc_cita.Name = "txt_busc_cita";
            this.txt_busc_cita.Size = new System.Drawing.Size(125, 20);
            this.txt_busc_cita.TabIndex = 167;
            // 
            // lbl_busca_cita
            // 
            this.lbl_busca_cita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_busca_cita.AutoSize = true;
            this.lbl_busca_cita.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_cita.Location = new System.Drawing.Point(347, 97);
            this.lbl_busca_cita.Name = "lbl_busca_cita";
            this.lbl_busca_cita.Size = new System.Drawing.Size(62, 20);
            this.lbl_busca_cita.TabIndex = 166;
            this.lbl_busca_cita.Text = "Buscar:";
            // 
            // pl_lab_cita
            // 
            this.pl_lab_cita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_lab_cita.Image = ((System.Drawing.Image)(resources.GetObject("pl_lab_cita.Image")));
            this.pl_lab_cita.Location = new System.Drawing.Point(688, 12);
            this.pl_lab_cita.Name = "pl_lab_cita";
            this.pl_lab_cita.Size = new System.Drawing.Size(100, 105);
            this.pl_lab_cita.TabIndex = 165;
            this.pl_lab_cita.TabStop = false;
            // 
            // btn_elim_cita
            // 
            this.btn_elim_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_cita.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_cita.Location = new System.Drawing.Point(213, 63);
            this.btn_elim_cita.Name = "btn_elim_cita";
            this.btn_elim_cita.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_cita.TabIndex = 164;
            this.btn_elim_cita.Text = "ELIMINAR";
            this.btn_elim_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_cita.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_cita
            // 
            this.btn_actlz_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_cita.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_cita.Location = new System.Drawing.Point(112, 63);
            this.btn_actlz_cita.Name = "btn_actlz_cita";
            this.btn_actlz_cita.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_cita.TabIndex = 163;
            this.btn_actlz_cita.Text = "ACTUALIZAR";
            this.btn_actlz_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_cita.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_cita
            // 
            this.btn_guardar_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_cita.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_cita.Location = new System.Drawing.Point(12, 63);
            this.btn_guardar_cita.Name = "btn_guardar_cita";
            this.btn_guardar_cita.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_cita.TabIndex = 162;
            this.btn_guardar_cita.Text = "GUARDAR";
            this.btn_guardar_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_cita.UseVisualStyleBackColor = true;
            this.btn_guardar_cita.Click += new System.EventHandler(this.btn_guardar_cita_Click);
            // 
            // lbl_cita
            // 
            this.lbl_cita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cita.AutoSize = true;
            this.lbl_cita.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cita.Location = new System.Drawing.Point(273, 9);
            this.lbl_cita.Name = "lbl_cita";
            this.lbl_cita.Size = new System.Drawing.Size(257, 32);
            this.lbl_cita.TabIndex = 161;
            this.lbl_cita.Text = "Citas de Pacientes";
            // 
            // cbo_id_emp
            // 
            this.cbo_id_emp.FormattingEnabled = true;
            this.cbo_id_emp.Location = new System.Drawing.Point(148, 91);
            this.cbo_id_emp.Name = "cbo_id_emp";
            this.cbo_id_emp.Size = new System.Drawing.Size(170, 24);
            this.cbo_id_emp.TabIndex = 159;
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(148, 133);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(170, 24);
            this.cbo_id_lab.TabIndex = 160;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(81, 22);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(237, 23);
            this.dtp_fecha.TabIndex = 161;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.gpb_vista_cita);
            this.Controls.Add(this.gpb_datos_cita);
            this.Controls.Add(this.btn_rnv_cita);
            this.Controls.Add(this.btn_busc_cita);
            this.Controls.Add(this.txt_busc_cita);
            this.Controls.Add(this.lbl_busca_cita);
            this.Controls.Add(this.pl_lab_cita);
            this.Controls.Add(this.btn_elim_cita);
            this.Controls.Add(this.btn_actlz_cita);
            this.Controls.Add(this.btn_guardar_cita);
            this.Controls.Add(this.lbl_cita);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita";
            this.gpb_vista_cita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_cita)).EndInit();
            this.gpb_datos_cita.ResumeLayout(false);
            this.gpb_datos_cita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_cita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_vista_cita;
        private System.Windows.Forms.DataGridView dgv_vista_cita;
        private System.Windows.Forms.GroupBox gpb_datos_cita;
        private System.Windows.Forms.ComboBox cbo_estado_cita;
        internal System.Windows.Forms.Label lbl_estado_cita;
        internal System.Windows.Forms.TextBox txt_hora_cita;
        internal System.Windows.Forms.Label lbl_id_cita;
        internal System.Windows.Forms.Label Lbl_id_lab_user;
        internal System.Windows.Forms.Label Lbl_fecha_cita;
        internal System.Windows.Forms.Label lbl_hora_cita;
        internal System.Windows.Forms.Label Lbl_id_emp_user;
        private System.Windows.Forms.Button btn_rnv_cita;
        private System.Windows.Forms.Button btn_busc_cita;
        internal System.Windows.Forms.TextBox txt_busc_cita;
        internal System.Windows.Forms.Label lbl_busca_cita;
        internal System.Windows.Forms.PictureBox pl_lab_cita;
        private System.Windows.Forms.Button btn_elim_cita;
        private System.Windows.Forms.Button btn_actlz_cita;
        private System.Windows.Forms.Button btn_guardar_cita;
        private System.Windows.Forms.Label lbl_cita;
        private System.Windows.Forms.ComboBox cbo_id_lab;
        private System.Windows.Forms.ComboBox cbo_id_emp;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
    }
}