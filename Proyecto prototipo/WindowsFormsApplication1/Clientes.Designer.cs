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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_cliente));
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.grb_datos1_pcnt = new System.Windows.Forms.GroupBox();
            this.Lbl_apellido = new System.Windows.Forms.Label();
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
            this.grb_datos2_pcnt = new System.Windows.Forms.GroupBox();
            this.cbo_tip_sang_pcnt = new System.Windows.Forms.ComboBox();
            this.cbo_sexo_pcnt = new System.Windows.Forms.ComboBox();
            this.grb_datos3_pnct = new System.Windows.Forms.GroupBox();
            this.cbo_lab_pcnt = new System.Windows.Forms.ComboBox();
            this.lbl_lab_pcnt = new System.Windows.Forms.Label();
            this.grb_vista_pcnt = new System.Windows.Forms.GroupBox();
            this.dgv_list_pcnt = new System.Windows.Forms.DataGridView();
            this.txt_busc_pcnt = new System.Windows.Forms.TextBox();
            this.lbl_busca_pcnt = new System.Windows.Forms.Label();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_nuevo_pcnt = new System.Windows.Forms.Button();
            this.btn_renov_pcnt = new System.Windows.Forms.Button();
            this.btn_elim_pcnt = new System.Windows.Forms.Button();
            this.btn_busc_pcnt = new System.Windows.Forms.Button();
            this.btn_actlz_pcnt = new System.Windows.Forms.Button();
            this.btn_guardar_pcnt = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlt_nuevo = new System.Windows.Forms.ToolTip(this.components);
            this.tlt_guardar = new System.Windows.Forms.ToolTip(this.components);
            this.tlt_modificar = new System.Windows.Forms.ToolTip(this.components);
            this.tltl_eliminar = new System.Windows.Forms.ToolTip(this.components);
            this.tlt_buscar = new System.Windows.Forms.ToolTip(this.components);
            this.tlt_cancelar = new System.Windows.Forms.ToolTip(this.components);
            this.tlt_aceptar = new System.Windows.Forms.ToolTip(this.components);
            this.tlt_actualizar = new System.Windows.Forms.ToolTip(this.components);
            this.grb_datos1_pcnt.SuspendLayout();
            this.grb_datos2_pcnt.SuspendLayout();
            this.grb_datos3_pnct.SuspendLayout();
            this.grb_vista_pcnt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_pcnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.grb_datos1_pcnt.Controls.Add(this.Lbl_apellido);
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
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(93, 48);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(325, 23);
            this.txt_apellido.TabIndex = 2;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            this.txt_apellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_apellido_KeyDown);
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(93, 152);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(325, 23);
            this.txt_email.TabIndex = 6;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_email_KeyDown);
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
            this.txt_nit.TabIndex = 5;
            this.txt_nit.TextChanged += new System.EventHandler(this.txt_nit_TextChanged);
            this.txt_nit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nit_KeyDown);
            this.txt_nit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nit_KeyPress);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(93, 123);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(173, 23);
            this.txt_telefono.TabIndex = 4;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            this.txt_telefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_telefono_KeyDown);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
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
            this.txt_direccion.TabIndex = 3;
            this.txt_direccion.TextChanged += new System.EventHandler(this.txt_direccion_TextChanged);
            this.txt_direccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_direccion_KeyDown);
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
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_KeyDown);
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_peso_pcnt
            // 
            this.txt_peso_pcnt.Location = new System.Drawing.Point(113, 106);
            this.txt_peso_pcnt.Name = "txt_peso_pcnt";
            this.txt_peso_pcnt.Size = new System.Drawing.Size(191, 23);
            this.txt_peso_pcnt.TabIndex = 10;
            this.txt_peso_pcnt.TextChanged += new System.EventHandler(this.txt_peso_pcnt_TextChanged);
            this.txt_peso_pcnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_peso_pcnt_KeyDown);
            this.txt_peso_pcnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_peso_pcnt_KeyPress);
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(113, 77);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(191, 23);
            this.txt_altura.TabIndex = 9;
            this.txt_altura.TextChanged += new System.EventHandler(this.txt_altura_TextChanged);
            this.txt_altura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_altura_KeyDown);
            this.txt_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_altura_KeyPress);
            // 
            // Lbl_peso
            // 
            this.Lbl_peso.AutoSize = true;
            this.Lbl_peso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_peso.Location = new System.Drawing.Point(30, 106);
            this.Lbl_peso.Name = "Lbl_peso";
            this.Lbl_peso.Size = new System.Drawing.Size(75, 20);
            this.Lbl_peso.TabIndex = 122;
            this.Lbl_peso.Text = "Peso(Lb):";
            // 
            // Lbl_altura
            // 
            this.Lbl_altura.AutoSize = true;
            this.Lbl_altura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_altura.Location = new System.Drawing.Point(11, 77);
            this.Lbl_altura.Name = "Lbl_altura";
            this.Lbl_altura.Size = new System.Drawing.Size(94, 20);
            this.Lbl_altura.TabIndex = 121;
            this.Lbl_altura.Text = "Altura (mts):";
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
            this.txt_referido.TabIndex = 12;
            this.txt_referido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_referido_KeyDown);
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(113, 48);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(191, 23);
            this.txt_dpi.TabIndex = 8;
            this.txt_dpi.TextChanged += new System.EventHandler(this.txt_dpi_TextChanged);
            this.txt_dpi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_dpi_KeyDown);
            this.txt_dpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dpi_KeyPress);
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpi.Location = new System.Drawing.Point(67, 48);
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
            this.txt_fecha_nacimiento.TabIndex = 7;
            this.txt_fecha_nacimiento.TextChanged += new System.EventHandler(this.txt_fecha_nacimiento_TextChanged);
            this.txt_fecha_nacimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fecha_nacimiento_KeyDown);
            this.txt_fecha_nacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fecha_nacimiento_KeyPress);
            // 
            // Lbl_fecha_nacimiento
            // 
            this.Lbl_fecha_nacimiento.AutoSize = true;
            this.Lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha_nacimiento.Location = new System.Drawing.Point(120, 19);
            this.Lbl_fecha_nacimiento.Name = "Lbl_fecha_nacimiento";
            this.Lbl_fecha_nacimiento.Size = new System.Drawing.Size(51, 20);
            this.Lbl_fecha_nacimiento.TabIndex = 112;
            this.Lbl_fecha_nacimiento.Text = "Edad:";
            // 
            // Lbl_sexo
            // 
            this.Lbl_sexo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_sexo.AutoSize = true;
            this.Lbl_sexo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_sexo.Location = new System.Drawing.Point(58, 138);
            this.Lbl_sexo.Name = "Lbl_sexo";
            this.Lbl_sexo.Size = new System.Drawing.Size(47, 20);
            this.Lbl_sexo.TabIndex = 110;
            this.Lbl_sexo.Text = "Sexo:";
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
            this.cbo_tip_sang_pcnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tip_sang_pcnt.FormattingEnabled = true;
            this.cbo_tip_sang_pcnt.Items.AddRange(new object[] {
            "A Positiva (A+)",
            "A Negativo (A-)",
            "B Positivo (B+)",
            "B Negativo (B-)",
            "O Positivo (O+)",
            "O Negativo (O-)",
            "AB Positivo (AB+)",
            "AB Negativo (AB-)"});
            this.cbo_tip_sang_pcnt.Location = new System.Drawing.Point(137, 164);
            this.cbo_tip_sang_pcnt.Name = "cbo_tip_sang_pcnt";
            this.cbo_tip_sang_pcnt.Size = new System.Drawing.Size(120, 24);
            this.cbo_tip_sang_pcnt.TabIndex = 127;
            // 
            // cbo_sexo_pcnt
            // 
            this.cbo_sexo_pcnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo_pcnt.FormattingEnabled = true;
            this.cbo_sexo_pcnt.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbo_sexo_pcnt.Location = new System.Drawing.Point(113, 134);
            this.cbo_sexo_pcnt.Name = "cbo_sexo_pcnt";
            this.cbo_sexo_pcnt.Size = new System.Drawing.Size(177, 24);
            this.cbo_sexo_pcnt.TabIndex = 126;
            this.cbo_sexo_pcnt.SelectedIndexChanged += new System.EventHandler(this.cbo_sexo_pcnt_SelectedIndexChanged);
            // 
            // grb_datos3_pnct
            // 
            this.grb_datos3_pnct.Controls.Add(this.cbo_lab_pcnt);
            this.grb_datos3_pnct.Controls.Add(this.lbl_lab_pcnt);
            this.grb_datos3_pnct.Controls.Add(this.txt_referido);
            this.grb_datos3_pnct.Controls.Add(this.Lbl_referido);
            this.grb_datos3_pnct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos3_pnct.Location = new System.Drawing.Point(12, 321);
            this.grb_datos3_pnct.Name = "grb_datos3_pnct";
            this.grb_datos3_pnct.Size = new System.Drawing.Size(754, 54);
            this.grb_datos3_pnct.TabIndex = 127;
            this.grb_datos3_pnct.TabStop = false;
            this.grb_datos3_pnct.Text = "Referencia y Laboratorio";
            // 
            // cbo_lab_pcnt
            // 
            this.cbo_lab_pcnt.FormattingEnabled = true;
            this.cbo_lab_pcnt.Location = new System.Drawing.Point(594, 21);
            this.cbo_lab_pcnt.Name = "cbo_lab_pcnt";
            this.cbo_lab_pcnt.Size = new System.Drawing.Size(152, 24);
            this.cbo_lab_pcnt.TabIndex = 129;
            // 
            // lbl_lab_pcnt
            // 
            this.lbl_lab_pcnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_lab_pcnt.AutoSize = true;
            this.lbl_lab_pcnt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lab_pcnt.Location = new System.Drawing.Point(427, 22);
            this.lbl_lab_pcnt.Name = "lbl_lab_pcnt";
            this.lbl_lab_pcnt.Size = new System.Drawing.Size(170, 20);
            this.lbl_lab_pcnt.TabIndex = 128;
            this.lbl_lab_pcnt.Text = "Laboratorio asignado:";
            // 
            // grb_vista_pcnt
            // 
            this.grb_vista_pcnt.Controls.Add(this.dgv_list_pcnt);
            this.grb_vista_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_pcnt.Location = new System.Drawing.Point(12, 418);
            this.grb_vista_pcnt.Name = "grb_vista_pcnt";
            this.grb_vista_pcnt.Size = new System.Drawing.Size(754, 180);
            this.grb_vista_pcnt.TabIndex = 128;
            this.grb_vista_pcnt.TabStop = false;
            this.grb_vista_pcnt.Text = "Pacientes";
            // 
            // dgv_list_pcnt
            // 
            this.dgv_list_pcnt.AllowUserToAddRows = false;
            this.dgv_list_pcnt.AllowUserToDeleteRows = false;
            this.dgv_list_pcnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_pcnt.Location = new System.Drawing.Point(7, 22);
            this.dgv_list_pcnt.Name = "dgv_list_pcnt";
            this.dgv_list_pcnt.ReadOnly = true;
            this.dgv_list_pcnt.Size = new System.Drawing.Size(739, 152);
            this.dgv_list_pcnt.TabIndex = 0;
            // 
            // txt_busc_pcnt
            // 
            this.txt_busc_pcnt.Location = new System.Drawing.Point(259, 392);
            this.txt_busc_pcnt.Name = "txt_busc_pcnt";
            this.txt_busc_pcnt.Size = new System.Drawing.Size(366, 20);
            this.txt_busc_pcnt.TabIndex = 14;
            this.txt_busc_pcnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_busc_pcnt_KeyDown);
            this.txt_busc_pcnt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_pcnt_KeyUp);
            // 
            // lbl_busca_pcnt
            // 
            this.lbl_busca_pcnt.AutoSize = true;
            this.lbl_busca_pcnt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_pcnt.Location = new System.Drawing.Point(121, 392);
            this.lbl_busca_pcnt.Name = "lbl_busca_pcnt";
            this.lbl_busca_pcnt.Size = new System.Drawing.Size(132, 20);
            this.lbl_busca_pcnt.TabIndex = 126;
            this.lbl_busca_pcnt.Text = "Buscar Paciente:";
            // 
            // btn_acept
            // 
            this.btn_acept.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.check_icon;
            this.btn_acept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acept.Enabled = false;
            this.btn_acept.FlatAppearance.BorderSize = 0;
            this.btn_acept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acept.Location = new System.Drawing.Point(446, 46);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 142;
            this.tlt_aceptar.SetToolTip(this.btn_acept, "Aceptar");
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
            this.btn_cancl.Location = new System.Drawing.Point(375, 46);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 141;
            this.tlt_cancelar.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_pcnt_Click);
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(19, 46);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 140;
            this.tlt_nuevo.SetToolTip(this.btn_nuevo_pcnt, "Nuevo");
            this.btn_nuevo_pcnt.UseVisualStyleBackColor = true;
            this.btn_nuevo_pcnt.Click += new System.EventHandler(this.btn_nuevo_pcnt_Click);
            // 
            // btn_renov_pcnt
            // 
            this.btn_renov_pcnt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_renov_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_renov_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_renov_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_renov_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_renov_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renov_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renov_pcnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_renov_pcnt.Location = new System.Drawing.Point(516, 46);
            this.btn_renov_pcnt.Name = "btn_renov_pcnt";
            this.btn_renov_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_renov_pcnt.TabIndex = 139;
            this.btn_renov_pcnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlt_actualizar.SetToolTip(this.btn_renov_pcnt, "Actualizar");
            this.btn_renov_pcnt.UseVisualStyleBackColor = true;
            this.btn_renov_pcnt.Click += new System.EventHandler(this.btn_renov_pcnt_Click);
            // 
            // btn_elim_pcnt
            // 
            this.btn_elim_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_elim_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_elim_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_pcnt.Location = new System.Drawing.Point(233, 46);
            this.btn_elim_pcnt.Name = "btn_elim_pcnt";
            this.btn_elim_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_pcnt.TabIndex = 138;
            this.btn_elim_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tltl_eliminar.SetToolTip(this.btn_elim_pcnt, "Eliminar");
            this.btn_elim_pcnt.UseVisualStyleBackColor = true;
            this.btn_elim_pcnt.Click += new System.EventHandler(this.btn_elim_pcnt_Click);
            // 
            // btn_busc_pcnt
            // 
            this.btn_busc_pcnt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busc_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_busc_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_pcnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_pcnt.Location = new System.Drawing.Point(304, 46);
            this.btn_busc_pcnt.Name = "btn_busc_pcnt";
            this.btn_busc_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_pcnt.TabIndex = 15;
            this.btn_busc_pcnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlt_buscar.SetToolTip(this.btn_busc_pcnt, "Buscar");
            this.btn_busc_pcnt.UseVisualStyleBackColor = true;
            this.btn_busc_pcnt.Click += new System.EventHandler(this.btn_busc_pcnt_Click);
            this.btn_busc_pcnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_busc_pcnt_KeyDown);
            // 
            // btn_actlz_pcnt
            // 
            this.btn_actlz_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actlz_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_actlz_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_pcnt.Location = new System.Drawing.Point(162, 46);
            this.btn_actlz_pcnt.Name = "btn_actlz_pcnt";
            this.btn_actlz_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_pcnt.TabIndex = 130;
            this.btn_actlz_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlt_modificar.SetToolTip(this.btn_actlz_pcnt, "Modificar");
            this.btn_actlz_pcnt.UseVisualStyleBackColor = true;
            this.btn_actlz_pcnt.Click += new System.EventHandler(this.btn_actlz_pcnt_Click);
            // 
            // btn_guardar_pcnt
            // 
            this.btn_guardar_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_guardar_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_pcnt.Location = new System.Drawing.Point(90, 46);
            this.btn_guardar_pcnt.Name = "btn_guardar_pcnt";
            this.btn_guardar_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_pcnt.TabIndex = 11;
            this.btn_guardar_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tlt_guardar.SetToolTip(this.btn_guardar_pcnt, "Guardar");
            this.btn_guardar_pcnt.UseVisualStyleBackColor = true;
            this.btn_guardar_pcnt.Click += new System.EventHandler(this.btn_guardar_pcnt_Click);
            this.btn_guardar_pcnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_guardar_pcnt_KeyDown);
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
            // frm_act_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 603);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.btn_renov_pcnt);
            this.Controls.Add(this.btn_elim_pcnt);
            this.Controls.Add(this.btn_busc_pcnt);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_act_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Datos del Cliente";
            this.Load += new System.EventHandler(this.frm_act_cliente_Load);
            this.grb_datos1_pcnt.ResumeLayout(false);
            this.grb_datos1_pcnt.PerformLayout();
            this.grb_datos2_pcnt.ResumeLayout(false);
            this.grb_datos2_pcnt.PerformLayout();
            this.grb_datos3_pnct.ResumeLayout(false);
            this.grb_datos3_pnct.PerformLayout();
            this.grb_vista_pcnt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_pcnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
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
        private System.Windows.Forms.GroupBox grb_datos2_pcnt;
        private System.Windows.Forms.GroupBox grb_datos3_pnct;
        private System.Windows.Forms.GroupBox grb_vista_pcnt;
        private System.Windows.Forms.DataGridView dgv_list_pcnt;
        internal System.Windows.Forms.TextBox txt_busc_pcnt;
        internal System.Windows.Forms.Label lbl_busca_pcnt;
        private System.Windows.Forms.Button btn_busc_pcnt;
        private System.Windows.Forms.Button btn_actlz_pcnt;
        private System.Windows.Forms.Button btn_guardar_pcnt;
        private System.Windows.Forms.Button btn_elim_pcnt;
        protected System.Windows.Forms.ComboBox cbo_sexo_pcnt;
        protected System.Windows.Forms.ComboBox cbo_tip_sang_pcnt;
        private System.Windows.Forms.Button btn_renov_pcnt;
        private System.Windows.Forms.ComboBox cbo_lab_pcnt;
        internal System.Windows.Forms.Label lbl_lab_pcnt;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.ToolTip tlt_nuevo;
        private System.Windows.Forms.ToolTip tlt_aceptar;
        private System.Windows.Forms.ToolTip tlt_cancelar;
        private System.Windows.Forms.ToolTip tlt_actualizar;
        private System.Windows.Forms.ToolTip tltl_eliminar;
        private System.Windows.Forms.ToolTip tlt_buscar;
        private System.Windows.Forms.ToolTip tlt_modificar;
        private System.Windows.Forms.ToolTip tlt_guardar;
    }
}