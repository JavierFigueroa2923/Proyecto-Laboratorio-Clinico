namespace WindowsFormsApplication1
{
    partial class frm_act_lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_lab));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_id_lab = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_inventario_suministro = new System.Windows.Forms.Label();
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbo_id_lab);
            this.panel1.Controls.Add(this.lbl_id_lab);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Controls.Add(this.txt_correo);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Lbl_correo);
            this.panel1.Controls.Add(this.Lbl_telefono);
            this.panel1.Controls.Add(this.Lbl_direccion);
            this.panel1.Controls.Add(this.Lbl_nombre);
            this.panel1.Controls.Add(this.Lbl_inventario_suministro);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 494);
            this.panel1.TabIndex = 3;
            // 
            // lbl_id_lab
            // 
            this.lbl_id_lab.AutoSize = true;
            this.lbl_id_lab.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbl_id_lab.Location = new System.Drawing.Point(62, 216);
            this.lbl_id_lab.Name = "lbl_id_lab";
            this.lbl_id_lab.Size = new System.Drawing.Size(109, 20);
            this.lbl_id_lab.TabIndex = 13;
            this.lbl_id_lab.Text = "Id laboratorio";
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(574, 404);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 54);
            this.btn_save.TabIndex = 12;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(229, 357);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(442, 20);
            this.txt_telefono.TabIndex = 11;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(229, 318);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(442, 20);
            this.txt_correo.TabIndex = 10;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(229, 285);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(442, 20);
            this.txt_direccion.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(229, 250);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(442, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(333, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 117);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_correo.Location = new System.Drawing.Point(62, 317);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(61, 20);
            this.Lbl_correo.TabIndex = 4;
            this.Lbl_correo.Text = "Correo";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_telefono.Location = new System.Drawing.Point(62, 356);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(71, 20);
            this.Lbl_telefono.TabIndex = 3;
            this.Lbl_telefono.Text = "Telefono";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_direccion.Location = new System.Drawing.Point(62, 284);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(80, 20);
            this.Lbl_direccion.TabIndex = 2;
            this.Lbl_direccion.Text = "Direccion";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_nombre.Location = new System.Drawing.Point(62, 249);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(153, 20);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Nombre laboratorio";
            // 
            // Lbl_inventario_suministro
            // 
            this.Lbl_inventario_suministro.AutoSize = true;
            this.Lbl_inventario_suministro.Font = new System.Drawing.Font("Century Gothic", 21F);
            this.Lbl_inventario_suministro.Location = new System.Drawing.Point(313, 150);
            this.Lbl_inventario_suministro.Name = "Lbl_inventario_suministro";
            this.Lbl_inventario_suministro.Size = new System.Drawing.Size(172, 34);
            this.Lbl_inventario_suministro.TabIndex = 0;
            this.Lbl_inventario_suministro.Text = "Laboratorio";
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(229, 215);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(190, 21);
            this.cbo_id_lab.TabIndex = 14;
            // 
            // frm_act_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 521);
            this.Controls.Add(this.panel1);
            this.Name = "frm_act_lab";
            this.Text = "Actualizar Laboratorio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_id_lab;
        private System.Windows.Forms.Label lbl_id_lab;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_inventario_suministro;
    }
}