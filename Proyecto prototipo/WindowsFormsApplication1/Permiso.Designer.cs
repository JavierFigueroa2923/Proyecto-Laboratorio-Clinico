﻿using System;

namespace WindowsFormsApplication1
{
    partial class frm_permiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_permiso));
            this.txt_busc_id_per = new System.Windows.Forms.TextBox();
            this.lbl_busca_per = new System.Windows.Forms.Label();
            this.grb_vista_per = new System.Windows.Forms.GroupBox();
            this.dgv_busc_per = new System.Windows.Forms.DataGridView();
            this.grb_datos1_per = new System.Windows.Forms.GroupBox();
            this.cbo_nombre_per = new System.Windows.Forms.ComboBox();
            this.cbo_id_carg_emp_per = new System.Windows.Forms.ComboBox();
            this.btn_busc_id_carg_emp_per = new System.Windows.Forms.Button();
            this.Lbl_id_carg_emp_per = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descr_per = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_permiso = new System.Windows.Forms.Label();
            this.pl_lab_user = new System.Windows.Forms.PictureBox();
            this.btn_rnv_per = new System.Windows.Forms.Button();
            this.btn_busc_id_per = new System.Windows.Forms.Button();
            this.btn_elim_per = new System.Windows.Forms.Button();
            this.btn_actlz_per = new System.Windows.Forms.Button();
            this.btn_guardar_per = new System.Windows.Forms.Button();
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
            this.grb_vista_per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_per)).BeginInit();
            this.grb_datos1_per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_user)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busc_id_per
            // 
            this.txt_busc_id_per.Location = new System.Drawing.Point(177, 341);
            this.txt_busc_id_per.Name = "txt_busc_id_per";
            this.txt_busc_id_per.Size = new System.Drawing.Size(473, 20);
            this.txt_busc_id_per.TabIndex = 5;
            this.txt_busc_id_per.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_busc_id_per_KeyDown);
            this.txt_busc_id_per.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_busc_id_per_KeyPress);
            this.txt_busc_id_per.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_busquedapermiso_KeyUp);
            // 
            // lbl_busca_per
            // 
            this.lbl_busca_per.AutoSize = true;
            this.lbl_busca_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_per.Location = new System.Drawing.Point(42, 338);
            this.lbl_busca_per.Name = "lbl_busca_per";
            this.lbl_busca_per.Size = new System.Drawing.Size(128, 20);
            this.lbl_busca_per.TabIndex = 166;
            this.lbl_busca_per.Text = "Buscar Permisos:";
            // 
            // grb_vista_per
            // 
            this.grb_vista_per.Controls.Add(this.dgv_busc_per);
            this.grb_vista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_per.Location = new System.Drawing.Point(12, 361);
            this.grb_vista_per.Name = "grb_vista_per";
            this.grb_vista_per.Size = new System.Drawing.Size(754, 163);
            this.grb_vista_per.TabIndex = 168;
            this.grb_vista_per.TabStop = false;
            this.grb_vista_per.Text = "Permisos";
            // 
            // dgv_busc_per
            // 
            this.dgv_busc_per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_per.Location = new System.Drawing.Point(9, 22);
            this.dgv_busc_per.Name = "dgv_busc_per";
            this.dgv_busc_per.Size = new System.Drawing.Size(739, 135);
            this.dgv_busc_per.TabIndex = 0;
            this.dgv_busc_per.TabStop = false;
            // 
            // grb_datos1_per
            // 
            this.grb_datos1_per.Controls.Add(this.cbo_nombre_per);
            this.grb_datos1_per.Controls.Add(this.cbo_id_carg_emp_per);
            this.grb_datos1_per.Controls.Add(this.btn_busc_id_carg_emp_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_id_carg_emp_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_descripcion);
            this.grb_datos1_per.Controls.Add(this.txt_descr_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_nombre);
            this.grb_datos1_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_per.Location = new System.Drawing.Point(12, 140);
            this.grb_datos1_per.Name = "grb_datos1_per";
            this.grb_datos1_per.Size = new System.Drawing.Size(716, 183);
            this.grb_datos1_per.TabIndex = 164;
            this.grb_datos1_per.TabStop = false;
            this.grb_datos1_per.Text = "Datos de Rol";
            this.grb_datos1_per.Enter += new System.EventHandler(this.grb_datos1_per_Enter);
            // 
            // cbo_nombre_per
            // 
            this.cbo_nombre_per.FormattingEnabled = true;
            this.cbo_nombre_per.Items.AddRange(new object[] {
            "Actualizar Cliente",
            "Actualizar Empleado",
            "Actualizar Examenes",
            "Actualizar Pagos",
            "Actualizar Aseguradora",
            "Actualizar Laboratorio",
            "Actualizar Inventario",
            "Citas",
            "Roles",
            "Etiquetas",
            "Area Laboratorio",
            "Membrecia",
            "Cargo Empleado",
            "Inventario De Suministros",
            "Tipo De Examen",
            "Reporte de pagos",
            "Reporte de suministros",
            "Reporte de facturas",
            "Reporte de resultado de examenes",
            "Creacion titulo empleado",
            "Creacion tipo de muestra",
            "Creacion de muestra",
            "Creacion de cotizacion",
            "Todo"});
            this.cbo_nombre_per.Location = new System.Drawing.Point(113, 30);
            this.cbo_nombre_per.Name = "cbo_nombre_per";
            this.cbo_nombre_per.Size = new System.Drawing.Size(403, 24);
            this.cbo_nombre_per.TabIndex = 171;
            // 
            // cbo_id_carg_emp_per
            // 
            this.cbo_id_carg_emp_per.FormattingEnabled = true;
            this.cbo_id_carg_emp_per.Location = new System.Drawing.Point(113, 150);
            this.cbo_id_carg_emp_per.Name = "cbo_id_carg_emp_per";
            this.cbo_id_carg_emp_per.Size = new System.Drawing.Size(151, 24);
            this.cbo_id_carg_emp_per.TabIndex = 3;
            this.cbo_id_carg_emp_per.SelectedIndexChanged += new System.EventHandler(this.cbo_id_carg_emp_per_SelectedIndexChanged);
            this.cbo_id_carg_emp_per.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_id_carg_emp_per_KeyDown);
            // 
            // btn_busc_id_carg_emp_per
            // 
            this.btn_busc_id_carg_emp_per.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_carg_emp_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_carg_emp_per.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_carg_emp_per.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_id_carg_emp_per.Location = new System.Drawing.Point(270, 140);
            this.btn_busc_id_carg_emp_per.Name = "btn_busc_id_carg_emp_per";
            this.btn_busc_id_carg_emp_per.Size = new System.Drawing.Size(103, 43);
            this.btn_busc_id_carg_emp_per.TabIndex = 170;
            this.btn_busc_id_carg_emp_per.Text = "BUSCAR";
            this.btn_busc_id_carg_emp_per.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_carg_emp_per.UseVisualStyleBackColor = true;
            this.btn_busc_id_carg_emp_per.Click += new System.EventHandler(this.btn_busc_id_carg_emp_per_Click);
            // 
            // Lbl_id_carg_emp_per
            // 
            this.Lbl_id_carg_emp_per.AutoSize = true;
            this.Lbl_id_carg_emp_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_carg_emp_per.Location = new System.Drawing.Point(34, 151);
            this.Lbl_id_carg_emp_per.Name = "Lbl_id_carg_emp_per";
            this.Lbl_id_carg_emp_per.Size = new System.Drawing.Size(79, 20);
            this.Lbl_id_carg_emp_per.TabIndex = 86;
            this.Lbl_id_carg_emp_per.Text = "Id Cargo:";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(7, 62);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 85;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_descr_per
            // 
            this.txt_descr_per.Location = new System.Drawing.Point(113, 65);
            this.txt_descr_per.Multiline = true;
            this.txt_descr_per.Name = "txt_descr_per";
            this.txt_descr_per.Size = new System.Drawing.Size(591, 69);
            this.txt_descr_per.TabIndex = 2;
            this.txt_descr_per.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descr_per_KeyDown);
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(24, 34);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 81;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // Lbl_permiso
            // 
            this.Lbl_permiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_permiso.AutoSize = true;
            this.Lbl_permiso.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_permiso.Location = new System.Drawing.Point(334, 9);
            this.Lbl_permiso.Name = "Lbl_permiso";
            this.Lbl_permiso.Size = new System.Drawing.Size(86, 34);
            this.Lbl_permiso.TabIndex = 160;
            this.Lbl_permiso.Text = "Roles";
            this.Lbl_permiso.Click += new System.EventHandler(this.Lbl_permiso_Click);
            // 
            // pl_lab_user
            // 
            this.pl_lab_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_lab_user.Image = ((System.Drawing.Image)(resources.GetObject("pl_lab_user.Image")));
            this.pl_lab_user.Location = new System.Drawing.Point(673, 12);
            this.pl_lab_user.Name = "pl_lab_user";
            this.pl_lab_user.Size = new System.Drawing.Size(100, 105);
            this.pl_lab_user.TabIndex = 171;
            this.pl_lab_user.TabStop = false;
            // 
            // btn_rnv_per
            // 
            this.btn_rnv_per.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rnv_per.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_rnv_per.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rnv_per.FlatAppearance.BorderSize = 0;
            this.btn_rnv_per.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rnv_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rnv_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rnv_per.Location = new System.Drawing.Point(516, 52);
            this.btn_rnv_per.Name = "btn_rnv_per";
            this.btn_rnv_per.Size = new System.Drawing.Size(65, 65);
            this.btn_rnv_per.TabIndex = 7;
            this.btn_rnv_per.Tag = "";
            this.btn_rnv_per.Text = " ";
            this.btn_rnv_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip8.SetToolTip(this.btn_rnv_per, "Actualizar");
            this.btn_rnv_per.UseVisualStyleBackColor = true;
            this.btn_rnv_per.Click += new System.EventHandler(this.btn_rnv_per_Click);
            // 
            // btn_busc_id_per
            // 
            this.btn_busc_id_per.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_per.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_id_per.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_id_per.FlatAppearance.BorderSize = 0;
            this.btn_busc_id_per.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_id_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_per.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_id_per.Location = new System.Drawing.Point(302, 51);
            this.btn_busc_id_per.Name = "btn_busc_id_per";
            this.btn_busc_id_per.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_id_per.TabIndex = 6;
            this.btn_busc_id_per.Text = " ";
            this.btn_busc_id_per.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip5.SetToolTip(this.btn_busc_id_per, "Buscar");
            this.btn_busc_id_per.UseVisualStyleBackColor = true;
            this.btn_busc_id_per.Click += new System.EventHandler(this.btn_busc_id_per_Click);
            // 
            // btn_elim_per
            // 
            this.btn_elim_per.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_per.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_per.FlatAppearance.BorderSize = 0;
            this.btn_elim_per.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_per.Location = new System.Drawing.Point(231, 52);
            this.btn_elim_per.Name = "btn_elim_per";
            this.btn_elim_per.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_per.TabIndex = 9;
            this.btn_elim_per.Text = " ";
            this.btn_elim_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_per, "Eliminar");
            this.btn_elim_per.UseVisualStyleBackColor = true;
            this.btn_elim_per.Click += new System.EventHandler(this.btn_elim_per_Click);
            // 
            // btn_actlz_per
            // 
            this.btn_actlz_per.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_per.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_per.FlatAppearance.BorderSize = 0;
            this.btn_actlz_per.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_per.Location = new System.Drawing.Point(160, 52);
            this.btn_actlz_per.Name = "btn_actlz_per";
            this.btn_actlz_per.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_per.TabIndex = 8;
            this.btn_actlz_per.Text = " ";
            this.btn_actlz_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_per, "Modificar");
            this.btn_actlz_per.UseVisualStyleBackColor = true;
            this.btn_actlz_per.Click += new System.EventHandler(this.btn_actlz_per_Click);
            // 
            // btn_guardar_per
            // 
            this.btn_guardar_per.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_per.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_per.FlatAppearance.BorderSize = 0;
            this.btn_guardar_per.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_per.Location = new System.Drawing.Point(89, 52);
            this.btn_guardar_per.Name = "btn_guardar_per";
            this.btn_guardar_per.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_per.TabIndex = 4;
            this.btn_guardar_per.Text = " ";
            this.btn_guardar_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_per, "Guardar");
            this.btn_guardar_per.UseVisualStyleBackColor = true;
            this.btn_guardar_per.Click += new System.EventHandler(this.btn_guardar_per_Click);
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(18, 52);
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
            this.btn_acept.Location = new System.Drawing.Point(445, 52);
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
            this.btn_cancl.Location = new System.Drawing.Point(374, 52);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 173;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // frm_permiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 539);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.pl_lab_user);
            this.Controls.Add(this.btn_rnv_per);
            this.Controls.Add(this.btn_busc_id_per);
            this.Controls.Add(this.txt_busc_id_per);
            this.Controls.Add(this.lbl_busca_per);
            this.Controls.Add(this.grb_vista_per);
            this.Controls.Add(this.grb_datos1_per);
            this.Controls.Add(this.btn_elim_per);
            this.Controls.Add(this.btn_actlz_per);
            this.Controls.Add(this.btn_guardar_per);
            this.Controls.Add(this.Lbl_permiso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_permiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permiso";
            this.Load += new System.EventHandler(this.frm_permiso_Load);
            this.grb_vista_per.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_per)).EndInit();
            this.grb_datos1_per.ResumeLayout(false);
            this.grb_datos1_per.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btn_busc_id_per;
        internal System.Windows.Forms.TextBox txt_busc_id_per;
        internal System.Windows.Forms.Label lbl_busca_per;
        private System.Windows.Forms.GroupBox grb_vista_per;
        private System.Windows.Forms.DataGridView dgv_busc_per;
        private System.Windows.Forms.GroupBox grb_datos1_per;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_descr_per;
        internal System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Button btn_elim_per;
        private System.Windows.Forms.Button btn_actlz_per;
        private System.Windows.Forms.Button btn_guardar_per;
        internal System.Windows.Forms.Label Lbl_permiso;
        private System.Windows.Forms.Button btn_rnv_per;
        internal System.Windows.Forms.PictureBox pl_lab_user;
        private System.Windows.Forms.Button btn_busc_id_carg_emp_per;
        internal System.Windows.Forms.Label Lbl_id_carg_emp_per;
        public System.Windows.Forms.ComboBox cbo_id_carg_emp_per;
        public System.Windows.Forms.ComboBox cbo_nombre_per;
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