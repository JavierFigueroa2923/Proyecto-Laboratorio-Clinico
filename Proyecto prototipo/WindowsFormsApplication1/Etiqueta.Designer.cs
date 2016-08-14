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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_etiqueta));
            this.lbl_busca_eti = new System.Windows.Forms.Label();
            this.txt_busc_eti = new System.Windows.Forms.TextBox();
            this.grb_vista_eti = new System.Windows.Forms.GroupBox();
            this.dgv_busc_eti = new System.Windows.Forms.DataGridView();
            this.grb_datos1_eti = new System.Windows.Forms.GroupBox();
            this.cbo_id_mst_busc_eti = new System.Windows.Forms.ComboBox();
            this.btn_id_mst_busc_eti = new System.Windows.Forms.Button();
            this.Lbl_id_mst_eti = new System.Windows.Forms.Label();
            this.Lbl_descripcion_eti = new System.Windows.Forms.Label();
            this.txt_descr_eti = new System.Windows.Forms.TextBox();
            this.Lbl_etiqueta = new System.Windows.Forms.Label();
            this.btn_busc_eti = new System.Windows.Forms.Button();
            this.btn_elim_eti = new System.Windows.Forms.Button();
            this.btn_actlz_eti = new System.Windows.Forms.Button();
            this.btn_guardar_eti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_nuevo_pcnt = new System.Windows.Forms.Button();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.grb_vista_eti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_eti)).BeginInit();
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
            this.txt_busc_eti.TabIndex = 6;
            this.txt_busc_eti.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_busquedaeti_KeyUp);
            // 
            // grb_vista_eti
            // 
            this.grb_vista_eti.Controls.Add(this.dgv_busc_eti);
            this.grb_vista_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_eti.Location = new System.Drawing.Point(12, 337);
            this.grb_vista_eti.Name = "grb_vista_eti";
            this.grb_vista_eti.Size = new System.Drawing.Size(639, 163);
            this.grb_vista_eti.TabIndex = 173;
            this.grb_vista_eti.TabStop = false;
            this.grb_vista_eti.Text = "Etiquetas";
            // 
            // dgv_busc_eti
            // 
            this.dgv_busc_eti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_eti.Location = new System.Drawing.Point(9, 22);
            this.dgv_busc_eti.Name = "dgv_busc_eti";
            this.dgv_busc_eti.Size = new System.Drawing.Size(624, 135);
            this.dgv_busc_eti.TabIndex = 0;
            this.dgv_busc_eti.TabStop = false;
            // 
            // grb_datos1_eti
            // 
            this.grb_datos1_eti.Controls.Add(this.cbo_id_mst_busc_eti);
            this.grb_datos1_eti.Controls.Add(this.btn_id_mst_busc_eti);
            this.grb_datos1_eti.Controls.Add(this.Lbl_id_mst_eti);
            this.grb_datos1_eti.Controls.Add(this.Lbl_descripcion_eti);
            this.grb_datos1_eti.Controls.Add(this.txt_descr_eti);
            this.grb_datos1_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_eti.Location = new System.Drawing.Point(12, 123);
            this.grb_datos1_eti.Name = "grb_datos1_eti";
            this.grb_datos1_eti.Size = new System.Drawing.Size(429, 187);
            this.grb_datos1_eti.TabIndex = 170;
            this.grb_datos1_eti.TabStop = false;
            this.grb_datos1_eti.Text = "Datos de etiqueta";
            // 
            // cbo_id_mst_busc_eti
            // 
            this.cbo_id_mst_busc_eti.FormattingEnabled = true;
            this.cbo_id_mst_busc_eti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbo_id_mst_busc_eti.Location = new System.Drawing.Point(102, 43);
            this.cbo_id_mst_busc_eti.Name = "cbo_id_mst_busc_eti";
            this.cbo_id_mst_busc_eti.Size = new System.Drawing.Size(115, 24);
            this.cbo_id_mst_busc_eti.TabIndex = 1;
            this.cbo_id_mst_busc_eti.SelectedIndexChanged += new System.EventHandler(this.cbo_id_mst_busc_eti_SelectedIndexChanged);
            // 
            // btn_id_mst_busc_eti
            // 
            this.btn_id_mst_busc_eti.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_id_mst_busc_eti.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_id_mst_busc_eti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_id_mst_busc_eti.FlatAppearance.BorderSize = 0;
            this.btn_id_mst_busc_eti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_id_mst_busc_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_id_mst_busc_eti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_id_mst_busc_eti.Location = new System.Drawing.Point(223, 34);
            this.btn_id_mst_busc_eti.Name = "btn_id_mst_busc_eti";
            this.btn_id_mst_busc_eti.Size = new System.Drawing.Size(40, 40);
            this.btn_id_mst_busc_eti.TabIndex = 2;
            this.btn_id_mst_busc_eti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip8.SetToolTip(this.btn_id_mst_busc_eti, "Buscar por Muesta");
            this.btn_id_mst_busc_eti.UseVisualStyleBackColor = true;
            this.btn_id_mst_busc_eti.Click += new System.EventHandler(this.btn_id_mst_busc_eti_Click);
            // 
            // Lbl_id_mst_eti
            // 
            this.Lbl_id_mst_eti.AutoSize = true;
            this.Lbl_id_mst_eti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_mst_eti.Location = new System.Drawing.Point(9, 44);
            this.Lbl_id_mst_eti.Name = "Lbl_id_mst_eti";
            this.Lbl_id_mst_eti.Size = new System.Drawing.Size(96, 20);
            this.Lbl_id_mst_eti.TabIndex = 89;
            this.Lbl_id_mst_eti.Text = "Id Muestra: ";
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
            this.txt_descr_eti.Location = new System.Drawing.Point(102, 93);
            this.txt_descr_eti.Multiline = true;
            this.txt_descr_eti.Name = "txt_descr_eti";
            this.txt_descr_eti.Size = new System.Drawing.Size(316, 90);
            this.txt_descr_eti.TabIndex = 5;
            // 
            // Lbl_etiqueta
            // 
            this.Lbl_etiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_etiqueta.AutoSize = true;
            this.Lbl_etiqueta.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_etiqueta.Location = new System.Drawing.Point(272, 9);
            this.Lbl_etiqueta.Name = "Lbl_etiqueta";
            this.Lbl_etiqueta.Size = new System.Drawing.Size(136, 34);
            this.Lbl_etiqueta.TabIndex = 169;
            this.Lbl_etiqueta.Text = "Etiquetas";
            // 
            // btn_busc_eti
            // 
            this.btn_busc_eti.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_eti.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_eti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_eti.FlatAppearance.BorderSize = 0;
            this.btn_busc_eti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_eti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_eti.Location = new System.Drawing.Point(296, 46);
            this.btn_busc_eti.Name = "btn_busc_eti";
            this.btn_busc_eti.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_eti.TabIndex = 7;
            this.btn_busc_eti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip5.SetToolTip(this.btn_busc_eti, "Buscar");
            this.btn_busc_eti.UseVisualStyleBackColor = true;
            this.btn_busc_eti.Click += new System.EventHandler(this.btn_busc_eti_Click);
            // 
            // btn_elim_eti
            // 
            this.btn_elim_eti.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_eti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_eti.FlatAppearance.BorderSize = 0;
            this.btn_elim_eti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_eti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_eti.Location = new System.Drawing.Point(225, 46);
            this.btn_elim_eti.Name = "btn_elim_eti";
            this.btn_elim_eti.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_eti.TabIndex = 9;
            this.btn_elim_eti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_eti, "Eliminar");
            this.btn_elim_eti.UseVisualStyleBackColor = true;
            this.btn_elim_eti.Click += new System.EventHandler(this.btn_elim_eti_Click);
            // 
            // btn_actlz_eti
            // 
            this.btn_actlz_eti.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_eti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_eti.FlatAppearance.BorderSize = 0;
            this.btn_actlz_eti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_eti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_eti.Location = new System.Drawing.Point(154, 46);
            this.btn_actlz_eti.Name = "btn_actlz_eti";
            this.btn_actlz_eti.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_eti.TabIndex = 8;
            this.btn_actlz_eti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_eti, "Modificar");
            this.btn_actlz_eti.UseVisualStyleBackColor = true;
            this.btn_actlz_eti.Click += new System.EventHandler(this.btn_actlz_eti_Click);
            // 
            // btn_guardar_eti
            // 
            this.btn_guardar_eti.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_eti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_eti.FlatAppearance.BorderSize = 0;
            this.btn_guardar_eti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_eti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_eti.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_eti.Location = new System.Drawing.Point(83, 46);
            this.btn_guardar_eti.Name = "btn_guardar_eti";
            this.btn_guardar_eti.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_eti.TabIndex = 166;
            this.btn_guardar_eti.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_eti, "Guardar");
            this.btn_guardar_eti.UseVisualStyleBackColor = true;
            this.btn_guardar_eti.Click += new System.EventHandler(this.btn_guardar_eti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(556, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 102);
            this.pictureBox1.TabIndex = 176;
            this.pictureBox1.TabStop = false;
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(12, 46);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 177;
            this.toolTip1.SetToolTip(this.btn_nuevo_pcnt, "Nuevo");
            this.btn_nuevo_pcnt.UseVisualStyleBackColor = true;
            this.btn_nuevo_pcnt.Click += new System.EventHandler(this.btn_nuevo_pcnt_Click);
            // 
            // btn_acept
            // 
            this.btn_acept.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.check_icon;
            this.btn_acept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acept.Enabled = false;
            this.btn_acept.FlatAppearance.BorderSize = 0;
            this.btn_acept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acept.Location = new System.Drawing.Point(436, 46);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 179;
            this.toolTip7.SetToolTip(this.btn_acept, "Aceptar");
            this.btn_acept.UseVisualStyleBackColor = true;
            // 
            // btn_cancl
            // 
            this.btn_cancl.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete_icon;
            this.btn_cancl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancl.Enabled = false;
            this.btn_cancl.FlatAppearance.BorderSize = 0;
            this.btn_cancl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancl.Location = new System.Drawing.Point(365, 46);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 178;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // frm_etiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 509);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_busca_eti);
            this.Controls.Add(this.btn_busc_eti);
            this.Controls.Add(this.txt_busc_eti);
            this.Controls.Add(this.grb_vista_eti);
            this.Controls.Add(this.grb_datos1_eti);
            this.Controls.Add(this.Lbl_etiqueta);
            this.Controls.Add(this.btn_elim_eti);
            this.Controls.Add(this.btn_actlz_eti);
            this.Controls.Add(this.btn_guardar_eti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_etiqueta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta";
            this.Load += new System.EventHandler(this.frm_etiqueta_Load);
            this.grb_vista_eti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_eti)).EndInit();
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
        private System.Windows.Forms.GroupBox grb_datos1_eti;
        internal System.Windows.Forms.Label Lbl_id_mst_eti;
        internal System.Windows.Forms.Label Lbl_descripcion_eti;
        internal System.Windows.Forms.TextBox txt_descr_eti;
        internal System.Windows.Forms.Label Lbl_etiqueta;
        private System.Windows.Forms.Button btn_elim_eti;
        private System.Windows.Forms.Button btn_actlz_eti;
        private System.Windows.Forms.Button btn_guardar_eti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_id_mst_busc_eti;
        public System.Windows.Forms.ComboBox cbo_id_mst_busc_eti;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}