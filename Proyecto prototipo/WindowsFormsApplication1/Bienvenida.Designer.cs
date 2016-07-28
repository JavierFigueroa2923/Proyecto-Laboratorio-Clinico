namespace WindowsFormsApplication1
{
    partial class Bienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenida));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Btn_log_empleado = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Btn_log_admin = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel1.Controls.Add(this.Btn_log_empleado);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Btn_log_admin);
            this.Panel1.Location = new System.Drawing.Point(105, 34);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(583, 389);
            this.Panel1.TabIndex = 6;
            // 
            // Btn_log_empleado
            // 
            this.Btn_log_empleado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_log_empleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_log_empleado.Location = new System.Drawing.Point(343, 230);
            this.Btn_log_empleado.Name = "Btn_log_empleado";
            this.Btn_log_empleado.Size = new System.Drawing.Size(138, 55);
            this.Btn_log_empleado.TabIndex = 6;
            this.Btn_log_empleado.Text = "Empleado";
            this.Btn_log_empleado.UseVisualStyleBackColor = false;
            this.Btn_log_empleado.Click += new System.EventHandler(this.button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(238, 94);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(198, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(190, 34);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Iniciar Sesion";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(158, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(276, 34);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Laboratorio Clinico";
            // 
            // Btn_log_admin
            // 
            this.Btn_log_admin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_log_admin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_log_admin.Location = new System.Drawing.Point(94, 230);
            this.Btn_log_admin.Name = "Btn_log_admin";
            this.Btn_log_admin.Size = new System.Drawing.Size(144, 55);
            this.Btn_log_admin.TabIndex = 3;
            this.Btn_log_admin.Text = "Administrador";
            this.Btn_log_admin.UseVisualStyleBackColor = false;
            this.Btn_log_admin.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 451);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bienvenida";
            this.Text = "Laboratorio clínico";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Btn_log_admin;
        internal System.Windows.Forms.Button Btn_log_empleado;
    }
}