namespace WindowsFormsApplication1
{
    partial class Titulo_de_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titulo_de_empleado));
            this.lbl_empleado = new System.Windows.Forms.Label();
            this.gpb_ingre_datos_titulo_emp = new System.Windows.Forms.GroupBox();
            this.dtp_fecha_title = new System.Windows.Forms.DateTimePicker();
            this.lbl_descrip_titulo = new System.Windows.Forms.Label();
            this.lbl_fecha_obt_titulo = new System.Windows.Forms.Label();
            this.lbl_nombre_titulo_emp = new System.Windows.Forms.Label();
            this.lbl_id_lab = new System.Windows.Forms.Label();
            this.lbl_id_empleado = new System.Windows.Forms.Label();
            this.txt_decrip_titulo_emp = new System.Windows.Forms.TextBox();
            this.txt_nom_titulo = new System.Windows.Forms.TextBox();
            this.txt_id_lab = new System.Windows.Forms.TextBox();
            this.txt_id_emp = new System.Windows.Forms.TextBox();
            this.gpb_busqueda_empleado = new System.Windows.Forms.GroupBox();
            this.dgv_busqueda_datos_empleado = new System.Windows.Forms.DataGridView();
            this.buscar_emp = new System.Windows.Forms.Label();
            this.btn_elim_titulo = new System.Windows.Forms.Button();
            this.btn_busc_emp = new System.Windows.Forms.Button();
            this.actualizar_titulo_emp = new System.Windows.Forms.Button();
            this.btn_actlz_titulo_emp = new System.Windows.Forms.Button();
            this.btn_guardar_titulo_emp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbo_buscar = new System.Windows.Forms.ComboBox();
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
            this.gpb_ingre_datos_titulo_emp.SuspendLayout();
            this.gpb_busqueda_empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda_datos_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_empleado
            // 
            this.lbl_empleado.AutoSize = true;
            this.lbl_empleado.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleado.Location = new System.Drawing.Point(285, 23);
            this.lbl_empleado.Name = "lbl_empleado";
            this.lbl_empleado.Size = new System.Drawing.Size(276, 34);
            this.lbl_empleado.TabIndex = 56;
            this.lbl_empleado.Text = "Título de Empleado";
            // 
            // gpb_ingre_datos_titulo_emp
            // 
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.dtp_fecha_title);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.lbl_descrip_titulo);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.lbl_fecha_obt_titulo);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.lbl_nombre_titulo_emp);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.lbl_id_lab);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.lbl_id_empleado);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.txt_decrip_titulo_emp);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.txt_nom_titulo);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.txt_id_lab);
            this.gpb_ingre_datos_titulo_emp.Controls.Add(this.txt_id_emp);
            this.gpb_ingre_datos_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ingre_datos_titulo_emp.Location = new System.Drawing.Point(12, 162);
            this.gpb_ingre_datos_titulo_emp.Name = "gpb_ingre_datos_titulo_emp";
            this.gpb_ingre_datos_titulo_emp.Size = new System.Drawing.Size(374, 370);
            this.gpb_ingre_datos_titulo_emp.TabIndex = 57;
            this.gpb_ingre_datos_titulo_emp.TabStop = false;
            this.gpb_ingre_datos_titulo_emp.Text = "Ingreso de datos";
            // 
            // dtp_fecha_title
            // 
            this.dtp_fecha_title.Location = new System.Drawing.Point(6, 189);
            this.dtp_fecha_title.Name = "dtp_fecha_title";
            this.dtp_fecha_title.Size = new System.Drawing.Size(345, 24);
            this.dtp_fecha_title.TabIndex = 74;
            this.dtp_fecha_title.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_fecha_title_KeyDown);
            // 
            // lbl_descrip_titulo
            // 
            this.lbl_descrip_titulo.AutoSize = true;
            this.lbl_descrip_titulo.Location = new System.Drawing.Point(3, 216);
            this.lbl_descrip_titulo.Name = "lbl_descrip_titulo";
            this.lbl_descrip_titulo.Size = new System.Drawing.Size(145, 18);
            this.lbl_descrip_titulo.TabIndex = 72;
            this.lbl_descrip_titulo.Text = "Descripción del título";
            // 
            // lbl_fecha_obt_titulo
            // 
            this.lbl_fecha_obt_titulo.AutoSize = true;
            this.lbl_fecha_obt_titulo.Location = new System.Drawing.Point(3, 168);
            this.lbl_fecha_obt_titulo.Name = "lbl_fecha_obt_titulo";
            this.lbl_fecha_obt_titulo.Size = new System.Drawing.Size(196, 18);
            this.lbl_fecha_obt_titulo.TabIndex = 71;
            this.lbl_fecha_obt_titulo.Text = "Fecha de obtención del título";
            // 
            // lbl_nombre_titulo_emp
            // 
            this.lbl_nombre_titulo_emp.AutoSize = true;
            this.lbl_nombre_titulo_emp.Location = new System.Drawing.Point(3, 120);
            this.lbl_nombre_titulo_emp.Name = "lbl_nombre_titulo_emp";
            this.lbl_nombre_titulo_emp.Size = new System.Drawing.Size(120, 18);
            this.lbl_nombre_titulo_emp.TabIndex = 70;
            this.lbl_nombre_titulo_emp.Text = "Nombre del título";
            // 
            // lbl_id_lab
            // 
            this.lbl_id_lab.AutoSize = true;
            this.lbl_id_lab.Location = new System.Drawing.Point(6, 72);
            this.lbl_id_lab.Name = "lbl_id_lab";
            this.lbl_id_lab.Size = new System.Drawing.Size(99, 18);
            this.lbl_id_lab.TabIndex = 70;
            this.lbl_id_lab.Text = "Id Laboratorio";
            // 
            // lbl_id_empleado
            // 
            this.lbl_id_empleado.AutoSize = true;
            this.lbl_id_empleado.Location = new System.Drawing.Point(6, 24);
            this.lbl_id_empleado.Name = "lbl_id_empleado";
            this.lbl_id_empleado.Size = new System.Drawing.Size(90, 18);
            this.lbl_id_empleado.TabIndex = 6;
            this.lbl_id_empleado.Text = "Id Empleado";
            // 
            // txt_decrip_titulo_emp
            // 
            this.txt_decrip_titulo_emp.Location = new System.Drawing.Point(6, 237);
            this.txt_decrip_titulo_emp.Multiline = true;
            this.txt_decrip_titulo_emp.Name = "txt_decrip_titulo_emp";
            this.txt_decrip_titulo_emp.Size = new System.Drawing.Size(348, 100);
            this.txt_decrip_titulo_emp.TabIndex = 5;
            this.txt_decrip_titulo_emp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_decrip_titulo_emp_KeyDown_1);
            // 
            // txt_nom_titulo
            // 
            this.txt_nom_titulo.Location = new System.Drawing.Point(6, 141);
            this.txt_nom_titulo.Name = "txt_nom_titulo";
            this.txt_nom_titulo.Size = new System.Drawing.Size(348, 24);
            this.txt_nom_titulo.TabIndex = 3;
            this.txt_nom_titulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nom_titulo_KeyDown_1);
            this.txt_nom_titulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_titulo_KeyPress);
            // 
            // txt_id_lab
            // 
            this.txt_id_lab.Location = new System.Drawing.Point(6, 93);
            this.txt_id_lab.Name = "txt_id_lab";
            this.txt_id_lab.Size = new System.Drawing.Size(348, 24);
            this.txt_id_lab.TabIndex = 2;
            this.txt_id_lab.TextChanged += new System.EventHandler(this.txt_id_lab_TextChanged);
            this.txt_id_lab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_lab_KeyDown_1);
            this.txt_id_lab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_lab_KeyPress);
            // 
            // txt_id_emp
            // 
            this.txt_id_emp.Location = new System.Drawing.Point(6, 45);
            this.txt_id_emp.Name = "txt_id_emp";
            this.txt_id_emp.Size = new System.Drawing.Size(348, 24);
            this.txt_id_emp.TabIndex = 1;
            this.txt_id_emp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_emp_KeyDown);
            this.txt_id_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_emp_KeyPress);
            // 
            // gpb_busqueda_empleado
            // 
            this.gpb_busqueda_empleado.Controls.Add(this.dgv_busqueda_datos_empleado);
            this.gpb_busqueda_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_busqueda_empleado.Location = new System.Drawing.Point(405, 186);
            this.gpb_busqueda_empleado.Name = "gpb_busqueda_empleado";
            this.gpb_busqueda_empleado.Size = new System.Drawing.Size(419, 346);
            this.gpb_busqueda_empleado.TabIndex = 70;
            this.gpb_busqueda_empleado.TabStop = false;
            this.gpb_busqueda_empleado.Text = "Busqueda de empleado";
            // 
            // dgv_busqueda_datos_empleado
            // 
            this.dgv_busqueda_datos_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busqueda_datos_empleado.Location = new System.Drawing.Point(6, 23);
            this.dgv_busqueda_datos_empleado.Name = "dgv_busqueda_datos_empleado";
            this.dgv_busqueda_datos_empleado.Size = new System.Drawing.Size(407, 305);
            this.dgv_busqueda_datos_empleado.TabIndex = 0;
            // 
            // buscar_emp
            // 
            this.buscar_emp.AutoSize = true;
            this.buscar_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_emp.Location = new System.Drawing.Point(409, 163);
            this.buscar_emp.Name = "buscar_emp";
            this.buscar_emp.Size = new System.Drawing.Size(55, 18);
            this.buscar_emp.TabIndex = 157;
            this.buscar_emp.Text = "Buscar";
            // 
            // btn_elim_titulo
            // 
            this.btn_elim_titulo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_titulo.FlatAppearance.BorderSize = 0;
            this.btn_elim_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_titulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_titulo.Location = new System.Drawing.Point(225, 74);
            this.btn_elim_titulo.Name = "btn_elim_titulo";
            this.btn_elim_titulo.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_titulo.TabIndex = 159;
            this.btn_elim_titulo.Text = " ";
            this.btn_elim_titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_titulo, "Eliminar");
            this.btn_elim_titulo.UseVisualStyleBackColor = true;
            this.btn_elim_titulo.Click += new System.EventHandler(this.btn_elim_titulo_Click);
            // 
            // btn_busc_emp
            // 
            this.btn_busc_emp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_emp.FlatAppearance.BorderSize = 0;
            this.btn_busc_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_emp.Location = new System.Drawing.Point(296, 74);
            this.btn_busc_emp.Name = "btn_busc_emp";
            this.btn_busc_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_emp.TabIndex = 156;
            this.btn_busc_emp.Text = " ";
            this.btn_busc_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_emp, "Buscar");
            this.btn_busc_emp.UseVisualStyleBackColor = true;
            this.btn_busc_emp.Click += new System.EventHandler(this.btn_busc_emp_Click);
            // 
            // actualizar_titulo_emp
            // 
            this.actualizar_titulo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.actualizar_titulo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizar_titulo_emp.FlatAppearance.BorderSize = 0;
            this.actualizar_titulo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_titulo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.actualizar_titulo_emp.Location = new System.Drawing.Point(509, 74);
            this.actualizar_titulo_emp.Name = "actualizar_titulo_emp";
            this.actualizar_titulo_emp.Size = new System.Drawing.Size(65, 65);
            this.actualizar_titulo_emp.TabIndex = 155;
            this.actualizar_titulo_emp.Text = " ";
            this.actualizar_titulo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip8.SetToolTip(this.actualizar_titulo_emp, "Actualizar");
            this.actualizar_titulo_emp.UseVisualStyleBackColor = true;
            this.actualizar_titulo_emp.Click += new System.EventHandler(this.actualizar_titulo_emp_Click);
            // 
            // btn_actlz_titulo_emp
            // 
            this.btn_actlz_titulo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_titulo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_titulo_emp.FlatAppearance.BorderSize = 0;
            this.btn_actlz_titulo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_titulo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_titulo_emp.Location = new System.Drawing.Point(154, 74);
            this.btn_actlz_titulo_emp.Name = "btn_actlz_titulo_emp";
            this.btn_actlz_titulo_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_titulo_emp.TabIndex = 69;
            this.btn_actlz_titulo_emp.Text = " ";
            this.btn_actlz_titulo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_titulo_emp, "Modificar");
            this.btn_actlz_titulo_emp.UseVisualStyleBackColor = true;
            this.btn_actlz_titulo_emp.Click += new System.EventHandler(this.btn_actlz_titulo_emp_Click);
            // 
            // btn_guardar_titulo_emp
            // 
            this.btn_guardar_titulo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_titulo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_titulo_emp.FlatAppearance.BorderSize = 0;
            this.btn_guardar_titulo_emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_titulo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_titulo_emp.Location = new System.Drawing.Point(83, 74);
            this.btn_guardar_titulo_emp.Name = "btn_guardar_titulo_emp";
            this.btn_guardar_titulo_emp.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_titulo_emp.TabIndex = 68;
            this.btn_guardar_titulo_emp.Text = " ";
            this.btn_guardar_titulo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_titulo_emp, "Guardar");
            this.btn_guardar_titulo_emp.UseVisualStyleBackColor = true;
            this.btn_guardar_titulo_emp.Click += new System.EventHandler(this.btn_guardar_titulo_emp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Clinica;
            this.pictureBox1.Location = new System.Drawing.Point(688, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            // 
            // cbo_buscar
            // 
            this.cbo_buscar.FormattingEnabled = true;
            this.cbo_buscar.Location = new System.Drawing.Point(480, 159);
            this.cbo_buscar.Name = "cbo_buscar";
            this.cbo_buscar.Size = new System.Drawing.Size(206, 21);
            this.cbo_buscar.TabIndex = 168;
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(12, 74);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 169;
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
            this.btn_acept.Location = new System.Drawing.Point(438, 74);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 171;
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
            this.btn_cancl.Location = new System.Drawing.Point(367, 74);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 170;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // Titulo_de_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 579);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.cbo_buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_elim_titulo);
            this.Controls.Add(this.buscar_emp);
            this.Controls.Add(this.btn_busc_emp);
            this.Controls.Add(this.actualizar_titulo_emp);
            this.Controls.Add(this.gpb_busqueda_empleado);
            this.Controls.Add(this.btn_actlz_titulo_emp);
            this.Controls.Add(this.btn_guardar_titulo_emp);
            this.Controls.Add(this.gpb_ingre_datos_titulo_emp);
            this.Controls.Add(this.lbl_empleado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Titulo_de_empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulo de empleado";
            this.Load += new System.EventHandler(this.Titulo_de_empleado_Load);
            this.gpb_ingre_datos_titulo_emp.ResumeLayout(false);
            this.gpb_ingre_datos_titulo_emp.PerformLayout();
            this.gpb_busqueda_empleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda_datos_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_empleado;
        private System.Windows.Forms.GroupBox gpb_ingre_datos_titulo_emp;
        private System.Windows.Forms.Button btn_guardar_titulo_emp;
        private System.Windows.Forms.Button btn_actlz_titulo_emp;
        private System.Windows.Forms.Label lbl_descrip_titulo;
        private System.Windows.Forms.Label lbl_fecha_obt_titulo;
        private System.Windows.Forms.Label lbl_nombre_titulo_emp;
        private System.Windows.Forms.Label lbl_id_lab;
        private System.Windows.Forms.Label lbl_id_empleado;
        private System.Windows.Forms.TextBox txt_decrip_titulo_emp;
        private System.Windows.Forms.TextBox txt_nom_titulo;
        private System.Windows.Forms.TextBox txt_id_lab;
        private System.Windows.Forms.TextBox txt_id_emp;
        private System.Windows.Forms.GroupBox gpb_busqueda_empleado;
        private System.Windows.Forms.Button actualizar_titulo_emp;
        private System.Windows.Forms.DataGridView dgv_busqueda_datos_empleado;
        private System.Windows.Forms.Button btn_busc_emp;
        private System.Windows.Forms.Label buscar_emp;
        private System.Windows.Forms.Button btn_elim_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_buscar;
        private System.Windows.Forms.DateTimePicker dtp_fecha_title;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}