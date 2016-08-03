namespace WindowsFormsApplication1
{
    partial class frm_act_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_cliente));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.grb_datos1_pcnt = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Lbl_email = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.Lbl_nit = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cbo_expediente = new System.Windows.Forms.ComboBox();
            this.txt_peso_pcnt = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.Lbl_peso = new System.Windows.Forms.Label();
            this.Lbl_altura = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txt_referido = new System.Windows.Forms.TextBox();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.Lbl_dpi = new System.Windows.Forms.Label();
            this.Lbl_referido = new System.Windows.Forms.Label();
            this.txt_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.Lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.Lbl_sexo = new System.Windows.Forms.Label();
            this.Lbl_expediente = new System.Windows.Forms.Label();
            this.grb_datos2_pcnt = new System.Windows.Forms.GroupBox();
            this.cbo_tip_sang_pcnt = new System.Windows.Forms.ComboBox();
            this.cbo_sexo_pcnt = new System.Windows.Forms.ComboBox();
            this.grb_datos3_pnct = new System.Windows.Forms.GroupBox();
            this.grb_vista_pcnt = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_busc_pcnt = new System.Windows.Forms.TextBox();
            this.lbl_busca_pcnt = new System.Windows.Forms.Label();
            this.btn_busc_aseg = new System.Windows.Forms.Button();
            this.btn_actlz_pcnt = new System.Windows.Forms.Button();
            this.btn_guardar_pcnt = new System.Windows.Forms.Button();
            this.btn_elim_pcnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grb_datos1_pcnt.SuspendLayout();
            this.grb_datos2_pcnt.SuspendLayout();
            this.grb_datos3_pnct.SuspendLayout();
            this.grb_vista_pcnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(668, 9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 102);
            this.PictureBox1.TabIndex = 48;
            this.PictureBox1.TabStop = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(293, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(135, 34);
            this.Lbl_titulo.TabIndex = 47;
            this.Lbl_titulo.Text = "Paciente";
            // 
            // grb_datos1_pcnt
            // 
            this.grb_datos1_pcnt.Controls.Add(this.comboBox3);
            this.grb_datos1_pcnt.Controls.Add(this.Lbl_apellido);
            this.grb_datos1_pcnt.Controls.Add(this.comboBox2);
            this.grb_datos1_pcnt.Controls.Add(this.txt_apellido);
            this.grb_datos1_pcnt.Controls.Add(this.txt_email);
            this.grb_datos1_pcnt.Controls.Add(this.Lbl_email);
            this.grb_datos1_pcnt.Controls.Add(this.txt_nit);
            this.grb_datos1_pcnt.Controls.Add(this.txt_telefono);
            this.grb_datos1_pcnt.Controls.Add(this.Lbl_nit);
            this.grb_datos1_pcnt.Controls.Add(this.Lbl_telefono);
            this.grb_datos1_pcnt.Controls.Add(this.Lbl_direccion);
            this.grb_datos1_pcnt.Controls.Add(this.txt_direccion);
            this.grb_datos1_pcnt.Controls.Add(this.Lbl_nombre);
            this.grb_datos1_pcnt.Controls.Add(this.txt_nombre);
            this.grb_datos1_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_pcnt.Location = new System.Drawing.Point(12, 117);
            this.grb_datos1_pcnt.Name = "grb_datos1_pcnt";
            this.grb_datos1_pcnt.Size = new System.Drawing.Size(436, 198);
            this.grb_datos1_pcnt.TabIndex = 79;
            this.grb_datos1_pcnt.TabStop = false;
            this.grb_datos1_pcnt.Text = "Datos Generales";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(93, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(37, 24);
            this.comboBox3.TabIndex = 140;
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_apellido.Location = new System.Drawing.Point(14, 48);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(73, 20);
            this.Lbl_apellido.TabIndex = 103;
            this.Lbl_apellido.Text = "Apellido:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(37, 24);
            this.comboBox2.TabIndex = 139;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(93, 48);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(325, 23);
            this.txt_apellido.TabIndex = 102;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(140, 152);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(278, 23);
            this.txt_email.TabIndex = 94;
            // 
            // Lbl_email
            // 
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_email.Location = new System.Drawing.Point(26, 152);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(55, 20);
            this.Lbl_email.TabIndex = 93;
            this.Lbl_email.Text = "E-mail:";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(310, 123);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(106, 23);
            this.txt_nit.TabIndex = 89;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(140, 123);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(126, 23);
            this.txt_telefono.TabIndex = 88;
            // 
            // Lbl_nit
            // 
            this.Lbl_nit.AutoSize = true;
            this.Lbl_nit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nit.Location = new System.Drawing.Point(272, 123);
            this.Lbl_nit.Name = "Lbl_nit";
            this.Lbl_nit.Size = new System.Drawing.Size(32, 20);
            this.Lbl_nit.TabIndex = 87;
            this.Lbl_nit.Text = "Nit:";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_telefono.Location = new System.Drawing.Point(12, 123);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(75, 20);
            this.Lbl_telefono.TabIndex = 86;
            this.Lbl_telefono.Text = "Telefono:";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direccion.Location = new System.Drawing.Point(3, 88);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(84, 20);
            this.Lbl_direccion.TabIndex = 85;
            this.Lbl_direccion.Text = "Direccion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(93, 77);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(325, 40);
            this.txt_direccion.TabIndex = 82;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(15, 19);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 81;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(93, 19);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(325, 23);
            this.txt_nombre.TabIndex = 80;
            // 
            // cbo_expediente
            // 
            this.cbo_expediente.FormattingEnabled = true;
            this.cbo_expediente.Location = new System.Drawing.Point(539, 21);
            this.cbo_expediente.Name = "cbo_expediente";
            this.cbo_expediente.Size = new System.Drawing.Size(207, 24);
            this.cbo_expediente.TabIndex = 125;
            // 
            // txt_peso_pcnt
            // 
            this.txt_peso_pcnt.Location = new System.Drawing.Point(80, 106);
            this.txt_peso_pcnt.Name = "txt_peso_pcnt";
            this.txt_peso_pcnt.Size = new System.Drawing.Size(224, 23);
            this.txt_peso_pcnt.TabIndex = 124;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(80, 77);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(224, 23);
            this.txt_altura.TabIndex = 123;
            // 
            // Lbl_peso
            // 
            this.Lbl_peso.AutoSize = true;
            this.Lbl_peso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peso.Location = new System.Drawing.Point(26, 104);
            this.Lbl_peso.Name = "Lbl_peso";
            this.Lbl_peso.Size = new System.Drawing.Size(48, 20);
            this.Lbl_peso.TabIndex = 122;
            this.Lbl_peso.Text = "Peso:";
            // 
            // Lbl_altura
            // 
            this.Lbl_altura.AutoSize = true;
            this.Lbl_altura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_altura.Location = new System.Drawing.Point(18, 77);
            this.Lbl_altura.Name = "Lbl_altura";
            this.Lbl_altura.Size = new System.Drawing.Size(56, 20);
            this.Lbl_altura.TabIndex = 121;
            this.Lbl_altura.Text = "Altura:";
            // 
            // Label13
            // 
            this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(11, 164);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(120, 20);
            this.Label13.TabIndex = 119;
            this.Label13.Text = "Tipo de Sangre:";
            // 
            // txt_referido
            // 
            this.txt_referido.Location = new System.Drawing.Point(121, 22);
            this.txt_referido.Name = "txt_referido";
            this.txt_referido.Size = new System.Drawing.Size(297, 23);
            this.txt_referido.TabIndex = 118;
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(80, 48);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(224, 23);
            this.txt_dpi.TabIndex = 117;
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpi.Location = new System.Drawing.Point(36, 48);
            this.Lbl_dpi.Name = "Lbl_dpi";
            this.Lbl_dpi.Size = new System.Drawing.Size(38, 20);
            this.Lbl_dpi.TabIndex = 116;
            this.Lbl_dpi.Text = "DPI:";
            // 
            // Lbl_referido
            // 
            this.Lbl_referido.AutoSize = true;
            this.Lbl_referido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_referido.Location = new System.Drawing.Point(40, 25);
            this.Lbl_referido.Name = "Lbl_referido";
            this.Lbl_referido.Size = new System.Drawing.Size(75, 20);
            this.Lbl_referido.TabIndex = 115;
            this.Lbl_referido.Text = "Referido:";
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(177, 19);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(127, 23);
            this.txt_fecha_nacimiento.TabIndex = 114;
            // 
            // Lbl_fecha_nacimiento
            // 
            this.Lbl_fecha_nacimiento.AutoSize = true;
            this.Lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha_nacimiento.Location = new System.Drawing.Point(10, 22);
            this.Lbl_fecha_nacimiento.Name = "Lbl_fecha_nacimiento";
            this.Lbl_fecha_nacimiento.Size = new System.Drawing.Size(171, 20);
            this.Lbl_fecha_nacimiento.TabIndex = 112;
            this.Lbl_fecha_nacimiento.Text = "Fecha de Nacimiento:";
            // 
            // Lbl_sexo
            // 
            this.Lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_sexo.AutoSize = true;
            this.Lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sexo.Location = new System.Drawing.Point(27, 138);
            this.Lbl_sexo.Name = "Lbl_sexo";
            this.Lbl_sexo.Size = new System.Drawing.Size(47, 20);
            this.Lbl_sexo.TabIndex = 110;
            this.Lbl_sexo.Text = "Sexo:";
            // 
            // Lbl_expediente
            // 
            this.Lbl_expediente.AutoSize = true;
            this.Lbl_expediente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_expediente.Location = new System.Drawing.Point(438, 21);
            this.Lbl_expediente.Name = "Lbl_expediente";
            this.Lbl_expediente.Size = new System.Drawing.Size(95, 20);
            this.Lbl_expediente.TabIndex = 109;
            this.Lbl_expediente.Text = "Expediente:";
            // 
            // grb_datos2_pcnt
            // 
            this.grb_datos2_pcnt.Controls.Add(this.cbo_tip_sang_pcnt);
            this.grb_datos2_pcnt.Controls.Add(this.cbo_sexo_pcnt);
            this.grb_datos2_pcnt.Controls.Add(this.txt_fecha_nacimiento);
            this.grb_datos2_pcnt.Controls.Add(this.Lbl_fecha_nacimiento);
            this.grb_datos2_pcnt.Controls.Add(this.Label13);
            this.grb_datos2_pcnt.Controls.Add(this.txt_peso_pcnt);
            this.grb_datos2_pcnt.Controls.Add(this.Lbl_peso);
            this.grb_datos2_pcnt.Controls.Add(this.txt_altura);
            this.grb_datos2_pcnt.Controls.Add(this.Lbl_sexo);
            this.grb_datos2_pcnt.Controls.Add(this.txt_dpi);
            this.grb_datos2_pcnt.Controls.Add(this.Lbl_altura);
            this.grb_datos2_pcnt.Controls.Add(this.Lbl_dpi);
            this.grb_datos2_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos2_pcnt.Location = new System.Drawing.Point(454, 117);
            this.grb_datos2_pcnt.Name = "grb_datos2_pcnt";
            this.grb_datos2_pcnt.Size = new System.Drawing.Size(312, 198);
            this.grb_datos2_pcnt.TabIndex = 126;
            this.grb_datos2_pcnt.TabStop = false;
            this.grb_datos2_pcnt.Text = "Datos Personales";
            // 
            // cbo_tip_sang_pcnt
            // 
            this.cbo_tip_sang_pcnt.FormattingEnabled = true;
            this.cbo_tip_sang_pcnt.Location = new System.Drawing.Point(137, 164);
            this.cbo_tip_sang_pcnt.Name = "cbo_tip_sang_pcnt";
            this.cbo_tip_sang_pcnt.Size = new System.Drawing.Size(100, 24);
            this.cbo_tip_sang_pcnt.TabIndex = 127;
            // 
            // cbo_sexo_pcnt
            // 
            this.cbo_sexo_pcnt.FormattingEnabled = true;
            this.cbo_sexo_pcnt.Location = new System.Drawing.Point(80, 137);
            this.cbo_sexo_pcnt.Name = "cbo_sexo_pcnt";
            this.cbo_sexo_pcnt.Size = new System.Drawing.Size(157, 24);
            this.cbo_sexo_pcnt.TabIndex = 126;
            // 
            // grb_datos3_pnct
            // 
            this.grb_datos3_pnct.Controls.Add(this.txt_referido);
            this.grb_datos3_pnct.Controls.Add(this.Lbl_referido);
            this.grb_datos3_pnct.Controls.Add(this.cbo_expediente);
            this.grb_datos3_pnct.Controls.Add(this.Lbl_expediente);
            this.grb_datos3_pnct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos3_pnct.Location = new System.Drawing.Point(12, 321);
            this.grb_datos3_pnct.Name = "grb_datos3_pnct";
            this.grb_datos3_pnct.Size = new System.Drawing.Size(754, 54);
            this.grb_datos3_pnct.TabIndex = 127;
            this.grb_datos3_pnct.TabStop = false;
            this.grb_datos3_pnct.Text = "Referencia y Expediente";
            // 
            // grb_vista_pcnt
            // 
            this.grb_vista_pcnt.Controls.Add(this.dataGridView1);
            this.grb_vista_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_pcnt.Location = new System.Drawing.Point(12, 418);
            this.grb_vista_pcnt.Name = "grb_vista_pcnt";
            this.grb_vista_pcnt.Size = new System.Drawing.Size(754, 180);
            this.grb_vista_pcnt.TabIndex = 128;
            this.grb_vista_pcnt.TabStop = false;
            this.grb_vista_pcnt.Text = "Pacientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_busc_pcnt
            // 
            this.txt_busc_pcnt.Location = new System.Drawing.Point(162, 392);
            this.txt_busc_pcnt.Name = "txt_busc_pcnt";
            this.txt_busc_pcnt.Size = new System.Drawing.Size(473, 20);
            this.txt_busc_pcnt.TabIndex = 127;
            // 
            // lbl_busca_pcnt
            // 
            this.lbl_busca_pcnt.AutoSize = true;
            this.lbl_busca_pcnt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_pcnt.Location = new System.Drawing.Point(24, 392);
            this.lbl_busca_pcnt.Name = "lbl_busca_pcnt";
            this.lbl_busca_pcnt.Size = new System.Drawing.Size(132, 20);
            this.lbl_busca_pcnt.TabIndex = 126;
            this.lbl_busca_pcnt.Text = "Buscar Paciente:";
            // 
            // btn_busc_aseg
            // 
            this.btn_busc_aseg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_aseg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_aseg.Location = new System.Drawing.Point(644, 381);
            this.btn_busc_aseg.Name = "btn_busc_aseg";
            this.btn_busc_aseg.Size = new System.Drawing.Size(114, 40);
            this.btn_busc_aseg.TabIndex = 131;
            this.btn_busc_aseg.Text = "BUSCAR";
            this.btn_busc_aseg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_aseg.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_pcnt
            // 
            this.btn_actlz_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_pcnt.Location = new System.Drawing.Point(112, 57);
            this.btn_actlz_pcnt.Name = "btn_actlz_pcnt";
            this.btn_actlz_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_pcnt.TabIndex = 130;
            this.btn_actlz_pcnt.Text = "ACTUALIZAR";
            this.btn_actlz_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_pcnt.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_pcnt
            // 
            this.btn_guardar_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_pcnt.Location = new System.Drawing.Point(12, 57);
            this.btn_guardar_pcnt.Name = "btn_guardar_pcnt";
            this.btn_guardar_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_pcnt.TabIndex = 129;
            this.btn_guardar_pcnt.Text = "GUARDAR";
            this.btn_guardar_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_pcnt.UseVisualStyleBackColor = true;
            // 
            // btn_elim_pcnt
            // 
            this.btn_elim_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_pcnt.Location = new System.Drawing.Point(212, 57);
            this.btn_elim_pcnt.Name = "btn_elim_pcnt";
            this.btn_elim_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_pcnt.TabIndex = 138;
            this.btn_elim_pcnt.Text = "ELIMINAR";
            this.btn_elim_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_pcnt.UseVisualStyleBackColor = true;
            // 
            // frm_act_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 603);
            this.Controls.Add(this.btn_elim_pcnt);
            this.Controls.Add(this.btn_busc_aseg);
            this.Controls.Add(this.btn_actlz_pcnt);
            this.Controls.Add(this.btn_guardar_pcnt);
            this.Controls.Add(this.txt_busc_pcnt);
            this.Controls.Add(this.lbl_busca_pcnt);
            this.Controls.Add(this.grb_vista_pcnt);
            this.Controls.Add(this.grb_datos3_pnct);
            this.Controls.Add(this.grb_datos2_pcnt);
            this.Controls.Add(this.grb_datos1_pcnt);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "frm_act_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Datos del Cliente";
            this.Load += new System.EventHandler(this.frm_act_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grb_datos1_pcnt.ResumeLayout(false);
            this.grb_datos1_pcnt.PerformLayout();
            this.grb_datos2_pcnt.ResumeLayout(false);
            this.grb_datos2_pcnt.PerformLayout();
            this.grb_datos3_pnct.ResumeLayout(false);
            this.grb_datos3_pnct.PerformLayout();
            this.grb_vista_pcnt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox grb_datos1_pcnt;
        internal System.Windows.Forms.Label Lbl_apellido;
        internal System.Windows.Forms.TextBox txt_apellido;
        internal System.Windows.Forms.TextBox txt_email;
        internal System.Windows.Forms.Label Lbl_email;
        internal System.Windows.Forms.TextBox txt_nit;
        internal System.Windows.Forms.TextBox txt_telefono;
        internal System.Windows.Forms.Label Lbl_nit;
        internal System.Windows.Forms.Label Lbl_telefono;
        internal System.Windows.Forms.Label Lbl_direccion;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.ComboBox cbo_expediente;
        internal System.Windows.Forms.TextBox txt_peso_pcnt;
        internal System.Windows.Forms.TextBox txt_altura;
        internal System.Windows.Forms.Label Lbl_peso;
        internal System.Windows.Forms.Label Lbl_altura;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txt_referido;
        internal System.Windows.Forms.TextBox txt_dpi;
        internal System.Windows.Forms.Label Lbl_dpi;
        internal System.Windows.Forms.Label Lbl_referido;
        internal System.Windows.Forms.TextBox txt_fecha_nacimiento;
        internal System.Windows.Forms.Label Lbl_fecha_nacimiento;
        internal System.Windows.Forms.Label Lbl_sexo;
        internal System.Windows.Forms.Label Lbl_expediente;
        private System.Windows.Forms.GroupBox grb_datos2_pcnt;
        private System.Windows.Forms.GroupBox grb_datos3_pnct;
        private System.Windows.Forms.GroupBox grb_vista_pcnt;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.TextBox txt_busc_pcnt;
        internal System.Windows.Forms.Label lbl_busca_pcnt;
        private System.Windows.Forms.Button btn_busc_aseg;
        private System.Windows.Forms.Button btn_actlz_pcnt;
        private System.Windows.Forms.Button btn_guardar_pcnt;
        private System.Windows.Forms.ComboBox cbo_sexo_pcnt;
        private System.Windows.Forms.ComboBox cbo_tip_sang_pcnt;
        private System.Windows.Forms.Button btn_elim_pcnt;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}