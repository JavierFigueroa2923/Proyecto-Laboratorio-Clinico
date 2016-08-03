namespace WindowsFormsApplication1
{
    partial class frm_muestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_muestra));
            this.txt_busc_id_mst = new System.Windows.Forms.TextBox();
            this.lbl_busca_mst = new System.Windows.Forms.Label();
            this.grb_vista_mst = new System.Windows.Forms.GroupBox();
            this.dgv_busc_mst = new System.Windows.Forms.DataGridView();
            this.grb_datos2_mst = new System.Windows.Forms.GroupBox();
            this.dgv_id_clt_mst = new System.Windows.Forms.DataGridView();
            this.btn_busc_id_clt_mst = new System.Windows.Forms.Button();
            this.Lbl_id_usur_per = new System.Windows.Forms.Label();
            this.txt_busc_id_clt_mst = new System.Windows.Forms.TextBox();
            this.grb_datos1_mst = new System.Windows.Forms.GroupBox();
            this.cbo_tipo_mst = new System.Windows.Forms.ComboBox();
            this.Lbl_tip_mst = new System.Windows.Forms.Label();
            this.txt_id_mst = new System.Windows.Forms.TextBox();
            this.Lbl_id_mst = new System.Windows.Forms.Label();
            this.Lbl_id_clt_mst = new System.Windows.Forms.Label();
            this.txt_id_clt_mst = new System.Windows.Forms.TextBox();
            this.Lbl_descr_mst = new System.Windows.Forms.Label();
            this.txt_descr_mst = new System.Windows.Forms.TextBox();
            this.Lbl_cantidad_mst = new System.Windows.Forms.Label();
            this.txt_cant_mst = new System.Windows.Forms.TextBox();
            this.Lbl_muestra = new System.Windows.Forms.Label();
            this.btn_busc_id_mst = new System.Windows.Forms.Button();
            this.btn_elim_mst = new System.Windows.Forms.Button();
            this.btn_actlz_mst = new System.Windows.Forms.Button();
            this.btn_guardar_mst = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.grb_vista_mst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst)).BeginInit();
            this.grb_datos2_mst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_id_clt_mst)).BeginInit();
            this.grb_datos1_mst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busc_id_mst
            // 
            this.txt_busc_id_mst.Location = new System.Drawing.Point(152, 324);
            this.txt_busc_id_mst.Name = "txt_busc_id_mst";
            this.txt_busc_id_mst.Size = new System.Drawing.Size(473, 20);
            this.txt_busc_id_mst.TabIndex = 167;
            // 
            // lbl_busca_mst
            // 
            this.lbl_busca_mst.AutoSize = true;
            this.lbl_busca_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_mst.Location = new System.Drawing.Point(17, 321);
            this.lbl_busca_mst.Name = "lbl_busca_mst";
            this.lbl_busca_mst.Size = new System.Drawing.Size(132, 20);
            this.lbl_busca_mst.TabIndex = 166;
            this.lbl_busca_mst.Text = "Buscar Muestras:";
            // 
            // grb_vista_mst
            // 
            this.grb_vista_mst.Controls.Add(this.dgv_busc_mst);
            this.grb_vista_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_mst.Location = new System.Drawing.Point(32, 344);
            this.grb_vista_mst.Name = "grb_vista_mst";
            this.grb_vista_mst.Size = new System.Drawing.Size(754, 163);
            this.grb_vista_mst.TabIndex = 168;
            this.grb_vista_mst.TabStop = false;
            this.grb_vista_mst.Text = "Muestras";
            // 
            // dgv_busc_mst
            // 
            this.dgv_busc_mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_mst.Location = new System.Drawing.Point(9, 22);
            this.dgv_busc_mst.Name = "dgv_busc_mst";
            this.dgv_busc_mst.Size = new System.Drawing.Size(739, 135);
            this.dgv_busc_mst.TabIndex = 0;
            // 
            // grb_datos2_mst
            // 
            this.grb_datos2_mst.Controls.Add(this.dgv_id_clt_mst);
            this.grb_datos2_mst.Controls.Add(this.btn_busc_id_clt_mst);
            this.grb_datos2_mst.Controls.Add(this.Lbl_id_usur_per);
            this.grb_datos2_mst.Controls.Add(this.txt_busc_id_clt_mst);
            this.grb_datos2_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos2_mst.Location = new System.Drawing.Point(457, 123);
            this.grb_datos2_mst.Name = "grb_datos2_mst";
            this.grb_datos2_mst.Size = new System.Drawing.Size(338, 189);
            this.grb_datos2_mst.TabIndex = 165;
            this.grb_datos2_mst.TabStop = false;
            this.grb_datos2_mst.Text = "Datos de cliente";
            // 
            // dgv_id_clt_mst
            // 
            this.dgv_id_clt_mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_id_clt_mst.Location = new System.Drawing.Point(10, 63);
            this.dgv_id_clt_mst.Name = "dgv_id_clt_mst";
            this.dgv_id_clt_mst.Size = new System.Drawing.Size(322, 112);
            this.dgv_id_clt_mst.TabIndex = 133;
            // 
            // btn_busc_id_clt_mst
            // 
            this.btn_busc_id_clt_mst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_clt_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_clt_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_clt_mst.Location = new System.Drawing.Point(292, 16);
            this.btn_busc_id_clt_mst.Name = "btn_busc_id_clt_mst";
            this.btn_busc_id_clt_mst.Size = new System.Drawing.Size(44, 41);
            this.btn_busc_id_clt_mst.TabIndex = 132;
            this.btn_busc_id_clt_mst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_clt_mst.UseVisualStyleBackColor = true;
            // 
            // Lbl_id_usur_per
            // 
            this.Lbl_id_usur_per.AutoSize = true;
            this.Lbl_id_usur_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_usur_per.Location = new System.Drawing.Point(6, 32);
            this.Lbl_id_usur_per.Name = "Lbl_id_usur_per";
            this.Lbl_id_usur_per.Size = new System.Drawing.Size(84, 20);
            this.Lbl_id_usur_per.TabIndex = 85;
            this.Lbl_id_usur_per.Text = "Id Cliente:";
            // 
            // txt_busc_id_clt_mst
            // 
            this.txt_busc_id_clt_mst.Location = new System.Drawing.Point(98, 32);
            this.txt_busc_id_clt_mst.Multiline = true;
            this.txt_busc_id_clt_mst.Name = "txt_busc_id_clt_mst";
            this.txt_busc_id_clt_mst.Size = new System.Drawing.Size(190, 23);
            this.txt_busc_id_clt_mst.TabIndex = 82;
            // 
            // grb_datos1_mst
            // 
            this.grb_datos1_mst.Controls.Add(this.cbo_tipo_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_tip_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_id_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_id_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_id_clt_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_id_clt_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_descr_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_descr_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_cantidad_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_cant_mst);
            this.grb_datos1_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_mst.Location = new System.Drawing.Point(-7, 123);
            this.grb_datos1_mst.Name = "grb_datos1_mst";
            this.grb_datos1_mst.Size = new System.Drawing.Size(436, 189);
            this.grb_datos1_mst.TabIndex = 164;
            this.grb_datos1_mst.TabStop = false;
            this.grb_datos1_mst.Text = "Datos de muestra";
            // 
            // cbo_tipo_mst
            // 
            this.cbo_tipo_mst.FormattingEnabled = true;
            this.cbo_tipo_mst.Location = new System.Drawing.Point(108, 140);
            this.cbo_tipo_mst.Name = "cbo_tipo_mst";
            this.cbo_tipo_mst.Size = new System.Drawing.Size(310, 24);
            this.cbo_tipo_mst.TabIndex = 93;
            // 
            // Lbl_tip_mst
            // 
            this.Lbl_tip_mst.AutoSize = true;
            this.Lbl_tip_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tip_mst.Location = new System.Drawing.Point(64, 142);
            this.Lbl_tip_mst.Name = "Lbl_tip_mst";
            this.Lbl_tip_mst.Size = new System.Drawing.Size(41, 20);
            this.Lbl_tip_mst.TabIndex = 92;
            this.Lbl_tip_mst.Text = "Tipo:";
            // 
            // txt_id_mst
            // 
            this.txt_id_mst.Location = new System.Drawing.Point(102, 27);
            this.txt_id_mst.Name = "txt_id_mst";
            this.txt_id_mst.Size = new System.Drawing.Size(115, 23);
            this.txt_id_mst.TabIndex = 91;
            // 
            // Lbl_id_mst
            // 
            this.Lbl_id_mst.AutoSize = true;
            this.Lbl_id_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_mst.Location = new System.Drawing.Point(9, 26);
            this.Lbl_id_mst.Name = "Lbl_id_mst";
            this.Lbl_id_mst.Size = new System.Drawing.Size(92, 20);
            this.Lbl_id_mst.TabIndex = 90;
            this.Lbl_id_mst.Text = "Id Muestra:";
            // 
            // Lbl_id_clt_mst
            // 
            this.Lbl_id_clt_mst.AutoSize = true;
            this.Lbl_id_clt_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_clt_mst.Location = new System.Drawing.Point(14, 56);
            this.Lbl_id_clt_mst.Name = "Lbl_id_clt_mst";
            this.Lbl_id_clt_mst.Size = new System.Drawing.Size(88, 20);
            this.Lbl_id_clt_mst.TabIndex = 89;
            this.Lbl_id_clt_mst.Text = "Id Cliente: ";
            // 
            // txt_id_clt_mst
            // 
            this.txt_id_clt_mst.Location = new System.Drawing.Point(102, 56);
            this.txt_id_clt_mst.Name = "txt_id_clt_mst";
            this.txt_id_clt_mst.Size = new System.Drawing.Size(115, 23);
            this.txt_id_clt_mst.TabIndex = 86;
            // 
            // Lbl_descr_mst
            // 
            this.Lbl_descr_mst.AutoSize = true;
            this.Lbl_descr_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descr_mst.Location = new System.Drawing.Point(6, 114);
            this.Lbl_descr_mst.Name = "Lbl_descr_mst";
            this.Lbl_descr_mst.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descr_mst.TabIndex = 85;
            this.Lbl_descr_mst.Text = "Descripcion:";
            // 
            // txt_descr_mst
            // 
            this.txt_descr_mst.Location = new System.Drawing.Point(108, 114);
            this.txt_descr_mst.Multiline = true;
            this.txt_descr_mst.Name = "txt_descr_mst";
            this.txt_descr_mst.Size = new System.Drawing.Size(310, 20);
            this.txt_descr_mst.TabIndex = 82;
            // 
            // Lbl_cantidad_mst
            // 
            this.Lbl_cantidad_mst.AutoSize = true;
            this.Lbl_cantidad_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad_mst.Location = new System.Drawing.Point(16, 85);
            this.Lbl_cantidad_mst.Name = "Lbl_cantidad_mst";
            this.Lbl_cantidad_mst.Size = new System.Drawing.Size(82, 20);
            this.Lbl_cantidad_mst.TabIndex = 81;
            this.Lbl_cantidad_mst.Text = "Cantidad:";
            // 
            // txt_cant_mst
            // 
            this.txt_cant_mst.Location = new System.Drawing.Point(102, 85);
            this.txt_cant_mst.Name = "txt_cant_mst";
            this.txt_cant_mst.Size = new System.Drawing.Size(316, 23);
            this.txt_cant_mst.TabIndex = 80;
            // 
            // Lbl_muestra
            // 
            this.Lbl_muestra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_muestra.AutoSize = true;
            this.Lbl_muestra.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_muestra.Location = new System.Drawing.Point(322, 17);
            this.Lbl_muestra.Name = "Lbl_muestra";
            this.Lbl_muestra.Size = new System.Drawing.Size(134, 34);
            this.Lbl_muestra.TabIndex = 160;
            this.Lbl_muestra.Text = "Muestras";
            // 
            // btn_busc_id_mst
            // 
            this.btn_busc_id_mst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_mst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_id_mst.Location = new System.Drawing.Point(651, 313);
            this.btn_busc_id_mst.Name = "btn_busc_id_mst";
            this.btn_busc_id_mst.Size = new System.Drawing.Size(114, 40);
            this.btn_busc_id_mst.TabIndex = 169;
            this.btn_busc_id_mst.Text = "BUSCAR";
            this.btn_busc_id_mst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_mst.UseVisualStyleBackColor = true;
            // 
            // btn_elim_mst
            // 
            this.btn_elim_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_mst.Location = new System.Drawing.Point(216, 63);
            this.btn_elim_mst.Name = "btn_elim_mst";
            this.btn_elim_mst.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_mst.TabIndex = 163;
            this.btn_elim_mst.Text = "ELIMINAR";
            this.btn_elim_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_mst.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_mst
            // 
            this.btn_actlz_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_mst.Location = new System.Drawing.Point(116, 63);
            this.btn_actlz_mst.Name = "btn_actlz_mst";
            this.btn_actlz_mst.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_mst.TabIndex = 162;
            this.btn_actlz_mst.Text = "ACTUALIZAR";
            this.btn_actlz_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_mst.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_mst
            // 
            this.btn_guardar_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_mst.Location = new System.Drawing.Point(16, 63);
            this.btn_guardar_mst.Name = "btn_guardar_mst";
            this.btn_guardar_mst.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_mst.TabIndex = 161;
            this.btn_guardar_mst.Text = "GUARDAR";
            this.btn_guardar_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_mst.UseVisualStyleBackColor = true;
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Image = global::WindowsFormsApplication1.Properties.Resources.Clinica;
            this.pic_logo.Location = new System.Drawing.Point(693, 17);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(106, 100);
            this.pic_logo.TabIndex = 159;
            this.pic_logo.TabStop = false;
            // 
            // frm_muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 525);
            this.Controls.Add(this.btn_busc_id_mst);
            this.Controls.Add(this.txt_busc_id_mst);
            this.Controls.Add(this.lbl_busca_mst);
            this.Controls.Add(this.grb_vista_mst);
            this.Controls.Add(this.grb_datos2_mst);
            this.Controls.Add(this.grb_datos1_mst);
            this.Controls.Add(this.btn_elim_mst);
            this.Controls.Add(this.btn_actlz_mst);
            this.Controls.Add(this.btn_guardar_mst);
            this.Controls.Add(this.Lbl_muestra);
            this.Controls.Add(this.pic_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_muestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra";
            this.grb_vista_mst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst)).EndInit();
            this.grb_datos2_mst.ResumeLayout(false);
            this.grb_datos2_mst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_id_clt_mst)).EndInit();
            this.grb_datos1_mst.ResumeLayout(false);
            this.grb_datos1_mst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_busc_id_mst;
        internal System.Windows.Forms.TextBox txt_busc_id_mst;
        internal System.Windows.Forms.Label lbl_busca_mst;
        private System.Windows.Forms.GroupBox grb_vista_mst;
        private System.Windows.Forms.DataGridView dgv_busc_mst;
        private System.Windows.Forms.GroupBox grb_datos2_mst;
        private System.Windows.Forms.DataGridView dgv_id_clt_mst;
        private System.Windows.Forms.Button btn_busc_id_clt_mst;
        internal System.Windows.Forms.Label Lbl_id_usur_per;
        internal System.Windows.Forms.TextBox txt_busc_id_clt_mst;
        private System.Windows.Forms.GroupBox grb_datos1_mst;
        internal System.Windows.Forms.TextBox txt_id_mst;
        internal System.Windows.Forms.Label Lbl_id_mst;
        internal System.Windows.Forms.Label Lbl_id_clt_mst;
        internal System.Windows.Forms.TextBox txt_id_clt_mst;
        internal System.Windows.Forms.Label Lbl_descr_mst;
        internal System.Windows.Forms.TextBox txt_descr_mst;
        internal System.Windows.Forms.Label Lbl_cantidad_mst;
        internal System.Windows.Forms.TextBox txt_cant_mst;
        private System.Windows.Forms.Button btn_elim_mst;
        private System.Windows.Forms.Button btn_actlz_mst;
        private System.Windows.Forms.Button btn_guardar_mst;
        internal System.Windows.Forms.Label Lbl_muestra;
        internal System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ComboBox cbo_tipo_mst;
        internal System.Windows.Forms.Label Lbl_tip_mst;
    }
}