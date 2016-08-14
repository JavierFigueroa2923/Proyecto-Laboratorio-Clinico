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
            this.txt_busc_fact = new System.Windows.Forms.TextBox();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.gpb_vista_fct = new System.Windows.Forms.GroupBox();
            this.dgv_vista_fct = new System.Windows.Forms.DataGridView();
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
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
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
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(603, 112);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 144;
            this.lbl_busc_tip_exam.Text = "Buscar:";
            // 
            // txt_busc_fact
            // 
            this.txt_busc_fact.Location = new System.Drawing.Point(671, 114);
            this.txt_busc_fact.Name = "txt_busc_fact";
            this.txt_busc_fact.Size = new System.Drawing.Size(263, 20);
            this.txt_busc_fact.TabIndex = 145;
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
            // 
            // gpb_vista_fct
            // 
            this.gpb_vista_fct.Controls.Add(this.dgv_vista_fct);
            this.gpb_vista_fct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_fct.Location = new System.Drawing.Point(451, 131);
            this.gpb_vista_fct.Name = "gpb_vista_fct";
            this.gpb_vista_fct.Size = new System.Drawing.Size(489, 337);
            this.gpb_vista_fct.TabIndex = 143;
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
            this.gpb_datos_fct.Controls.Add(this.txt_cliente);
            this.gpb_datos_fct.Controls.Add(this.Lbl_descripcion);
            this.gpb_datos_fct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_fct.Location = new System.Drawing.Point(22, 131);
            this.gpb_datos_fct.Name = "gpb_datos_fct";
            this.gpb_datos_fct.Size = new System.Drawing.Size(423, 337);
            this.gpb_datos_fct.TabIndex = 142;
            this.gpb_datos_fct.TabStop = false;
            this.gpb_datos_fct.Text = "Encabezado";
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
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(118, 107);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(297, 23);
            this.txt_cliente.TabIndex = 55;
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
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.txt_busc_fact);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_fct)).EndInit();
            this.gpb_datos_fct.ResumeLayout(false);
            this.gpb_datos_fct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_elim_inv_sumin;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        internal System.Windows.Forms.TextBox txt_busc_fact;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.GroupBox gpb_vista_fct;
        private System.Windows.Forms.DataGridView dgv_vista_fct;
        private System.Windows.Forms.GroupBox gpb_datos_fct;
        internal System.Windows.Forms.TextBox txt_id_fm_pg;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txt_fecha;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txt_nit;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txt_id_clt;
        internal System.Windows.Forms.Label lbl_nom_sumin;
        internal System.Windows.Forms.TextBox txt_cliente;
        internal System.Windows.Forms.Label Lbl_descripcion;
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
    }
}