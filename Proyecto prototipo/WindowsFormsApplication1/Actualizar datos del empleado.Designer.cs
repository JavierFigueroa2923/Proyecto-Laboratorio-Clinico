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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.Lbl_cargo = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.Lbl_dpi = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Lbl_email = new System.Windows.Forms.Label();
            this.txt_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Lbl_fecha_nacimiento = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_Id_emp = new System.Windows.Forms.Label();
            this.cbo_cod_emp = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel1.Controls.Add(this.cbo_cod_emp);
            this.Panel1.Controls.Add(this.lbl_Id_emp);
            this.Panel1.Controls.Add(this.btn_save);
            this.Panel1.Controls.Add(this.txt_cargo);
            this.Panel1.Controls.Add(this.Lbl_cargo);
            this.Panel1.Controls.Add(this.txt_titulo);
            this.Panel1.Controls.Add(this.Lbl_titulo);
            this.Panel1.Controls.Add(this.Lbl_apellido);
            this.Panel1.Controls.Add(this.txt_apellido);
            this.Panel1.Controls.Add(this.txt_dpi);
            this.Panel1.Controls.Add(this.Lbl_dpi);
            this.Panel1.Controls.Add(this.txt_email);
            this.Panel1.Controls.Add(this.Lbl_email);
            this.Panel1.Controls.Add(this.txt_fecha_nacimiento);
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Controls.Add(this.Lbl_fecha_nacimiento);
            this.Panel1.Controls.Add(this.TextBox4);
            this.Panel1.Controls.Add(this.txt_telefono);
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.Lbl_telefono);
            this.Panel1.Controls.Add(this.Lbl_direccion);
            this.Panel1.Controls.Add(this.txt_direccion);
            this.Panel1.Controls.Add(this.Lbl_nombre);
            this.Panel1.Controls.Add(this.txt_nombre);
            this.Panel1.Controls.Add(this.Pic_logo);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Location = new System.Drawing.Point(32, 30);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(792, 490);
            this.Panel1.TabIndex = 12;
            // 
            // txt_cargo
            // 
            this.txt_cargo.Location = new System.Drawing.Point(586, 395);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(149, 20);
            this.txt_cargo.TabIndex = 49;
            // 
            // Lbl_cargo
            // 
            this.Lbl_cargo.AutoSize = true;
            this.Lbl_cargo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_cargo.Location = new System.Drawing.Point(583, 374);
            this.Lbl_cargo.Name = "Lbl_cargo";
            this.Lbl_cargo.Size = new System.Drawing.Size(60, 20);
            this.Lbl_cargo.TabIndex = 48;
            this.Lbl_cargo.Text = "Cargo:";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(586, 351);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(149, 20);
            this.txt_titulo.TabIndex = 47;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_titulo.Location = new System.Drawing.Point(583, 330);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(48, 20);
            this.Lbl_titulo.TabIndex = 46;
            this.Lbl_titulo.Text = "Titulo:";
            // 
            // Lbl_apellido
            // 
            this.Lbl_apellido.AutoSize = true;
            this.Lbl_apellido.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_apellido.Location = new System.Drawing.Point(57, 241);
            this.Lbl_apellido.Name = "Lbl_apellido";
            this.Lbl_apellido.Size = new System.Drawing.Size(73, 20);
            this.Lbl_apellido.TabIndex = 40;
            this.Lbl_apellido.Text = "Apellido:";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(60, 262);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(454, 20);
            this.txt_apellido.TabIndex = 39;
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(586, 306);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(149, 20);
            this.txt_dpi.TabIndex = 34;
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_dpi.Location = new System.Drawing.Point(583, 285);
            this.Lbl_dpi.Name = "Lbl_dpi";
            this.Lbl_dpi.Size = new System.Drawing.Size(38, 20);
            this.Lbl_dpi.TabIndex = 33;
            this.Lbl_dpi.Text = "DPI:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(60, 395);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(454, 20);
            this.txt_email.TabIndex = 31;
            // 
            // Lbl_email
            // 
            this.Lbl_email.AutoSize = true;
            this.Lbl_email.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_email.Location = new System.Drawing.Point(57, 374);
            this.Lbl_email.Name = "Lbl_email";
            this.Lbl_email.Size = new System.Drawing.Size(152, 20);
            this.Lbl_email.TabIndex = 30;
            this.Lbl_email.Text = "Correo Electronico:";
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(586, 218);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(149, 20);
            this.txt_fecha_nacimiento.TabIndex = 29;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label11.Location = new System.Drawing.Point(621, 241);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(85, 20);
            this.Label11.TabIndex = 28;
            this.Label11.Text = "dd/mm/yy";
            // 
            // Lbl_fecha_nacimiento
            // 
            this.Lbl_fecha_nacimiento.AutoSize = true;
            this.Lbl_fecha_nacimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_fecha_nacimiento.Location = new System.Drawing.Point(583, 197);
            this.Lbl_fecha_nacimiento.Name = "Lbl_fecha_nacimiento";
            this.Lbl_fecha_nacimiento.Size = new System.Drawing.Size(171, 20);
            this.Lbl_fecha_nacimiento.TabIndex = 21;
            this.Lbl_fecha_nacimiento.Text = "Fecha de Nacimiento:";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(308, 351);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(206, 20);
            this.TextBox4.TabIndex = 19;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(60, 351);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(224, 20);
            this.txt_telefono.TabIndex = 18;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Label7.Location = new System.Drawing.Point(305, 330);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(32, 20);
            this.Label7.TabIndex = 17;
            this.Label7.Text = "Nit:";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_telefono.Location = new System.Drawing.Point(57, 330);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(75, 20);
            this.Lbl_telefono.TabIndex = 16;
            this.Lbl_telefono.Text = "Telefono:";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_direccion.Location = new System.Drawing.Point(57, 285);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(84, 20);
            this.Lbl_direccion.TabIndex = 15;
            this.Lbl_direccion.Text = "Direccion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(60, 307);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(454, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_nombre.Location = new System.Drawing.Point(57, 197);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 9;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(60, 218);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(454, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(345, 48);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 100);
            this.Pic_logo.TabIndex = 5;
            this.Pic_logo.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(205, 11);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(438, 34);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Actualizar Datos del Empleado";
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(25, 421);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(61, 50);
            this.btn_save.TabIndex = 50;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // lbl_Id_emp
            // 
            this.lbl_Id_emp.AutoSize = true;
            this.lbl_Id_emp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_emp.Location = new System.Drawing.Point(57, 152);
            this.lbl_Id_emp.Name = "lbl_Id_emp";
            this.lbl_Id_emp.Size = new System.Drawing.Size(106, 20);
            this.lbl_Id_emp.TabIndex = 51;
            this.lbl_Id_emp.Text = "Id Empleado:";
            // 
            // cbo_cod_emp
            // 
            this.cbo_cod_emp.FormattingEnabled = true;
            this.cbo_cod_emp.Location = new System.Drawing.Point(60, 173);
            this.cbo_cod_emp.Name = "cbo_cod_emp";
            this.cbo_cod_emp.Size = new System.Drawing.Size(218, 21);
            this.cbo_cod_emp.TabIndex = 52;
            // 
            // frm_act_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 550);
            this.Controls.Add(this.Panel1);
            this.Name = "frm_act_emp";
            this.Text = "Actualizar datos de empleado";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.ComboBox cbo_cod_emp;
        internal System.Windows.Forms.Label lbl_Id_emp;
        private System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.TextBox txt_cargo;
        internal System.Windows.Forms.Label Lbl_cargo;
        internal System.Windows.Forms.TextBox txt_titulo;
        internal System.Windows.Forms.Label Lbl_titulo;
        internal System.Windows.Forms.Label Lbl_apellido;
        internal System.Windows.Forms.TextBox txt_apellido;
        internal System.Windows.Forms.TextBox txt_dpi;
        internal System.Windows.Forms.Label Lbl_dpi;
        internal System.Windows.Forms.TextBox txt_email;
        internal System.Windows.Forms.Label Lbl_email;
        internal System.Windows.Forms.TextBox txt_fecha_nacimiento;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Lbl_fecha_nacimiento;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox txt_telefono;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Lbl_telefono;
        internal System.Windows.Forms.Label Lbl_direccion;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox Pic_logo;
        internal System.Windows.Forms.Label Label2;
    }
}