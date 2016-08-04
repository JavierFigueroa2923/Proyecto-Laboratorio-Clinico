using System;

namespace WindowsFormsApplication1
{
    partial class frm_permiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_permiso));
            this.txt_busc_id_per = new System.Windows.Forms.TextBox();
            this.lbl_busca_per = new System.Windows.Forms.Label();
            this.grb_vista_per = new System.Windows.Forms.GroupBox();
            this.dgv_busc_per = new System.Windows.Forms.DataGridView();
            this.grb_datos1_per = new System.Windows.Forms.GroupBox();
            this.txt_id_per = new System.Windows.Forms.TextBox();
            this.Lbl_id_per = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descr_per = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre_per = new System.Windows.Forms.TextBox();
            this.Lbl_permiso = new System.Windows.Forms.Label();
            this.btn_busc_id_per = new System.Windows.Forms.Button();
            this.btn_elim_per = new System.Windows.Forms.Button();
            this.btn_actlz_per = new System.Windows.Forms.Button();
            this.btn_guardar_per = new System.Windows.Forms.Button();
            this.btn_rnv_per = new System.Windows.Forms.Button();
            this.pl_lab_user = new System.Windows.Forms.PictureBox();
            this.grb_vista_per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_per)).BeginInit();
            this.grb_datos1_per.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_user)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busc_id_per
            // 
            this.txt_busc_id_per.Location = new System.Drawing.Point(177, 341);
            this.txt_busc_id_per.Name = "txt_busc_id_per";
            this.txt_busc_id_per.Size = new System.Drawing.Size(473, 20);
            this.txt_busc_id_per.TabIndex = 167;
            this.txt_busc_id_per.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_busquedapermiso_KeyUp);
            // 
            // lbl_busca_per
            // 
            this.lbl_busca_per.AutoSize = true;
            this.lbl_busca_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_per.Location = new System.Drawing.Point(42, 338);
            this.lbl_busca_per.Name = "lbl_busca_per";
            this.lbl_busca_per.Size = new System.Drawing.Size(128, 20);
            this.lbl_busca_per.TabIndex = 166;
            this.lbl_busca_per.Text = "Buscar Permisos:";
            // 
            // grb_vista_per
            // 
            this.grb_vista_per.Controls.Add(this.dgv_busc_per);
            this.grb_vista_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_per.Location = new System.Drawing.Point(57, 361);
            this.grb_vista_per.Name = "grb_vista_per";
            this.grb_vista_per.Size = new System.Drawing.Size(754, 163);
            this.grb_vista_per.TabIndex = 168;
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
            // grb_datos1_per
            // 
            this.grb_datos1_per.Controls.Add(this.txt_id_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_id_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_descripcion);
            this.grb_datos1_per.Controls.Add(this.txt_descr_per);
            this.grb_datos1_per.Controls.Add(this.Lbl_nombre);
            this.grb_datos1_per.Controls.Add(this.txt_nombre_per);
            this.grb_datos1_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_per.Location = new System.Drawing.Point(18, 140);
            this.grb_datos1_per.Name = "grb_datos1_per";
            this.grb_datos1_per.Size = new System.Drawing.Size(716, 173);
            this.grb_datos1_per.TabIndex = 164;
            this.grb_datos1_per.TabStop = false;
            this.grb_datos1_per.Text = "Datos de permiso";
            // 
            // txt_id_per
            // 
            this.txt_id_per.Location = new System.Drawing.Point(102, 22);
            this.txt_id_per.Name = "txt_id_per";
            this.txt_id_per.Size = new System.Drawing.Size(115, 23);
            this.txt_id_per.TabIndex = 91;
            // 
            // Lbl_id_per
            // 
            this.Lbl_id_per.AutoSize = true;
            this.Lbl_id_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_per.Location = new System.Drawing.Point(6, 22);
            this.Lbl_id_per.Name = "Lbl_id_per";
            this.Lbl_id_per.Size = new System.Drawing.Size(92, 20);
            this.Lbl_id_per.TabIndex = 90;
            this.Lbl_id_per.Text = "Id Permiso: ";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(-4, 83);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 85;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_descr_per
            // 
            this.txt_descr_per.Location = new System.Drawing.Point(102, 83);
            this.txt_descr_per.Multiline = true;
            this.txt_descr_per.Name = "txt_descr_per";
            this.txt_descr_per.Size = new System.Drawing.Size(581, 69);
            this.txt_descr_per.TabIndex = 82;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(24, 54);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 81;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre_per
            // 
            this.txt_nombre_per.Location = new System.Drawing.Point(102, 54);
            this.txt_nombre_per.Name = "txt_nombre_per";
            this.txt_nombre_per.Size = new System.Drawing.Size(581, 23);
            this.txt_nombre_per.TabIndex = 80;
            // 
            // Lbl_permiso
            // 
            this.Lbl_permiso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_permiso.AutoSize = true;
            this.Lbl_permiso.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_permiso.Location = new System.Drawing.Point(332, 34);
            this.Lbl_permiso.Name = "Lbl_permiso";
            this.Lbl_permiso.Size = new System.Drawing.Size(133, 34);
            this.Lbl_permiso.TabIndex = 160;
            this.Lbl_permiso.Text = "Permisos";
            // 
            // btn_busc_id_per
            // 
            this.btn_busc_id_per.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_per.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_per.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_id_per.Location = new System.Drawing.Point(656, 329);
            this.btn_busc_id_per.Name = "btn_busc_id_per";
            this.btn_busc_id_per.Size = new System.Drawing.Size(103, 40);
            this.btn_busc_id_per.TabIndex = 169;
            this.btn_busc_id_per.Text = "BUSCAR";
            this.btn_busc_id_per.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_per.UseVisualStyleBackColor = true;
            this.btn_busc_id_per.Click += new System.EventHandler(this.btn_busc_id_per_Click);
            // 
            // btn_elim_per
            // 
            this.btn_elim_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_per.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_per.Location = new System.Drawing.Point(241, 80);
            this.btn_elim_per.Name = "btn_elim_per";
            this.btn_elim_per.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_per.TabIndex = 163;
            this.btn_elim_per.Text = "ELIMINAR";
            this.btn_elim_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_per.UseVisualStyleBackColor = true;
            this.btn_elim_per.Click += new System.EventHandler(this.btn_elim_per_Click);
            // 
            // btn_actlz_per
            // 
            this.btn_actlz_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_per.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_per.Location = new System.Drawing.Point(141, 80);
            this.btn_actlz_per.Name = "btn_actlz_per";
            this.btn_actlz_per.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_per.TabIndex = 162;
            this.btn_actlz_per.Text = "ACTUALIZAR";
            this.btn_actlz_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_per.UseVisualStyleBackColor = true;
            this.btn_actlz_per.Click += new System.EventHandler(this.btn_actlz_per_Click);
            // 
            // btn_guardar_per
            // 
            this.btn_guardar_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_per.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_per.Location = new System.Drawing.Point(41, 80);
            this.btn_guardar_per.Name = "btn_guardar_per";
            this.btn_guardar_per.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_per.TabIndex = 161;
            this.btn_guardar_per.Text = "GUARDAR";
            this.btn_guardar_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_per.UseVisualStyleBackColor = true;
            this.btn_guardar_per.Click += new System.EventHandler(this.btn_guardar_per_Click);
            // 
            // btn_rnv_per
            // 
            this.btn_rnv_per.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rnv_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rnv_per.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_rnv_per.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rnv_per.Location = new System.Drawing.Point(761, 319);
            this.btn_rnv_per.Name = "btn_rnv_per";
            this.btn_rnv_per.Size = new System.Drawing.Size(63, 50);
            this.btn_rnv_per.TabIndex = 170;
            this.btn_rnv_per.Text = "RENOVAR";
            this.btn_rnv_per.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rnv_per.UseVisualStyleBackColor = true;
            this.btn_rnv_per.Click += new System.EventHandler(this.btn_rnv_per_Click);
            // 
            // pl_lab_user
            // 
            this.pl_lab_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_lab_user.Image = ((System.Drawing.Image)(resources.GetObject("pl_lab_user.Image")));
            this.pl_lab_user.Location = new System.Drawing.Point(724, 12);
            this.pl_lab_user.Name = "pl_lab_user";
            this.pl_lab_user.Size = new System.Drawing.Size(100, 105);
            this.pl_lab_user.TabIndex = 171;
            this.pl_lab_user.TabStop = false;
            // 
            // frm_permiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(828, 539);
            this.Controls.Add(this.pl_lab_user);
            this.Controls.Add(this.btn_rnv_per);
            this.Controls.Add(this.btn_busc_id_per);
            this.Controls.Add(this.txt_busc_id_per);
            this.Controls.Add(this.lbl_busca_per);
            this.Controls.Add(this.grb_vista_per);
            this.Controls.Add(this.grb_datos1_per);
            this.Controls.Add(this.btn_elim_per);
            this.Controls.Add(this.btn_actlz_per);
            this.Controls.Add(this.btn_guardar_per);
            this.Controls.Add(this.Lbl_permiso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_permiso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permiso";
            this.Load += new System.EventHandler(this.frm_permiso_Load);
            this.grb_vista_per.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_per)).EndInit();
            this.grb_datos1_per.ResumeLayout(false);
            this.grb_datos1_per.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btn_busc_id_per;
        internal System.Windows.Forms.TextBox txt_busc_id_per;
        internal System.Windows.Forms.Label lbl_busca_per;
        private System.Windows.Forms.GroupBox grb_vista_per;
        private System.Windows.Forms.DataGridView dgv_busc_per;
        private System.Windows.Forms.GroupBox grb_datos1_per;
        internal System.Windows.Forms.TextBox txt_id_per;
        internal System.Windows.Forms.Label Lbl_id_per;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_descr_per;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre_per;
        private System.Windows.Forms.Button btn_elim_per;
        private System.Windows.Forms.Button btn_actlz_per;
        private System.Windows.Forms.Button btn_guardar_per;
        internal System.Windows.Forms.Label Lbl_permiso;
        private System.Windows.Forms.Button btn_rnv_per;
        internal System.Windows.Forms.PictureBox pl_lab_user;
    }
}