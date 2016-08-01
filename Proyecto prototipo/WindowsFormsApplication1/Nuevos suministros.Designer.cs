namespace WindowsFormsApplication1
{
    partial class Nuevos_suministros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevos_suministros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo_id_inventario = new System.Windows.Forms.ComboBox();
            this.cbo_id_laboratorio = new System.Windows.Forms.ComboBox();
            this.lbl_inventario = new System.Windows.Forms.Label();
            this.lbl_laboratorio = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_detalle = new System.Windows.Forms.TextBox();
            this.txt_cantDisponible = new System.Windows.Forms.TextBox();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.Lbl_idSuminstro = new System.Windows.Forms.Label();
            this.Lbl_CantDisponible = new System.Windows.Forms.Label();
            this.Lbl_detalle = new System.Windows.Forms.Label();
            this.Lbl_costo = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_inventario_suministro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cbo_id_inventario);
            this.panel1.Controls.Add(this.cbo_id_laboratorio);
            this.panel1.Controls.Add(this.lbl_inventario);
            this.panel1.Controls.Add(this.lbl_laboratorio);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_detalle);
            this.panel1.Controls.Add(this.txt_cantDisponible);
            this.panel1.Controls.Add(this.txt_costo);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.Lbl_idSuminstro);
            this.panel1.Controls.Add(this.Lbl_CantDisponible);
            this.panel1.Controls.Add(this.Lbl_detalle);
            this.panel1.Controls.Add(this.Lbl_costo);
            this.panel1.Controls.Add(this.Lbl_nombre);
            this.panel1.Controls.Add(this.Lbl_inventario_suministro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 505);
            this.panel1.TabIndex = 2;
            // 
            // cbo_id_inventario
            // 
            this.cbo_id_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_id_inventario.FormattingEnabled = true;
            this.cbo_id_inventario.Location = new System.Drawing.Point(228, 421);
            this.cbo_id_inventario.Name = "cbo_id_inventario";
            this.cbo_id_inventario.Size = new System.Drawing.Size(121, 21);
            this.cbo_id_inventario.TabIndex = 16;
            // 
            // cbo_id_laboratorio
            // 
            this.cbo_id_laboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_id_laboratorio.FormattingEnabled = true;
            this.cbo_id_laboratorio.Location = new System.Drawing.Point(228, 391);
            this.cbo_id_laboratorio.Name = "cbo_id_laboratorio";
            this.cbo_id_laboratorio.Size = new System.Drawing.Size(121, 21);
            this.cbo_id_laboratorio.TabIndex = 15;
            // 
            // lbl_inventario
            // 
            this.lbl_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_inventario.AutoSize = true;
            this.lbl_inventario.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbl_inventario.Location = new System.Drawing.Point(62, 425);
            this.lbl_inventario.Name = "lbl_inventario";
            this.lbl_inventario.Size = new System.Drawing.Size(85, 20);
            this.lbl_inventario.TabIndex = 14;
            this.lbl_inventario.Text = "Inventario";
            // 
            // lbl_laboratorio
            // 
            this.lbl_laboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_laboratorio.AutoSize = true;
            this.lbl_laboratorio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbl_laboratorio.Location = new System.Drawing.Point(62, 395);
            this.lbl_laboratorio.Name = "lbl_laboratorio";
            this.lbl_laboratorio.Size = new System.Drawing.Size(94, 20);
            this.lbl_laboratorio.TabIndex = 13;
            this.lbl_laboratorio.Text = "Laboratorio";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Location = new System.Drawing.Point(683, 437);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 54);
            this.btn_save.TabIndex = 12;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_detalle
            // 
            this.txt_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_detalle.Location = new System.Drawing.Point(229, 315);
            this.txt_detalle.Name = "txt_detalle";
            this.txt_detalle.Size = new System.Drawing.Size(442, 20);
            this.txt_detalle.TabIndex = 11;
            // 
            // txt_cantDisponible
            // 
            this.txt_cantDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantDisponible.Location = new System.Drawing.Point(229, 357);
            this.txt_cantDisponible.Name = "txt_cantDisponible";
            this.txt_cantDisponible.Size = new System.Drawing.Size(442, 20);
            this.txt_cantDisponible.TabIndex = 10;
            // 
            // txt_costo
            // 
            this.txt_costo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_costo.Location = new System.Drawing.Point(229, 279);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(442, 20);
            this.txt_costo.TabIndex = 9;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.Location = new System.Drawing.Point(229, 244);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(442, 20);
            this.txt_nombre.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(333, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 117);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_codigo.Location = new System.Drawing.Point(229, 207);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(165, 20);
            this.txt_codigo.TabIndex = 6;
            // 
            // Lbl_idSuminstro
            // 
            this.Lbl_idSuminstro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_idSuminstro.AutoSize = true;
            this.Lbl_idSuminstro.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_idSuminstro.Location = new System.Drawing.Point(62, 206);
            this.Lbl_idSuminstro.Name = "Lbl_idSuminstro";
            this.Lbl_idSuminstro.Size = new System.Drawing.Size(137, 20);
            this.Lbl_idSuminstro.TabIndex = 5;
            this.Lbl_idSuminstro.Text = "Codigo suministro";
            // 
            // Lbl_CantDisponible
            // 
            this.Lbl_CantDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_CantDisponible.AutoSize = true;
            this.Lbl_CantDisponible.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_CantDisponible.Location = new System.Drawing.Point(62, 356);
            this.Lbl_CantDisponible.Name = "Lbl_CantDisponible";
            this.Lbl_CantDisponible.Size = new System.Drawing.Size(156, 20);
            this.Lbl_CantDisponible.TabIndex = 4;
            this.Lbl_CantDisponible.Text = "Cantidad disponible";
            // 
            // Lbl_detalle
            // 
            this.Lbl_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_detalle.AutoSize = true;
            this.Lbl_detalle.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_detalle.Location = new System.Drawing.Point(62, 314);
            this.Lbl_detalle.Name = "Lbl_detalle";
            this.Lbl_detalle.Size = new System.Drawing.Size(61, 20);
            this.Lbl_detalle.TabIndex = 3;
            this.Lbl_detalle.Text = "Detalle";
            // 
            // Lbl_costo
            // 
            this.Lbl_costo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_costo.AutoSize = true;
            this.Lbl_costo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_costo.Location = new System.Drawing.Point(62, 278);
            this.Lbl_costo.Name = "Lbl_costo";
            this.Lbl_costo.Size = new System.Drawing.Size(52, 20);
            this.Lbl_costo.TabIndex = 2;
            this.Lbl_costo.Text = "Costo";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_nombre.Location = new System.Drawing.Point(62, 243);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(68, 20);
            this.Lbl_nombre.TabIndex = 1;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_inventario_suministro
            // 
            this.Lbl_inventario_suministro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_inventario_suministro.AutoSize = true;
            this.Lbl_inventario_suministro.Font = new System.Drawing.Font("Century Gothic", 21F);
            this.Lbl_inventario_suministro.Location = new System.Drawing.Point(316, 150);
            this.Lbl_inventario_suministro.Name = "Lbl_inventario_suministro";
            this.Lbl_inventario_suministro.Size = new System.Drawing.Size(161, 34);
            this.Lbl_inventario_suministro.TabIndex = 0;
            this.Lbl_inventario_suministro.Text = "Suministros";
            // 
            // Nuevos_suministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 505);
            this.Controls.Add(this.panel1);
            this.Name = "Nuevos_suministros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevos_suministros";
            this.Load += new System.EventHandler(this.Nuevos_suministros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_id_inventario;
        private System.Windows.Forms.ComboBox cbo_id_laboratorio;
        private System.Windows.Forms.Label lbl_inventario;
        private System.Windows.Forms.Label lbl_laboratorio;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_detalle;
        private System.Windows.Forms.TextBox txt_cantDisponible;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label Lbl_idSuminstro;
        private System.Windows.Forms.Label Lbl_CantDisponible;
        private System.Windows.Forms.Label Lbl_detalle;
        private System.Windows.Forms.Label Lbl_costo;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_inventario_suministro;
    }
}