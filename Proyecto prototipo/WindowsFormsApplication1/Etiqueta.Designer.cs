namespace WindowsFormsApplication1
{
    partial class frm_etiqueta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_etiqueta));
            this.lbl_busca_eti = new System.Windows.Forms.Label();
            this.txt_busc_eti = new System.Windows.Forms.TextBox();
            this.grb_vista_eti = new System.Windows.Forms.GroupBox();
            this.dgv_busc_eti = new System.Windows.Forms.DataGridView();
            this.grb_datos2_eti = new System.Windows.Forms.GroupBox();
            this.dgv_busc_mst_eti = new System.Windows.Forms.DataGridView();
            this.btn_busc__mst_eti = new System.Windows.Forms.Button();
            this.Lbl_busc_id_mst_eti = new System.Windows.Forms.Label();
            this.txt_busc_mst_eti = new System.Windows.Forms.TextBox();
            this.grb_datos1_eti = new System.Windows.Forms.GroupBox();
            this.txt_id_eti = new System.Windows.Forms.TextBox();
            this.Lbl_id_eti = new System.Windows.Forms.Label();
            this.Lbl_id_mst_eti = new System.Windows.Forms.Label();
            this.txt_id_mst_eti = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion_eti = new System.Windows.Forms.Label();
            this.txt_descr_eti = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_id_clt__eti = new System.Windows.Forms.TextBox();
            this.Lbl_etiqueta = new System.Windows.Forms.Label();
            this.btn_busc_eti = new System.Windows.Forms.Button();
            this.btn_elim_eti = new System.Windows.Forms.Button();
            this.btn_actlz_eti = new System.Windows.Forms.Button();
            this.btn_guardar_eti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_vista_eti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_eti)).BeginInit();
            this.grb_datos2_eti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst_eti)).BeginInit();
            this.grb_datos1_eti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_busca_eti
            // 
            this.lbl_busca_eti.AutoSize = true;
            this.lbl_busca_eti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_eti.Location = new System.Drawing.Point(25, 314);
            this.lbl_busca_eti.Name = "lbl_busca_eti";
            this.lbl_busca_eti.Size = new System.Drawing.Size(132, 20);
            this.lbl_busca_eti.TabIndex = 175;
            this.lbl_busca_eti.Text = "Buscar Etiquetas:";
            // 
            // txt_busc_eti
            // 
            this.txt_busc_eti.Location = new System.Drawing.Point(163, 316);
            this.txt_busc_eti.Name = "txt_busc_eti";
            this.txt_busc_eti.Size = new System.Drawing.Size(473, 20);
            this.txt_busc_eti.TabIndex = 172;
            this.txt_busc_eti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_busquedaeti_KeyUp);
            // 
            // grb_vista_eti
            // 
            this.grb_vista_eti.Controls.Add(this.dgv_busc_eti);
            this.grb_vista_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_eti.Location = new System.Drawing.Point(43, 336);
            this.grb_vista_eti.Name = "grb_vista_eti";
            this.grb_vista_eti.Size = new System.Drawing.Size(754, 163);
            this.grb_vista_eti.TabIndex = 173;
            this.grb_vista_eti.TabStop = false;
            this.grb_vista_eti.Text = "Etiquetas";
            // 
            // dgv_busc_eti
            // 
            this.dgv_busc_eti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_eti.Location = new System.Drawing.Point(9, 22);
            this.dgv_busc_eti.Name = "dgv_busc_eti";
            this.dgv_busc_eti.Size = new System.Drawing.Size(739, 135);
            this.dgv_busc_eti.TabIndex = 0;
            // 
            // grb_datos2_eti
            // 
            this.grb_datos2_eti.Controls.Add(this.dgv_busc_mst_eti);
            this.grb_datos2_eti.Controls.Add(this.btn_busc__mst_eti);
            this.grb_datos2_eti.Controls.Add(this.Lbl_busc_id_mst_eti);
            this.grb_datos2_eti.Controls.Add(this.txt_busc_mst_eti);
            this.grb_datos2_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos2_eti.Location = new System.Drawing.Point(468, 115);
            this.grb_datos2_eti.Name = "grb_datos2_eti";
            this.grb_datos2_eti.Size = new System.Drawing.Size(338, 189);
            this.grb_datos2_eti.TabIndex = 171;
            this.grb_datos2_eti.TabStop = false;
            this.grb_datos2_eti.Text = "Datos de muestras";
            // 
            // dgv_busc_mst_eti
            // 
            this.dgv_busc_mst_eti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_mst_eti.Location = new System.Drawing.Point(10, 63);
            this.dgv_busc_mst_eti.Name = "dgv_busc_mst_eti";
            this.dgv_busc_mst_eti.Size = new System.Drawing.Size(322, 112);
            this.dgv_busc_mst_eti.TabIndex = 133;
            // 
            // btn_busc__mst_eti
            // 
            this.btn_busc__mst_eti.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc__mst_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc__mst_eti.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc__mst_eti.Location = new System.Drawing.Point(292, 16);
            this.btn_busc__mst_eti.Name = "btn_busc__mst_eti";
            this.btn_busc__mst_eti.Size = new System.Drawing.Size(44, 41);
            this.btn_busc__mst_eti.TabIndex = 132;
            this.btn_busc__mst_eti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc__mst_eti.UseVisualStyleBackColor = true;
            this.btn_busc__mst_eti.Click += new System.EventHandler(this.btn_busc__mst_eti_Click);
            // 
            // Lbl_busc_id_mst_eti
            // 
            this.Lbl_busc_id_mst_eti.AutoSize = true;
            this.Lbl_busc_id_mst_eti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_busc_id_mst_eti.Location = new System.Drawing.Point(6, 32);
            this.Lbl_busc_id_mst_eti.Name = "Lbl_busc_id_mst_eti";
            this.Lbl_busc_id_mst_eti.Size = new System.Drawing.Size(92, 20);
            this.Lbl_busc_id_mst_eti.TabIndex = 85;
            this.Lbl_busc_id_mst_eti.Text = "Id Muestra:";
            // 
            // txt_busc_mst_eti
            // 
            this.txt_busc_mst_eti.Location = new System.Drawing.Point(98, 32);
            this.txt_busc_mst_eti.Multiline = true;
            this.txt_busc_mst_eti.Name = "txt_busc_mst_eti";
            this.txt_busc_mst_eti.Size = new System.Drawing.Size(190, 23);
            this.txt_busc_mst_eti.TabIndex = 82;
            this.txt_busc_mst_eti.TextChanged += new System.EventHandler(this.txt_busc_mst_eti_TextChanged);
            // 
            // grb_datos1_eti
            // 
            this.grb_datos1_eti.Controls.Add(this.txt_id_eti);
            this.grb_datos1_eti.Controls.Add(this.Lbl_id_eti);
            this.grb_datos1_eti.Controls.Add(this.Lbl_id_mst_eti);
            this.grb_datos1_eti.Controls.Add(this.txt_id_mst_eti);
            this.grb_datos1_eti.Controls.Add(this.Lbl_descripcion_eti);
            this.grb_datos1_eti.Controls.Add(this.txt_descr_eti);
            this.grb_datos1_eti.Controls.Add(this.Lbl_nombre);
            this.grb_datos1_eti.Controls.Add(this.txt_id_clt__eti);
            this.grb_datos1_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_eti.Location = new System.Drawing.Point(4, 115);
            this.grb_datos1_eti.Name = "grb_datos1_eti";
            this.grb_datos1_eti.Size = new System.Drawing.Size(436, 189);
            this.grb_datos1_eti.TabIndex = 170;
            this.grb_datos1_eti.TabStop = false;
            this.grb_datos1_eti.Text = "Datos de etiqueta";
            // 
            // txt_id_eti
            // 
            this.txt_id_eti.Location = new System.Drawing.Point(102, 27);
            this.txt_id_eti.Name = "txt_id_eti";
            this.txt_id_eti.Size = new System.Drawing.Size(115, 23);
            this.txt_id_eti.TabIndex = 91;
            // 
            // Lbl_id_eti
            // 
            this.Lbl_id_eti.AutoSize = true;
            this.Lbl_id_eti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_eti.Location = new System.Drawing.Point(9, 26);
            this.Lbl_id_eti.Name = "Lbl_id_eti";
            this.Lbl_id_eti.Size = new System.Drawing.Size(96, 20);
            this.Lbl_id_eti.TabIndex = 90;
            this.Lbl_id_eti.Text = "Id Etiqueta: ";
            // 
            // Lbl_id_mst_eti
            // 
            this.Lbl_id_mst_eti.AutoSize = true;
            this.Lbl_id_mst_eti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_mst_eti.Location = new System.Drawing.Point(6, 56);
            this.Lbl_id_mst_eti.Name = "Lbl_id_mst_eti";
            this.Lbl_id_mst_eti.Size = new System.Drawing.Size(96, 20);
            this.Lbl_id_mst_eti.TabIndex = 89;
            this.Lbl_id_mst_eti.Text = "Id Muestra: ";
            // 
            // txt_id_mst_eti
            // 
            this.txt_id_mst_eti.Location = new System.Drawing.Point(102, 56);
            this.txt_id_mst_eti.Name = "txt_id_mst_eti";
            this.txt_id_mst_eti.Size = new System.Drawing.Size(115, 23);
            this.txt_id_mst_eti.TabIndex = 86;
            // 
            // Lbl_descripcion_eti
            // 
            this.Lbl_descripcion_eti.AutoSize = true;
            this.Lbl_descripcion_eti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion_eti.Location = new System.Drawing.Point(-4, 114);
            this.Lbl_descripcion_eti.Name = "Lbl_descripcion_eti";
            this.Lbl_descripcion_eti.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion_eti.TabIndex = 85;
            this.Lbl_descripcion_eti.Text = "Descripcion:";
            // 
            // txt_descr_eti
            // 
            this.txt_descr_eti.Location = new System.Drawing.Point(102, 114);
            this.txt_descr_eti.Multiline = true;
            this.txt_descr_eti.Name = "txt_descr_eti";
            this.txt_descr_eti.Size = new System.Drawing.Size(316, 69);
            this.txt_descr_eti.TabIndex = 82;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(12, 85);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(84, 20);
            this.Lbl_nombre.TabIndex = 81;
            this.Lbl_nombre.Text = "Id Cliente:";
            // 
            // txt_id_clt__eti
            // 
            this.txt_id_clt__eti.Location = new System.Drawing.Point(102, 85);
            this.txt_id_clt__eti.Name = "txt_id_clt__eti";
            this.txt_id_clt__eti.Size = new System.Drawing.Size(117, 23);
            this.txt_id_clt__eti.TabIndex = 80;
            // 
            // Lbl_etiqueta
            // 
            this.Lbl_etiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_etiqueta.AutoSize = true;
            this.Lbl_etiqueta.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_etiqueta.Location = new System.Drawing.Point(224, 9);
            this.Lbl_etiqueta.Name = "Lbl_etiqueta";
            this.Lbl_etiqueta.Size = new System.Drawing.Size(136, 34);
            this.Lbl_etiqueta.TabIndex = 169;
            this.Lbl_etiqueta.Text = "Etiquetas";
            // 
            // btn_busc_eti
            // 
            this.btn_busc_eti.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_eti.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_eti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_eti.Location = new System.Drawing.Point(642, 305);
            this.btn_busc_eti.Name = "btn_busc_eti";
            this.btn_busc_eti.Size = new System.Drawing.Size(114, 40);
            this.btn_busc_eti.TabIndex = 174;
            this.btn_busc_eti.Text = "BUSCAR";
            this.btn_busc_eti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_eti.UseVisualStyleBackColor = true;
            this.btn_busc_eti.Click += new System.EventHandler(this.btn_busc_eti_Click);
            // 
            // btn_elim_eti
            // 
            this.btn_elim_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_eti.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_eti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_eti.Location = new System.Drawing.Point(229, 55);
            this.btn_elim_eti.Name = "btn_elim_eti";
            this.btn_elim_eti.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_eti.TabIndex = 168;
            this.btn_elim_eti.Text = "ELIMINAR";
            this.btn_elim_eti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_eti.UseVisualStyleBackColor = true;
            this.btn_elim_eti.Click += new System.EventHandler(this.btn_elim_eti_Click);
            // 
            // btn_actlz_eti
            // 
            this.btn_actlz_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_eti.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_eti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_eti.Location = new System.Drawing.Point(129, 55);
            this.btn_actlz_eti.Name = "btn_actlz_eti";
            this.btn_actlz_eti.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_eti.TabIndex = 167;
            this.btn_actlz_eti.Text = "ACTUALIZAR";
            this.btn_actlz_eti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_eti.UseVisualStyleBackColor = true;
            this.btn_actlz_eti.Click += new System.EventHandler(this.btn_actlz_eti_Click);
            // 
            // btn_guardar_eti
            // 
            this.btn_guardar_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_eti.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_eti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_eti.Location = new System.Drawing.Point(29, 55);
            this.btn_guardar_eti.Name = "btn_guardar_eti";
            this.btn_guardar_eti.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_eti.TabIndex = 166;
            this.btn_guardar_eti.Text = "GUARDAR";
            this.btn_guardar_eti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_eti.UseVisualStyleBackColor = true;
            this.btn_guardar_eti.Click += new System.EventHandler(this.btn_guardar_eti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(682, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 102);
            this.pictureBox1.TabIndex = 176;
            this.pictureBox1.TabStop = false;
            // 
            // frm_etiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_busca_eti);
            this.Controls.Add(this.btn_busc_eti);
            this.Controls.Add(this.txt_busc_eti);
            this.Controls.Add(this.grb_vista_eti);
            this.Controls.Add(this.grb_datos2_eti);
            this.Controls.Add(this.grb_datos1_eti);
            this.Controls.Add(this.Lbl_etiqueta);
            this.Controls.Add(this.btn_elim_eti);
            this.Controls.Add(this.btn_actlz_eti);
            this.Controls.Add(this.btn_guardar_eti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_etiqueta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta";
            this.Load += new System.EventHandler(this.frm_etiqueta_Load);
            this.grb_vista_eti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_eti)).EndInit();
            this.grb_datos2_eti.ResumeLayout(false);
            this.grb_datos2_eti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst_eti)).EndInit();
            this.grb_datos1_eti.ResumeLayout(false);
            this.grb_datos1_eti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_busca_eti;
        private System.Windows.Forms.Button btn_busc_eti;
        internal System.Windows.Forms.TextBox txt_busc_eti;
        private System.Windows.Forms.GroupBox grb_vista_eti;
        private System.Windows.Forms.DataGridView dgv_busc_eti;
        private System.Windows.Forms.GroupBox grb_datos2_eti;
        private System.Windows.Forms.DataGridView dgv_busc_mst_eti;
        private System.Windows.Forms.Button btn_busc__mst_eti;
        internal System.Windows.Forms.Label Lbl_busc_id_mst_eti;
        internal System.Windows.Forms.TextBox txt_busc_mst_eti;
        private System.Windows.Forms.GroupBox grb_datos1_eti;
        internal System.Windows.Forms.TextBox txt_id_eti;
        internal System.Windows.Forms.Label Lbl_id_eti;
        internal System.Windows.Forms.Label Lbl_id_mst_eti;
        internal System.Windows.Forms.TextBox txt_id_mst_eti;
        internal System.Windows.Forms.Label Lbl_descripcion_eti;
        internal System.Windows.Forms.TextBox txt_descr_eti;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_id_clt__eti;
        internal System.Windows.Forms.Label Lbl_etiqueta;
        private System.Windows.Forms.Button btn_elim_eti;
        private System.Windows.Forms.Button btn_actlz_eti;
        private System.Windows.Forms.Button btn_guardar_eti;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}