namespace WindowsFormsApplication1
{
    partial class Tipo_de_muestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo_de_muestra));
            this.lbl_tipo_muestra = new System.Windows.Forms.Label();
            this.gpb_ingr_datos = new System.Windows.Forms.GroupBox();
            this.txt_descp_muestra = new System.Windows.Forms.TextBox();
            this.lbl_descrp_tip_mst = new System.Windows.Forms.Label();
            this.txt_nombre_tipo = new System.Windows.Forms.TextBox();
            this.lbl_nom_mst = new System.Windows.Forms.Label();
            this.btn_elim_tp_muestra = new System.Windows.Forms.Button();
            this.btn_actlz_tipo_muestra = new System.Windows.Forms.Button();
            this.btn_guardar_tipo_muestra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_vista_tipos_mist = new System.Windows.Forms.GroupBox();
            this.dgv_muestras = new System.Windows.Forms.DataGridView();
            this.cbo_buscar = new System.Windows.Forms.ComboBox();
            this.lbl_busq_clt = new System.Windows.Forms.Label();
            this.btn_busc_memb = new System.Windows.Forms.Button();
            this.btn_act_datos = new System.Windows.Forms.Button();
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
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.gpb_ingr_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpb_vista_tipos_mist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestras)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tipo_muestra
            // 
            this.lbl_tipo_muestra.AutoSize = true;
            this.lbl_tipo_muestra.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_muestra.Location = new System.Drawing.Point(256, 12);
            this.lbl_tipo_muestra.Name = "lbl_tipo_muestra";
            this.lbl_tipo_muestra.Size = new System.Drawing.Size(232, 34);
            this.lbl_tipo_muestra.TabIndex = 71;
            this.lbl_tipo_muestra.Text = "Tipo de muestra";
            // 
            // gpb_ingr_datos
            // 
            this.gpb_ingr_datos.Controls.Add(this.txt_descp_muestra);
            this.gpb_ingr_datos.Controls.Add(this.lbl_descrp_tip_mst);
            this.gpb_ingr_datos.Controls.Add(this.txt_nombre_tipo);
            this.gpb_ingr_datos.Controls.Add(this.lbl_nom_mst);
            this.gpb_ingr_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ingr_datos.Location = new System.Drawing.Point(12, 166);
            this.gpb_ingr_datos.Name = "gpb_ingr_datos";
            this.gpb_ingr_datos.Size = new System.Drawing.Size(362, 270);
            this.gpb_ingr_datos.TabIndex = 162;
            this.gpb_ingr_datos.TabStop = false;
            this.gpb_ingr_datos.Text = "Datos generales";
            // 
            // txt_descp_muestra
            // 
            this.txt_descp_muestra.Location = new System.Drawing.Point(9, 109);
            this.txt_descp_muestra.Multiline = true;
            this.txt_descp_muestra.Name = "txt_descp_muestra";
            this.txt_descp_muestra.Size = new System.Drawing.Size(326, 146);
            this.txt_descp_muestra.TabIndex = 5;
            // 
            // lbl_descrp_tip_mst
            // 
            this.lbl_descrp_tip_mst.AutoSize = true;
            this.lbl_descrp_tip_mst.Location = new System.Drawing.Point(6, 88);
            this.lbl_descrp_tip_mst.Name = "lbl_descrp_tip_mst";
            this.lbl_descrp_tip_mst.Size = new System.Drawing.Size(216, 18);
            this.lbl_descrp_tip_mst.TabIndex = 4;
            this.lbl_descrp_tip_mst.Text = "Descripción del tipo de muestra";
            // 
            // txt_nombre_tipo
            // 
            this.txt_nombre_tipo.Location = new System.Drawing.Point(9, 45);
            this.txt_nombre_tipo.Name = "txt_nombre_tipo";
            this.txt_nombre_tipo.Size = new System.Drawing.Size(326, 24);
            this.txt_nombre_tipo.TabIndex = 3;
            // 
            // lbl_nom_mst
            // 
            this.lbl_nom_mst.AutoSize = true;
            this.lbl_nom_mst.Location = new System.Drawing.Point(6, 24);
            this.lbl_nom_mst.Name = "lbl_nom_mst";
            this.lbl_nom_mst.Size = new System.Drawing.Size(191, 18);
            this.lbl_nom_mst.TabIndex = 2;
            this.lbl_nom_mst.Text = "Nombre del tipo de muestra";
            // 
            // btn_elim_tp_muestra
            // 
            this.btn_elim_tp_muestra.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_tp_muestra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_tp_muestra.FlatAppearance.BorderSize = 0;
            this.btn_elim_tp_muestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_tp_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_tp_muestra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_tp_muestra.Location = new System.Drawing.Point(225, 67);
            this.btn_elim_tp_muestra.Name = "btn_elim_tp_muestra";
            this.btn_elim_tp_muestra.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_tp_muestra.TabIndex = 161;
            this.btn_elim_tp_muestra.Text = " ";
            this.btn_elim_tp_muestra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_tp_muestra, "Eliminar");
            this.btn_elim_tp_muestra.UseVisualStyleBackColor = true;
            this.btn_elim_tp_muestra.Click += new System.EventHandler(this.btn_elim_tp_muestra_Click);
            // 
            // btn_actlz_tipo_muestra
            // 
            this.btn_actlz_tipo_muestra.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_tipo_muestra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_tipo_muestra.FlatAppearance.BorderSize = 0;
            this.btn_actlz_tipo_muestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_tipo_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_tipo_muestra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_tipo_muestra.Location = new System.Drawing.Point(154, 67);
            this.btn_actlz_tipo_muestra.Name = "btn_actlz_tipo_muestra";
            this.btn_actlz_tipo_muestra.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_tipo_muestra.TabIndex = 72;
            this.btn_actlz_tipo_muestra.Text = " ";
            this.btn_actlz_tipo_muestra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_tipo_muestra, "Modificar");
            this.btn_actlz_tipo_muestra.UseVisualStyleBackColor = true;
            this.btn_actlz_tipo_muestra.Click += new System.EventHandler(this.btn_actlz_tipo_muestra_Click);
            // 
            // btn_guardar_tipo_muestra
            // 
            this.btn_guardar_tipo_muestra.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_tipo_muestra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_tipo_muestra.FlatAppearance.BorderSize = 0;
            this.btn_guardar_tipo_muestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_tipo_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_tipo_muestra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_tipo_muestra.Location = new System.Drawing.Point(83, 67);
            this.btn_guardar_tipo_muestra.Name = "btn_guardar_tipo_muestra";
            this.btn_guardar_tipo_muestra.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_tipo_muestra.TabIndex = 70;
            this.btn_guardar_tipo_muestra.Text = " ";
            this.btn_guardar_tipo_muestra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_tipo_muestra, "Guardar");
            this.btn_guardar_tipo_muestra.UseVisualStyleBackColor = true;
            this.btn_guardar_tipo_muestra.Click += new System.EventHandler(this.btn_guardar_tipo_muestra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Clinica;
            this.pictureBox1.Location = new System.Drawing.Point(624, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // gpb_vista_tipos_mist
            // 
            this.gpb_vista_tipos_mist.Controls.Add(this.dgv_muestras);
            this.gpb_vista_tipos_mist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_tipos_mist.Location = new System.Drawing.Point(381, 166);
            this.gpb_vista_tipos_mist.Name = "gpb_vista_tipos_mist";
            this.gpb_vista_tipos_mist.Size = new System.Drawing.Size(346, 292);
            this.gpb_vista_tipos_mist.TabIndex = 163;
            this.gpb_vista_tipos_mist.TabStop = false;
            this.gpb_vista_tipos_mist.Text = "Tipos de Muestra";
            // 
            // dgv_muestras
            // 
            this.dgv_muestras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muestras.Location = new System.Drawing.Point(6, 24);
            this.dgv_muestras.Name = "dgv_muestras";
            this.dgv_muestras.Size = new System.Drawing.Size(340, 262);
            this.dgv_muestras.TabIndex = 0;
            // 
            // cbo_buscar
            // 
            this.cbo_buscar.FormattingEnabled = true;
            this.cbo_buscar.Location = new System.Drawing.Point(439, 142);
            this.cbo_buscar.Name = "cbo_buscar";
            this.cbo_buscar.Size = new System.Drawing.Size(147, 21);
            this.cbo_buscar.TabIndex = 168;
            // 
            // lbl_busq_clt
            // 
            this.lbl_busq_clt.AutoSize = true;
            this.lbl_busq_clt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busq_clt.Location = new System.Drawing.Point(378, 145);
            this.lbl_busq_clt.Name = "lbl_busq_clt";
            this.lbl_busq_clt.Size = new System.Drawing.Size(55, 18);
            this.lbl_busq_clt.TabIndex = 169;
            this.lbl_busq_clt.Text = "Buscar";
            // 
            // btn_busc_memb
            // 
            this.btn_busc_memb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_memb.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_memb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_memb.FlatAppearance.BorderSize = 0;
            this.btn_busc_memb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_memb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_memb.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_memb.Location = new System.Drawing.Point(296, 67);
            this.btn_busc_memb.Name = "btn_busc_memb";
            this.btn_busc_memb.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_memb.TabIndex = 170;
            this.btn_busc_memb.Text = " ";
            this.btn_busc_memb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_memb, "Buscar");
            this.btn_busc_memb.UseVisualStyleBackColor = true;
            this.btn_busc_memb.Click += new System.EventHandler(this.btn_busc_memb_Click);
            // 
            // btn_act_datos
            // 
            this.btn_act_datos.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_act_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_act_datos.FlatAppearance.BorderSize = 0;
            this.btn_act_datos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act_datos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_act_datos.Location = new System.Drawing.Point(510, 67);
            this.btn_act_datos.Name = "btn_act_datos";
            this.btn_act_datos.Size = new System.Drawing.Size(65, 65);
            this.btn_act_datos.TabIndex = 171;
            this.btn_act_datos.Text = " ";
            this.btn_act_datos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip8.SetToolTip(this.btn_act_datos, "Actualizar");
            this.btn_act_datos.UseVisualStyleBackColor = true;
            this.btn_act_datos.Click += new System.EventHandler(this.btn_act_datos_Click);
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(12, 67);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 172;
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
            this.btn_acept.Location = new System.Drawing.Point(439, 67);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 174;
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
            this.btn_cancl.Location = new System.Drawing.Point(368, 67);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 173;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // Tipo_de_muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 492);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.btn_act_datos);
            this.Controls.Add(this.btn_busc_memb);
            this.Controls.Add(this.lbl_busq_clt);
            this.Controls.Add(this.cbo_buscar);
            this.Controls.Add(this.gpb_vista_tipos_mist);
            this.Controls.Add(this.gpb_ingr_datos);
            this.Controls.Add(this.btn_elim_tp_muestra);
            this.Controls.Add(this.btn_actlz_tipo_muestra);
            this.Controls.Add(this.lbl_tipo_muestra);
            this.Controls.Add(this.btn_guardar_tipo_muestra);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tipo_de_muestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo_de_muestra";
            this.Load += new System.EventHandler(this.Tipo_de_muestra_Load);
            this.gpb_ingr_datos.ResumeLayout(false);
            this.gpb_ingr_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpb_vista_tipos_mist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muestras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_guardar_tipo_muestra;
        private System.Windows.Forms.Label lbl_tipo_muestra;
        private System.Windows.Forms.Button btn_actlz_tipo_muestra;
        private System.Windows.Forms.Button btn_elim_tp_muestra;
        private System.Windows.Forms.GroupBox gpb_ingr_datos;
        private System.Windows.Forms.TextBox txt_descp_muestra;
        private System.Windows.Forms.Label lbl_descrp_tip_mst;
        private System.Windows.Forms.TextBox txt_nombre_tipo;
        private System.Windows.Forms.Label lbl_nom_mst;
        private System.Windows.Forms.GroupBox gpb_vista_tipos_mist;
        private System.Windows.Forms.DataGridView dgv_muestras;
        private System.Windows.Forms.ComboBox cbo_buscar;
        private System.Windows.Forms.Label lbl_busq_clt;
        private System.Windows.Forms.Button btn_busc_memb;
        private System.Windows.Forms.Button btn_act_datos;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}