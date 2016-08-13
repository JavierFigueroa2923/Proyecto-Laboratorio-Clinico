namespace WindowsFormsApplication1
{
    partial class frm_act_emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_emp));
            this.Lbl_cargo = new System.Windows.Forms.Label();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.Lbl_email_emp = new System.Windows.Forms.Label();
            this.txt_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.Lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.grb_datos_emp = new System.Windows.Forms.GroupBox();
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contraseña2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_datosp_emp = new System.Windows.Forms.GroupBox();
            this.lbl_date_formato = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.cbo_sexo_emp = new System.Windows.Forms.ComboBox();
            this.Lbl_sexo = new System.Windows.Forms.Label();
            this.cbo_carg_emp = new System.Windows.Forms.ComboBox();
            this.grb_vista_emp = new System.Windows.Forms.GroupBox();
            this.dgv_empleads = new System.Windows.Forms.DataGridView();
            this.lbl_busca_emp = new System.Windows.Forms.Label();
            this.btn_elim_emp = new System.Windows.Forms.Button();
            this.btn_actlz_emp = new System.Windows.Forms.Button();
            this.btn_guardar_emp = new System.Windows.Forms.Button();
            this.btn_busc_emp = new System.Windows.Forms.Button();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.grb_datos_emp.SuspendLayout();
            this.grb_datosp_emp.SuspendLayout();
            this.grb_vista_emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_cargo
            // 
            this.Lbl_cargo.AutoSize = true;
            this.Lbl_cargo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_cargo.Location = new System.Drawing.Point(26, 70);
            this.Lbl_cargo.Name = "Lbl_cargo";
            this.Lbl_cargo.Size = new System.Drawing.Size(60, 20);
            this.Lbl_cargo.TabIndex = 74;
            this.Lbl_cargo.Text = "Cargo:";
            this.Lbl_cargo.Click += new System.EventHandler(this.Lbl_cargo_Click);
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_apellido.Location = new System.Drawing.Point(31, 50);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(73, 20);
            this.Lbl_apellido.TabIndex = 71;
            this.Lbl_apellido.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_apellido.Location = new System.Drawing.Point(111, 56);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(264, 23);
            this.txt_apellido.TabIndex = 2;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_usuario.Location = new System.Drawing.Point(110, 86);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(265, 23);
            this.txt_usuario.TabIndex = 3;
            // 
            // Lbl_email_emp
            // 
            this.Lbl_email_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_email_emp.AutoSize = true;
            this.Lbl_email_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_email_emp.Location = new System.Drawing.Point(36, 82);
            this.Lbl_email_emp.Name = "Lbl_email_emp";
            this.Lbl_email_emp.Size = new System.Drawing.Size(67, 20);
            this.Lbl_email_emp.TabIndex = 66;
            this.Lbl_email_emp.Text = "Usuario:";
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(177, 21);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(129, 23);
            this.txt_fecha_nacimiento.TabIndex = 7;
            // 
            // Lbl_fecha_nacimiento
            // 
            this.Lbl_fecha_nacimiento.AutoSize = true;
            this.Lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_fecha_nacimiento.Location = new System.Drawing.Point(2, 24);
            this.Lbl_fecha_nacimiento.Name = "Lbl_fecha_nacimiento";
            this.Lbl_fecha_nacimiento.Size = new System.Drawing.Size(169, 20);
            this.Lbl_fecha_nacimiento.TabIndex = 63;
            this.Lbl_fecha_nacimiento.Text = "Fecha de nacimiento:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_telefono.Location = new System.Drawing.Point(92, 209);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(214, 23);
            this.txt_telefono.TabIndex = 12;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_telefono.Location = new System.Drawing.Point(2, 212);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(75, 20);
            this.Lbl_telefono.TabIndex = 59;
            this.Lbl_telefono.Text = "Telefono:";
            this.Lbl_telefono.Click += new System.EventHandler(this.Lbl_telefono_Click);
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_direccion.Location = new System.Drawing.Point(2, 160);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(84, 20);
            this.Lbl_direccion.TabIndex = 58;
            this.Lbl_direccion.Text = "Direccion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_direccion.Location = new System.Drawing.Point(92, 156);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(214, 47);
            this.txt_direccion.TabIndex = 11;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_nombre.Location = new System.Drawing.Point(32, 21);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 56;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_nombre.Location = new System.Drawing.Point(111, 21);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(264, 23);
            this.txt_nombre.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(258, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(153, 34);
            this.Label2.TabIndex = 53;
            this.Label2.Text = "Empleado";
            // 
            // grb_datos_emp
            // 
            this.grb_datos_emp.Controls.Add(this.cbo_id_lab);
            this.grb_datos_emp.Controls.Add(this.label4);
            this.grb_datos_emp.Controls.Add(this.txt_contraseña2);
            this.grb_datos_emp.Controls.Add(this.label3);
            this.grb_datos_emp.Controls.Add(this.txt_contraseña);
            this.grb_datos_emp.Controls.Add(this.label1);
            this.grb_datos_emp.Controls.Add(this.txt_nombre);
            this.grb_datos_emp.Controls.Add(this.Lbl_nombre);
            this.grb_datos_emp.Controls.Add(this.txt_apellido);
            this.grb_datos_emp.Controls.Add(this.Lbl_apellido);
            this.grb_datos_emp.Controls.Add(this.txt_usuario);
            this.grb_datos_emp.Controls.Add(this.Lbl_email_emp);
            this.grb_datos_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos_emp.Location = new System.Drawing.Point(12, 120);
            this.grb_datos_emp.Name = "grb_datos_emp";
            this.grb_datos_emp.Size = new System.Drawing.Size(399, 240);
            this.grb_datos_emp.TabIndex = 78;
            this.grb_datos_emp.TabStop = false;
            this.grb_datos_emp.Text = "Datos Generales";
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(129, 205);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(152, 24);
            this.cbo_id_lab.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 82;
            this.label4.Text = "Id Laboratorio:";
            // 
            // txt_contraseña2
            // 
            this.txt_contraseña2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_contraseña2.Location = new System.Drawing.Point(110, 144);
            this.txt_contraseña2.Name = "txt_contraseña2";
            this.txt_contraseña2.PasswordChar = '*';
            this.txt_contraseña2.Size = new System.Drawing.Size(265, 23);
            this.txt_contraseña2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Contraseña:";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_contraseña.Location = new System.Drawing.Point(110, 115);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(265, 23);
            this.txt_contraseña.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(5, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Contraseña:";
            // 
            // grb_datosp_emp
            // 
            this.grb_datosp_emp.Controls.Add(this.lbl_date_formato);
            this.grb_datosp_emp.Controls.Add(this.txt_correo);
            this.grb_datosp_emp.Controls.Add(this.lbl_correo);
            this.grb_datosp_emp.Controls.Add(this.cbo_sexo_emp);
            this.grb_datosp_emp.Controls.Add(this.Lbl_sexo);
            this.grb_datosp_emp.Controls.Add(this.cbo_carg_emp);
            this.grb_datosp_emp.Controls.Add(this.Lbl_fecha_nacimiento);
            this.grb_datosp_emp.Controls.Add(this.txt_fecha_nacimiento);
            this.grb_datosp_emp.Controls.Add(this.Lbl_cargo);
            this.grb_datosp_emp.Controls.Add(this.txt_direccion);
            this.grb_datosp_emp.Controls.Add(this.Lbl_direccion);
            this.grb_datosp_emp.Controls.Add(this.txt_telefono);
            this.grb_datosp_emp.Controls.Add(this.Lbl_telefono);
            this.grb_datosp_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datosp_emp.Location = new System.Drawing.Point(417, 120);
            this.grb_datosp_emp.Name = "grb_datosp_emp";
            this.grb_datosp_emp.Size = new System.Drawing.Size(318, 240);
            this.grb_datosp_emp.TabIndex = 79;
            this.grb_datosp_emp.TabStop = false;
            this.grb_datosp_emp.Text = "Datos Personales";
            // 
            // lbl_date_formato
            // 
            this.lbl_date_formato.AutoSize = true;
            this.lbl_date_formato.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_date_formato.Location = new System.Drawing.Point(190, 47);
            this.lbl_date_formato.Name = "lbl_date_formato";
            this.lbl_date_formato.Size = new System.Drawing.Size(97, 20);
            this.lbl_date_formato.TabIndex = 115;
            this.lbl_date_formato.Text = "yyyy-mm-dd";
            // 
            // txt_correo
            // 
            this.txt_correo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_correo.Location = new System.Drawing.Point(92, 129);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(214, 23);
            this.txt_correo.TabIndex = 10;
            // 
            // lbl_correo
            // 
            this.lbl_correo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_correo.Location = new System.Drawing.Point(21, 132);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(65, 20);
            this.lbl_correo.TabIndex = 114;
            this.lbl_correo.Text = "Correo:";
            // 
            // cbo_sexo_emp
            // 
            this.cbo_sexo_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo_emp.FormattingEnabled = true;
            this.cbo_sexo_emp.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbo_sexo_emp.Location = new System.Drawing.Point(92, 100);
            this.cbo_sexo_emp.Name = "cbo_sexo_emp";
            this.cbo_sexo_emp.Size = new System.Drawing.Size(214, 24);
            this.cbo_sexo_emp.TabIndex = 9;
            this.cbo_sexo_emp.SelectedIndexChanged += new System.EventHandler(this.cbo_sexo_emp_SelectedIndexChanged);
            // 
            // Lbl_sexo
            // 
            this.Lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_sexo.AutoSize = true;
            this.Lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sexo.Location = new System.Drawing.Point(39, 102);
            this.Lbl_sexo.Name = "Lbl_sexo";
            this.Lbl_sexo.Size = new System.Drawing.Size(47, 20);
            this.Lbl_sexo.TabIndex = 112;
            this.Lbl_sexo.Text = "Sexo:";
            // 
            // cbo_carg_emp
            // 
            this.cbo_carg_emp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_carg_emp.Enabled = false;
            this.cbo_carg_emp.Location = new System.Drawing.Point(92, 70);
            this.cbo_carg_emp.Name = "cbo_carg_emp";
            this.cbo_carg_emp.Size = new System.Drawing.Size(214, 24);
            this.cbo_carg_emp.TabIndex = 8;
            // 
            // grb_vista_emp
            // 
            this.grb_vista_emp.Controls.Add(this.dgv_empleads);
            this.grb_vista_emp.Location = new System.Drawing.Point(12, 434);
            this.grb_vista_emp.Name = "grb_vista_emp";
            this.grb_vista_emp.Size = new System.Drawing.Size(723, 204);
            this.grb_vista_emp.TabIndex = 80;
            this.grb_vista_emp.TabStop = false;
            this.grb_vista_emp.Text = "Empleados";
            // 
            // dgv_empleads
            // 
            this.dgv_empleads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleads.Location = new System.Drawing.Point(1, 20);
            this.dgv_empleads.Name = "dgv_empleads";
            this.dgv_empleads.Size = new System.Drawing.Size(716, 178);
            this.dgv_empleads.TabIndex = 0;
            // 
            // lbl_busca_emp
            // 
            this.lbl_busca_emp.AutoSize = true;
            this.lbl_busca_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_emp.Location = new System.Drawing.Point(413, 383);
            this.lbl_busca_emp.Name = "lbl_busca_emp";
            this.lbl_busca_emp.Size = new System.Drawing.Size(230, 20);
            this.lbl_busca_emp.TabIndex = 132;
            this.lbl_busca_emp.Text = "Buscar Nombre del Empleado:";
            // 
            // btn_elim_emp
            // 
            this.btn_elim_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_emp.Location = new System.Drawing.Point(212, 60);
            this.btn_elim_emp.Name = "btn_elim_emp";
            this.btn_elim_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_emp.TabIndex = 137;
            this.btn_elim_emp.Text = "ELIMINAR";
            this.btn_elim_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_emp.UseVisualStyleBackColor = true;
            this.btn_elim_emp.Click += new System.EventHandler(this.btn_elim_emp_Click);
            // 
            // btn_actlz_emp
            // 
            this.btn_actlz_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_emp.Location = new System.Drawing.Point(112, 60);
            this.btn_actlz_emp.Name = "btn_actlz_emp";
            this.btn_actlz_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_emp.TabIndex = 136;
            this.btn_actlz_emp.Text = "ACTUALIZAR";
            this.btn_actlz_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_emp.UseVisualStyleBackColor = true;
            this.btn_actlz_emp.Click += new System.EventHandler(this.btn_actlz_emp_Click);
            // 
            // btn_guardar_emp
            // 
            this.btn_guardar_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_emp.Location = new System.Drawing.Point(12, 60);
            this.btn_guardar_emp.Name = "btn_guardar_emp";
            this.btn_guardar_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_emp.TabIndex = 135;
            this.btn_guardar_emp.Text = "GUARDAR";
            this.btn_guardar_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_emp.UseVisualStyleBackColor = true;
            this.btn_guardar_emp.Click += new System.EventHandler(this.btn_guardar_emp_Click);
            // 
            // btn_busc_emp
            // 
            this.btn_busc_emp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_emp.Location = new System.Drawing.Point(663, 384);
            this.btn_busc_emp.Name = "btn_busc_emp";
            this.btn_busc_emp.Size = new System.Drawing.Size(69, 52);
            this.btn_busc_emp.TabIndex = 134;
            this.btn_busc_emp.Text = "BUSCAR";
            this.btn_busc_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_emp.UseVisualStyleBackColor = true;
            this.btn_busc_emp.Click += new System.EventHandler(this.btn_busc_emp_Click);
            // 
            // Pic_logo
            // 
            this.Pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(635, 12);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 200);
            this.Pic_logo.TabIndex = 54;
            this.Pic_logo.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(417, 408);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(226, 20);
            this.txt_buscar.TabIndex = 138;
            // 
            // frm_act_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 666);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_elim_emp);
            this.Controls.Add(this.btn_actlz_emp);
            this.Controls.Add(this.btn_guardar_emp);
            this.Controls.Add(this.btn_busc_emp);
            this.Controls.Add(this.lbl_busca_emp);
            this.Controls.Add(this.grb_vista_emp);
            this.Controls.Add(this.grb_datosp_emp);
            this.Controls.Add(this.grb_datos_emp);
            this.Controls.Add(this.Pic_logo);
            this.Controls.Add(this.Label2);
            this.Name = "frm_act_emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar datos de empleado";
            this.Load += new System.EventHandler(this.frm_act_emp_Load);
            this.grb_datos_emp.ResumeLayout(false);
            this.grb_datos_emp.PerformLayout();
            this.grb_datosp_emp.ResumeLayout(false);
            this.grb_datosp_emp.PerformLayout();
            this.grb_vista_emp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Lbl_cargo;
        internal System.Windows.Forms.Label Lbl_apellido;
        internal System.Windows.Forms.TextBox txt_apellido;
        internal System.Windows.Forms.TextBox txt_usuario;
        internal System.Windows.Forms.Label Lbl_email_emp;
        internal System.Windows.Forms.TextBox txt_fecha_nacimiento;
        internal System.Windows.Forms.Label Lbl_fecha_nacimiento;
        internal System.Windows.Forms.TextBox txt_telefono;
        internal System.Windows.Forms.Label Lbl_telefono;
        internal System.Windows.Forms.Label Lbl_direccion;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox Pic_logo;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox grb_datos_emp;
        private System.Windows.Forms.GroupBox grb_datosp_emp;
        private System.Windows.Forms.ComboBox cbo_carg_emp;
        internal System.Windows.Forms.Label Lbl_sexo;
        private System.Windows.Forms.GroupBox grb_vista_emp;
        private System.Windows.Forms.DataGridView dgv_empleads;
        private System.Windows.Forms.Button btn_busc_emp;
        internal System.Windows.Forms.Label lbl_busca_emp;
        private System.Windows.Forms.Button btn_actlz_emp;
        private System.Windows.Forms.Button btn_guardar_emp;
        private System.Windows.Forms.Button btn_elim_emp;
        internal System.Windows.Forms.TextBox txt_contraseña2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_contraseña;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        internal System.Windows.Forms.TextBox txt_correo;
        internal System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.ComboBox cbo_id_lab;
        internal System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ComboBox cbo_sexo_emp;
        internal System.Windows.Forms.Label lbl_date_formato;
    }
}