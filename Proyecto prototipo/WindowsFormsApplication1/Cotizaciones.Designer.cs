namespace WindowsFormsApplication1
{
    partial class Cotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizacion));
            this.btn_elim_inv_sumin = new System.Windows.Forms.Button();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.btn_busc_tip_exam = new System.Windows.Forms.Button();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.gpb_vista_ctzn = new System.Windows.Forms.GroupBox();
            this.dgv_vista_ctzn = new System.Windows.Forms.DataGridView();
            this.gpb_datos_ctzn = new System.Windows.Forms.GroupBox();
            this.cbo_id_clnt = new System.Windows.Forms.ComboBox();
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nom_sumin = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.Lbl_id_inventario = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.txt_busc_fact = new System.Windows.Forms.TextBox();
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
            this.gpb_vista_ctzn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_ctzn)).BeginInit();
            this.gpb_datos_ctzn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_elim_inv_sumin
            // 
            this.btn_elim_inv_sumin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_inv_sumin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_inv_sumin.FlatAppearance.BorderSize = 0;
            this.btn_elim_inv_sumin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_inv_sumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_inv_sumin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_inv_sumin.Location = new System.Drawing.Point(225, 71);
            this.btn_elim_inv_sumin.Name = "btn_elim_inv_sumin";
            this.btn_elim_inv_sumin.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_inv_sumin.TabIndex = 150;
            this.btn_elim_inv_sumin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_inv_sumin, "Eliminar");
            this.btn_elim_inv_sumin.UseVisualStyleBackColor = true;
            this.btn_elim_inv_sumin.Click += new System.EventHandler(this.btn_elim_inv_sumin_Click);
            // 
            // lbl_busc_tip_exam
            // 
            this.lbl_busc_tip_exam.AutoSize = true;
            this.lbl_busc_tip_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(538, 135);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 145;
            this.lbl_busc_tip_exam.Text = "Buscar:";
            // 
            // btn_busc_tip_exam
            // 
            this.btn_busc_tip_exam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_tip_exam.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_tip_exam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_tip_exam.FlatAppearance.BorderSize = 0;
            this.btn_busc_tip_exam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_tip_exam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_tip_exam.Location = new System.Drawing.Point(296, 71);
            this.btn_busc_tip_exam.Name = "btn_busc_tip_exam";
            this.btn_busc_tip_exam.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_tip_exam.TabIndex = 149;
            this.btn_busc_tip_exam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_tip_exam, "Buscar");
            this.btn_busc_tip_exam.UseVisualStyleBackColor = true;
            this.btn_busc_tip_exam.Click += new System.EventHandler(this.btn_busc_tip_exam_Click);
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_aseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_aseg.FlatAppearance.BorderSize = 0;
            this.btn_actlz_aseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(154, 71);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_aseg.TabIndex = 148;
            this.btn_actlz_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_aseg, "Modificar");
            this.btn_actlz_aseg.UseVisualStyleBackColor = true;
            this.btn_actlz_aseg.Click += new System.EventHandler(this.btn_actlz_aseg_Click);
            // 
            // btn_guardar_aseg
            // 
            this.btn_guardar_aseg.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_aseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_aseg.FlatAppearance.BorderSize = 0;
            this.btn_guardar_aseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_aseg.Location = new System.Drawing.Point(83, 71);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_aseg.TabIndex = 147;
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_aseg, "Guardar");
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            this.btn_guardar_aseg.Click += new System.EventHandler(this.btn_guardar_aseg_Click);
            // 
            // gpb_vista_ctzn
            // 
            this.gpb_vista_ctzn.Controls.Add(this.dgv_vista_ctzn);
            this.gpb_vista_ctzn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_ctzn.Location = new System.Drawing.Point(466, 164);
            this.gpb_vista_ctzn.Name = "gpb_vista_ctzn";
            this.gpb_vista_ctzn.Size = new System.Drawing.Size(509, 337);
            this.gpb_vista_ctzn.TabIndex = 144;
            this.gpb_vista_ctzn.TabStop = false;
            this.gpb_vista_ctzn.Text = "Cotizaciones";
            // 
            // dgv_vista_ctzn
            // 
            this.dgv_vista_ctzn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_ctzn.Location = new System.Drawing.Point(12, 22);
            this.dgv_vista_ctzn.Name = "dgv_vista_ctzn";
            this.dgv_vista_ctzn.Size = new System.Drawing.Size(491, 306);
            this.dgv_vista_ctzn.TabIndex = 0;
            // 
            // gpb_datos_ctzn
            // 
            this.gpb_datos_ctzn.Controls.Add(this.cbo_id_clnt);
            this.gpb_datos_ctzn.Controls.Add(this.cbo_id_lab);
            this.gpb_datos_ctzn.Controls.Add(this.txt_descuento);
            this.gpb_datos_ctzn.Controls.Add(this.label4);
            this.gpb_datos_ctzn.Controls.Add(this.txt_total);
            this.gpb_datos_ctzn.Controls.Add(this.label3);
            this.gpb_datos_ctzn.Controls.Add(this.txt_fecha);
            this.gpb_datos_ctzn.Controls.Add(this.label1);
            this.gpb_datos_ctzn.Controls.Add(this.lbl_nom_sumin);
            this.gpb_datos_ctzn.Controls.Add(this.txt_cliente);
            this.gpb_datos_ctzn.Controls.Add(this.Lbl_id_inventario);
            this.gpb_datos_ctzn.Controls.Add(this.Lbl_descripcion);
            this.gpb_datos_ctzn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_ctzn.Location = new System.Drawing.Point(12, 164);
            this.gpb_datos_ctzn.Name = "gpb_datos_ctzn";
            this.gpb_datos_ctzn.Size = new System.Drawing.Size(423, 245);
            this.gpb_datos_ctzn.TabIndex = 143;
            this.gpb_datos_ctzn.TabStop = false;
            this.gpb_datos_ctzn.Text = "Descripcion";
            // 
            // cbo_id_clnt
            // 
            this.cbo_id_clnt.FormattingEnabled = true;
            this.cbo_id_clnt.Location = new System.Drawing.Point(118, 72);
            this.cbo_id_clnt.Name = "cbo_id_clnt";
            this.cbo_id_clnt.Size = new System.Drawing.Size(297, 24);
            this.cbo_id_clnt.TabIndex = 76;
            this.cbo_id_clnt.SelectedIndexChanged += new System.EventHandler(this.cbo_id_clnt_SelectedIndexChanged);
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(150, 42);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(267, 24);
            this.cbo_id_lab.TabIndex = 75;
            this.cbo_id_lab.SelectedIndexChanged += new System.EventHandler(this.cbo_id_lab_SelectedIndexChanged);
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(118, 202);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(297, 23);
            this.txt_descuento.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Descuento:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(118, 168);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(297, 23);
            this.txt_total.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Total: (Q.)";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(118, 137);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(297, 23);
            this.txt_fecha.TabIndex = 67;
            this.txt_fecha.TextChanged += new System.EventHandler(this.txt_fecha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Fecha:";
            // 
            // lbl_nom_sumin
            // 
            this.lbl_nom_sumin.AutoSize = true;
            this.lbl_nom_sumin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_sumin.Location = new System.Drawing.Point(6, 78);
            this.lbl_nom_sumin.Name = "lbl_nom_sumin";
            this.lbl_nom_sumin.Size = new System.Drawing.Size(84, 20);
            this.lbl_nom_sumin.TabIndex = 60;
            this.lbl_nom_sumin.Text = "Id Cliente:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(118, 107);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(297, 23);
            this.txt_cliente.TabIndex = 55;
            // 
            // Lbl_id_inventario
            // 
            this.Lbl_id_inventario.AutoSize = true;
            this.Lbl_id_inventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_inventario.Location = new System.Drawing.Point(6, 49);
            this.Lbl_id_inventario.Name = "Lbl_id_inventario";
            this.Lbl_id_inventario.Size = new System.Drawing.Size(113, 20);
            this.Lbl_id_inventario.TabIndex = 57;
            this.Lbl_id_inventario.Text = "Id laboratorio:";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(6, 107);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(65, 20);
            this.Lbl_descripcion.TabIndex = 56;
            this.Lbl_descripcion.Text = "Cliente:";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(869, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 102);
            this.PictureBox1.TabIndex = 142;
            this.PictureBox1.TabStop = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(418, 12);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(161, 34);
            this.Lbl_titulo.TabIndex = 141;
            this.Lbl_titulo.Text = "Cotizacion";
            // 
            // txt_busc_fact
            // 
            this.txt_busc_fact.Location = new System.Drawing.Point(634, 132);
            this.txt_busc_fact.Name = "txt_busc_fact";
            this.txt_busc_fact.Size = new System.Drawing.Size(287, 26);
            this.txt_busc_fact.TabIndex = 146;
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(12, 71);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 151;
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
            this.btn_acept.Location = new System.Drawing.Point(441, 71);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 153;
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
            this.btn_cancl.Location = new System.Drawing.Point(370, 71);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 152;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_pcnt_Click);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 514);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.btn_elim_inv_sumin);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_tip_exam);
            this.Controls.Add(this.txt_busc_fact);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_ctzn);
            this.Controls.Add(this.gpb_datos_ctzn);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gpb_vista_ctzn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_ctzn)).EndInit();
            this.gpb_datos_ctzn.ResumeLayout(false);
            this.gpb_datos_ctzn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_elim_inv_sumin;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        private System.Windows.Forms.Button btn_busc_tip_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.GroupBox gpb_vista_ctzn;
        private System.Windows.Forms.DataGridView dgv_vista_ctzn;
        private System.Windows.Forms.GroupBox gpb_datos_ctzn;
        internal System.Windows.Forms.TextBox txt_descuento;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txt_total;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_fecha;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lbl_nom_sumin;
        internal System.Windows.Forms.TextBox txt_cliente;
        internal System.Windows.Forms.Label Lbl_id_inventario;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        internal System.Windows.Forms.TextBox txt_busc_fact;
        private System.Windows.Forms.ComboBox cbo_id_clnt;
        private System.Windows.Forms.ComboBox cbo_id_lab;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}