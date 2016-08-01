namespace WindowsFormsApplication1
{
    partial class frm_Nuevo_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nuevo_inventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_cantDisponible = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_idSuminstro = new System.Windows.Forms.Label();
            this.Lbl_CantDisponible = new System.Windows.Forms.Label();
            this.Lbl_detalle = new System.Windows.Forms.Label();
            this.Lbl_inventario_suministro = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_detalle);
            this.panel1.Controls.Add(this.txt_cantDisponible);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.Lbl_idSuminstro);
            this.panel1.Controls.Add(this.Lbl_CantDisponible);
            this.panel1.Controls.Add(this.Lbl_detalle);
            this.panel1.Controls.Add(this.Lbl_inventario_suministro);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 416);
            this.panel1.TabIndex = 1;
            // 
            // txt_detalle
            // 
            this.txt_detalle.Location = new System.Drawing.Point(183, 287);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(442, 20);
            this.txt_detalle.TabIndex = 11;
            // 
            // txt_cantDisponible
            // 
            this.txt_cantDisponible.Location = new System.Drawing.Point(183, 248);
            this.txt_cantDisponible.Name = "txt_cantDisponible";
            this.txt_cantDisponible.Size = new System.Drawing.Size(442, 20);
            this.txt_cantDisponible.TabIndex = 10;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(183, 222);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(165, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // Lbl_idSuminstro
            // 
            this.Lbl_idSuminstro.AutoSize = true;
            this.Lbl_idSuminstro.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_idSuminstro.Location = new System.Drawing.Point(16, 221);
            this.Lbl_idSuminstro.Name = "Lbl_idSuminstro";
            this.Lbl_idSuminstro.Size = new System.Drawing.Size(142, 20);
            this.Lbl_idSuminstro.TabIndex = 5;
            this.Lbl_idSuminstro.Text = "Codigo inventario";
            // 
            // Lbl_CantDisponible
            // 
            this.Lbl_CantDisponible.AutoSize = true;
            this.Lbl_CantDisponible.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_CantDisponible.Location = new System.Drawing.Point(16, 247);
            this.Lbl_CantDisponible.Name = "Lbl_CantDisponible";
            this.Lbl_CantDisponible.Size = new System.Drawing.Size(156, 20);
            this.Lbl_CantDisponible.TabIndex = 4;
            this.Lbl_CantDisponible.Text = "Cantidad disponible";
            // 
            // Lbl_detalle
            // 
            this.Lbl_detalle.AutoSize = true;
            this.Lbl_detalle.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_detalle.Location = new System.Drawing.Point(16, 286);
            this.Lbl_detalle.Name = "Lbl_detalle";
            this.Lbl_detalle.Size = new System.Drawing.Size(61, 20);
            this.Lbl_detalle.TabIndex = 3;
            this.Lbl_detalle.Text = "Detalle";
            // 
            // Lbl_inventario_suministro
            // 
            this.Lbl_inventario_suministro.AutoSize = true;
            this.Lbl_inventario_suministro.Font = new System.Drawing.Font("Century Gothic", 21F);
            this.Lbl_inventario_suministro.Location = new System.Drawing.Point(177, 155);
            this.Lbl_inventario_suministro.Name = "Lbl_inventario_suministro";
            this.Lbl_inventario_suministro.Size = new System.Drawing.Size(351, 34);
            this.Lbl_inventario_suministro.TabIndex = 0;
            this.Lbl_inventario_suministro.Text = "Inventario de Suministros";
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(547, 335);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 54);
            this.btn_save.TabIndex = 12;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(288, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 117);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Nuevo_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 463);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Nuevo_inventario";
            this.Text = "Nuevo_inventario";
            this.Load += new System.EventHandler(this.Nuevo_inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.TextBox txt_cantDisponible;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label Lbl_idSuminstro;
        private System.Windows.Forms.Label Lbl_CantDisponible;
        private System.Windows.Forms.Label Lbl_detalle;
        private System.Windows.Forms.Label Lbl_inventario_suministro;
    }
}