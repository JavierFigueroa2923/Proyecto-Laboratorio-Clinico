namespace WindowsFormsApplication1
{
    partial class frm_muestra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_muestra));
            this.txt_busc_id_mst = new System.Windows.Forms.TextBox();
            this.dgv_busc_mst = new System.Windows.Forms.DataGridView();
            this.grb_datos2_mst = new System.Windows.Forms.GroupBox();
            this.lbl_mst = new System.Windows.Forms.Label();
            this.grb_datos1_mst = new System.Windows.Forms.GroupBox();
            this.cbo_id_cliente = new System.Windows.Forms.ComboBox();
            this.cbo_tipo_mst = new System.Windows.Forms.ComboBox();
            this.Lbl_tip_mst = new System.Windows.Forms.Label();
            this.Lbl_id_clt_mst = new System.Windows.Forms.Label();
            this.Lbl_descr_mst = new System.Windows.Forms.Label();
            this.txt_descr_mst = new System.Windows.Forms.TextBox();
            this.Lbl_cantidad_mst = new System.Windows.Forms.Label();
            this.txt_cant_mst = new System.Windows.Forms.TextBox();
            this.Lbl_muestra = new System.Windows.Forms.Label();
            this.btn_busc_id_mst = new System.Windows.Forms.Button();
            this.btn_elim_mst = new System.Windows.Forms.Button();
            this.btn_actlz_mst = new System.Windows.Forms.Button();
            this.btn_guardar_mst = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_nuevo_pcnt = new System.Windows.Forms.Button();
            this.btn_acept = new System.Windows.Forms.Button();
            this.btn_cancl = new System.Windows.Forms.Button();
            this.btn_renov_pcnt = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst)).BeginInit();
            this.grb_datos2_mst.SuspendLayout();
            this.grb_datos1_mst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busc_id_mst
            // 
            this.txt_busc_id_mst.Location = new System.Drawing.Point(106, 23);
            this.txt_busc_id_mst.Name = "txt_busc_id_mst";
            this.txt_busc_id_mst.Size = new System.Drawing.Size(312, 23);
            this.txt_busc_id_mst.TabIndex = 167;
            this.txt_busc_id_mst.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_id_mst_KeyUp);
            // 
            // dgv_busc_mst
            // 
            this.dgv_busc_mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_mst.Location = new System.Drawing.Point(6, 56);
            this.dgv_busc_mst.Name = "dgv_busc_mst";
            this.dgv_busc_mst.Size = new System.Drawing.Size(412, 163);
            this.dgv_busc_mst.TabIndex = 0;
            this.dgv_busc_mst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_busc_mst_CellContentClick);
            // 
            // grb_datos2_mst
            // 
            this.grb_datos2_mst.Controls.Add(this.lbl_mst);
            this.grb_datos2_mst.Controls.Add(this.dgv_busc_mst);
            this.grb_datos2_mst.Controls.Add(this.txt_busc_id_mst);
            this.grb_datos2_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos2_mst.Location = new System.Drawing.Point(368, 129);
            this.grb_datos2_mst.Name = "grb_datos2_mst";
            this.grb_datos2_mst.Size = new System.Drawing.Size(424, 225);
            this.grb_datos2_mst.TabIndex = 165;
            this.grb_datos2_mst.TabStop = false;
            this.grb_datos2_mst.Text = "Muestras";
            // 
            // lbl_mst
            // 
            this.lbl_mst.AutoSize = true;
            this.lbl_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mst.Location = new System.Drawing.Point(12, 23);
            this.lbl_mst.Name = "lbl_mst";
            this.lbl_mst.Size = new System.Drawing.Size(73, 20);
            this.lbl_mst.TabIndex = 168;
            this.lbl_mst.Text = "Muestra:";
            // 
            // grb_datos1_mst
            // 
            this.grb_datos1_mst.Controls.Add(this.cbo_id_cliente);
            this.grb_datos1_mst.Controls.Add(this.cbo_tipo_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_tip_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_id_clt_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_descr_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_descr_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_cantidad_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_cant_mst);
            this.grb_datos1_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_mst.Location = new System.Drawing.Point(12, 129);
            this.grb_datos1_mst.Name = "grb_datos1_mst";
            this.grb_datos1_mst.Size = new System.Drawing.Size(350, 225);
            this.grb_datos1_mst.TabIndex = 164;
            this.grb_datos1_mst.TabStop = false;
            this.grb_datos1_mst.Text = "Datos de muestra";
            // 
            // cbo_id_cliente
            // 
            this.cbo_id_cliente.FormattingEnabled = true;
            this.cbo_id_cliente.Location = new System.Drawing.Point(108, 53);
            this.cbo_id_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_id_cliente.Name = "cbo_id_cliente";
            this.cbo_id_cliente.Size = new System.Drawing.Size(230, 24);
            this.cbo_id_cliente.TabIndex = 95;
            this.cbo_id_cliente.SelectedIndexChanged += new System.EventHandler(this.cbo_id_cliente_SelectedIndexChanged);
            // 
            // cbo_tipo_mst
            // 
            this.cbo_tipo_mst.FormattingEnabled = true;
            this.cbo_tipo_mst.Location = new System.Drawing.Point(108, 187);
            this.cbo_tipo_mst.Name = "cbo_tipo_mst";
            this.cbo_tipo_mst.Size = new System.Drawing.Size(230, 24);
            this.cbo_tipo_mst.TabIndex = 93;
            // 
            // Lbl_tip_mst
            // 
            this.Lbl_tip_mst.AutoSize = true;
            this.Lbl_tip_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tip_mst.Location = new System.Drawing.Point(1, 187);
            this.Lbl_tip_mst.Name = "Lbl_tip_mst";
            this.Lbl_tip_mst.Size = new System.Drawing.Size(105, 20);
            this.Lbl_tip_mst.TabIndex = 92;
            this.Lbl_tip_mst.Text = "Tipo Muestra:";
            // 
            // Lbl_id_clt_mst
            // 
            this.Lbl_id_clt_mst.AutoSize = true;
            this.Lbl_id_clt_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_clt_mst.Location = new System.Drawing.Point(14, 56);
            this.Lbl_id_clt_mst.Name = "Lbl_id_clt_mst";
            this.Lbl_id_clt_mst.Size = new System.Drawing.Size(88, 20);
            this.Lbl_id_clt_mst.TabIndex = 89;
            this.Lbl_id_clt_mst.Text = "Id Cliente: ";
            // 
            // Lbl_descr_mst
            // 
            this.Lbl_descr_mst.AutoSize = true;
            this.Lbl_descr_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descr_mst.Location = new System.Drawing.Point(6, 114);
            this.Lbl_descr_mst.Name = "Lbl_descr_mst";
            this.Lbl_descr_mst.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descr_mst.TabIndex = 85;
            this.Lbl_descr_mst.Text = "Descripcion:";
            // 
            // txt_descr_mst
            // 
            this.txt_descr_mst.Location = new System.Drawing.Point(108, 114);
            this.txt_descr_mst.Multiline = true;
            this.txt_descr_mst.Name = "txt_descr_mst";
            this.txt_descr_mst.Size = new System.Drawing.Size(230, 67);
            this.txt_descr_mst.TabIndex = 82;
            this.txt_descr_mst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_descr_mst_KeyDown);
            // 
            // Lbl_cantidad_mst
            // 
            this.Lbl_cantidad_mst.AutoSize = true;
            this.Lbl_cantidad_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad_mst.Location = new System.Drawing.Point(16, 85);
            this.Lbl_cantidad_mst.Name = "Lbl_cantidad_mst";
            this.Lbl_cantidad_mst.Size = new System.Drawing.Size(82, 20);
            this.Lbl_cantidad_mst.TabIndex = 81;
            this.Lbl_cantidad_mst.Text = "Cantidad:";
            // 
            // txt_cant_mst
            // 
            this.txt_cant_mst.Location = new System.Drawing.Point(108, 86);
            this.txt_cant_mst.Name = "txt_cant_mst";
            this.txt_cant_mst.Size = new System.Drawing.Size(230, 23);
            this.txt_cant_mst.TabIndex = 80;
            this.txt_cant_mst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_cant_mst_KeyDown);
            this.txt_cant_mst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_mst_KeyPress);
            // 
            // Lbl_muestra
            // 
            this.Lbl_muestra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_muestra.AutoSize = true;
            this.Lbl_muestra.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_muestra.Location = new System.Drawing.Point(342, 9);
            this.Lbl_muestra.Name = "Lbl_muestra";
            this.Lbl_muestra.Size = new System.Drawing.Size(134, 34);
            this.Lbl_muestra.TabIndex = 160;
            this.Lbl_muestra.Text = "Muestras";
            // 
            // btn_busc_id_mst
            // 
            this.btn_busc_id_mst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_mst.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_busc_id_mst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_busc_id_mst.FlatAppearance.BorderSize = 0;
            this.btn_busc_id_mst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_busc_id_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_mst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_id_mst.Location = new System.Drawing.Point(297, 52);
            this.btn_busc_id_mst.Name = "btn_busc_id_mst";
            this.btn_busc_id_mst.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_id_mst.TabIndex = 169;
            this.btn_busc_id_mst.Text = " ";
            this.btn_busc_id_mst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip5.SetToolTip(this.btn_busc_id_mst, "Buscar");
            this.btn_busc_id_mst.UseVisualStyleBackColor = true;
            this.btn_busc_id_mst.Click += new System.EventHandler(this.btn_busc_id_mst_Click);
            // 
            // btn_elim_mst
            // 
            this.btn_elim_mst.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_mst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_mst.FlatAppearance.BorderSize = 0;
            this.btn_elim_mst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_mst.Location = new System.Drawing.Point(226, 58);
            this.btn_elim_mst.Name = "btn_elim_mst";
            this.btn_elim_mst.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_mst.TabIndex = 163;
            this.btn_elim_mst.Text = " ";
            this.btn_elim_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_mst, "Eliminar");
            this.btn_elim_mst.UseVisualStyleBackColor = true;
            this.btn_elim_mst.Click += new System.EventHandler(this.btn_elim_mst_Click);
            // 
            // btn_actlz_mst
            // 
            this.btn_actlz_mst.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_mst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_mst.FlatAppearance.BorderSize = 0;
            this.btn_actlz_mst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_mst.Location = new System.Drawing.Point(155, 58);
            this.btn_actlz_mst.Name = "btn_actlz_mst";
            this.btn_actlz_mst.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_mst.TabIndex = 162;
            this.btn_actlz_mst.Text = " ";
            this.btn_actlz_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_mst, "Modificar");
            this.btn_actlz_mst.UseVisualStyleBackColor = true;
            this.btn_actlz_mst.Click += new System.EventHandler(this.btn_actlz_mst_Click);
            // 
            // btn_guardar_mst
            // 
            this.btn_guardar_mst.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_mst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_mst.FlatAppearance.BorderSize = 0;
            this.btn_guardar_mst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_mst.Location = new System.Drawing.Point(84, 58);
            this.btn_guardar_mst.Name = "btn_guardar_mst";
            this.btn_guardar_mst.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_mst.TabIndex = 161;
            this.btn_guardar_mst.Text = " ";
            this.btn_guardar_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_mst, "Guardar");
            this.btn_guardar_mst.UseVisualStyleBackColor = true;
            this.btn_guardar_mst.Click += new System.EventHandler(this.btn_guardar_mst_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Image = global::WindowsFormsApplication1.Properties.Resources.Clinica;
            this.pic_logo.Location = new System.Drawing.Point(693, 17);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(106, 0);
            this.pic_logo.TabIndex = 159;
            this.pic_logo.TabStop = false;
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(12, 58);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 170;
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
            this.btn_acept.Location = new System.Drawing.Point(439, 52);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 173;
            this.toolTip7.SetToolTip(this.btn_acept, "Aceptar");
            this.btn_acept.UseVisualStyleBackColor = true;
            this.btn_acept.Click += new System.EventHandler(this.btn_acept_Click);
            // 
            // btn_cancl
            // 
            this.btn_cancl.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete_icon;
            this.btn_cancl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancl.Enabled = false;
            this.btn_cancl.FlatAppearance.BorderSize = 0;
            this.btn_cancl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancl.Location = new System.Drawing.Point(368, 52);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 172;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_Click);
            // 
            // btn_renov_pcnt
            // 
            this.btn_renov_pcnt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_renov_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_renov_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_renov_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_renov_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_renov_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renov_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renov_pcnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_renov_pcnt.Location = new System.Drawing.Point(510, 54);
            this.btn_renov_pcnt.Name = "btn_renov_pcnt";
            this.btn_renov_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_renov_pcnt.TabIndex = 171;
            this.btn_renov_pcnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip8.SetToolTip(this.btn_renov_pcnt, "Actualizar");
            this.btn_renov_pcnt.UseVisualStyleBackColor = true;
            this.btn_renov_pcnt.Click += new System.EventHandler(this.btn_renov_pcnt_Click);
            // 
            // frm_muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 406);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_renov_pcnt);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.btn_busc_id_mst);
            this.Controls.Add(this.grb_datos2_mst);
            this.Controls.Add(this.grb_datos1_mst);
            this.Controls.Add(this.btn_elim_mst);
            this.Controls.Add(this.btn_actlz_mst);
            this.Controls.Add(this.btn_guardar_mst);
            this.Controls.Add(this.Lbl_muestra);
            this.Controls.Add(this.pic_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_muestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra";
            this.Load += new System.EventHandler(this.frm_muestra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst)).EndInit();
            this.grb_datos2_mst.ResumeLayout(false);
            this.grb_datos2_mst.PerformLayout();
            this.grb_datos1_mst.ResumeLayout(false);
            this.grb_datos1_mst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_busc_id_mst;
        internal System.Windows.Forms.TextBox txt_busc_id_mst;
        private System.Windows.Forms.DataGridView dgv_busc_mst;
        private System.Windows.Forms.GroupBox grb_datos2_mst;
        private System.Windows.Forms.GroupBox grb_datos1_mst;
        internal System.Windows.Forms.Label Lbl_id_clt_mst;
        internal System.Windows.Forms.Label Lbl_descr_mst;
        internal System.Windows.Forms.TextBox txt_descr_mst;
        internal System.Windows.Forms.Label Lbl_cantidad_mst;
        internal System.Windows.Forms.TextBox txt_cant_mst;
        private System.Windows.Forms.Button btn_elim_mst;
        private System.Windows.Forms.Button btn_actlz_mst;
        private System.Windows.Forms.Button btn_guardar_mst;
        internal System.Windows.Forms.Label Lbl_muestra;
        internal System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.ComboBox cbo_tipo_mst;
        internal System.Windows.Forms.Label Lbl_tip_mst;
        private System.Windows.Forms.ComboBox cbo_id_cliente;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_renov_pcnt;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip8;
        internal System.Windows.Forms.Label lbl_mst;
    }
}