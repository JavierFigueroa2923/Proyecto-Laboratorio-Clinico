﻿namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas));
            this.gpb_vista_cita = new System.Windows.Forms.GroupBox();
            this.dgv_vista_cita = new System.Windows.Forms.DataGridView();
            this.gpb_datos_cita = new System.Windows.Forms.GroupBox();
            this.cbo_hora1_cit = new System.Windows.Forms.ComboBox();
            this.dtp_fec_cit = new System.Windows.Forms.DateTimePicker();
            this.Lbl_hora_cit = new System.Windows.Forms.Label();
            this.cbo_id_lab_cit = new System.Windows.Forms.ComboBox();
            this.cbo_id_clt_cit = new System.Windows.Forms.ComboBox();
            this.Lbl_id_lab_cit = new System.Windows.Forms.Label();
            this.Lbl_fecha_cita = new System.Windows.Forms.Label();
            this.Lbl_id_emp_cit = new System.Windows.Forms.Label();
            this.btn_rnv_cita = new System.Windows.Forms.Button();
            this.btn_busc_cita = new System.Windows.Forms.Button();
            this.txt_busc_cit = new System.Windows.Forms.TextBox();
            this.lbl_busca_cita = new System.Windows.Forms.Label();
            this.pl_lab_cita = new System.Windows.Forms.PictureBox();
            this.btn_elim_cita = new System.Windows.Forms.Button();
            this.btn_actlz_cita = new System.Windows.Forms.Button();
            this.btn_guardar_cita = new System.Windows.Forms.Button();
            this.lbl_cita = new System.Windows.Forms.Label();
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
            this.gpb_vista_cita.Location = new System.Drawing.Point(352, 159);
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
            this.gpb_datos_cita.Controls.Add(this.cbo_hora1_cit);
            this.gpb_datos_cita.Controls.Add(this.dtp_fec_cit);
            this.gpb_datos_cita.Controls.Add(this.Lbl_hora_cit);
            this.gpb_datos_cita.Controls.Add(this.cbo_id_lab_cit);
            this.gpb_datos_cita.Controls.Add(this.cbo_id_clt_cit);
            this.gpb_datos_cita.Controls.Add(this.Lbl_id_lab_cit);
            this.gpb_datos_cita.Controls.Add(this.Lbl_fecha_cita);
            this.gpb_datos_cita.Controls.Add(this.Lbl_id_emp_cit);
            this.gpb_datos_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_cita.Location = new System.Drawing.Point(11, 159);
            this.gpb_datos_cita.Name = "gpb_datos_cita";
            this.gpb_datos_cita.Size = new System.Drawing.Size(335, 198);
            this.gpb_datos_cita.TabIndex = 170;
            this.gpb_datos_cita.TabStop = false;
            this.gpb_datos_cita.Text = "Informacion General";
            // 
            // cbo_hora1_cit
            // 
            this.cbo_hora1_cit.FormattingEnabled = true;
            this.cbo_hora1_cit.Items.AddRange(new object[] {
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.cbo_hora1_cit.Location = new System.Drawing.Point(155, 52);
            this.cbo_hora1_cit.Name = "cbo_hora1_cit";
            this.cbo_hora1_cit.Size = new System.Drawing.Size(57, 24);
            this.cbo_hora1_cit.TabIndex = 2;
            // 
            // dtp_fec_cit
            // 
            this.dtp_fec_cit.Location = new System.Drawing.Point(73, 21);
            this.dtp_fec_cit.Name = "dtp_fec_cit";
            this.dtp_fec_cit.Size = new System.Drawing.Size(253, 23);
            this.dtp_fec_cit.TabIndex = 1;
            // 
            // Lbl_hora_cit
            // 
            this.Lbl_hora_cit.AutoSize = true;
            this.Lbl_hora_cit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_hora_cit.Location = new System.Drawing.Point(96, 52);
            this.Lbl_hora_cit.Name = "Lbl_hora_cit";
            this.Lbl_hora_cit.Size = new System.Drawing.Size(48, 20);
            this.Lbl_hora_cit.TabIndex = 162;
            this.Lbl_hora_cit.Text = "Hora:";
            this.Lbl_hora_cit.Click += new System.EventHandler(this.Lbl_hora_cit_Click);
            // 
            // cbo_id_lab_cit
            // 
            this.cbo_id_lab_cit.FormattingEnabled = true;
            this.cbo_id_lab_cit.Location = new System.Drawing.Point(156, 111);
            this.cbo_id_lab_cit.Name = "cbo_id_lab_cit";
            this.cbo_id_lab_cit.Size = new System.Drawing.Size(171, 24);
            this.cbo_id_lab_cit.TabIndex = 4;
            // 
            // cbo_id_clt_cit
            // 
            this.cbo_id_clt_cit.FormattingEnabled = true;
            this.cbo_id_clt_cit.Location = new System.Drawing.Point(155, 81);
            this.cbo_id_clt_cit.Name = "cbo_id_clt_cit";
            this.cbo_id_clt_cit.Size = new System.Drawing.Size(171, 24);
            this.cbo_id_clt_cit.TabIndex = 3;
            // 
            // Lbl_id_lab_cit
            // 
            this.Lbl_id_lab_cit.AutoSize = true;
            this.Lbl_id_lab_cit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_lab_cit.Location = new System.Drawing.Point(9, 115);
            this.Lbl_id_lab_cit.Name = "Lbl_id_lab_cit";
            this.Lbl_id_lab_cit.Size = new System.Drawing.Size(141, 20);
            this.Lbl_id_lab_cit.TabIndex = 149;
            this.Lbl_id_lab_cit.Text = "Id de Laboratorio:";
            // 
            // Lbl_fecha_cita
            // 
            this.Lbl_fecha_cita.AutoSize = true;
            this.Lbl_fecha_cita.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_fecha_cita.Location = new System.Drawing.Point(8, 21);
            this.Lbl_fecha_cita.Name = "Lbl_fecha_cita";
            this.Lbl_fecha_cita.Size = new System.Drawing.Size(59, 20);
            this.Lbl_fecha_cita.TabIndex = 144;
            this.Lbl_fecha_cita.Text = "Fecha:";
            this.Lbl_fecha_cita.Click += new System.EventHandler(this.Lbl_fecha_cita_Click);
            // 
            // Lbl_id_emp_cit
            // 
            this.Lbl_id_emp_cit.AutoSize = true;
            this.Lbl_id_emp_cit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_emp_cit.Location = new System.Drawing.Point(41, 81);
            this.Lbl_id_emp_cit.Name = "Lbl_id_emp_cit";
            this.Lbl_id_emp_cit.Size = new System.Drawing.Size(108, 20);
            this.Lbl_id_emp_cit.TabIndex = 146;
            this.Lbl_id_emp_cit.Text = "Id de Cliente:";
            // 
            // btn_rnv_cita
            // 
            this.btn_rnv_cita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rnv_cita.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_rnv_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rnv_cita.FlatAppearance.BorderSize = 0;
            this.btn_rnv_cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rnv_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rnv_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rnv_cita.Location = new System.Drawing.Point(508, 51);
            this.btn_rnv_cita.Name = "btn_rnv_cita";
            this.btn_rnv_cita.Size = new System.Drawing.Size(65, 65);
            this.btn_rnv_cita.TabIndex = 8;
            this.btn_rnv_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip8.SetToolTip(this.btn_rnv_cita, "Actualizar");
            this.btn_rnv_cita.UseVisualStyleBackColor = true;
            this.btn_rnv_cita.Click += new System.EventHandler(this.btn_rnv_cita_Click);
            // 
            // btn_busc_cita
            // 
            this.btn_busc_cita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_busc_cita.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_cita.FlatAppearance.BorderSize = 0;
            this.btn_busc_cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_cita.Location = new System.Drawing.Point(295, 51);
            this.btn_busc_cita.Name = "btn_busc_cita";
            this.btn_busc_cita.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_cita.TabIndex = 7;
            this.btn_busc_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_cita, "Buscar");
            this.btn_busc_cita.UseVisualStyleBackColor = true;
            this.btn_busc_cita.Click += new System.EventHandler(this.btn_busc_cita_Click);
            // 
            // txt_busc_cit
            // 
            this.txt_busc_cit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busc_cit.Location = new System.Drawing.Point(470, 133);
            this.txt_busc_cit.Name = "txt_busc_cit";
            this.txt_busc_cit.Size = new System.Drawing.Size(265, 20);
            this.txt_busc_cit.TabIndex = 6;
            this.txt_busc_cit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_busquedacita_KeyUp);
            // 
            // lbl_busca_cita
            // 
            this.lbl_busca_cita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_busca_cita.AutoSize = true;
            this.lbl_busca_cita.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_cita.Location = new System.Drawing.Point(402, 133);
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
            this.btn_elim_cita.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_cita.FlatAppearance.BorderSize = 0;
            this.btn_elim_cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_cita.Location = new System.Drawing.Point(224, 51);
            this.btn_elim_cita.Name = "btn_elim_cita";
            this.btn_elim_cita.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_cita.TabIndex = 10;
            this.btn_elim_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_cita, "Eliminar");
            this.btn_elim_cita.UseVisualStyleBackColor = true;
            this.btn_elim_cita.Click += new System.EventHandler(this.btn_elim_cita_Click);
            // 
            // btn_actlz_cita
            // 
            this.btn_actlz_cita.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_cita.FlatAppearance.BorderSize = 0;
            this.btn_actlz_cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_cita.Location = new System.Drawing.Point(153, 51);
            this.btn_actlz_cita.Name = "btn_actlz_cita";
            this.btn_actlz_cita.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_cita.TabIndex = 9;
            this.btn_actlz_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_cita, "Modificar");
            this.btn_actlz_cita.UseVisualStyleBackColor = true;
            this.btn_actlz_cita.Click += new System.EventHandler(this.btn_actlz_cita_Click);
            // 
            // btn_guardar_cita
            // 
            this.btn_guardar_cita.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_cita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_cita.FlatAppearance.BorderSize = 0;
            this.btn_guardar_cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_cita.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_cita.Location = new System.Drawing.Point(82, 51);
            this.btn_guardar_cita.Name = "btn_guardar_cita";
            this.btn_guardar_cita.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_cita.TabIndex = 5;
            this.btn_guardar_cita.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_cita, "Guardar");
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
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(11, 51);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 172;
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
            this.btn_acept.Location = new System.Drawing.Point(437, 51);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 174;
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
            this.btn_cancl.Location = new System.Drawing.Point(366, 51);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 173;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_pcnt_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.gpb_vista_cita);
            this.Controls.Add(this.gpb_datos_cita);
            this.Controls.Add(this.btn_rnv_cita);
            this.Controls.Add(this.btn_busc_cita);
            this.Controls.Add(this.txt_busc_cit);
            this.Controls.Add(this.lbl_busca_cita);
            this.Controls.Add(this.pl_lab_cita);
            this.Controls.Add(this.btn_elim_cita);
            this.Controls.Add(this.btn_actlz_cita);
            this.Controls.Add(this.btn_guardar_cita);
            this.Controls.Add(this.lbl_cita);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Citas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cita";
            this.Load += new System.EventHandler(this.Citas_Load);
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
        internal System.Windows.Forms.Label Lbl_id_lab_cit;
        internal System.Windows.Forms.Label Lbl_fecha_cita;
        internal System.Windows.Forms.Label Lbl_id_emp_cit;
        private System.Windows.Forms.Button btn_rnv_cita;
        private System.Windows.Forms.Button btn_busc_cita;
        internal System.Windows.Forms.TextBox txt_busc_cit;
        internal System.Windows.Forms.Label lbl_busca_cita;
        internal System.Windows.Forms.PictureBox pl_lab_cita;
        private System.Windows.Forms.Button btn_elim_cita;
        private System.Windows.Forms.Button btn_actlz_cita;
        private System.Windows.Forms.Button btn_guardar_cita;
        private System.Windows.Forms.Label lbl_cita;
        private System.Windows.Forms.DateTimePicker dtp_fec_cit;
        internal System.Windows.Forms.Label Lbl_hora_cit;
        private System.Windows.Forms.ComboBox cbo_id_lab_cit;
        private System.Windows.Forms.ComboBox cbo_id_clt_cit;
        private System.Windows.Forms.ComboBox cbo_hora1_cit;
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
    }
}