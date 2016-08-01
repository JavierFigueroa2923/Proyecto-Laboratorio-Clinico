namespace WindowsFormsApplication1
{
    partial class frm_act_inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_inventario));
            this.cbo_id_inv = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Lbl_id_inventario = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_cant = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_id_inv
            // 
            this.cbo_id_inv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_id_inv.FormattingEnabled = true;
            this.cbo_id_inv.Location = new System.Drawing.Point(84, 198);
            this.cbo_id_inv.Name = "cbo_id_inv";
            this.cbo_id_inv.Size = new System.Drawing.Size(215, 21);
            this.cbo_id_inv.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(506, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 52);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Lbl_id_inventario
            // 
            this.Lbl_id_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_id_inventario.AutoSize = true;
            this.Lbl_id_inventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_inventario.Location = new System.Drawing.Point(79, 175);
            this.Lbl_id_inventario.Name = "Lbl_id_inventario";
            this.Lbl_id_inventario.Size = new System.Drawing.Size(106, 20);
            this.Lbl_id_inventario.TabIndex = 57;
            this.Lbl_id_inventario.Text = "Id inventario:";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(80, 262);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 56;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_direccion.Location = new System.Drawing.Point(83, 284);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(454, 20);
            this.txt_direccion.TabIndex = 55;
            // 
            // Lbl_cant
            // 
            this.Lbl_cant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_cant.AutoSize = true;
            this.Lbl_cant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cant.Location = new System.Drawing.Point(80, 219);
            this.Lbl_cant.Name = "Lbl_cant";
            this.Lbl_cant.Size = new System.Drawing.Size(160, 20);
            this.Lbl_cant.TabIndex = 54;
            this.Lbl_cant.Text = "Cantidad disponible:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.Location = new System.Drawing.Point(83, 240);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(454, 20);
            this.txt_nombre.TabIndex = 53;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(292, 60);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(203, 23);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(298, 34);
            this.Lbl_titulo.TabIndex = 51;
            this.Lbl_titulo.Text = "Actualizar inventario";
            // 
            // frm_act_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 401);
            this.Controls.Add(this.cbo_id_inv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_id_inventario);
            this.Controls.Add(this.Lbl_descripcion);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.Lbl_cant);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Name = "frm_act_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar inventario";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_id_inv;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label Lbl_id_inventario;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label Lbl_cant;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
    }
}