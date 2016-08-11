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
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nom_aseg = new System.Windows.Forms.TextBox();
            this.lbl_aseguradora = new System.Windows.Forms.Label();
            this.grb_ing_datos_aseg = new System.Windows.Forms.GroupBox();
            this.grb_datos_aseg = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_busc_aseg = new System.Windows.Forms.Button();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_busc_aseg = new System.Windows.Forms.Label();
            this.btn_elim_aseg = new System.Windows.Forms.Button();
            this.cbo_buscar = new System.Windows.Forms.ComboBox();
            this.txt_desc_aseg = new System.Windows.Forms.TextBox();
            this.lbl_desc_aseg = new System.Windows.Forms.Label();
            this.grb_ing_datos_aseg.SuspendLayout();
            this.grb_datos_aseg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Lbl_nombre.Location = new System.Drawing.Point(6, 19);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(66, 18);
            this.Lbl_nombre.TabIndex = 56;
            this.Lbl_nombre.Text = "Nombre:";
            this.Lbl_nombre.Click += new System.EventHandler(this.Lbl_nombre_Click);
            // 
            // txt_nom_aseg
            // 
            this.txt_nom_aseg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nom_aseg.Location = new System.Drawing.Point(9, 40);
            this.txt_nom_aseg.Name = "txt_nom_aseg";
            this.txt_nom_aseg.Size = new System.Drawing.Size(392, 23);
            this.txt_nom_aseg.TabIndex = 55;
            this.txt_nom_aseg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_aseg_KeyPress);
            // 
            // lbl_aseguradora
            // 
            this.lbl_aseguradora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_aseguradora.AutoSize = true;
            this.lbl_aseguradora.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aseguradora.Location = new System.Drawing.Point(183, 9);
            this.lbl_aseguradora.Name = "lbl_aseguradora";
            this.lbl_aseguradora.Size = new System.Drawing.Size(192, 34);
            this.lbl_aseguradora.TabIndex = 53;
            this.lbl_aseguradora.Text = "Aseguradora";
            // 
            // grb_ing_datos_aseg
            // 
            this.grb_ing_datos_aseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_ing_datos_aseg.Controls.Add(this.lbl_desc_aseg);
            this.grb_ing_datos_aseg.Controls.Add(this.txt_desc_aseg);
            this.grb_ing_datos_aseg.Controls.Add(this.txt_nom_aseg);
            this.grb_ing_datos_aseg.Controls.Add(this.Lbl_nombre);
            this.grb_ing_datos_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ing_datos_aseg.Location = new System.Drawing.Point(12, 116);
            this.grb_ing_datos_aseg.Name = "grb_ing_datos_aseg";
            this.grb_ing_datos_aseg.Size = new System.Drawing.Size(482, 177);
            this.grb_ing_datos_aseg.TabIndex = 65;
            this.grb_ing_datos_aseg.TabStop = false;
            this.grb_ing_datos_aseg.Text = "Ingreso de Datos";
            // 
            // grb_datos_aseg
            // 
            this.grb_datos_aseg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_datos_aseg.Controls.Add(this.dataGridView1);
            this.grb_datos_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos_aseg.Location = new System.Drawing.Point(12, 353);
            this.grb_datos_aseg.Name = "grb_datos_aseg";
            this.grb_datos_aseg.Size = new System.Drawing.Size(588, 205);
            this.grb_datos_aseg.TabIndex = 66;
            this.grb_datos_aseg.TabStop = false;
            this.grb_datos_aseg.Text = "Datos Actuales";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_busc_aseg
            // 
            this.btn_busc_aseg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_aseg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_aseg.Location = new System.Drawing.Point(510, 318);
            this.btn_busc_aseg.Name = "btn_busc_aseg";
            this.btn_busc_aseg.Size = new System.Drawing.Size(94, 40);
            this.btn_busc_aseg.TabIndex = 69;
            this.btn_busc_aseg.Text = "BUSCAR";
            this.btn_busc_aseg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_aseg.UseVisualStyleBackColor = true;
            this.btn_busc_aseg.Click += new System.EventHandler(this.btn_busc_aseg_Click);
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(112, 56);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_aseg.TabIndex = 68;
            this.btn_actlz_aseg.Text = "ACTUALIZAR";
            this.btn_actlz_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_aseg.UseVisualStyleBackColor = true;
            this.btn_actlz_aseg.Click += new System.EventHandler(this.btn_actlz_aseg_Click_1);
            // 
            // btn_guardar_aseg
            // 
            this.btn_guardar_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_aseg.Location = new System.Drawing.Point(12, 55);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_aseg.TabIndex = 67;
            this.btn_guardar_aseg.Text = "GUARDAR";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            this.btn_guardar_aseg.Click += new System.EventHandler(this.btn_guardar_aseg_Click_1);
            // 
            // Pic_logo
            // 
            this.Pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(504, 9);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 100);
            this.Pic_logo.TabIndex = 54;
            this.Pic_logo.TabStop = false;
            // 
            // lbl_busc_aseg
            // 
            this.lbl_busc_aseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_busc_aseg.AutoSize = true;
            this.lbl_busc_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_busc_aseg.Location = new System.Drawing.Point(18, 328);
            this.lbl_busc_aseg.Name = "lbl_busc_aseg";
            this.lbl_busc_aseg.Size = new System.Drawing.Size(225, 18);
            this.lbl_busc_aseg.TabIndex = 64;
            this.lbl_busc_aseg.Text = "Buscar Nombre de Aseguradora:";
            this.lbl_busc_aseg.Click += new System.EventHandler(this.lbl_busc_aseg_Click);
            // 
            // btn_elim_aseg
            // 
            this.btn_elim_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_aseg.Location = new System.Drawing.Point(212, 55);
            this.btn_elim_aseg.Name = "btn_elim_aseg";
            this.btn_elim_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_aseg.TabIndex = 161;
            this.btn_elim_aseg.Text = "ELIMINAR";
            this.btn_elim_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_aseg.UseVisualStyleBackColor = true;
            this.btn_elim_aseg.Click += new System.EventHandler(this.btn_elim_aseg_Click);
            // 
            // cbo_buscar
            // 
            this.cbo_buscar.FormattingEnabled = true;
            this.cbo_buscar.Location = new System.Drawing.Point(248, 328);
            this.cbo_buscar.Name = "cbo_buscar";
            this.cbo_buscar.Size = new System.Drawing.Size(246, 21);
            this.cbo_buscar.TabIndex = 162;
            // 
            // txt_desc_aseg
            // 
            this.txt_desc_aseg.Location = new System.Drawing.Point(9, 107);
            this.txt_desc_aseg.Multiline = true;
            this.txt_desc_aseg.Name = "txt_desc_aseg";
            this.txt_desc_aseg.Size = new System.Drawing.Size(392, 53);
            this.txt_desc_aseg.TabIndex = 59;
            // 
            // lbl_desc_aseg
            // 
            this.lbl_desc_aseg.AutoSize = true;
            this.lbl_desc_aseg.Location = new System.Drawing.Point(12, 76);
            this.lbl_desc_aseg.Name = "lbl_desc_aseg";
            this.lbl_desc_aseg.Size = new System.Drawing.Size(82, 17);
            this.lbl_desc_aseg.TabIndex = 60;
            this.lbl_desc_aseg.Text = "Descripción";
            // 
            // frm_act_aseg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 570);
            this.Controls.Add(this.cbo_buscar);
            this.Controls.Add(this.btn_elim_aseg);
            this.Controls.Add(this.lbl_busc_aseg);
            this.Controls.Add(this.btn_busc_aseg);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.grb_datos_aseg);
            this.Controls.Add(this.grb_ing_datos_aseg);
            this.Controls.Add(this.Pic_logo);
            this.Controls.Add(this.lbl_aseguradora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_act_aseg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aseguradora";
            this.Load += new System.EventHandler(this.frm_act_aseg_Load);
            this.grb_ing_datos_aseg.ResumeLayout(false);
            this.grb_ing_datos_aseg.PerformLayout();
            this.grb_datos_aseg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nom_aseg;
        internal System.Windows.Forms.PictureBox Pic_logo;
        internal System.Windows.Forms.Label lbl_aseguradora;
        private System.Windows.Forms.GroupBox grb_ing_datos_aseg;
        private System.Windows.Forms.GroupBox grb_datos_aseg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_busc_aseg;
        internal System.Windows.Forms.Label lbl_busc_aseg;
        private System.Windows.Forms.Button btn_elim_aseg;
        private System.Windows.Forms.ComboBox cbo_buscar;
        private System.Windows.Forms.Label lbl_desc_aseg;
        private System.Windows.Forms.TextBox txt_desc_aseg;
    }
}