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
            this.Lbl_id_inventario = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_cant = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.gpb_datos_inv_sumin = new System.Windows.Forms.GroupBox();
            this.txt_prec_vent_inv_sumin = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txt_prec_comp_inv_sumin = new System.Windows.Forms.TextBox();
            this.lbl_prec_vent_inv_sumin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_nom_sumin = new System.Windows.Forms.Label();
            this.txt_id_inv_sumin = new System.Windows.Forms.TextBox();
            this.gpb_vista_inv_sumin = new System.Windows.Forms.GroupBox();
            this.dgv_vista_inv_sumin = new System.Windows.Forms.DataGridView();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.btn_busc_tip_exam = new System.Windows.Forms.Button();
            this.txt_busc_tips_exam = new System.Windows.Forms.TextBox();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.btn_elim_inv_sumin = new System.Windows.Forms.Button();
            this.cbo_id_laboratorio = new System.Windows.Forms.ComboBox();
            this.lbl_laboratorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.gpb_datos_inv_sumin.SuspendLayout();
            this.gpb_vista_inv_sumin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_inv_sumin)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id_inventario
            // 
            this.Lbl_id_inventario.AutoSize = true;
            this.Lbl_id_inventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_inventario.Location = new System.Drawing.Point(2, 26);
            this.Lbl_id_inventario.Name = "Lbl_id_inventario";
            this.Lbl_id_inventario.Size = new System.Drawing.Size(106, 20);
            this.Lbl_id_inventario.TabIndex = 57;
            this.Lbl_id_inventario.Text = "Id inventario:";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(2, 84);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 56;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(114, 84);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(297, 150);
            this.txt_direccion.TabIndex = 55;
            // 
            // Lbl_cant
            // 
            this.Lbl_cant.AutoSize = true;
            this.Lbl_cant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cant.Location = new System.Drawing.Point(6, 240);
            this.Lbl_cant.Name = "Lbl_cant";
            this.Lbl_cant.Size = new System.Drawing.Size(160, 20);
            this.Lbl_cant.TabIndex = 54;
            this.Lbl_cant.Text = "Cantidad disponible:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(172, 240);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(79, 23);
            this.txt_nombre.TabIndex = 53;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(830, 9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 102);
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(284, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(351, 34);
            this.Lbl_titulo.TabIndex = 51;
            this.Lbl_titulo.Text = "Inventario de Suministros";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // gpb_datos_inv_sumin
            // 
            this.gpb_datos_inv_sumin.Controls.Add(this.cbo_id_laboratorio);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl_laboratorio);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_prec_vent_inv_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_prec_comp_inv_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl_prec_vent_inv_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.textBox1);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl_nom_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_id_inv_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_direccion);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_nombre);
            this.gpb_datos_inv_sumin.Controls.Add(this.Lbl_id_inventario);
            this.gpb_datos_inv_sumin.Controls.Add(this.Lbl_cant);
            this.gpb_datos_inv_sumin.Controls.Add(this.Lbl_descripcion);
            this.gpb_datos_inv_sumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_inv_sumin.Location = new System.Drawing.Point(12, 120);
            this.gpb_datos_inv_sumin.Name = "gpb_datos_inv_sumin";
            this.gpb_datos_inv_sumin.Size = new System.Drawing.Size(423, 337);
            this.gpb_datos_inv_sumin.TabIndex = 60;
            this.gpb_datos_inv_sumin.TabStop = false;
            this.gpb_datos_inv_sumin.Text = "Informacion del Inventario";
            // 
            // txt_prec_vent_inv_sumin
            // 
            this.txt_prec_vent_inv_sumin.Location = new System.Drawing.Point(363, 273);
            this.txt_prec_vent_inv_sumin.Name = "txt_prec_vent_inv_sumin";
            this.txt_prec_vent_inv_sumin.Size = new System.Drawing.Size(46, 23);
            this.txt_prec_vent_inv_sumin.TabIndex = 63;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(248, 273);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(109, 20);
            this.lbl.TabIndex = 64;
            this.lbl.Text = "Precio Venta:";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_prec_comp_inv_sumin
            // 
            this.txt_prec_comp_inv_sumin.Location = new System.Drawing.Point(136, 273);
            this.txt_prec_comp_inv_sumin.Name = "txt_prec_comp_inv_sumin";
            this.txt_prec_comp_inv_sumin.Size = new System.Drawing.Size(46, 23);
            this.txt_prec_comp_inv_sumin.TabIndex = 61;
            // 
            // lbl_prec_vent_inv_sumin
            // 
            this.lbl_prec_vent_inv_sumin.AutoSize = true;
            this.lbl_prec_vent_inv_sumin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prec_vent_inv_sumin.Location = new System.Drawing.Point(6, 273);
            this.lbl_prec_vent_inv_sumin.Name = "lbl_prec_vent_inv_sumin";
            this.lbl_prec_vent_inv_sumin.Size = new System.Drawing.Size(124, 20);
            this.lbl_prec_vent_inv_sumin.TabIndex = 62;
            this.lbl_prec_vent_inv_sumin.Text = "Precio Compra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 23);
            this.textBox1.TabIndex = 59;
            // 
            // lbl_nom_sumin
            // 
            this.lbl_nom_sumin.AutoSize = true;
            this.lbl_nom_sumin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_sumin.Location = new System.Drawing.Point(2, 55);
            this.lbl_nom_sumin.Name = "lbl_nom_sumin";
            this.lbl_nom_sumin.Size = new System.Drawing.Size(146, 20);
            this.lbl_nom_sumin.TabIndex = 60;
            this.lbl_nom_sumin.Text = "Nombre Suministro:";
            // 
            // txt_id_inv_sumin
            // 
            this.txt_id_inv_sumin.Location = new System.Drawing.Point(114, 26);
            this.txt_id_inv_sumin.Name = "txt_id_inv_sumin";
            this.txt_id_inv_sumin.Size = new System.Drawing.Size(195, 23);
            this.txt_id_inv_sumin.TabIndex = 58;
            // 
            // gpb_vista_inv_sumin
            // 
            this.gpb_vista_inv_sumin.Controls.Add(this.dgv_vista_inv_sumin);
            this.gpb_vista_inv_sumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_inv_sumin.Location = new System.Drawing.Point(441, 120);
            this.gpb_vista_inv_sumin.Name = "gpb_vista_inv_sumin";
            this.gpb_vista_inv_sumin.Size = new System.Drawing.Size(489, 337);
            this.gpb_vista_inv_sumin.TabIndex = 61;
            this.gpb_vista_inv_sumin.TabStop = false;
            this.gpb_vista_inv_sumin.Text = "Suministros";
            // 
            // dgv_vista_inv_sumin
            // 
            this.dgv_vista_inv_sumin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_inv_sumin.Location = new System.Drawing.Point(6, 22);
            this.dgv_vista_inv_sumin.Name = "dgv_vista_inv_sumin";
            this.dgv_vista_inv_sumin.Size = new System.Drawing.Size(477, 306);
            this.dgv_vista_inv_sumin.TabIndex = 0;
            // 
            // lbl_busc_tip_exam
            // 
            this.lbl_busc_tip_exam.AutoSize = true;
            this.lbl_busc_tip_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(516, 101);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 135;
            this.lbl_busc_tip_exam.Text = "Buscar:";
            // 
            // btn_busc_tip_exam
            // 
            this.btn_busc_tip_exam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_tip_exam.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_tip_exam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_tip_exam.Location = new System.Drawing.Point(748, 86);
            this.btn_busc_tip_exam.Name = "btn_busc_tip_exam";
            this.btn_busc_tip_exam.Size = new System.Drawing.Size(76, 54);
            this.btn_busc_tip_exam.TabIndex = 139;
            this.btn_busc_tip_exam.Text = "BUSCAR";
            this.btn_busc_tip_exam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_tip_exam.UseVisualStyleBackColor = true;
            // 
            // txt_busc_tips_exam
            // 
            this.txt_busc_tips_exam.Location = new System.Drawing.Point(584, 103);
            this.txt_busc_tips_exam.Name = "txt_busc_tips_exam";
            this.txt_busc_tips_exam.Size = new System.Drawing.Size(158, 20);
            this.txt_busc_tips_exam.TabIndex = 136;
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(112, 60);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_aseg.TabIndex = 138;
            this.btn_actlz_aseg.Text = "ACTUALIZAR";
            this.btn_actlz_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_aseg.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_aseg
            // 
            this.btn_guardar_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_aseg.Location = new System.Drawing.Point(12, 60);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_aseg.TabIndex = 137;
            this.btn_guardar_aseg.Text = "GUARDAR";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            // 
            // btn_elim_inv_sumin
            // 
            this.btn_elim_inv_sumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_inv_sumin.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_inv_sumin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_inv_sumin.Location = new System.Drawing.Point(212, 60);
            this.btn_elim_inv_sumin.Name = "btn_elim_inv_sumin";
            this.btn_elim_inv_sumin.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_inv_sumin.TabIndex = 140;
            this.btn_elim_inv_sumin.Text = "ELIMINAR";
            this.btn_elim_inv_sumin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_inv_sumin.UseVisualStyleBackColor = true;
            // 
            // cbo_id_laboratorio
            // 
            this.cbo_id_laboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_id_laboratorio.FormattingEnabled = true;
            this.cbo_id_laboratorio.Location = new System.Drawing.Point(136, 308);
            this.cbo_id_laboratorio.Name = "cbo_id_laboratorio";
            this.cbo_id_laboratorio.Size = new System.Drawing.Size(121, 24);
            this.cbo_id_laboratorio.TabIndex = 66;
            // 
            // lbl_laboratorio
            // 
            this.lbl_laboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_laboratorio.AutoSize = true;
            this.lbl_laboratorio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbl_laboratorio.Location = new System.Drawing.Point(32, 308);
            this.lbl_laboratorio.Name = "lbl_laboratorio";
            this.lbl_laboratorio.Size = new System.Drawing.Size(98, 20);
            this.lbl_laboratorio.TabIndex = 65;
            this.lbl_laboratorio.Text = "Laboratorio:";
            // 
            // frm_act_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 481);
            this.Controls.Add(this.btn_elim_inv_sumin);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_tip_exam);
            this.Controls.Add(this.txt_busc_tips_exam);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_inv_sumin);
            this.Controls.Add(this.gpb_datos_inv_sumin);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_act_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suministros";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.gpb_datos_inv_sumin.ResumeLayout(false);
            this.gpb_datos_inv_sumin.PerformLayout();
            this.gpb_vista_inv_sumin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_inv_sumin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Lbl_id_inventario;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label Lbl_cant;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox gpb_datos_inv_sumin;
        internal System.Windows.Forms.TextBox txt_prec_vent_inv_sumin;
        internal System.Windows.Forms.Label lbl;
        internal System.Windows.Forms.TextBox txt_prec_comp_inv_sumin;
        internal System.Windows.Forms.Label lbl_prec_vent_inv_sumin;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label lbl_nom_sumin;
        internal System.Windows.Forms.TextBox txt_id_inv_sumin;
        private System.Windows.Forms.GroupBox gpb_vista_inv_sumin;
        private System.Windows.Forms.DataGridView dgv_vista_inv_sumin;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        private System.Windows.Forms.Button btn_busc_tip_exam;
        internal System.Windows.Forms.TextBox txt_busc_tips_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.Button btn_elim_inv_sumin;
        private System.Windows.Forms.ComboBox cbo_id_laboratorio;
        private System.Windows.Forms.Label lbl_laboratorio;
    }
}