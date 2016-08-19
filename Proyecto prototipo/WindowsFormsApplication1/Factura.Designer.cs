namespace WindowsFormsApplication1
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.btn_elim_inv_sumin = new System.Windows.Forms.Button();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.gpb_vista_fct = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_id_examen = new System.Windows.Forms.ComboBox();
            this.dgv_vista_fct = new System.Windows.Forms.DataGridView();
            this.gpb_datos_fct = new System.Windows.Forms.GroupBox();
            this.dtp_factura = new System.Windows.Forms.DateTimePicker();
            this.cbo_id_fp = new System.Windows.Forms.ComboBox();
            this.cbo_id_cliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nom_sumin = new System.Windows.Forms.Label();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.btn_nuevo_pcnt = new System.Windows.Forms.Button();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_renov = new System.Windows.Forms.Button();
            this.btn_busc = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb_vista_fct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_fct)).BeginInit();
            this.gpb_datos_fct.SuspendLayout();
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
            this.btn_elim_inv_sumin.Location = new System.Drawing.Point(235, 60);
            this.btn_elim_inv_sumin.Name = "btn_elim_inv_sumin";
            this.btn_elim_inv_sumin.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_inv_sumin.TabIndex = 148;
            this.btn_elim_inv_sumin.Text = " ";
            this.btn_elim_inv_sumin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_inv_sumin, "Eliminar");
            this.btn_elim_inv_sumin.UseVisualStyleBackColor = true;
            // 
            // lbl_busc_tip_exam
            // 
            this.lbl_busc_tip_exam.AutoSize = true;
            this.lbl_busc_tip_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(169, 22);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(70, 20);
            this.lbl_busc_tip_exam.TabIndex = 144;
            this.lbl_busc_tip_exam.Text = "Examen:";
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_aseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_aseg.FlatAppearance.BorderSize = 0;
            this.btn_actlz_aseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(164, 60);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_aseg.TabIndex = 147;
            this.btn_actlz_aseg.Text = " ";
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
            this.btn_guardar_aseg.Location = new System.Drawing.Point(93, 60);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_aseg.TabIndex = 146;
            this.btn_guardar_aseg.Text = " ";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_aseg, "Guardar");
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            this.btn_guardar_aseg.Click += new System.EventHandler(this.btn_guardar_aseg_Click);
            // 
            // gpb_vista_fct
            // 
            this.gpb_vista_fct.Controls.Add(this.button1);
            this.gpb_vista_fct.Controls.Add(this.txt_cantidad);
            this.gpb_vista_fct.Controls.Add(this.label5);
            this.gpb_vista_fct.Controls.Add(this.cbo_id_examen);
            this.gpb_vista_fct.Controls.Add(this.dgv_vista_fct);
            this.gpb_vista_fct.Controls.Add(this.lbl_busc_tip_exam);
            this.gpb_vista_fct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_fct.Location = new System.Drawing.Point(451, 131);
            this.gpb_vista_fct.Name = "gpb_vista_fct";
            this.gpb_vista_fct.Size = new System.Drawing.Size(489, 337);
            this.gpb_vista_fct.TabIndex = 143;
            this.gpb_vista_fct.TabStop = false;
            this.gpb_vista_fct.Text = "Detalle";
            this.gpb_vista_fct.Enter += new System.EventHandler(this.gpb_vista_fct_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(413, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 157;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip8.SetToolTip(this.button1, "Actualizar");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(98, 22);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(66, 23);
            this.txt_cantidad.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 156;
            this.label5.Text = "Cantidad:";
            // 
            // cbo_id_examen
            // 
            this.cbo_id_examen.FormattingEnabled = true;
            this.cbo_id_examen.Location = new System.Drawing.Point(245, 22);
            this.cbo_id_examen.Name = "cbo_id_examen";
            this.cbo_id_examen.Size = new System.Drawing.Size(152, 24);
            this.cbo_id_examen.TabIndex = 154;
            // 
            // dgv_vista_fct
            // 
            this.dgv_vista_fct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_fct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Examen,
            this.Precio,
            this.Id_Examen});
            this.dgv_vista_fct.Location = new System.Drawing.Point(6, 61);
            this.dgv_vista_fct.Name = "dgv_vista_fct";
            this.dgv_vista_fct.Size = new System.Drawing.Size(477, 267);
            this.dgv_vista_fct.TabIndex = 0;
            // 
            // gpb_datos_fct
            // 
            this.gpb_datos_fct.Controls.Add(this.dtp_factura);
            this.gpb_datos_fct.Controls.Add(this.cbo_id_fp);
            this.gpb_datos_fct.Controls.Add(this.cbo_id_cliente);
            this.gpb_datos_fct.Controls.Add(this.label4);
            this.gpb_datos_fct.Controls.Add(this.label2);
            this.gpb_datos_fct.Controls.Add(this.lbl_nom_sumin);
            this.gpb_datos_fct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_fct.Location = new System.Drawing.Point(22, 131);
            this.gpb_datos_fct.Name = "gpb_datos_fct";
            this.gpb_datos_fct.Size = new System.Drawing.Size(423, 337);
            this.gpb_datos_fct.TabIndex = 142;
            this.gpb_datos_fct.TabStop = false;
            this.gpb_datos_fct.Text = "Encabezado";
            // 
            // dtp_factura
            // 
            this.dtp_factura.Location = new System.Drawing.Point(118, 84);
            this.dtp_factura.Name = "dtp_factura";
            this.dtp_factura.Size = new System.Drawing.Size(297, 23);
            this.dtp_factura.TabIndex = 77;
            // 
            // cbo_id_fp
            // 
            this.cbo_id_fp.FormattingEnabled = true;
            this.cbo_id_fp.Location = new System.Drawing.Point(142, 113);
            this.cbo_id_fp.Name = "cbo_id_fp";
            this.cbo_id_fp.Size = new System.Drawing.Size(152, 24);
            this.cbo_id_fp.TabIndex = 76;
            // 
            // cbo_id_cliente
            // 
            this.cbo_id_cliente.FormattingEnabled = true;
            this.cbo_id_cliente.Location = new System.Drawing.Point(118, 45);
            this.cbo_id_cliente.Name = "cbo_id_cliente";
            this.cbo_id_cliente.Size = new System.Drawing.Size(297, 24);
            this.cbo_id_cliente.TabIndex = 75;
            this.cbo_id_cliente.SelectedIndexChanged += new System.EventHandler(this.cbo_id_cliente_SelectedIndexChanged);
            this.cbo_id_cliente.SelectedValueChanged += new System.EventHandler(this.cbo_id_cliente_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Forma de pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha:";
            // 
            // lbl_nom_sumin
            // 
            this.lbl_nom_sumin.AutoSize = true;
            this.lbl_nom_sumin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_sumin.Location = new System.Drawing.Point(6, 45);
            this.lbl_nom_sumin.Name = "lbl_nom_sumin";
            this.lbl_nom_sumin.Size = new System.Drawing.Size(84, 20);
            this.lbl_nom_sumin.TabIndex = 60;
            this.lbl_nom_sumin.Text = "Id Cliente:";
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(418, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(116, 34);
            this.Lbl_titulo.TabIndex = 141;
            this.Lbl_titulo.Text = "Factura";
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(22, 60);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 149;
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
            this.btn_acept.Location = new System.Drawing.Point(448, 60);
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
            this.btn_cancl.Location = new System.Drawing.Point(377, 60);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 152;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            // 
            // btn_renov
            // 
            this.btn_renov.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_renov.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_renov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_renov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_renov.FlatAppearance.BorderSize = 0;
            this.btn_renov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_renov.Location = new System.Drawing.Point(518, 60);
            this.btn_renov.Name = "btn_renov";
            this.btn_renov.Size = new System.Drawing.Size(65, 65);
            this.btn_renov.TabIndex = 151;
            this.btn_renov.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip8.SetToolTip(this.btn_renov, "Actualizar");
            this.btn_renov.UseVisualStyleBackColor = true;
            // 
            // btn_busc
            // 
            this.btn_busc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_busc.FlatAppearance.BorderSize = 0;
            this.btn_busc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc.Location = new System.Drawing.Point(306, 60);
            this.btn_busc.Name = "btn_busc";
            this.btn_busc.Size = new System.Drawing.Size(65, 65);
            this.btn_busc.TabIndex = 150;
            this.btn_busc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip5.SetToolTip(this.btn_busc, "Buscar");
            this.btn_busc.UseVisualStyleBackColor = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Examen
            // 
            this.Examen.HeaderText = "Examen";
            this.Examen.Name = "Examen";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Id_Examen
            // 
            this.Id_Examen.HeaderText = "Id_Examen";
            this.Id_Examen.Name = "Id_Examen";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 489);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_renov);
            this.Controls.Add(this.btn_busc);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.btn_elim_inv_sumin);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_fct);
            this.Controls.Add(this.gpb_datos_fct);
            this.Controls.Add(this.Lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.gpb_vista_fct.ResumeLayout(false);
            this.gpb_vista_fct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_fct)).EndInit();
            this.gpb_datos_fct.ResumeLayout(false);
            this.gpb_datos_fct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_elim_inv_sumin;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.GroupBox gpb_vista_fct;
        private System.Windows.Forms.DataGridView dgv_vista_fct;
        private System.Windows.Forms.GroupBox gpb_datos_fct;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lbl_nom_sumin;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_renov;
        private System.Windows.Forms.Button btn_busc;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ComboBox cbo_id_fp;
        private System.Windows.Forms.ComboBox cbo_id_cliente;
        private System.Windows.Forms.ComboBox cbo_id_examen;
        private System.Windows.Forms.DateTimePicker dtp_factura;
        internal System.Windows.Forms.TextBox txt_cantidad;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Examen;
    }
}