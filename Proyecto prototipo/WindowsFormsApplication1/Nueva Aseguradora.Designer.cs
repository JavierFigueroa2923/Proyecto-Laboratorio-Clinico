namespace WindowsFormsApplication1
{
    partial class frm_aseguradora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_aseguradora));
            this.pnl_aseguradora = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dsc = new System.Windows.Forms.TextBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Lbl_num_aseg = new System.Windows.Forms.Label();
            this.Lbl_id_aseg = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_aseguradora = new System.Windows.Forms.Label();
            this.pnl_aseguradora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_aseguradora
            // 
            this.pnl_aseguradora.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_aseguradora.Controls.Add(this.btn_save);
            this.pnl_aseguradora.Controls.Add(this.label1);
            this.pnl_aseguradora.Controls.Add(this.txt_dsc);
            this.pnl_aseguradora.Controls.Add(this.lbl_descuento);
            this.pnl_aseguradora.Controls.Add(this.txt_email);
            this.pnl_aseguradora.Controls.Add(this.Lbl_num_aseg);
            this.pnl_aseguradora.Controls.Add(this.Lbl_id_aseg);
            this.pnl_aseguradora.Controls.Add(this.txt_direccion);
            this.pnl_aseguradora.Controls.Add(this.Lbl_nombre);
            this.pnl_aseguradora.Controls.Add(this.txt_nombre);
            this.pnl_aseguradora.Controls.Add(this.Pic_logo);
            this.pnl_aseguradora.Controls.Add(this.lbl_aseguradora);
            this.pnl_aseguradora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_aseguradora.Location = new System.Drawing.Point(0, 0);
            this.pnl_aseguradora.Name = "pnl_aseguradora";
            this.pnl_aseguradora.Size = new System.Drawing.Size(573, 460);
            this.pnl_aseguradora.TabIndex = 13;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(376, 388);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(57, 53);
            this.btn_save.TabIndex = 51;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(76, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "%";
            // 
            // txt_dsc
            // 
            this.txt_dsc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dsc.Location = new System.Drawing.Point(103, 363);
            this.txt_dsc.Name = "txt_dsc";
            this.txt_dsc.Size = new System.Drawing.Size(108, 20);
            this.txt_dsc.TabIndex = 47;
            this.txt_dsc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_descuento.Location = new System.Drawing.Point(61, 342);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(80, 18);
            this.lbl_descuento.TabIndex = 46;
            this.lbl_descuento.Text = "Descuento";
            this.lbl_descuento.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.Location = new System.Drawing.Point(64, 275);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(454, 20);
            this.txt_email.TabIndex = 31;
            // 
            // Lbl_num_aseg
            // 
            this.Lbl_num_aseg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_num_aseg.AutoSize = true;
            this.Lbl_num_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_num_aseg.Location = new System.Drawing.Point(61, 254);
            this.Lbl_num_aseg.Name = "Lbl_num_aseg";
            this.Lbl_num_aseg.Size = new System.Drawing.Size(150, 18);
            this.Lbl_num_aseg.TabIndex = 30;
            this.Lbl_num_aseg.Text = "Numero Aseguradora";
            // 
            // Lbl_id_aseg
            // 
            this.Lbl_id_aseg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_id_aseg.AutoSize = true;
            this.Lbl_id_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_id_aseg.Location = new System.Drawing.Point(61, 210);
            this.Lbl_id_aseg.Name = "Lbl_id_aseg";
            this.Lbl_id_aseg.Size = new System.Drawing.Size(111, 18);
            this.Lbl_id_aseg.TabIndex = 15;
            this.Lbl_id_aseg.Text = "Id Aseguradora:";
            this.Lbl_id_aseg.Click += new System.EventHandler(this.Lbl_direccion_Click);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.Location = new System.Drawing.Point(64, 231);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(454, 20);
            this.txt_direccion.TabIndex = 10;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_nombre.Location = new System.Drawing.Point(61, 298);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(66, 18);
            this.Lbl_nombre.TabIndex = 9;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.Location = new System.Drawing.Point(64, 319);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(454, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(234, 66);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 100);
            this.Pic_logo.TabIndex = 5;
            this.Pic_logo.TabStop = false;
            // 
            // lbl_aseguradora
            // 
            this.lbl_aseguradora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aseguradora.AutoSize = true;
            this.lbl_aseguradora.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aseguradora.Location = new System.Drawing.Point(154, 20);
            this.lbl_aseguradora.Name = "lbl_aseguradora";
            this.lbl_aseguradora.Size = new System.Drawing.Size(292, 34);
            this.lbl_aseguradora.TabIndex = 1;
            this.lbl_aseguradora.Text = "Nueva Aseguradora";
            this.lbl_aseguradora.Click += new System.EventHandler(this.Label2_Click);
            // 
            // frm_aseguradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 460);
            this.Controls.Add(this.pnl_aseguradora);
            this.Name = "frm_aseguradora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Aseguradora";
            this.pnl_aseguradora.ResumeLayout(false);
            this.pnl_aseguradora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnl_aseguradora;
        internal System.Windows.Forms.TextBox txt_email;
        internal System.Windows.Forms.Label Lbl_num_aseg;
        internal System.Windows.Forms.Label Lbl_id_aseg;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox Pic_logo;
        internal System.Windows.Forms.Label lbl_aseguradora;
        internal System.Windows.Forms.TextBox txt_dsc;
        internal System.Windows.Forms.Label lbl_descuento;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
    }
}