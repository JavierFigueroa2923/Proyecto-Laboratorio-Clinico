namespace WindowsFormsApplication1
{
    partial class Cargo_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargo_Empleado));
            this.lbl_cargo_emp = new System.Windows.Forms.Label();
            this.btn_elim_cargo_emp = new System.Windows.Forms.Button();
            this.btn_actlz_cargo_emp = new System.Windows.Forms.Button();
            this.btn_guardar_cargo_emp = new System.Windows.Forms.Button();
            this.pl_lab_cargo_emp = new System.Windows.Forms.PictureBox();
            this.gpb_datos_cargo_emp = new System.Windows.Forms.GroupBox();
            this.txt_descp_cargo_emp = new System.Windows.Forms.TextBox();
            this.txt_nombre_cargo_emp = new System.Windows.Forms.TextBox();
            this.Lbl_id_lab_cargo_emp = new System.Windows.Forms.Label();
            this.Lbl_nombre_cargo_emp = new System.Windows.Forms.Label();
            this.lbl_descrp_cargo_emp = new System.Windows.Forms.Label();
            this.txt_fecha_contrat_cargo_emp = new System.Windows.Forms.TextBox();
            this.Lbl_id_emp_cargo_emp = new System.Windows.Forms.Label();
            this.Lbl_fecha_contrat_cargo_emp = new System.Windows.Forms.Label();
            this.dgv_cargo_emp = new System.Windows.Forms.DataGridView();
            this.grb_vista_emp = new System.Windows.Forms.GroupBox();
            this.btn_rnv_cargo_emp = new System.Windows.Forms.Button();
            this.btn_busc_cargo_emp = new System.Windows.Forms.Button();
            this.txt_busc_cargo_emp = new System.Windows.Forms.TextBox();
            this.lbl_busca_cargo_emp = new System.Windows.Forms.Label();
            this.cbo_id_emp = new System.Windows.Forms.ComboBox();
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_cargo_emp)).BeginInit();
            this.gpb_datos_cargo_emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo_emp)).BeginInit();
            this.grb_vista_emp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cargo_emp
            // 
            this.lbl_cargo_emp.AutoSize = true;
            this.lbl_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo_emp.Location = new System.Drawing.Point(324, 9);
            this.lbl_cargo_emp.Name = "lbl_cargo_emp";
            this.lbl_cargo_emp.Size = new System.Drawing.Size(282, 32);
            this.lbl_cargo_emp.TabIndex = 0;
            this.lbl_cargo_emp.Text = "Cargo de Empleado";
            // 
            // btn_elim_cargo_emp
            // 
            this.btn_elim_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_cargo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_cargo_emp.Location = new System.Drawing.Point(212, 60);
            this.btn_elim_cargo_emp.Name = "btn_elim_cargo_emp";
            this.btn_elim_cargo_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_cargo_emp.TabIndex = 140;
            this.btn_elim_cargo_emp.Text = "ELIMINAR";
            this.btn_elim_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_elim_cargo_emp.Click += new System.EventHandler(this.btn_elim_cargo_emp_Click);
            // 
            // btn_actlz_cargo_emp
            // 
            this.btn_actlz_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_cargo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_cargo_emp.Location = new System.Drawing.Point(112, 60);
            this.btn_actlz_cargo_emp.Name = "btn_actlz_cargo_emp";
            this.btn_actlz_cargo_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_cargo_emp.TabIndex = 139;
            this.btn_actlz_cargo_emp.Text = "ACTUALIZAR";
            this.btn_actlz_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_actlz_cargo_emp.Click += new System.EventHandler(this.btn_actlz_cargo_emp_Click);
            // 
            // btn_guardar_cargo_emp
            // 
            this.btn_guardar_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_cargo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_cargo_emp.Location = new System.Drawing.Point(12, 60);
            this.btn_guardar_cargo_emp.Name = "btn_guardar_cargo_emp";
            this.btn_guardar_cargo_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_cargo_emp.TabIndex = 138;
            this.btn_guardar_cargo_emp.Text = "GUARDAR";
            this.btn_guardar_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_guardar_cargo_emp.Click += new System.EventHandler(this.btn_guardar_cargo_emp_Click);
            // 
            // pl_lab_cargo_emp
            // 
            this.pl_lab_cargo_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pl_lab_cargo_emp.Image = ((System.Drawing.Image)(resources.GetObject("pl_lab_cargo_emp.Image")));
            this.pl_lab_cargo_emp.Location = new System.Drawing.Point(795, 12);
            this.pl_lab_cargo_emp.Name = "pl_lab_cargo_emp";
            this.pl_lab_cargo_emp.Size = new System.Drawing.Size(100, 105);
            this.pl_lab_cargo_emp.TabIndex = 141;
            this.pl_lab_cargo_emp.TabStop = false;
            // 
            // gpb_datos_cargo_emp
            // 
            this.gpb_datos_cargo_emp.Controls.Add(this.cbo_id_lab);
            this.gpb_datos_cargo_emp.Controls.Add(this.cbo_id_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.txt_descp_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.txt_nombre_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_id_lab_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_nombre_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.lbl_descrp_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.txt_fecha_contrat_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_id_emp_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_fecha_contrat_cargo_emp);
            this.gpb_datos_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_cargo_emp.Location = new System.Drawing.Point(13, 120);
            this.gpb_datos_cargo_emp.Name = "gpb_datos_cargo_emp";
            this.gpb_datos_cargo_emp.Size = new System.Drawing.Size(385, 329);
            this.gpb_datos_cargo_emp.TabIndex = 142;
            this.gpb_datos_cargo_emp.TabStop = false;
            this.gpb_datos_cargo_emp.Text = "Informacion General";
            // 
            // txt_descp_cargo_emp
            // 
            this.txt_descp_cargo_emp.Location = new System.Drawing.Point(118, 75);
            this.txt_descp_cargo_emp.Multiline = true;
            this.txt_descp_cargo_emp.Name = "txt_descp_cargo_emp";
            this.txt_descp_cargo_emp.Size = new System.Drawing.Size(256, 55);
            this.txt_descp_cargo_emp.TabIndex = 145;
            // 
            // txt_nombre_cargo_emp
            // 
            this.txt_nombre_cargo_emp.Location = new System.Drawing.Point(119, 48);
            this.txt_nombre_cargo_emp.Name = "txt_nombre_cargo_emp";
            this.txt_nombre_cargo_emp.Size = new System.Drawing.Size(255, 23);
            this.txt_nombre_cargo_emp.TabIndex = 143;
            // 
            // Lbl_id_lab_cargo_emp
            // 
            this.Lbl_id_lab_cargo_emp.AutoSize = true;
            this.Lbl_id_lab_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_lab_cargo_emp.Location = new System.Drawing.Point(9, 194);
            this.Lbl_id_lab_cargo_emp.Name = "Lbl_id_lab_cargo_emp";
            this.Lbl_id_lab_cargo_emp.Size = new System.Drawing.Size(141, 20);
            this.Lbl_id_lab_cargo_emp.TabIndex = 149;
            this.Lbl_id_lab_cargo_emp.Text = "Id de Laboratorio:";
            // 
            // Lbl_nombre_cargo_emp
            // 
            this.Lbl_nombre_cargo_emp.AutoSize = true;
            this.Lbl_nombre_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_nombre_cargo_emp.Location = new System.Drawing.Point(9, 48);
            this.Lbl_nombre_cargo_emp.Name = "Lbl_nombre_cargo_emp";
            this.Lbl_nombre_cargo_emp.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre_cargo_emp.TabIndex = 144;
            this.Lbl_nombre_cargo_emp.Text = "Nombre:";
            // 
            // lbl_descrp_cargo_emp
            // 
            this.lbl_descrp_cargo_emp.AutoSize = true;
            this.lbl_descrp_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_descrp_cargo_emp.Location = new System.Drawing.Point(9, 75);
            this.lbl_descrp_cargo_emp.Name = "lbl_descrp_cargo_emp";
            this.lbl_descrp_cargo_emp.Size = new System.Drawing.Size(100, 20);
            this.lbl_descrp_cargo_emp.TabIndex = 146;
            this.lbl_descrp_cargo_emp.Text = "Descripción:";
            // 
            // txt_fecha_contrat_cargo_emp
            // 
            this.txt_fecha_contrat_cargo_emp.Location = new System.Drawing.Point(172, 136);
            this.txt_fecha_contrat_cargo_emp.Name = "txt_fecha_contrat_cargo_emp";
            this.txt_fecha_contrat_cargo_emp.Size = new System.Drawing.Size(202, 23);
            this.txt_fecha_contrat_cargo_emp.TabIndex = 148;
            // 
            // Lbl_id_emp_cargo_emp
            // 
            this.Lbl_id_emp_cargo_emp.AutoSize = true;
            this.Lbl_id_emp_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_emp_cargo_emp.Location = new System.Drawing.Point(9, 165);
            this.Lbl_id_emp_cargo_emp.Name = "Lbl_id_emp_cargo_emp";
            this.Lbl_id_emp_cargo_emp.Size = new System.Drawing.Size(130, 20);
            this.Lbl_id_emp_cargo_emp.TabIndex = 146;
            this.Lbl_id_emp_cargo_emp.Text = "Id de Empleado:";
            // 
            // Lbl_fecha_contrat_cargo_emp
            // 
            this.Lbl_fecha_contrat_cargo_emp.AutoSize = true;
            this.Lbl_fecha_contrat_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_fecha_contrat_cargo_emp.Location = new System.Drawing.Point(9, 136);
            this.Lbl_fecha_contrat_cargo_emp.Name = "Lbl_fecha_contrat_cargo_emp";
            this.Lbl_fecha_contrat_cargo_emp.Size = new System.Drawing.Size(161, 20);
            this.Lbl_fecha_contrat_cargo_emp.TabIndex = 147;
            this.Lbl_fecha_contrat_cargo_emp.Text = "Fecha Contratacion:";
            // 
            // dgv_cargo_emp
            // 
            this.dgv_cargo_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargo_emp.Location = new System.Drawing.Point(6, 19);
            this.dgv_cargo_emp.Name = "dgv_cargo_emp";
            this.dgv_cargo_emp.Size = new System.Drawing.Size(486, 310);
            this.dgv_cargo_emp.TabIndex = 0;
            // 
            // grb_vista_emp
            // 
            this.grb_vista_emp.Controls.Add(this.dgv_cargo_emp);
            this.grb_vista_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_emp.Location = new System.Drawing.Point(404, 120);
            this.grb_vista_emp.Name = "grb_vista_emp";
            this.grb_vista_emp.Size = new System.Drawing.Size(498, 329);
            this.grb_vista_emp.TabIndex = 143;
            this.grb_vista_emp.TabStop = false;
            this.grb_vista_emp.Text = "Cargos de Empleados";
            // 
            // btn_rnv_cargo_emp
            // 
            this.btn_rnv_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rnv_cargo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_rnv_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rnv_cargo_emp.Location = new System.Drawing.Point(725, 63);
            this.btn_rnv_cargo_emp.Name = "btn_rnv_cargo_emp";
            this.btn_rnv_cargo_emp.Size = new System.Drawing.Size(65, 54);
            this.btn_rnv_cargo_emp.TabIndex = 149;
            this.btn_rnv_cargo_emp.Text = "RENOVAR";
            this.btn_rnv_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rnv_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_rnv_cargo_emp.Click += new System.EventHandler(this.btn_rnv_cargo_emp_Click);
            // 
            // btn_busc_cargo_emp
            // 
            this.btn_busc_cargo_emp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_cargo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_cargo_emp.Location = new System.Drawing.Point(654, 65);
            this.btn_busc_cargo_emp.Name = "btn_busc_cargo_emp";
            this.btn_busc_cargo_emp.Size = new System.Drawing.Size(65, 52);
            this.btn_busc_cargo_emp.TabIndex = 148;
            this.btn_busc_cargo_emp.Text = "BUSCAR";
            this.btn_busc_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_busc_cargo_emp.Click += new System.EventHandler(this.btn_busc_cargo_emp_Click);
            // 
            // txt_busc_cargo_emp
            // 
            this.txt_busc_cargo_emp.Location = new System.Drawing.Point(440, 95);
            this.txt_busc_cargo_emp.Name = "txt_busc_cargo_emp";
            this.txt_busc_cargo_emp.Size = new System.Drawing.Size(208, 20);
            this.txt_busc_cargo_emp.TabIndex = 147;
            // 
            // lbl_busca_cargo_emp
            // 
            this.lbl_busca_cargo_emp.AutoSize = true;
            this.lbl_busca_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_cargo_emp.Location = new System.Drawing.Point(372, 97);
            this.lbl_busca_cargo_emp.Name = "lbl_busca_cargo_emp";
            this.lbl_busca_cargo_emp.Size = new System.Drawing.Size(62, 20);
            this.lbl_busca_cargo_emp.TabIndex = 146;
            this.lbl_busca_cargo_emp.Text = "Buscar:";
            // 
            // cbo_id_emp
            // 
            this.cbo_id_emp.FormattingEnabled = true;
            this.cbo_id_emp.Location = new System.Drawing.Point(172, 165);
            this.cbo_id_emp.Name = "cbo_id_emp";
            this.cbo_id_emp.Size = new System.Drawing.Size(152, 24);
            this.cbo_id_emp.TabIndex = 151;
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(172, 194);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(152, 24);
            this.cbo_id_lab.TabIndex = 152;
            // 
            // Cargo_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 481);
            this.Controls.Add(this.btn_rnv_cargo_emp);
            this.Controls.Add(this.btn_busc_cargo_emp);
            this.Controls.Add(this.txt_busc_cargo_emp);
            this.Controls.Add(this.lbl_busca_cargo_emp);
            this.Controls.Add(this.grb_vista_emp);
            this.Controls.Add(this.gpb_datos_cargo_emp);
            this.Controls.Add(this.pl_lab_cargo_emp);
            this.Controls.Add(this.btn_elim_cargo_emp);
            this.Controls.Add(this.btn_actlz_cargo_emp);
            this.Controls.Add(this.btn_guardar_cargo_emp);
            this.Controls.Add(this.lbl_cargo_emp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cargo_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargo Empleado";
            this.Load += new System.EventHandler(this.Cargo_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_cargo_emp)).EndInit();
            this.gpb_datos_cargo_emp.ResumeLayout(false);
            this.gpb_datos_cargo_emp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo_emp)).EndInit();
            this.grb_vista_emp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cargo_emp;
        private System.Windows.Forms.Button btn_elim_cargo_emp;
        private System.Windows.Forms.Button btn_actlz_cargo_emp;
        private System.Windows.Forms.Button btn_guardar_cargo_emp;
        internal System.Windows.Forms.PictureBox pl_lab_cargo_emp;
        private System.Windows.Forms.GroupBox gpb_datos_cargo_emp;
        internal System.Windows.Forms.TextBox txt_descp_cargo_emp;
        internal System.Windows.Forms.TextBox txt_nombre_cargo_emp;
        internal System.Windows.Forms.Label Lbl_id_lab_cargo_emp;
        internal System.Windows.Forms.Label Lbl_nombre_cargo_emp;
        internal System.Windows.Forms.Label lbl_descrp_cargo_emp;
        internal System.Windows.Forms.TextBox txt_fecha_contrat_cargo_emp;
        internal System.Windows.Forms.Label Lbl_id_emp_cargo_emp;
        internal System.Windows.Forms.Label Lbl_fecha_contrat_cargo_emp;
        private System.Windows.Forms.DataGridView dgv_cargo_emp;
        private System.Windows.Forms.GroupBox grb_vista_emp;
        private System.Windows.Forms.Button btn_rnv_cargo_emp;
        private System.Windows.Forms.Button btn_busc_cargo_emp;
        internal System.Windows.Forms.TextBox txt_busc_cargo_emp;
        internal System.Windows.Forms.Label lbl_busca_cargo_emp;
        private System.Windows.Forms.ComboBox cbo_id_lab;
        private System.Windows.Forms.ComboBox cbo_id_emp;
    }
}