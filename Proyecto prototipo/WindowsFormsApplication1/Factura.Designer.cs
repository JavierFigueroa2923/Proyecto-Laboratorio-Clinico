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
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.gpb_datos_fct = new System.Windows.Forms.GroupBox();
            this.txt_id_fm_pg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_clt = new System.Windows.Forms.TextBox();
            this.lbl_nom_sumin = new System.Windows.Forms.Label();
            this.txt_id_fact = new System.Windows.Forms.TextBox();
            this.gpb_vista_fct = new System.Windows.Forms.GroupBox();
            this.dgv_vista_fct = new System.Windows.Forms.DataGridView();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.txt_busc_fact = new System.Windows.Forms.TextBox();
            this.btn_elim_inv_sumin = new System.Windows.Forms.Button();
            this.btn_busc_tip_exam = new System.Windows.Forms.Button();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_datos_fct.SuspendLayout();
            this.gpb_vista_fct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_fct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id_inventario
            // 
            this.Lbl_id_inventario.AutoSize = true;
            this.Lbl_id_inventario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_inventario.Location = new System.Drawing.Point(6, 49);
            this.Lbl_id_inventario.Name = "Lbl_id_inventario";
            this.Lbl_id_inventario.Size = new System.Drawing.Size(86, 20);
            this.Lbl_id_inventario.TabIndex = 57;
            this.Lbl_id_inventario.Text = "Id factura:";
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
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(118, 107);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(297, 23);
            this.txt_cliente.TabIndex = 55;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(386, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(116, 34);
            this.Lbl_titulo.TabIndex = 51;
            this.Lbl_titulo.Text = "Factura";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // gpb_datos_fct
            // 
            this.gpb_datos_fct.Controls.Add(this.txt_id_fm_pg);
            this.gpb_datos_fct.Controls.Add(this.label4);
            this.gpb_datos_fct.Controls.Add(this.txt_direccion);
            this.gpb_datos_fct.Controls.Add(this.label3);
            this.gpb_datos_fct.Controls.Add(this.txt_fecha);
            this.gpb_datos_fct.Controls.Add(this.label2);
            this.gpb_datos_fct.Controls.Add(this.txt_nit);
            this.gpb_datos_fct.Controls.Add(this.label1);
            this.gpb_datos_fct.Controls.Add(this.txt_id_clt);
            this.gpb_datos_fct.Controls.Add(this.lbl_nom_sumin);
            this.gpb_datos_fct.Controls.Add(this.txt_id_fact);
            this.gpb_datos_fct.Controls.Add(this.txt_cliente);
            this.gpb_datos_fct.Controls.Add(this.Lbl_id_inventario);
            this.gpb_datos_fct.Controls.Add(this.Lbl_descripcion);
            this.gpb_datos_fct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_fct.Location = new System.Drawing.Point(12, 120);
            this.gpb_datos_fct.Name = "gpb_datos_fct";
            this.gpb_datos_fct.Size = new System.Drawing.Size(423, 337);
            this.gpb_datos_fct.TabIndex = 60;
            this.gpb_datos_fct.TabStop = false;
            this.gpb_datos_fct.Text = "Encabezado";
            this.gpb_datos_fct.Enter += new System.EventHandler(this.gpb_datos_inv_sumin_Enter);
            // 
            // txt_id_fm_pg
            // 
            this.txt_id_fm_pg.Location = new System.Drawing.Point(138, 233);
            this.txt_id_fm_pg.Name = "txt_id_fm_pg";
            this.txt_id_fm_pg.Size = new System.Drawing.Size(277, 23);
            this.txt_id_fm_pg.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Forma de pago:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(118, 168);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(297, 23);
            this.txt_direccion.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Direccion:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(118, 200);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(297, 23);
            this.txt_fecha.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Fecha:";
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(118, 137);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(297, 23);
            this.txt_nit.TabIndex = 67;
            this.txt_nit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "NIT:";
            // 
            // txt_id_clt
            // 
            this.txt_id_clt.Location = new System.Drawing.Point(118, 78);
            this.txt_id_clt.Name = "txt_id_clt";
            this.txt_id_clt.Size = new System.Drawing.Size(242, 23);
            this.txt_id_clt.TabIndex = 59;
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
            // txt_id_fact
            // 
            this.txt_id_fact.Location = new System.Drawing.Point(118, 49);
            this.txt_id_fact.Name = "txt_id_fact";
            this.txt_id_fact.Size = new System.Drawing.Size(195, 23);
            this.txt_id_fact.TabIndex = 58;
            // 
            // gpb_vista_fct
            // 
            this.gpb_vista_fct.Controls.Add(this.dgv_vista_fct);
            this.gpb_vista_fct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_fct.Location = new System.Drawing.Point(441, 120);
            this.gpb_vista_fct.Name = "gpb_vista_fct";
            this.gpb_vista_fct.Size = new System.Drawing.Size(489, 337);
            this.gpb_vista_fct.TabIndex = 61;
            this.gpb_vista_fct.TabStop = false;
            this.gpb_vista_fct.Text = "Detalle";
            // 
            // dgv_vista_fct
            // 
            this.dgv_vista_fct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_fct.Location = new System.Drawing.Point(6, 22);
            this.dgv_vista_fct.Name = "dgv_vista_fct";
            this.dgv_vista_fct.Size = new System.Drawing.Size(477, 306);
            this.dgv_vista_fct.TabIndex = 0;
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
            // txt_busc_fact
            // 
            this.txt_busc_fact.Location = new System.Drawing.Point(584, 103);
            this.txt_busc_fact.Name = "txt_busc_fact";
            this.txt_busc_fact.Size = new System.Drawing.Size(158, 20);
            this.txt_busc_fact.TabIndex = 136;
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
            // btn_busc_tip_exam
            // 
            this.btn_busc_tip_exam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_tip_exam.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_tip_exam.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_tip_exam.Location = new System.Drawing.Point(748, 69);
            this.btn_busc_tip_exam.Name = "btn_busc_tip_exam";
            this.btn_busc_tip_exam.Size = new System.Drawing.Size(76, 54);
            this.btn_busc_tip_exam.TabIndex = 139;
            this.btn_busc_tip_exam.Text = "BUSCAR";
            this.btn_busc_tip_exam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_tip_exam.UseVisualStyleBackColor = true;
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
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(830, 9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 102);
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
            // 
            // frm_act_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 481);
            this.Controls.Add(this.btn_elim_inv_sumin);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_tip_exam);
            this.Controls.Add(this.txt_busc_fact);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_fct);
            this.Controls.Add(this.gpb_datos_fct);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_act_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suministros";
            this.gpb_datos_fct.ResumeLayout(false);
            this.gpb_datos_fct.PerformLayout();
            this.gpb_vista_fct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_fct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Lbl_id_inventario;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_cliente;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox gpb_datos_fct;
        internal System.Windows.Forms.TextBox txt_id_clt;
        internal System.Windows.Forms.Label lbl_nom_sumin;
        internal System.Windows.Forms.TextBox txt_id_fact;
        private System.Windows.Forms.GroupBox gpb_vista_fct;
        private System.Windows.Forms.DataGridView dgv_vista_fct;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        private System.Windows.Forms.Button btn_busc_tip_exam;
        internal System.Windows.Forms.TextBox txt_busc_fact;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.Button btn_elim_inv_sumin;
        internal System.Windows.Forms.TextBox txt_nit;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_fecha;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_id_fm_pg;
        internal System.Windows.Forms.Label label4;
    }
}