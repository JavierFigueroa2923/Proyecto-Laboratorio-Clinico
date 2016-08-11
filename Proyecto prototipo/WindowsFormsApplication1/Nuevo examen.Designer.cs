namespace WindowsFormsApplication1
{
    partial class frm_nuevo_examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_nuevo_examen));
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Lbl_precio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.Lbl_observacion = new System.Windows.Forms.Label();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_guardar_mst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fecha.Location = new System.Drawing.Point(33, 305);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(616, 22);
            this.txt_fecha.TabIndex = 55;
            this.txt_fecha.TextChanged += new System.EventHandler(this.txt_id_exm_TextChanged);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(29, 280);
            this.Lbl_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(68, 22);
            this.Lbl_fecha.TabIndex = 56;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Lbl_precio
            // 
            this.Lbl_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_precio.AutoSize = true;
            this.Lbl_precio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_precio.Location = new System.Drawing.Point(31, 387);
            this.Lbl_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_precio.Name = "Lbl_precio";
            this.Lbl_precio.Size = new System.Drawing.Size(71, 22);
            this.Lbl_precio.TabIndex = 54;
            this.Lbl_precio.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precio.Location = new System.Drawing.Point(35, 414);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(616, 22);
            this.txt_precio.TabIndex = 53;
            // 
            // Lbl_observacion
            // 
            this.Lbl_observacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_observacion.AutoSize = true;
            this.Lbl_observacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_observacion.Location = new System.Drawing.Point(31, 334);
            this.Lbl_observacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_observacion.Name = "Lbl_observacion";
            this.Lbl_observacion.Size = new System.Drawing.Size(135, 22);
            this.Lbl_observacion.TabIndex = 52;
            this.Lbl_observacion.Text = "Observacion:";
            // 
            // txt_observacion
            // 
            this.txt_observacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_observacion.Location = new System.Drawing.Point(35, 360);
            this.txt_observacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(616, 22);
            this.txt_observacion.TabIndex = 51;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(176, 48);
            this.Lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(336, 42);
            this.Lbl_titulo.TabIndex = 49;
            this.Lbl_titulo.Text = "Actualizar examen";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(294, 111);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(101, 104);
            this.PictureBox1.TabIndex = 50;
            this.PictureBox1.TabStop = false;
            // 
            // btn_guardar_mst
            // 
            this.btn_guardar_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_mst.Location = new System.Drawing.Point(520, 474);
            this.btn_guardar_mst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar_mst.Name = "btn_guardar_mst";
            this.btn_guardar_mst.Size = new System.Drawing.Size(109, 73);
            this.btn_guardar_mst.TabIndex = 162;
            this.btn_guardar_mst.Text = "GUARDAR";
            this.btn_guardar_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_mst.UseVisualStyleBackColor = true;
            this.btn_guardar_mst.Click += new System.EventHandler(this.btn_guardar_mst_Click);
            // 
            // frm_nuevo_examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 578);
            this.Controls.Add(this.btn_guardar_mst);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.Lbl_precio);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.Lbl_observacion);
            this.Controls.Add(this.txt_observacion);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_nuevo_examen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo_examen";
            this.Load += new System.EventHandler(this.frm_nuevo_examen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lbl_fecha;
        internal System.Windows.Forms.Label Lbl_precio;
        internal System.Windows.Forms.TextBox txt_precio;
        internal System.Windows.Forms.Label Lbl_observacion;
        internal System.Windows.Forms.TextBox txt_observacion;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button btn_guardar_mst;
        private System.Windows.Forms.TextBox txt_fecha;
    }
}