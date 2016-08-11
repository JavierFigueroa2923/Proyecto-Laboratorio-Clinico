namespace WindowsFormsApplication1
{
    partial class Membresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membresia));
            this.lbl_membresia = new System.Windows.Forms.Label();
            this.gpb_ingreso_datos_mem = new System.Windows.Forms.GroupBox();
            this.cbo_id_clt_mem = new System.Windows.Forms.ComboBox();
            this.dtp_fec_expir_mem = new System.Windows.Forms.DateTimePicker();
            this.dtp_fec_crea_mem = new System.Windows.Forms.DateTimePicker();
            this.txt_beneficio_mem = new System.Windows.Forms.TextBox();
            this.lbl_fecha_expr_mem = new System.Windows.Forms.Label();
            this.lbl_fecha_expe_mem = new System.Windows.Forms.Label();
            this.lbl_benef_mem = new System.Windows.Forms.Label();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.btn_guardar_membresia = new System.Windows.Forms.Button();
            this.btn_actlz_membresia = new System.Windows.Forms.Button();
            this.btn_elim_membresia = new System.Windows.Forms.Button();
            this.gpb_vista_clientes_mem = new System.Windows.Forms.GroupBox();
            this.dgv_busc_membresia = new System.Windows.Forms.DataGridView();
            this.btn_busc_memb = new System.Windows.Forms.Button();
            this.btn_act_datos_mem = new System.Windows.Forms.Button();
            this.lbl_busq_clt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_busc_mem = new System.Windows.Forms.TextBox();
            this.gpb_ingreso_datos_mem.SuspendLayout();
            this.gpb_vista_clientes_mem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_membresia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_membresia
            // 
            this.lbl_membresia.AutoSize = true;
            this.lbl_membresia.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_membresia.Location = new System.Drawing.Point(326, 12);
            this.lbl_membresia.Name = "lbl_membresia";
            this.lbl_membresia.Size = new System.Drawing.Size(165, 34);
            this.lbl_membresia.TabIndex = 57;
            this.lbl_membresia.Text = "Membresía";
            // 
            // gpb_ingreso_datos_mem
            // 
            this.gpb_ingreso_datos_mem.Controls.Add(this.cbo_id_clt_mem);
            this.gpb_ingreso_datos_mem.Controls.Add(this.dtp_fec_expir_mem);
            this.gpb_ingreso_datos_mem.Controls.Add(this.dtp_fec_crea_mem);
            this.gpb_ingreso_datos_mem.Controls.Add(this.txt_beneficio_mem);
            this.gpb_ingreso_datos_mem.Controls.Add(this.lbl_fecha_expr_mem);
            this.gpb_ingreso_datos_mem.Controls.Add(this.lbl_fecha_expe_mem);
            this.gpb_ingreso_datos_mem.Controls.Add(this.lbl_benef_mem);
            this.gpb_ingreso_datos_mem.Controls.Add(this.lbl_id_cliente);
            this.gpb_ingreso_datos_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ingreso_datos_mem.Location = new System.Drawing.Point(12, 160);
            this.gpb_ingreso_datos_mem.Name = "gpb_ingreso_datos_mem";
            this.gpb_ingreso_datos_mem.Size = new System.Drawing.Size(337, 326);
            this.gpb_ingreso_datos_mem.TabIndex = 58;
            this.gpb_ingreso_datos_mem.TabStop = false;
            this.gpb_ingreso_datos_mem.Text = "Ingreso de datos";
            this.gpb_ingreso_datos_mem.Enter += new System.EventHandler(this.gpb_ingreso_datos_Enter);
            // 
            // cbo_id_clt_mem
            // 
            this.cbo_id_clt_mem.FormattingEnabled = true;
            this.cbo_id_clt_mem.Location = new System.Drawing.Point(9, 41);
            this.cbo_id_clt_mem.Name = "cbo_id_clt_mem";
            this.cbo_id_clt_mem.Size = new System.Drawing.Size(307, 26);
            this.cbo_id_clt_mem.TabIndex = 1;
            this.cbo_id_clt_mem.SelectedIndexChanged += new System.EventHandler(this.cbo_id_clt_mem_SelectedIndexChanged);
            // 
            // dtp_fec_expir_mem
            // 
            this.dtp_fec_expir_mem.Location = new System.Drawing.Point(9, 252);
            this.dtp_fec_expir_mem.Name = "dtp_fec_expir_mem";
            this.dtp_fec_expir_mem.Size = new System.Drawing.Size(285, 24);
            this.dtp_fec_expir_mem.TabIndex = 4;
            // 
            // dtp_fec_crea_mem
            // 
            this.dtp_fec_crea_mem.Location = new System.Drawing.Point(9, 208);
            this.dtp_fec_crea_mem.Name = "dtp_fec_crea_mem";
            this.dtp_fec_crea_mem.Size = new System.Drawing.Size(285, 24);
            this.dtp_fec_crea_mem.TabIndex = 3;
            // 
            // txt_beneficio_mem
            // 
            this.txt_beneficio_mem.Location = new System.Drawing.Point(6, 89);
            this.txt_beneficio_mem.Multiline = true;
            this.txt_beneficio_mem.Name = "txt_beneficio_mem";
            this.txt_beneficio_mem.Size = new System.Drawing.Size(310, 91);
            this.txt_beneficio_mem.TabIndex = 2;
            // 
            // lbl_fecha_expr_mem
            // 
            this.lbl_fecha_expr_mem.AutoSize = true;
            this.lbl_fecha_expr_mem.Location = new System.Drawing.Point(3, 231);
            this.lbl_fecha_expr_mem.Name = "lbl_fecha_expr_mem";
            this.lbl_fecha_expr_mem.Size = new System.Drawing.Size(140, 18);
            this.lbl_fecha_expr_mem.TabIndex = 4;
            this.lbl_fecha_expr_mem.Text = "Fecha de expiración";
            // 
            // lbl_fecha_expe_mem
            // 
            this.lbl_fecha_expe_mem.AutoSize = true;
            this.lbl_fecha_expe_mem.Location = new System.Drawing.Point(6, 183);
            this.lbl_fecha_expe_mem.Name = "lbl_fecha_expe_mem";
            this.lbl_fecha_expe_mem.Size = new System.Drawing.Size(130, 18);
            this.lbl_fecha_expe_mem.TabIndex = 3;
            this.lbl_fecha_expe_mem.Text = "Fecha de creacion";
            // 
            // lbl_benef_mem
            // 
            this.lbl_benef_mem.AutoSize = true;
            this.lbl_benef_mem.Location = new System.Drawing.Point(6, 68);
            this.lbl_benef_mem.Name = "lbl_benef_mem";
            this.lbl_benef_mem.Size = new System.Drawing.Size(77, 18);
            this.lbl_benef_mem.TabIndex = 2;
            this.lbl_benef_mem.Text = "Beneficios";
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(6, 20);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(68, 18);
            this.lbl_id_cliente.TabIndex = 1;
            this.lbl_id_cliente.Text = "Id Cliente";
            // 
            // btn_guardar_membresia
            // 
            this.btn_guardar_membresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_membresia.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_membresia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_membresia.Location = new System.Drawing.Point(12, 100);
            this.btn_guardar_membresia.Name = "btn_guardar_membresia";
            this.btn_guardar_membresia.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_membresia.TabIndex = 5;
            this.btn_guardar_membresia.Text = "GUARDAR";
            this.btn_guardar_membresia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_membresia.UseVisualStyleBackColor = true;
            this.btn_guardar_membresia.Click += new System.EventHandler(this.btn_guardar_membresia_Click);
            // 
            // btn_actlz_membresia
            // 
            this.btn_actlz_membresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_membresia.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_membresia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_membresia.Location = new System.Drawing.Point(112, 100);
            this.btn_actlz_membresia.Name = "btn_actlz_membresia";
            this.btn_actlz_membresia.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_membresia.TabIndex = 8;
            this.btn_actlz_membresia.Text = "ACTUALIZAR";
            this.btn_actlz_membresia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_membresia.UseVisualStyleBackColor = true;
            this.btn_actlz_membresia.Click += new System.EventHandler(this.btn_actlz_membresia_Click);
            // 
            // btn_elim_membresia
            // 
            this.btn_elim_membresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_membresia.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_membresia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_membresia.Location = new System.Drawing.Point(212, 100);
            this.btn_elim_membresia.Name = "btn_elim_membresia";
            this.btn_elim_membresia.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_membresia.TabIndex = 9;
            this.btn_elim_membresia.Text = "ELIMINAR";
            this.btn_elim_membresia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_membresia.UseVisualStyleBackColor = true;
            this.btn_elim_membresia.Click += new System.EventHandler(this.btn_elim_membresia_Click);
            // 
            // gpb_vista_clientes_mem
            // 
            this.gpb_vista_clientes_mem.Controls.Add(this.dgv_busc_membresia);
            this.gpb_vista_clientes_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_clientes_mem.Location = new System.Drawing.Point(355, 174);
            this.gpb_vista_clientes_mem.Name = "gpb_vista_clientes_mem";
            this.gpb_vista_clientes_mem.Size = new System.Drawing.Size(460, 318);
            this.gpb_vista_clientes_mem.TabIndex = 161;
            this.gpb_vista_clientes_mem.TabStop = false;
            this.gpb_vista_clientes_mem.Text = "Clientes";
            // 
            // dgv_busc_membresia
            // 
            this.dgv_busc_membresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_membresia.Location = new System.Drawing.Point(6, 23);
            this.dgv_busc_membresia.Name = "dgv_busc_membresia";
            this.dgv_busc_membresia.Size = new System.Drawing.Size(448, 289);
            this.dgv_busc_membresia.TabIndex = 0;
            // 
            // btn_busc_memb
            // 
            this.btn_busc_memb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_memb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_memb.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_memb.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_memb.Location = new System.Drawing.Point(679, 122);
            this.btn_busc_memb.Name = "btn_busc_memb";
            this.btn_busc_memb.Size = new System.Drawing.Size(65, 52);
            this.btn_busc_memb.TabIndex = 6;
            this.btn_busc_memb.Text = "BUSCAR";
            this.btn_busc_memb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_memb.UseVisualStyleBackColor = true;
            this.btn_busc_memb.Click += new System.EventHandler(this.btn_busc_memb_Click);
            // 
            // btn_act_datos_mem
            // 
            this.btn_act_datos_mem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_act_datos_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act_datos_mem.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_act_datos_mem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_act_datos_mem.Location = new System.Drawing.Point(750, 120);
            this.btn_act_datos_mem.Name = "btn_act_datos_mem";
            this.btn_act_datos_mem.Size = new System.Drawing.Size(65, 54);
            this.btn_act_datos_mem.TabIndex = 7;
            this.btn_act_datos_mem.Text = "RENOVAR";
            this.btn_act_datos_mem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_act_datos_mem.UseVisualStyleBackColor = true;
            this.btn_act_datos_mem.Click += new System.EventHandler(this.btn_act_datos_Click);
            // 
            // lbl_busq_clt
            // 
            this.lbl_busq_clt.AutoSize = true;
            this.lbl_busq_clt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busq_clt.Location = new System.Drawing.Point(358, 137);
            this.lbl_busq_clt.Name = "lbl_busq_clt";
            this.lbl_busq_clt.Size = new System.Drawing.Size(55, 18);
            this.lbl_busq_clt.TabIndex = 165;
            this.lbl_busq_clt.Text = "Buscar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Clinica;
            this.pictureBox1.Location = new System.Drawing.Point(706, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.TabIndex = 166;
            this.pictureBox1.TabStop = false;
            // 
            // txt_busc_mem
            // 
            this.txt_busc_mem.Location = new System.Drawing.Point(419, 137);
            this.txt_busc_mem.Name = "txt_busc_mem";
            this.txt_busc_mem.Size = new System.Drawing.Size(254, 20);
            this.txt_busc_mem.TabIndex = 6;
            // 
            // Membresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.txt_busc_mem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_busq_clt);
            this.Controls.Add(this.btn_act_datos_mem);
            this.Controls.Add(this.btn_busc_memb);
            this.Controls.Add(this.gpb_vista_clientes_mem);
            this.Controls.Add(this.btn_elim_membresia);
            this.Controls.Add(this.btn_actlz_membresia);
            this.Controls.Add(this.btn_guardar_membresia);
            this.Controls.Add(this.gpb_ingreso_datos_mem);
            this.Controls.Add(this.lbl_membresia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Membresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresia";
            this.Load += new System.EventHandler(this.txt_fecha_expir_Load);
            this.gpb_ingreso_datos_mem.ResumeLayout(false);
            this.gpb_ingreso_datos_mem.PerformLayout();
            this.gpb_vista_clientes_mem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_membresia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_membresia;
        private System.Windows.Forms.GroupBox gpb_ingreso_datos_mem;
        private System.Windows.Forms.Button btn_guardar_membresia;
        private System.Windows.Forms.Button btn_actlz_membresia;
        private System.Windows.Forms.Button btn_elim_membresia;
        private System.Windows.Forms.TextBox txt_beneficio_mem;
        private System.Windows.Forms.Label lbl_fecha_expr_mem;
        private System.Windows.Forms.Label lbl_fecha_expe_mem;
        private System.Windows.Forms.Label lbl_benef_mem;
        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.GroupBox gpb_vista_clientes_mem;
        private System.Windows.Forms.Button btn_busc_memb;
        private System.Windows.Forms.DataGridView dgv_busc_membresia;
        private System.Windows.Forms.Button btn_act_datos_mem;
        private System.Windows.Forms.Label lbl_busq_clt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_fec_expir_mem;
        private System.Windows.Forms.DateTimePicker dtp_fec_crea_mem;
        private System.Windows.Forms.TextBox txt_busc_mem;
        private System.Windows.Forms.ComboBox cbo_id_clt_mem;
    }
}