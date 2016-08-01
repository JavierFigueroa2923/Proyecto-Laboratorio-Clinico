namespace WindowsFormsApplication1
{
    partial class frm_act_aseg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_aseg));
            this.pnl_aseguradora = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dsc = new System.Windows.Forms.TextBox();
            this.lbl_descuento = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.Lbl_num_aseg = new System.Windows.Forms.Label();
            this.Lbl_id_aseg = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_aseguradora = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_aseguradora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_aseguradora
            // 
            this.pnl_aseguradora.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_aseguradora.Controls.Add(this.comboBox1);
            this.pnl_aseguradora.Controls.Add(this.btn_save);
            this.pnl_aseguradora.Controls.Add(this.label1);
            this.pnl_aseguradora.Controls.Add(this.txt_dsc);
            this.pnl_aseguradora.Controls.Add(this.lbl_descuento);
            this.pnl_aseguradora.Controls.Add(this.txt_email);
            this.pnl_aseguradora.Controls.Add(this.Lbl_num_aseg);
            this.pnl_aseguradora.Controls.Add(this.Lbl_id_aseg);
            this.pnl_aseguradora.Controls.Add(this.Lbl_nombre);
            this.pnl_aseguradora.Controls.Add(this.txt_nombre);
            this.pnl_aseguradora.Controls.Add(this.Pic_logo);
            this.pnl_aseguradora.Controls.Add(this.lbl_aseguradora);
            this.pnl_aseguradora.Location = new System.Drawing.Point(41, 25);
            this.pnl_aseguradora.Name = "pnl_aseguradora";
            this.pnl_aseguradora.Size = new System.Drawing.Size(707, 480);
            this.pnl_aseguradora.TabIndex = 15;
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(452, 382);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(57, 53);
            this.btn_save.TabIndex = 51;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(152, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 48;
            this.label1.Text = "%";
            // 
            // txt_dsc
            // 
            this.txt_dsc.Location = new System.Drawing.Point(179, 357);
            this.txt_dsc.Name = "txt_dsc";
            this.txt_dsc.Size = new System.Drawing.Size(108, 20);
            this.txt_dsc.TabIndex = 47;
            // 
            // lbl_descuento
            // 
            this.lbl_descuento.AutoSize = true;
            this.lbl_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_descuento.Location = new System.Drawing.Point(137, 336);
            this.lbl_descuento.Name = "lbl_descuento";
            this.lbl_descuento.Size = new System.Drawing.Size(80, 18);
            this.lbl_descuento.TabIndex = 46;
            this.lbl_descuento.Text = "Descuento";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(140, 269);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(454, 20);
            this.txt_email.TabIndex = 31;
            // 
            // Lbl_num_aseg
            // 
            this.Lbl_num_aseg.AutoSize = true;
            this.Lbl_num_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_num_aseg.Location = new System.Drawing.Point(137, 248);
            this.Lbl_num_aseg.Name = "Lbl_num_aseg";
            this.Lbl_num_aseg.Size = new System.Drawing.Size(150, 18);
            this.Lbl_num_aseg.TabIndex = 30;
            this.Lbl_num_aseg.Text = "Numero Aseguradora";
            // 
            // Lbl_id_aseg
            // 
            this.Lbl_id_aseg.AutoSize = true;
            this.Lbl_id_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_id_aseg.Location = new System.Drawing.Point(137, 204);
            this.Lbl_id_aseg.Name = "Lbl_id_aseg";
            this.Lbl_id_aseg.Size = new System.Drawing.Size(111, 18);
            this.Lbl_id_aseg.TabIndex = 15;
            this.Lbl_id_aseg.Text = "Id Aseguradora:";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_nombre.Location = new System.Drawing.Point(137, 292);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(66, 18);
            this.Lbl_nombre.TabIndex = 9;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(140, 313);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(454, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // Pic_logo
            // 
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(310, 60);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 100);
            this.Pic_logo.TabIndex = 5;
            this.Pic_logo.TabStop = false;
            // 
            // lbl_aseguradora
            // 
            this.lbl_aseguradora.AutoSize = true;
            this.lbl_aseguradora.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aseguradora.Location = new System.Drawing.Point(230, 14);
            this.lbl_aseguradora.Name = "lbl_aseguradora";
            this.lbl_aseguradora.Size = new System.Drawing.Size(292, 34);
            this.lbl_aseguradora.TabIndex = 1;
            this.lbl_aseguradora.Text = "Nueva Aseguradora";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(454, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // frm_act_aseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.pnl_aseguradora);
            this.Name = "frm_act_aseg";
            this.Text = "Actualizar Aseguradora";
            this.pnl_aseguradora.ResumeLayout(false);
            this.pnl_aseguradora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnl_aseguradora;
        private System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txt_dsc;
        internal System.Windows.Forms.Label lbl_descuento;
        internal System.Windows.Forms.TextBox txt_email;
        internal System.Windows.Forms.Label Lbl_num_aseg;
        internal System.Windows.Forms.Label Lbl_id_aseg;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox Pic_logo;
        internal System.Windows.Forms.Label lbl_aseguradora;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}