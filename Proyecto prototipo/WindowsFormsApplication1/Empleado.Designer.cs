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
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.Lbl_dpi = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbo_id_empleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_datosp_emp = new System.Windows.Forms.GroupBox();
            this.btn_nuev_cargo_emp = new System.Windows.Forms.Button();
            this.btn_nuev_titulo = new System.Windows.Forms.Button();
            this.cbo_sexo_emp = new System.Windows.Forms.ComboBox();
            this.Lbl_sexo = new System.Windows.Forms.Label();
            this.cbo_carg_emp = new System.Windows.Forms.ComboBox();
            this.cbo_titl_emp = new System.Windows.Forms.ComboBox();
            this.grb_vista_emp = new System.Windows.Forms.GroupBox();
            this.dgv_empleads = new System.Windows.Forms.DataGridView();
            this.txt_busc_emp = new System.Windows.Forms.TextBox();
            this.lbl_busca_emp = new System.Windows.Forms.Label();
            this.btn_elim_emp = new System.Windows.Forms.Button();
            this.btn_actlz_emp = new System.Windows.Forms.Button();
            this.btn_guardar_emp = new System.Windows.Forms.Button();
            this.btn_busc_emp = new System.Windows.Forms.Button();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
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
            this.Lbl_cargo.Location = new System.Drawing.Point(5, 108);
            this.Lbl_cargo.Name = "Lbl_cargo";
            this.Lbl_cargo.Size = new System.Drawing.Size(60, 20);
            this.Lbl_cargo.TabIndex = 74;
            this.Lbl_cargo.Text = "Cargo:";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_titulo.Location = new System.Drawing.Point(17, 79);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(48, 20);
            this.Lbl_titulo.TabIndex = 72;
            this.Lbl_titulo.Text = "Titulo:";
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_apellido.Location = new System.Drawing.Point(34, 79);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(73, 20);
            this.Lbl_apellido.TabIndex = 71;
            this.Lbl_apellido.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_apellido.Location = new System.Drawing.Point(114, 79);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(264, 23);
            this.txt_apellido.TabIndex = 70;
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(73, 50);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(233, 23);
            this.txt_dpi.TabIndex = 69;
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_dpi.Location = new System.Drawing.Point(29, 50);
            this.Lbl_dpi.Name = "Lbl_dpi";
            this.Lbl_dpi.Size = new System.Drawing.Size(38, 20);
            this.Lbl_dpi.TabIndex = 68;
            this.Lbl_dpi.Text = "DPI:";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_email.Location = new System.Drawing.Point(157, 186);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(221, 23);
            this.txt_email.TabIndex = 67;
            // 
            // Lbl_email_emp
            // 
            this.Lbl_email_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_email_emp.AutoSize = true;
            this.Lbl_email_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_email_emp.Location = new System.Drawing.Point(51, 189);
            this.Lbl_email_emp.Name = "Lbl_email_emp";
            this.Lbl_email_emp.Size = new System.Drawing.Size(55, 20);
            this.Lbl_email_emp.TabIndex = 66;
            this.Lbl_email_emp.Text = "E-mail:";
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(183, 21);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(123, 23);
            this.txt_fecha_nacimiento.TabIndex = 65;
            // 
            // Lbl_fecha_nacimiento
            // 
            this.Lbl_fecha_nacimiento.AutoSize = true;
            this.Lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_fecha_nacimiento.Location = new System.Drawing.Point(6, 21);
            this.Lbl_fecha_nacimiento.Name = "Lbl_fecha_nacimiento";
            this.Lbl_fecha_nacimiento.Size = new System.Drawing.Size(171, 20);
            this.Lbl_fecha_nacimiento.TabIndex = 63;
            this.Lbl_fecha_nacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_telefono.Location = new System.Drawing.Point(157, 153);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(221, 23);
            this.txt_telefono.TabIndex = 61;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_telefono.Location = new System.Drawing.Point(33, 153);
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
            this.Lbl_direccion.Location = new System.Drawing.Point(23, 117);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(84, 20);
            this.Lbl_direccion.TabIndex = 58;
            this.Lbl_direccion.Text = "Direccion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_direccion.Location = new System.Drawing.Point(113, 108);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(265, 39);
            this.txt_direccion.TabIndex = 57;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_nombre.Location = new System.Drawing.Point(34, 47);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 56;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_nombre.Location = new System.Drawing.Point(114, 47);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(264, 23);
            this.txt_nombre.TabIndex = 55;
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
            this.grb_datos_emp.Controls.Add(this.comboBox3);
            this.grb_datos_emp.Controls.Add(this.comboBox2);
            this.grb_datos_emp.Controls.Add(this.cbo_id_empleado);
            this.grb_datos_emp.Controls.Add(this.label1);
            this.grb_datos_emp.Controls.Add(this.txt_nombre);
            this.grb_datos_emp.Controls.Add(this.Lbl_nombre);
            this.grb_datos_emp.Controls.Add(this.txt_apellido);
            this.grb_datos_emp.Controls.Add(this.Lbl_apellido);
            this.grb_datos_emp.Controls.Add(this.txt_direccion);
            this.grb_datos_emp.Controls.Add(this.txt_email);
            this.grb_datos_emp.Controls.Add(this.Lbl_direccion);
            this.grb_datos_emp.Controls.Add(this.Lbl_email_emp);
            this.grb_datos_emp.Controls.Add(this.txt_telefono);
            this.grb_datos_emp.Controls.Add(this.Lbl_telefono);
            this.grb_datos_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos_emp.Location = new System.Drawing.Point(12, 120);
            this.grb_datos_emp.Name = "grb_datos_emp";
            this.grb_datos_emp.Size = new System.Drawing.Size(399, 226);
            this.grb_datos_emp.TabIndex = 78;
            this.grb_datos_emp.TabStop = false;
            this.grb_datos_emp.Text = "Datos Generales";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(114, 186);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(37, 24);
            this.comboBox3.TabIndex = 79;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(37, 24);
            this.comboBox2.TabIndex = 78;
            // 
            // cbo_id_empleado
            // 
            this.cbo_id_empleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_id_empleado.FormattingEnabled = true;
            this.cbo_id_empleado.Location = new System.Drawing.Point(115, 17);
            this.cbo_id_empleado.Name = "cbo_id_empleado";
            this.cbo_id_empleado.Size = new System.Drawing.Size(111, 24);
            this.cbo_id_empleado.TabIndex = 77;
            this.cbo_id_empleado.SelectedIndexChanged += new System.EventHandler(this.cbo_id_empleado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Id Empleado:";
            // 
            // grb_datosp_emp
            // 
            this.grb_datosp_emp.Controls.Add(this.btn_nuev_cargo_emp);
            this.grb_datosp_emp.Controls.Add(this.btn_nuev_titulo);
            this.grb_datosp_emp.Controls.Add(this.cbo_sexo_emp);
            this.grb_datosp_emp.Controls.Add(this.Lbl_sexo);
            this.grb_datosp_emp.Controls.Add(this.cbo_carg_emp);
            this.grb_datosp_emp.Controls.Add(this.cbo_titl_emp);
            this.grb_datosp_emp.Controls.Add(this.Lbl_fecha_nacimiento);
            this.grb_datosp_emp.Controls.Add(this.txt_fecha_nacimiento);
            this.grb_datosp_emp.Controls.Add(this.Lbl_cargo);
            this.grb_datosp_emp.Controls.Add(this.txt_dpi);
            this.grb_datosp_emp.Controls.Add(this.Lbl_dpi);
            this.grb_datosp_emp.Controls.Add(this.Lbl_titulo);
            this.grb_datosp_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datosp_emp.Location = new System.Drawing.Point(417, 120);
            this.grb_datosp_emp.Name = "grb_datosp_emp";
            this.grb_datosp_emp.Size = new System.Drawing.Size(318, 182);
            this.grb_datosp_emp.TabIndex = 79;
            this.grb_datosp_emp.TabStop = false;
            this.grb_datosp_emp.Text = "Datos Personales";
            // 
            // btn_nuev_cargo_emp
            // 
            this.btn_nuev_cargo_emp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btn_nuev_cargo_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuev_cargo_emp.Location = new System.Drawing.Point(285, 109);
            this.btn_nuev_cargo_emp.Name = "btn_nuev_cargo_emp";
            this.btn_nuev_cargo_emp.Size = new System.Drawing.Size(27, 24);
            this.btn_nuev_cargo_emp.TabIndex = 115;
            this.btn_nuev_cargo_emp.UseVisualStyleBackColor = true;
            // 
            // btn_nuev_titulo
            // 
            this.btn_nuev_titulo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btn_nuev_titulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuev_titulo.Location = new System.Drawing.Point(285, 79);
            this.btn_nuev_titulo.Name = "btn_nuev_titulo";
            this.btn_nuev_titulo.Size = new System.Drawing.Size(27, 24);
            this.btn_nuev_titulo.TabIndex = 114;
            this.btn_nuev_titulo.UseVisualStyleBackColor = true;
            // 
            // cbo_sexo_emp
            // 
            this.cbo_sexo_emp.FormattingEnabled = true;
            this.cbo_sexo_emp.Location = new System.Drawing.Point(73, 139);
            this.cbo_sexo_emp.Name = "cbo_sexo_emp";
            this.cbo_sexo_emp.Size = new System.Drawing.Size(148, 24);
            this.cbo_sexo_emp.TabIndex = 113;
            // 
            // Lbl_sexo
            // 
            this.Lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_sexo.AutoSize = true;
            this.Lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sexo.Location = new System.Drawing.Point(20, 139);
            this.Lbl_sexo.Name = "Lbl_sexo";
            this.Lbl_sexo.Size = new System.Drawing.Size(47, 20);
            this.Lbl_sexo.TabIndex = 112;
            this.Lbl_sexo.Text = "Sexo:";
            // 
            // cbo_carg_emp
            // 
            this.cbo_carg_emp.FormattingEnabled = true;
            this.cbo_carg_emp.Location = new System.Drawing.Point(73, 109);
            this.cbo_carg_emp.Name = "cbo_carg_emp";
            this.cbo_carg_emp.Size = new System.Drawing.Size(206, 24);
            this.cbo_carg_emp.TabIndex = 81;
            // 
            // cbo_titl_emp
            // 
            this.cbo_titl_emp.FormattingEnabled = true;
            this.cbo_titl_emp.Location = new System.Drawing.Point(73, 79);
            this.cbo_titl_emp.Name = "cbo_titl_emp";
            this.cbo_titl_emp.Size = new System.Drawing.Size(206, 24);
            this.cbo_titl_emp.TabIndex = 80;
            // 
            // grb_vista_emp
            // 
            this.grb_vista_emp.Controls.Add(this.dgv_empleads);
            this.grb_vista_emp.Location = new System.Drawing.Point(12, 352);
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
            // txt_busc_emp
            // 
            this.txt_busc_emp.Location = new System.Drawing.Point(485, 329);
            this.txt_busc_emp.Name = "txt_busc_emp";
            this.txt_busc_emp.Size = new System.Drawing.Size(175, 20);
            this.txt_busc_emp.TabIndex = 133;
            // 
            // lbl_busca_emp
            // 
            this.lbl_busca_emp.AutoSize = true;
            this.lbl_busca_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_emp.Location = new System.Drawing.Point(417, 329);
            this.lbl_busca_emp.Name = "lbl_busca_emp";
            this.lbl_busca_emp.Size = new System.Drawing.Size(62, 20);
            this.lbl_busca_emp.TabIndex = 132;
            this.lbl_busca_emp.Text = "Buscar:";
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
            this.btn_busc_emp.Location = new System.Drawing.Point(666, 306);
            this.btn_busc_emp.Name = "btn_busc_emp";
            this.btn_busc_emp.Size = new System.Drawing.Size(69, 52);
            this.btn_busc_emp.TabIndex = 134;
            this.btn_busc_emp.Text = "BUSCAR";
            this.btn_busc_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_emp.UseVisualStyleBackColor = true;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(635, 12);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 102);
            this.Pic_logo.TabIndex = 54;
            this.Pic_logo.TabStop = false;
            // 
            // frm_act_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 568);
            this.Controls.Add(this.btn_elim_emp);
            this.Controls.Add(this.btn_actlz_emp);
            this.Controls.Add(this.btn_guardar_emp);
            this.Controls.Add(this.btn_busc_emp);
            this.Controls.Add(this.txt_busc_emp);
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
        internal System.Windows.Forms.Label Lbl_titulo;
        internal System.Windows.Forms.Label Lbl_apellido;
        internal System.Windows.Forms.TextBox txt_apellido;
        internal System.Windows.Forms.TextBox txt_dpi;
        internal System.Windows.Forms.Label Lbl_dpi;
        internal System.Windows.Forms.TextBox txt_email;
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
        private System.Windows.Forms.ComboBox cbo_id_empleado;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox grb_datosp_emp;
        private System.Windows.Forms.ComboBox cbo_carg_emp;
        private System.Windows.Forms.ComboBox cbo_titl_emp;
        internal System.Windows.Forms.Label Lbl_sexo;
        private System.Windows.Forms.GroupBox grb_vista_emp;
        private System.Windows.Forms.DataGridView dgv_empleads;
        private System.Windows.Forms.Button btn_busc_emp;
        internal System.Windows.Forms.TextBox txt_busc_emp;
        internal System.Windows.Forms.Label lbl_busca_emp;
        private System.Windows.Forms.Button btn_actlz_emp;
        private System.Windows.Forms.Button btn_guardar_emp;
        private System.Windows.Forms.ComboBox cbo_sexo_emp;
        private System.Windows.Forms.Button btn_nuev_titulo;
        private System.Windows.Forms.Button btn_elim_emp;
        private System.Windows.Forms.Button btn_nuev_cargo_emp;
    }
}