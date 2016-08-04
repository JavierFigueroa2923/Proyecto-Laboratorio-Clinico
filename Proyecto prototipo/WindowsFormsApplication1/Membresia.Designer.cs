namespace WindowsFormsApplication1
{
    partial class txt_fecha_expir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(txt_fecha_expir));
            this.lbl_membresia = new System.Windows.Forms.Label();
            this.gpb_ingreso_datos = new System.Windows.Forms.GroupBox();
            this.txt_beneficio = new System.Windows.Forms.TextBox();
            this.txt_id_clt = new System.Windows.Forms.TextBox();
            this.txt_membresia = new System.Windows.Forms.TextBox();
            this.lbl_fecha_expr = new System.Windows.Forms.Label();
            this.lbl_fecha_expe = new System.Windows.Forms.Label();
            this.lbl_benef = new System.Windows.Forms.Label();
            this.lbl_id_cliente = new System.Windows.Forms.Label();
            this.lbl_mem = new System.Windows.Forms.Label();
            this.btn_guardar_membresia = new System.Windows.Forms.Button();
            this.btn_actlz_membresia = new System.Windows.Forms.Button();
            this.btn_elim_membresia = new System.Windows.Forms.Button();
            this.gpb_vista_clientes = new System.Windows.Forms.GroupBox();
            this.dgv_membresia = new System.Windows.Forms.DataGridView();
            this.txt_buscar_clt = new System.Windows.Forms.TextBox();
            this.btn_busc_memb = new System.Windows.Forms.Button();
            this.btn_act_datos = new System.Windows.Forms.Button();
            this.lbl_busq_clt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_fecha_exp = new System.Windows.Forms.TextBox();
            this.txt_fec_expirar = new System.Windows.Forms.TextBox();
            this.gpb_ingreso_datos.SuspendLayout();
            this.gpb_vista_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_membresia)).BeginInit();
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
            // gpb_ingreso_datos
            // 
            this.gpb_ingreso_datos.Controls.Add(this.txt_fec_expirar);
            this.gpb_ingreso_datos.Controls.Add(this.txt_fecha_exp);
            this.gpb_ingreso_datos.Controls.Add(this.txt_beneficio);
            this.gpb_ingreso_datos.Controls.Add(this.txt_id_clt);
            this.gpb_ingreso_datos.Controls.Add(this.txt_membresia);
            this.gpb_ingreso_datos.Controls.Add(this.lbl_fecha_expr);
            this.gpb_ingreso_datos.Controls.Add(this.lbl_fecha_expe);
            this.gpb_ingreso_datos.Controls.Add(this.lbl_benef);
            this.gpb_ingreso_datos.Controls.Add(this.lbl_id_cliente);
            this.gpb_ingreso_datos.Controls.Add(this.lbl_mem);
            this.gpb_ingreso_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ingreso_datos.Location = new System.Drawing.Point(12, 160);
            this.gpb_ingreso_datos.Name = "gpb_ingreso_datos";
            this.gpb_ingreso_datos.Size = new System.Drawing.Size(337, 357);
            this.gpb_ingreso_datos.TabIndex = 58;
            this.gpb_ingreso_datos.TabStop = false;
            this.gpb_ingreso_datos.Text = "Ingreso de datos";
            // 
            // txt_beneficio
            // 
            this.txt_beneficio.Location = new System.Drawing.Point(9, 159);
            this.txt_beneficio.Multiline = true;
            this.txt_beneficio.Name = "txt_beneficio";
            this.txt_beneficio.Size = new System.Drawing.Size(310, 71);
            this.txt_beneficio.TabIndex = 7;
            // 
            // txt_id_clt
            // 
            this.txt_id_clt.Location = new System.Drawing.Point(9, 101);
            this.txt_id_clt.Name = "txt_id_clt";
            this.txt_id_clt.Size = new System.Drawing.Size(310, 24);
            this.txt_id_clt.TabIndex = 6;
            this.txt_id_clt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_clt_KeyPress);
            // 
            // txt_membresia
            // 
            this.txt_membresia.Location = new System.Drawing.Point(9, 41);
            this.txt_membresia.Name = "txt_membresia";
            this.txt_membresia.Size = new System.Drawing.Size(310, 24);
            this.txt_membresia.TabIndex = 5;
            this.txt_membresia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_membresia_KeyPress);
            // 
            // lbl_fecha_expr
            // 
            this.lbl_fecha_expr.AutoSize = true;
            this.lbl_fecha_expr.Location = new System.Drawing.Point(6, 306);
            this.lbl_fecha_expr.Name = "lbl_fecha_expr";
            this.lbl_fecha_expr.Size = new System.Drawing.Size(140, 18);
            this.lbl_fecha_expr.TabIndex = 4;
            this.lbl_fecha_expr.Text = "Fecha de expiración";
            // 
            // lbl_fecha_expe
            // 
            this.lbl_fecha_expe.AutoSize = true;
            this.lbl_fecha_expe.Location = new System.Drawing.Point(6, 246);
            this.lbl_fecha_expe.Name = "lbl_fecha_expe";
            this.lbl_fecha_expe.Size = new System.Drawing.Size(143, 18);
            this.lbl_fecha_expe.TabIndex = 3;
            this.lbl_fecha_expe.Text = "Fecha de expedición";
            // 
            // lbl_benef
            // 
            this.lbl_benef.AutoSize = true;
            this.lbl_benef.Location = new System.Drawing.Point(6, 138);
            this.lbl_benef.Name = "lbl_benef";
            this.lbl_benef.Size = new System.Drawing.Size(77, 18);
            this.lbl_benef.TabIndex = 2;
            this.lbl_benef.Text = "Beneficios";
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.AutoSize = true;
            this.lbl_id_cliente.Location = new System.Drawing.Point(6, 80);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(68, 18);
            this.lbl_id_cliente.TabIndex = 1;
            this.lbl_id_cliente.Text = "Id Cliente";
            // 
            // lbl_mem
            // 
            this.lbl_mem.AutoSize = true;
            this.lbl_mem.Location = new System.Drawing.Point(6, 20);
            this.lbl_mem.Name = "lbl_mem";
            this.lbl_mem.Size = new System.Drawing.Size(97, 18);
            this.lbl_mem.TabIndex = 0;
            this.lbl_mem.Text = "Id Membresía";
            // 
            // btn_guardar_membresia
            // 
            this.btn_guardar_membresia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_membresia.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_membresia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_membresia.Location = new System.Drawing.Point(12, 100);
            this.btn_guardar_membresia.Name = "btn_guardar_membresia";
            this.btn_guardar_membresia.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_membresia.TabIndex = 69;
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
            this.btn_actlz_membresia.TabIndex = 70;
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
            this.btn_elim_membresia.TabIndex = 160;
            this.btn_elim_membresia.Text = "ELIMINAR";
            this.btn_elim_membresia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_membresia.UseVisualStyleBackColor = true;
            this.btn_elim_membresia.Click += new System.EventHandler(this.btn_elim_membresia_Click);
            // 
            // gpb_vista_clientes
            // 
            this.gpb_vista_clientes.Controls.Add(this.dgv_membresia);
            this.gpb_vista_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_clientes.Location = new System.Drawing.Point(355, 174);
            this.gpb_vista_clientes.Name = "gpb_vista_clientes";
            this.gpb_vista_clientes.Size = new System.Drawing.Size(460, 318);
            this.gpb_vista_clientes.TabIndex = 161;
            this.gpb_vista_clientes.TabStop = false;
            this.gpb_vista_clientes.Text = "Clientes";
            // 
            // dgv_membresia
            // 
            this.dgv_membresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_membresia.Location = new System.Drawing.Point(6, 23);
            this.dgv_membresia.Name = "dgv_membresia";
            this.dgv_membresia.Size = new System.Drawing.Size(448, 289);
            this.dgv_membresia.TabIndex = 0;
            // 
            // txt_buscar_clt
            // 
            this.txt_buscar_clt.Location = new System.Drawing.Point(413, 135);
            this.txt_buscar_clt.Name = "txt_buscar_clt";
            this.txt_buscar_clt.Size = new System.Drawing.Size(261, 20);
            this.txt_buscar_clt.TabIndex = 162;
            this.txt_buscar_clt.TextChanged += new System.EventHandler(this.txt_buscar_clt_TextChanged);
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
            this.btn_busc_memb.TabIndex = 163;
            this.btn_busc_memb.Text = "BUSCAR";
            this.btn_busc_memb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_memb.UseVisualStyleBackColor = true;
            this.btn_busc_memb.Click += new System.EventHandler(this.btn_busc_memb_Click);
            // 
            // btn_act_datos
            // 
            this.btn_act_datos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_act_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act_datos.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_act_datos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_act_datos.Location = new System.Drawing.Point(750, 120);
            this.btn_act_datos.Name = "btn_act_datos";
            this.btn_act_datos.Size = new System.Drawing.Size(65, 54);
            this.btn_act_datos.TabIndex = 164;
            this.btn_act_datos.Text = "RENOVAR";
            this.btn_act_datos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_act_datos.UseVisualStyleBackColor = true;
            this.btn_act_datos.Click += new System.EventHandler(this.btn_act_datos_Click);
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
            // txt_fecha_exp
            // 
            this.txt_fecha_exp.Location = new System.Drawing.Point(9, 268);
            this.txt_fecha_exp.Name = "txt_fecha_exp";
            this.txt_fecha_exp.Size = new System.Drawing.Size(310, 24);
            this.txt_fecha_exp.TabIndex = 163;
            // 
            // txt_fec_expirar
            // 
            this.txt_fec_expirar.Location = new System.Drawing.Point(9, 331);
            this.txt_fec_expirar.Name = "txt_fec_expirar";
            this.txt_fec_expirar.Size = new System.Drawing.Size(310, 24);
            this.txt_fec_expirar.TabIndex = 164;
            // 
            // txt_fecha_expir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_busq_clt);
            this.Controls.Add(this.btn_act_datos);
            this.Controls.Add(this.btn_busc_memb);
            this.Controls.Add(this.txt_buscar_clt);
            this.Controls.Add(this.gpb_vista_clientes);
            this.Controls.Add(this.btn_elim_membresia);
            this.Controls.Add(this.btn_actlz_membresia);
            this.Controls.Add(this.btn_guardar_membresia);
            this.Controls.Add(this.gpb_ingreso_datos);
            this.Controls.Add(this.lbl_membresia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "txt_fecha_expir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresia";
            this.Load += new System.EventHandler(this.txt_fecha_expir_Load);
            this.gpb_ingreso_datos.ResumeLayout(false);
            this.gpb_ingreso_datos.PerformLayout();
            this.gpb_vista_clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_membresia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_membresia;
        private System.Windows.Forms.GroupBox gpb_ingreso_datos;
        private System.Windows.Forms.Button btn_guardar_membresia;
        private System.Windows.Forms.Button btn_actlz_membresia;
        private System.Windows.Forms.Button btn_elim_membresia;
        private System.Windows.Forms.TextBox txt_beneficio;
        private System.Windows.Forms.TextBox txt_id_clt;
        private System.Windows.Forms.TextBox txt_membresia;
        private System.Windows.Forms.Label lbl_fecha_expr;
        private System.Windows.Forms.Label lbl_fecha_expe;
        private System.Windows.Forms.Label lbl_benef;
        private System.Windows.Forms.Label lbl_id_cliente;
        private System.Windows.Forms.Label lbl_mem;
        private System.Windows.Forms.GroupBox gpb_vista_clientes;
        private System.Windows.Forms.TextBox txt_buscar_clt;
        private System.Windows.Forms.Button btn_busc_memb;
        private System.Windows.Forms.DataGridView dgv_membresia;
        private System.Windows.Forms.Button btn_act_datos;
        private System.Windows.Forms.Label lbl_busq_clt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_fec_expirar;
        private System.Windows.Forms.TextBox txt_fecha_exp;
    }
}