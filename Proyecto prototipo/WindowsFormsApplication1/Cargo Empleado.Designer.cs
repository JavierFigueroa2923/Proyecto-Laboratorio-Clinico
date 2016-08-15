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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargo_Empleado));
            this.lbl_cargo_emp = new System.Windows.Forms.Label();
            this.btn_elim_cargo_emp = new System.Windows.Forms.Button();
            this.btn_actlz_cargo_emp = new System.Windows.Forms.Button();
            this.btn_guardar_cargo_emp = new System.Windows.Forms.Button();
            this.pl_lab_cargo_emp = new System.Windows.Forms.PictureBox();
            this.gpb_datos_cargo_emp = new System.Windows.Forms.GroupBox();
            this.dtp_fec_contr_carg_emp = new System.Windows.Forms.DateTimePicker();
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            this.cbo_id_emp = new System.Windows.Forms.ComboBox();
            this.txt_descp_cargo_emp = new System.Windows.Forms.TextBox();
            this.txt_nombre_cargo_emp = new System.Windows.Forms.TextBox();
            this.Lbl_id_lab_cargo_emp = new System.Windows.Forms.Label();
            this.Lbl_nombre_cargo_emp = new System.Windows.Forms.Label();
            this.lbl_descrp_cargo_emp = new System.Windows.Forms.Label();
            this.Lbl_id_emp_cargo_emp = new System.Windows.Forms.Label();
            this.Lbl_fecha_contrat_cargo_emp = new System.Windows.Forms.Label();
            this.dgv_cargo_emp = new System.Windows.Forms.DataGridView();
            this.grb_vista_emp = new System.Windows.Forms.GroupBox();
            this.btn_rnv_cargo_emp = new System.Windows.Forms.Button();
            this.btn_busc_cargo_emp = new System.Windows.Forms.Button();
            this.txt_busc_cargo_emp = new System.Windows.Forms.TextBox();
            this.lbl_busca_cargo_emp = new System.Windows.Forms.Label();
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
            this.btn_elim_cargo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_cargo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_cargo_emp.FlatAppearance.BorderSize = 0;
            this.btn_elim_cargo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_cargo_emp.Location = new System.Drawing.Point(226, 52);
            this.btn_elim_cargo_emp.Name = "btn_elim_cargo_emp";
            this.btn_elim_cargo_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_cargo_emp.TabIndex = 140;
            this.btn_elim_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_cargo_emp, "Eliminar");
            this.btn_elim_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_elim_cargo_emp.Click += new System.EventHandler(this.btn_elim_cargo_emp_Click);
            // 
            // btn_actlz_cargo_emp
            // 
            this.btn_actlz_cargo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_cargo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_cargo_emp.FlatAppearance.BorderSize = 0;
            this.btn_actlz_cargo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_cargo_emp.Location = new System.Drawing.Point(155, 52);
            this.btn_actlz_cargo_emp.Name = "btn_actlz_cargo_emp";
            this.btn_actlz_cargo_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_cargo_emp.TabIndex = 139;
            this.btn_actlz_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_cargo_emp, "Modificar");
            this.btn_actlz_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_actlz_cargo_emp.Click += new System.EventHandler(this.btn_actlz_cargo_emp_Click);
            // 
            // btn_guardar_cargo_emp
            // 
            this.btn_guardar_cargo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_cargo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_cargo_emp.FlatAppearance.BorderSize = 0;
            this.btn_guardar_cargo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_cargo_emp.Location = new System.Drawing.Point(84, 52);
            this.btn_guardar_cargo_emp.Name = "btn_guardar_cargo_emp";
            this.btn_guardar_cargo_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_cargo_emp.TabIndex = 138;
            this.btn_guardar_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_cargo_emp, "Guardar");
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
            this.gpb_datos_cargo_emp.Controls.Add(this.dtp_fec_contr_carg_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.cbo_id_lab);
            this.gpb_datos_cargo_emp.Controls.Add(this.cbo_id_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.txt_descp_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.txt_nombre_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_id_lab_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_nombre_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.lbl_descrp_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_id_emp_cargo_emp);
            this.gpb_datos_cargo_emp.Controls.Add(this.Lbl_fecha_contrat_cargo_emp);
            this.gpb_datos_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_cargo_emp.Location = new System.Drawing.Point(6, 150);
            this.gpb_datos_cargo_emp.Name = "gpb_datos_cargo_emp";
            this.gpb_datos_cargo_emp.Size = new System.Drawing.Size(385, 310);
            this.gpb_datos_cargo_emp.TabIndex = 142;
            this.gpb_datos_cargo_emp.TabStop = false;
            this.gpb_datos_cargo_emp.Text = "Informacion General";
            // 
            // dtp_fec_contr_carg_emp
            // 
            this.dtp_fec_contr_carg_emp.Location = new System.Drawing.Point(118, 159);
            this.dtp_fec_contr_carg_emp.Name = "dtp_fec_contr_carg_emp";
            this.dtp_fec_contr_carg_emp.Size = new System.Drawing.Size(254, 23);
            this.dtp_fec_contr_carg_emp.TabIndex = 153;
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(172, 222);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(152, 24);
            this.cbo_id_lab.TabIndex = 152;
            // 
            // cbo_id_emp
            // 
            this.cbo_id_emp.FormattingEnabled = true;
            this.cbo_id_emp.Location = new System.Drawing.Point(172, 191);
            this.cbo_id_emp.Name = "cbo_id_emp";
            this.cbo_id_emp.Size = new System.Drawing.Size(152, 24);
            this.cbo_id_emp.TabIndex = 151;
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
            this.Lbl_id_lab_cargo_emp.Location = new System.Drawing.Point(9, 223);
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
            // Lbl_id_emp_cargo_emp
            // 
            this.Lbl_id_emp_cargo_emp.AutoSize = true;
            this.Lbl_id_emp_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_emp_cargo_emp.Location = new System.Drawing.Point(19, 195);
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
            this.dgv_cargo_emp.AllowUserToAddRows = false;
            this.dgv_cargo_emp.AllowUserToDeleteRows = false;
            this.dgv_cargo_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargo_emp.Location = new System.Drawing.Point(6, 22);
            this.dgv_cargo_emp.Name = "dgv_cargo_emp";
            this.dgv_cargo_emp.ReadOnly = true;
            this.dgv_cargo_emp.Size = new System.Drawing.Size(486, 307);
            this.dgv_cargo_emp.TabIndex = 0;
            // 
            // grb_vista_emp
            // 
            this.grb_vista_emp.Controls.Add(this.dgv_cargo_emp);
            this.grb_vista_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_emp.Location = new System.Drawing.Point(397, 150);
            this.grb_vista_emp.Name = "grb_vista_emp";
            this.grb_vista_emp.Size = new System.Drawing.Size(498, 310);
            this.grb_vista_emp.TabIndex = 143;
            this.grb_vista_emp.TabStop = false;
            this.grb_vista_emp.Text = "Cargos de Empleados";
            // 
            // btn_rnv_cargo_emp
            // 
            this.btn_rnv_cargo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_rnv_cargo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rnv_cargo_emp.FlatAppearance.BorderSize = 0;
            this.btn_rnv_cargo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rnv_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rnv_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rnv_cargo_emp.Location = new System.Drawing.Point(510, 52);
            this.btn_rnv_cargo_emp.Name = "btn_rnv_cargo_emp";
            this.btn_rnv_cargo_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_rnv_cargo_emp.TabIndex = 149;
            this.btn_rnv_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip8.SetToolTip(this.btn_rnv_cargo_emp, "Actualizar");
            this.btn_rnv_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_rnv_cargo_emp.Click += new System.EventHandler(this.btn_rnv_cargo_emp_Click);
            // 
            // btn_busc_cargo_emp
            // 
            this.btn_busc_cargo_emp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_cargo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_cargo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_cargo_emp.FlatAppearance.BorderSize = 0;
            this.btn_busc_cargo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_cargo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_cargo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_cargo_emp.Location = new System.Drawing.Point(297, 52);
            this.btn_busc_cargo_emp.Name = "btn_busc_cargo_emp";
            this.btn_busc_cargo_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_cargo_emp.TabIndex = 148;
            this.btn_busc_cargo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_cargo_emp, "Buscar");
            this.btn_busc_cargo_emp.UseVisualStyleBackColor = true;
            this.btn_busc_cargo_emp.Click += new System.EventHandler(this.btn_busc_cargo_emp_Click);
            // 
            // txt_busc_cargo_emp
            // 
            this.txt_busc_cargo_emp.Location = new System.Drawing.Point(566, 124);
            this.txt_busc_cargo_emp.Name = "txt_busc_cargo_emp";
            this.txt_busc_cargo_emp.Size = new System.Drawing.Size(264, 20);
            this.txt_busc_cargo_emp.TabIndex = 147;
            this.txt_busc_cargo_emp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_cargo_emp_KeyUp);
            // 
            // lbl_busca_cargo_emp
            // 
            this.lbl_busca_cargo_emp.AutoSize = true;
            this.lbl_busca_cargo_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_cargo_emp.Location = new System.Drawing.Point(498, 126);
            this.lbl_busca_cargo_emp.Name = "lbl_busca_cargo_emp";
            this.lbl_busca_cargo_emp.Size = new System.Drawing.Size(62, 20);
            this.lbl_busca_cargo_emp.TabIndex = 146;
            this.lbl_busca_cargo_emp.Text = "Buscar:";
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(13, 52);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 150;
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
            this.btn_acept.Location = new System.Drawing.Point(439, 52);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 152;
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
            this.btn_cancl.Location = new System.Drawing.Point(368, 52);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 151;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_pcnt_Click);
            // 
            // Cargo_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 481);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
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
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.DateTimePicker dtp_fec_contr_carg_emp;
    }
}