﻿namespace WindowsFormsApplication1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Btn_Inicio_secion = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Lbl_contraseña = new System.Windows.Forms.Label();
            this.Lbl_ejemplo = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btn_ayuda_login = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel1.Controls.Add(this.btn_ayuda_login);
            this.Panel1.Controls.Add(this.Btn_Inicio_secion);
            this.Panel1.Controls.Add(this.txt_pass);
            this.Panel1.Controls.Add(this.Lbl_contraseña);
            this.Panel1.Controls.Add(this.Lbl_ejemplo);
            this.Panel1.Controls.Add(this.txt_user);
            this.Panel1.Controls.Add(this.Lbl_usuario);
            this.Panel1.Controls.Add(this.pic_logo);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(465, 491);
            this.Panel1.TabIndex = 7;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Btn_Inicio_secion
            // 
            this.Btn_Inicio_secion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Inicio_secion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_Inicio_secion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inicio_secion.Location = new System.Drawing.Point(224, 382);
            this.Btn_Inicio_secion.Name = "Btn_Inicio_secion";
            this.Btn_Inicio_secion.Size = new System.Drawing.Size(131, 40);
            this.Btn_Inicio_secion.TabIndex = 11;
            this.Btn_Inicio_secion.Text = "Iniciar Sesion";
            this.Btn_Inicio_secion.UseVisualStyleBackColor = false;
            this.Btn_Inicio_secion.Click += new System.EventHandler(this.Btn_Inicio_secion_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pass.Location = new System.Drawing.Point(111, 297);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(244, 20);
            this.txt_pass.TabIndex = 10;
            // 
            // Lbl_contraseña
            // 
            this.Lbl_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_contraseña.AutoSize = true;
            this.Lbl_contraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_contraseña.Location = new System.Drawing.Point(66, 276);
            this.Lbl_contraseña.Name = "Lbl_contraseña";
            this.Lbl_contraseña.Size = new System.Drawing.Size(99, 20);
            this.Lbl_contraseña.TabIndex = 9;
            this.Lbl_contraseña.Text = "Contraseña:";
            // 
            // Lbl_ejemplo
            // 
            this.Lbl_ejemplo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ejemplo.AutoSize = true;
            this.Lbl_ejemplo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ejemplo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Lbl_ejemplo.Location = new System.Drawing.Point(108, 243);
            this.Lbl_ejemplo.Name = "Lbl_ejemplo";
            this.Lbl_ejemplo.Size = new System.Drawing.Size(153, 20);
            this.Lbl_ejemplo.TabIndex = 8;
            this.Lbl_ejemplo.Text = "Ejemplo: tgonzalesc";
            // 
            // txt_user
            // 
            this.txt_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user.Location = new System.Drawing.Point(111, 220);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(244, 20);
            this.txt_user.TabIndex = 7;
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(66, 199);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(67, 20);
            this.Lbl_usuario.TabIndex = 6;
            this.Lbl_usuario.Text = "Usuario:";
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(171, 80);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(100, 100);
            this.pic_logo.TabIndex = 5;
            this.pic_logo.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(140, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(169, 34);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Bienvenido";
            // 
            // btn_ayuda_login
            // 
            this.btn_ayuda_login.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Help_icon;
            this.btn_ayuda_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ayuda_login.FlatAppearance.BorderSize = 0;
            this.btn_ayuda_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda_login.Location = new System.Drawing.Point(413, 12);
            this.btn_ayuda_login.Name = "btn_ayuda_login";
            this.btn_ayuda_login.Size = new System.Drawing.Size(40, 40);
            this.btn_ayuda_login.TabIndex = 12;
            this.btn_ayuda_login.UseVisualStyleBackColor = true;
            this.btn_ayuda_login.Click += new System.EventHandler(this.btn_ayuda_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 491);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar secion";
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button Btn_Inicio_secion;
        internal System.Windows.Forms.TextBox txt_pass;
        internal System.Windows.Forms.Label Lbl_contraseña;
        internal System.Windows.Forms.Label Lbl_ejemplo;
        internal System.Windows.Forms.TextBox txt_user;
        internal System.Windows.Forms.Label Lbl_usuario;
        internal System.Windows.Forms.PictureBox pic_logo;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btn_ayuda_login;
    }
}