namespace WindowsFormsApplication1
{
    partial class frm_per
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_per));
            this.txt_busc_id_per = new System.Windows.Forms.TextBox();
            this.lbl_busca_per = new System.Windows.Forms.Label();
            this.grb_vista_per = new System.Windows.Forms.GroupBox();
            this.dgv_busc_per = new System.Windows.Forms.DataGridView();
            this.grb_datos2_per = new System.Windows.Forms.GroupBox();
            this.dgv_id_usur_per = new System.Windows.Forms.DataGridView();
            this.btn_busc_id_usur_per = new System.Windows.Forms.Button();
            this.Lbl_id_usur_per = new System.Windows.Forms.Label();
            this.txt_busc_id_usur_per = new System.Windows.Forms.TextBox();
            this.grb_datos1_per = new System.Windows.Forms.GroupBox();
            this.txt_id_per = new System.Windows.Forms.TextBox();
            this.Lbl_id_per = new System.Windows.Forms.Label();
            this.Lbl_id_usur = new System.Windows.Forms.Label();
            this.txt_usur_per = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descr_per = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre_per = new System.Windows.Forms.TextBox();
            this.Lbl_permiso = new System.Windows.Forms.Label();
            this.btn_busc_id_per = new System.Windows.Forms.Button();
            this.btn_elim_per = new System.Windows.Forms.Button();
            this.btn_actlz_per = new System.Windows.Forms.Button();
            this.btn_guardar_per = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.grb_vista_per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_per)).BeginInit();
            this.grb_datos2_per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_id_usur_per)).BeginInit();
            this.grb_datos1_per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busc_id_per
            // 
            this.txt_busc_id_per.Location = new System.Drawing.Point(162, 319);
            this.txt_busc_id_per.Name = "txt_busc_id_per";
            this.txt_busc_id_per.Size = new System.Drawing.Size(473, 20);
            this.txt_busc_id_per.TabIndex = 156;
            // 
            // lbl_busca_per
            // 
            this.lbl_busca_per.AutoSize = true;
            this.lbl_busca_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_per.Location = new System.Drawing.Point(27, 316);
            this.lbl_busca_per.Name = "lbl_busca_per";
            this.lbl_busca_per.Size = new System.Drawing.Size(128, 20);
            this.lbl_busca_per.TabIndex = 155;
            this.lbl_busca_per.Text = "Buscar Permisos:";
            // 
            // grb_vista_per
            // 
            this.grb_vista_per.Controls.Add(this.dgv_busc_per);
            this.grb_vista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_per.Location = new System.Drawing.Point(42, 339);
            this.grb_vista_per.Name = "grb_vista_per";
            this.grb_vista_per.Size = new System.Drawing.Size(754, 163);
            this.grb_vista_per.TabIndex = 157;
            this.grb_vista_per.TabStop = false;
            this.grb_vista_per.Text = "Permisos";
            // 
            // dgv_busc_per
            // 
            this.dgv_busc_per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_per.Location = new System.Drawing.Point(9, 22);
            this.dgv_busc_per.Name = "dgv_busc_per";
            this.dgv_busc_per.Size = new System.Drawing.Size(739, 135);
            this.dgv_busc_per.TabIndex = 0;
            // 
            // grb_datos2_per
            // 
            this.grb_datos2_per.Controls.Add(this.dgv_id_usur_per);
            this.grb_datos2_per.Controls.Add(this.btn_busc_id_usur_per);
            this.grb_datos2_per.Controls.Add(this.Lbl_id_usur_per);
            this.grb_datos2_per.Controls.Add(this.txt_busc_id_usur_per);
            this.grb_datos2_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos2_per.Location = new System.Drawing.Point(467, 118);
            this.grb_datos2_per.Name = "grb_datos2_per";
            this.grb_datos2_per.Size = new System.Drawing.Size(338, 189);
            this.grb_datos2_per.TabIndex = 154;
            this.grb_datos2_per.TabStop = false;
            this.grb_datos2_per.Text = "Datos de usuarios";
            // 
            // dgv_id_usur_per
            // 
            this.dgv_id_usur_per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_id_usur_per.Location = new System.Drawing.Point(10, 63);
            this.dgv_id_usur_per.Name = "dgv_id_usur_per";
            this.dgv_id_usur_per.Size = new System.Drawing.Size(322, 112);
            this.dgv_id_usur_per.TabIndex = 133;
            // 
            // btn_busc_id_usur_per
            // 
            this.btn_busc_id_usur_per.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_usur_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_usur_per.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_usur_per.Location = new System.Drawing.Point(292, 16);
            this.btn_busc_id_usur_per.Name = "btn_busc_id_usur_per";
            this.btn_busc_id_usur_per.Size = new System.Drawing.Size(44, 41);
            this.btn_busc_id_usur_per.TabIndex = 132;
            this.btn_busc_id_usur_per.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_usur_per.UseVisualStyleBackColor = true;
            // 
            // Lbl_id_usur_per
            // 
            this.Lbl_id_usur_per.AutoSize = true;
            this.Lbl_id_usur_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_usur_per.Location = new System.Drawing.Point(6, 32);
            this.Lbl_id_usur_per.Name = "Lbl_id_usur_per";
            this.Lbl_id_usur_per.Size = new System.Drawing.Size(86, 20);
            this.Lbl_id_usur_per.TabIndex = 85;
            this.Lbl_id_usur_per.Text = "Id Usuario:";
            // 
            // txt_busc_id_usur_per
            // 
            this.txt_busc_id_usur_per.Location = new System.Drawing.Point(98, 32);
            this.txt_busc_id_usur_per.Multiline = true;
            this.txt_busc_id_usur_per.Name = "txt_busc_id_usur_per";
            this.txt_busc_id_usur_per.Size = new System.Drawing.Size(190, 23);
            this.txt_busc_id_usur_per.TabIndex = 82;
            // 
            // grb_datos1_per
            // 
            this.grb_datos1_per.Controls.Add(this.txt_id_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_id_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_id_usur);
            this.grb_datos1_per.Controls.Add(this.txt_usur_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_descripcion);
            this.grb_datos1_per.Controls.Add(this.txt_descr_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_nombre);
            this.grb_datos1_per.Controls.Add(this.txt_nombre_per);
            this.grb_datos1_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_per.Location = new System.Drawing.Point(3, 118);
            this.grb_datos1_per.Name = "grb_datos1_per";
            this.grb_datos1_per.Size = new System.Drawing.Size(436, 189);
            this.grb_datos1_per.TabIndex = 153;
            this.grb_datos1_per.TabStop = false;
            this.grb_datos1_per.Text = "Datos de permiso";
            // 
            // txt_id_per
            // 
            this.txt_id_per.Location = new System.Drawing.Point(102, 27);
            this.txt_id_per.Name = "txt_id_per";
            this.txt_id_per.Size = new System.Drawing.Size(115, 23);
            this.txt_id_per.TabIndex = 91;
            // 
            // Lbl_id_per
            // 
            this.Lbl_id_per.AutoSize = true;
            this.Lbl_id_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_per.Location = new System.Drawing.Point(9, 26);
            this.Lbl_id_per.Name = "Lbl_id_per";
            this.Lbl_id_per.Size = new System.Drawing.Size(92, 20);
            this.Lbl_id_per.TabIndex = 90;
            this.Lbl_id_per.Text = "Id Permiso: ";
            // 
            // Lbl_id_usur
            // 
            this.Lbl_id_usur.AutoSize = true;
            this.Lbl_id_usur.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_usur.Location = new System.Drawing.Point(9, 56);
            this.Lbl_id_usur.Name = "Lbl_id_usur";
            this.Lbl_id_usur.Size = new System.Drawing.Size(90, 20);
            this.Lbl_id_usur.TabIndex = 89;
            this.Lbl_id_usur.Text = "Id Usuario: ";
            // 
            // txt_usur_per
            // 
            this.txt_usur_per.Location = new System.Drawing.Point(102, 56);
            this.txt_usur_per.Name = "txt_usur_per";
            this.txt_usur_per.Size = new System.Drawing.Size(115, 23);
            this.txt_usur_per.TabIndex = 86;
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(-4, 114);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 85;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_descr_per
            // 
            this.txt_descr_per.Location = new System.Drawing.Point(102, 114);
            this.txt_descr_per.Multiline = true;
            this.txt_descr_per.Name = "txt_descr_per";
            this.txt_descr_per.Size = new System.Drawing.Size(316, 69);
            this.txt_descr_per.TabIndex = 82;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(24, 85);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 81;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre_per
            // 
            this.txt_nombre_per.Location = new System.Drawing.Point(102, 85);
            this.txt_nombre_per.Name = "txt_nombre_per";
            this.txt_nombre_per.Size = new System.Drawing.Size(316, 23);
            this.txt_nombre_per.TabIndex = 80;
            // 
            // Lbl_permiso
            // 
            this.Lbl_permiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_permiso.AutoSize = true;
            this.Lbl_permiso.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_permiso.Location = new System.Drawing.Point(322, 12);
            this.Lbl_permiso.Name = "Lbl_permiso";
            this.Lbl_permiso.Size = new System.Drawing.Size(133, 34);
            this.Lbl_permiso.TabIndex = 149;
            this.Lbl_permiso.Text = "Permisos";
            // 
            // btn_busc_id_per
            // 
            this.btn_busc_id_per.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_per.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_per.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_id_per.Location = new System.Drawing.Point(641, 308);
            this.btn_busc_id_per.Name = "btn_busc_id_per";
            this.btn_busc_id_per.Size = new System.Drawing.Size(114, 40);
            this.btn_busc_id_per.TabIndex = 158;
            this.btn_busc_id_per.Text = "BUSCAR";
            this.btn_busc_id_per.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_per.UseVisualStyleBackColor = true;
            // 
            // btn_elim_per
            // 
            this.btn_elim_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_per.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_per.Location = new System.Drawing.Point(226, 58);
            this.btn_elim_per.Name = "btn_elim_per";
            this.btn_elim_per.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_per.TabIndex = 152;
            this.btn_elim_per.Text = "ELIMINAR";
            this.btn_elim_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_per.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_per
            // 
            this.btn_actlz_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_per.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_per.Location = new System.Drawing.Point(126, 58);
            this.btn_actlz_per.Name = "btn_actlz_per";
            this.btn_actlz_per.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_per.TabIndex = 151;
            this.btn_actlz_per.Text = "ACTUALIZAR";
            this.btn_actlz_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_per.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_per
            // 
            this.btn_guardar_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_per.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_per.Location = new System.Drawing.Point(26, 58);
            this.btn_guardar_per.Name = "btn_guardar_per";
            this.btn_guardar_per.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_per.TabIndex = 150;
            this.btn_guardar_per.Text = "GUARDAR";
            this.btn_guardar_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_per.UseVisualStyleBackColor = true;
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(696, 12);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(103, 100);
            this.pic_logo.TabIndex = 148;
            this.pic_logo.TabStop = false;
            // 
            // frm_per
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(806, 511);
            this.Controls.Add(this.btn_busc_id_per);
            this.Controls.Add(this.txt_busc_id_per);
            this.Controls.Add(this.lbl_busca_per);
            this.Controls.Add(this.grb_vista_per);
            this.Controls.Add(this.grb_datos2_per);
            this.Controls.Add(this.grb_datos1_per);
            this.Controls.Add(this.btn_elim_per);
            this.Controls.Add(this.btn_actlz_per);
            this.Controls.Add(this.btn_guardar_per);
            this.Controls.Add(this.Lbl_permiso);
            this.Controls.Add(this.pic_logo);
            this.Name = "frm_per";
            this.Text = "Permiso";
            this.grb_vista_per.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_per)).EndInit();
            this.grb_datos2_per.ResumeLayout(false);
            this.grb_datos2_per.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_id_usur_per)).EndInit();
            this.grb_datos1_per.ResumeLayout(false);
            this.grb_datos1_per.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_busc_id_per;
        internal System.Windows.Forms.TextBox txt_busc_id_per;
        internal System.Windows.Forms.Label lbl_busca_per;
        private System.Windows.Forms.GroupBox grb_vista_per;
        private System.Windows.Forms.DataGridView dgv_busc_per;
        private System.Windows.Forms.GroupBox grb_datos2_per;
        private System.Windows.Forms.DataGridView dgv_id_usur_per;
        private System.Windows.Forms.Button btn_busc_id_usur_per;
        internal System.Windows.Forms.Label Lbl_id_usur_per;
        internal System.Windows.Forms.TextBox txt_busc_id_usur_per;
        private System.Windows.Forms.GroupBox grb_datos1_per;
        internal System.Windows.Forms.Label Lbl_id_usur;
        internal System.Windows.Forms.TextBox txt_usur_per;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_descr_per;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre_per;
        private System.Windows.Forms.Button btn_elim_per;
        private System.Windows.Forms.Button btn_actlz_per;
        private System.Windows.Forms.Button btn_guardar_per;
        internal System.Windows.Forms.Label Lbl_permiso;
        internal System.Windows.Forms.PictureBox pic_logo;
        internal System.Windows.Forms.TextBox txt_id_per;
        internal System.Windows.Forms.Label Lbl_id_per;
    }
}