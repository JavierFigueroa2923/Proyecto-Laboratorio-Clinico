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
            this.btn_elim_cotz = new System.Windows.Forms.Button();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.btn_busc_cotz = new System.Windows.Forms.Button();
            this.btn_actlz_cotz = new System.Windows.Forms.Button();
            this.btn_guardar_cotz = new System.Windows.Forms.Button();
            this.gpb_vista_ctzn = new System.Windows.Forms.GroupBox();
            this.dgv_vista_ctzn = new System.Windows.Forms.DataGridView();
            this.gpb_datos_ctzn = new System.Windows.Forms.GroupBox();
            this.dtp_fec_cotz = new System.Windows.Forms.DateTimePicker();
            this.cbo_id_clnt = new System.Windows.Forms.ComboBox();
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nom_sumin = new System.Windows.Forms.Label();
            this.Lbl_id_inventario = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.txt_busc_cotz = new System.Windows.Forms.TextBox();
            this.btn_nueva_cotz = new System.Windows.Forms.Button();
            this.btn_acept_cotz = new System.Windows.Forms.Button();
            this.btn_cancl_cotz = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_imp_cotz = new System.Windows.Forms.Button();
            this.gpb_vista_ctzn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_ctzn)).BeginInit();
            this.gpb_datos_ctzn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_elim_cotz
            // 
            this.btn_elim_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_cotz.FlatAppearance.BorderSize = 0;
            this.btn_elim_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_cotz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_cotz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_cotz.Location = new System.Drawing.Point(225, 71);
            this.btn_elim_cotz.Name = "btn_elim_cotz";
            this.btn_elim_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_cotz.TabIndex = 150;
            this.btn_elim_cotz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_cotz, "Eliminar");
            this.btn_elim_cotz.UseVisualStyleBackColor = true;
            this.btn_elim_cotz.Click += new System.EventHandler(this.btn_elim_cotz_Click);
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
            // btn_busc_cotz
            // 
            this.btn_busc_cotz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_cotz.FlatAppearance.BorderSize = 0;
            this.btn_busc_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_cotz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_cotz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_cotz.Location = new System.Drawing.Point(296, 71);
            this.btn_busc_cotz.Name = "btn_busc_cotz";
            this.btn_busc_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_cotz.TabIndex = 149;
            this.btn_busc_cotz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_cotz, "Buscar");
            this.btn_busc_cotz.UseVisualStyleBackColor = true;
            this.btn_busc_cotz.Click += new System.EventHandler(this.btn_busc_cotz_Click);
            // 
            // btn_actlz_cotz
            // 
            this.btn_actlz_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_cotz.FlatAppearance.BorderSize = 0;
            this.btn_actlz_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_cotz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_cotz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_cotz.Location = new System.Drawing.Point(154, 71);
            this.btn_actlz_cotz.Name = "btn_actlz_cotz";
            this.btn_actlz_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_cotz.TabIndex = 148;
            this.btn_actlz_cotz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_cotz, "Modificar");
            this.btn_actlz_cotz.UseVisualStyleBackColor = true;
            this.btn_actlz_cotz.Click += new System.EventHandler(this.btn_actlz_cotzClick);
            // 
            // btn_guardar_cotz
            // 
            this.btn_guardar_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_cotz.FlatAppearance.BorderSize = 0;
            this.btn_guardar_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_cotz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_cotz.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_cotz.Location = new System.Drawing.Point(83, 71);
            this.btn_guardar_cotz.Name = "btn_guardar_cotz";
            this.btn_guardar_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_cotz.TabIndex = 147;
            this.btn_guardar_cotz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_cotz, "Guardar");
            this.btn_guardar_cotz.UseVisualStyleBackColor = true;
            this.btn_guardar_cotz.Click += new System.EventHandler(this.btn_guardar_cotz_Click);
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
            this.gpb_datos_ctzn.Controls.Add(this.dtp_fec_cotz);
            this.gpb_datos_ctzn.Controls.Add(this.cbo_id_clnt);
            this.gpb_datos_ctzn.Controls.Add(this.cbo_id_lab);
            this.gpb_datos_ctzn.Controls.Add(this.txt_descuento);
            this.gpb_datos_ctzn.Controls.Add(this.label4);
            this.gpb_datos_ctzn.Controls.Add(this.txt_total);
            this.gpb_datos_ctzn.Controls.Add(this.label3);
            this.gpb_datos_ctzn.Controls.Add(this.label1);
            this.gpb_datos_ctzn.Controls.Add(this.lbl_nom_sumin);
            this.gpb_datos_ctzn.Controls.Add(this.Lbl_id_inventario);
            this.gpb_datos_ctzn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_ctzn.Location = new System.Drawing.Point(12, 164);
            this.gpb_datos_ctzn.Name = "gpb_datos_ctzn";
            this.gpb_datos_ctzn.Size = new System.Drawing.Size(423, 221);
            this.gpb_datos_ctzn.TabIndex = 143;
            this.gpb_datos_ctzn.TabStop = false;
            this.gpb_datos_ctzn.Text = "Descripcion";
            // 
            // dtp_fec_cotz
            // 
            this.dtp_fec_cotz.Location = new System.Drawing.Point(118, 101);
            this.dtp_fec_cotz.Name = "dtp_fec_cotz";
            this.dtp_fec_cotz.Size = new System.Drawing.Size(297, 23);
            this.dtp_fec_cotz.TabIndex = 77;
            // 
            // cbo_id_clnt
            // 
            this.cbo_id_clnt.FormattingEnabled = true;
            this.cbo_id_clnt.Location = new System.Drawing.Point(118, 66);
            this.cbo_id_clnt.Name = "cbo_id_clnt";
            this.cbo_id_clnt.Size = new System.Drawing.Size(297, 24);
            this.cbo_id_clnt.TabIndex = 76;
            this.cbo_id_clnt.SelectedIndexChanged += new System.EventHandler(this.cbo_id_clnt_SelectedIndexChanged);
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(118, 33);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(299, 24);
            this.cbo_id_lab.TabIndex = 75;
            this.cbo_id_lab.SelectedIndexChanged += new System.EventHandler(this.cbo_id_lab_SelectedIndexChanged);
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(118, 171);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(297, 23);
            this.txt_descuento.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Descuento:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(118, 137);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(297, 23);
            this.txt_total.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Total: (Q.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Fecha:";
            // 
            // lbl_nom_sumin
            // 
            this.lbl_nom_sumin.AutoSize = true;
            this.lbl_nom_sumin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_sumin.Location = new System.Drawing.Point(32, 69);
            this.lbl_nom_sumin.Name = "lbl_nom_sumin";
            this.lbl_nom_sumin.Size = new System.Drawing.Size(84, 20);
            this.lbl_nom_sumin.TabIndex = 60;
            this.lbl_nom_sumin.Text = "Id Cliente:";
            // 
            // Lbl_id_inventario
            // 
            this.Lbl_id_inventario.AutoSize = true;
            this.Lbl_id_inventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_inventario.Location = new System.Drawing.Point(6, 31);
            this.Lbl_id_inventario.Name = "Lbl_id_inventario";
            this.Lbl_id_inventario.Size = new System.Drawing.Size(113, 20);
            this.Lbl_id_inventario.TabIndex = 57;
            this.Lbl_id_inventario.Text = "Id laboratorio:";
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
            // txt_busc_cotz
            // 
            this.txt_busc_cotz.Location = new System.Drawing.Point(634, 132);
            this.txt_busc_cotz.Name = "txt_busc_cotz";
            this.txt_busc_cotz.Size = new System.Drawing.Size(287, 26);
            this.txt_busc_cotz.TabIndex = 146;
            this.txt_busc_cotz.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_cotz_KeyUp);
            // 
            // btn_nueva_cotz
            // 
            this.btn_nueva_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nueva_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva_cotz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nueva_cotz.FlatAppearance.BorderSize = 0;
            this.btn_nueva_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva_cotz.Location = new System.Drawing.Point(12, 71);
            this.btn_nueva_cotz.Name = "btn_nueva_cotz";
            this.btn_nueva_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_nueva_cotz.TabIndex = 151;
            this.toolTip1.SetToolTip(this.btn_nueva_cotz, "Nuevo");
            this.btn_nueva_cotz.UseVisualStyleBackColor = true;
            this.btn_nueva_cotz.Click += new System.EventHandler(this.btn_nuevo_cotz_Click);
            // 
            // btn_acept_cotz
            // 
            this.btn_acept_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.check_icon;
            this.btn_acept_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acept_cotz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acept_cotz.Enabled = false;
            this.btn_acept_cotz.FlatAppearance.BorderSize = 0;
            this.btn_acept_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acept_cotz.Location = new System.Drawing.Point(441, 71);
            this.btn_acept_cotz.Name = "btn_acept_cotz";
            this.btn_acept_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_acept_cotz.TabIndex = 153;
            this.toolTip7.SetToolTip(this.btn_acept_cotz, "Aceptar");
            this.btn_acept_cotz.UseVisualStyleBackColor = true;
            this.btn_acept_cotz.Click += new System.EventHandler(this.btn_acept_cotz_Click);
            // 
            // btn_cancl_cotz
            // 
            this.btn_cancl_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete_icon;
            this.btn_cancl_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancl_cotz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancl_cotz.Enabled = false;
            this.btn_cancl_cotz.FlatAppearance.BorderSize = 0;
            this.btn_cancl_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancl_cotz.Location = new System.Drawing.Point(370, 71);
            this.btn_cancl_cotz.Name = "btn_cancl_cotz";
            this.btn_cancl_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl_cotz.TabIndex = 152;
            this.toolTip6.SetToolTip(this.btn_cancl_cotz, "Cancelar");
            this.btn_cancl_cotz.UseVisualStyleBackColor = true;
            this.btn_cancl_cotz.Click += new System.EventHandler(this.btn_cancl_cotz_Click);
            // 
            // btn_imp_cotz
            // 
            this.btn_imp_cotz.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.printer_icon;
            this.btn_imp_cotz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imp_cotz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imp_cotz.Enabled = false;
            this.btn_imp_cotz.FlatAppearance.BorderSize = 0;
            this.btn_imp_cotz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imp_cotz.Location = new System.Drawing.Point(514, 71);
            this.btn_imp_cotz.Name = "btn_imp_cotz";
            this.btn_imp_cotz.Size = new System.Drawing.Size(65, 65);
            this.btn_imp_cotz.TabIndex = 154;
            this.toolTip7.SetToolTip(this.btn_imp_cotz, "Aceptar");
            this.btn_imp_cotz.UseVisualStyleBackColor = true;
            this.btn_imp_cotz.Click += new System.EventHandler(this.btn_imp_cotz_Click);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 514);
            this.Controls.Add(this.btn_imp_cotz);
            this.Controls.Add(this.btn_acept_cotz);
            this.Controls.Add(this.btn_cancl_cotz);
            this.Controls.Add(this.btn_nueva_cotz);
            this.Controls.Add(this.btn_elim_cotz);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_cotz);
            this.Controls.Add(this.txt_busc_cotz);
            this.Controls.Add(this.btn_actlz_cotz);
            this.Controls.Add(this.btn_guardar_cotz);
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

        private System.Windows.Forms.Button btn_elim_cotz;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        private System.Windows.Forms.Button btn_busc_cotz;
        private System.Windows.Forms.Button btn_actlz_cotz;
        private System.Windows.Forms.Button btn_guardar_cotz;
        private System.Windows.Forms.GroupBox gpb_vista_ctzn;
        private System.Windows.Forms.DataGridView dgv_vista_ctzn;
        private System.Windows.Forms.GroupBox gpb_datos_ctzn;
        internal System.Windows.Forms.TextBox txt_descuento;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txt_total;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lbl_nom_sumin;
        internal System.Windows.Forms.Label Lbl_id_inventario;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        internal System.Windows.Forms.TextBox txt_busc_cotz;
        private System.Windows.Forms.ComboBox cbo_id_clnt;
        private System.Windows.Forms.ComboBox cbo_id_lab;
        private System.Windows.Forms.Button btn_nueva_cotz;
        private System.Windows.Forms.Button btn_acept_cotz;
        private System.Windows.Forms.Button btn_cancl_cotz;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Button btn_imp_cotz;
        private System.Windows.Forms.DateTimePicker dtp_fec_cotz;
    }
}