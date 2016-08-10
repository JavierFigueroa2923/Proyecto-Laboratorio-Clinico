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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_muestra));
            this.txt_busc_id_mst = new System.Windows.Forms.TextBox();
            this.lbl_busca_mst = new System.Windows.Forms.Label();
            this.grb_vista_mst = new System.Windows.Forms.GroupBox();
            this.dgv_busc_mst = new System.Windows.Forms.DataGridView();
            this.grb_datos2_mst = new System.Windows.Forms.GroupBox();
            this.dgv_id_clt_mst = new System.Windows.Forms.DataGridView();
            this.btn_busc_id_clt_mst = new System.Windows.Forms.Button();
            this.Lbl_id_usur_per = new System.Windows.Forms.Label();
            this.txt_busc_id_clt_mst = new System.Windows.Forms.TextBox();
            this.grb_datos1_mst = new System.Windows.Forms.GroupBox();
            this.cbo_id_cliente = new System.Windows.Forms.ComboBox();
            this.cbo_id_muestra = new System.Windows.Forms.ComboBox();
            this.cbo_tipo_mst = new System.Windows.Forms.ComboBox();
            this.Lbl_tip_mst = new System.Windows.Forms.Label();
            this.Lbl_id_mst = new System.Windows.Forms.Label();
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
            this.grb_vista_mst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst)).BeginInit();
            this.grb_datos2_mst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_id_clt_mst)).BeginInit();
            this.grb_datos1_mst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_busc_id_mst
            // 
            this.txt_busc_id_mst.Location = new System.Drawing.Point(203, 399);
            this.txt_busc_id_mst.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busc_id_mst.Name = "txt_busc_id_mst";
            this.txt_busc_id_mst.Size = new System.Drawing.Size(629, 22);
            this.txt_busc_id_mst.TabIndex = 167;
            // 
            // lbl_busca_mst
            // 
            this.lbl_busca_mst.AutoSize = true;
            this.lbl_busca_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_mst.Location = new System.Drawing.Point(23, 395);
            this.lbl_busca_mst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_busca_mst.Name = "lbl_busca_mst";
            this.lbl_busca_mst.Size = new System.Drawing.Size(162, 22);
            this.lbl_busca_mst.TabIndex = 166;
            this.lbl_busca_mst.Text = "Buscar Muestras:";
            // 
            // grb_vista_mst
            // 
            this.grb_vista_mst.Controls.Add(this.dgv_busc_mst);
            this.grb_vista_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_vista_mst.Location = new System.Drawing.Point(43, 423);
            this.grb_vista_mst.Margin = new System.Windows.Forms.Padding(4);
            this.grb_vista_mst.Name = "grb_vista_mst";
            this.grb_vista_mst.Padding = new System.Windows.Forms.Padding(4);
            this.grb_vista_mst.Size = new System.Drawing.Size(1005, 201);
            this.grb_vista_mst.TabIndex = 168;
            this.grb_vista_mst.TabStop = false;
            this.grb_vista_mst.Text = "Muestras";
            // 
            // dgv_busc_mst
            // 
            this.dgv_busc_mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busc_mst.Location = new System.Drawing.Point(12, 27);
            this.dgv_busc_mst.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_busc_mst.Name = "dgv_busc_mst";
            this.dgv_busc_mst.Size = new System.Drawing.Size(985, 166);
            this.dgv_busc_mst.TabIndex = 0;
            this.dgv_busc_mst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_busc_mst_CellContentClick);
            // 
            // grb_datos2_mst
            // 
            this.grb_datos2_mst.Controls.Add(this.dgv_id_clt_mst);
            this.grb_datos2_mst.Controls.Add(this.btn_busc_id_clt_mst);
            this.grb_datos2_mst.Controls.Add(this.Lbl_id_usur_per);
            this.grb_datos2_mst.Controls.Add(this.txt_busc_id_clt_mst);
            this.grb_datos2_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos2_mst.Location = new System.Drawing.Point(609, 151);
            this.grb_datos2_mst.Margin = new System.Windows.Forms.Padding(4);
            this.grb_datos2_mst.Name = "grb_datos2_mst";
            this.grb_datos2_mst.Padding = new System.Windows.Forms.Padding(4);
            this.grb_datos2_mst.Size = new System.Drawing.Size(451, 233);
            this.grb_datos2_mst.TabIndex = 165;
            this.grb_datos2_mst.TabStop = false;
            this.grb_datos2_mst.Text = "Datos de cliente";
            // 
            // dgv_id_clt_mst
            // 
            this.dgv_id_clt_mst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_id_clt_mst.Location = new System.Drawing.Point(13, 78);
            this.dgv_id_clt_mst.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_id_clt_mst.Name = "dgv_id_clt_mst";
            this.dgv_id_clt_mst.Size = new System.Drawing.Size(429, 138);
            this.dgv_id_clt_mst.TabIndex = 133;
            this.dgv_id_clt_mst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_id_clt_mst_CellContentClick);
            // 
            // btn_busc_id_clt_mst
            // 
            this.btn_busc_id_clt_mst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_clt_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_clt_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_clt_mst.Location = new System.Drawing.Point(389, 20);
            this.btn_busc_id_clt_mst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busc_id_clt_mst.Name = "btn_busc_id_clt_mst";
            this.btn_busc_id_clt_mst.Size = new System.Drawing.Size(59, 50);
            this.btn_busc_id_clt_mst.TabIndex = 132;
            this.btn_busc_id_clt_mst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_clt_mst.UseVisualStyleBackColor = true;
            this.btn_busc_id_clt_mst.Click += new System.EventHandler(this.btn_busc_id_clt_mst_Click);
            // 
            // Lbl_id_usur_per
            // 
            this.Lbl_id_usur_per.AutoSize = true;
            this.Lbl_id_usur_per.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_usur_per.Location = new System.Drawing.Point(8, 39);
            this.Lbl_id_usur_per.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_usur_per.Name = "Lbl_id_usur_per";
            this.Lbl_id_usur_per.Size = new System.Drawing.Size(102, 22);
            this.Lbl_id_usur_per.TabIndex = 85;
            this.Lbl_id_usur_per.Text = "Id Cliente:";
            // 
            // txt_busc_id_clt_mst
            // 
            this.txt_busc_id_clt_mst.Location = new System.Drawing.Point(131, 39);
            this.txt_busc_id_clt_mst.Margin = new System.Windows.Forms.Padding(4);
            this.txt_busc_id_clt_mst.Multiline = true;
            this.txt_busc_id_clt_mst.Name = "txt_busc_id_clt_mst";
            this.txt_busc_id_clt_mst.Size = new System.Drawing.Size(252, 27);
            this.txt_busc_id_clt_mst.TabIndex = 82;
            // 
            // grb_datos1_mst
            // 
            this.grb_datos1_mst.Controls.Add(this.cbo_id_cliente);
            this.grb_datos1_mst.Controls.Add(this.cbo_id_muestra);
            this.grb_datos1_mst.Controls.Add(this.cbo_tipo_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_tip_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_id_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_id_clt_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_descr_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_descr_mst);
            this.grb_datos1_mst.Controls.Add(this.Lbl_cantidad_mst);
            this.grb_datos1_mst.Controls.Add(this.txt_cant_mst);
            this.grb_datos1_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_datos1_mst.Location = new System.Drawing.Point(-9, 151);
            this.grb_datos1_mst.Margin = new System.Windows.Forms.Padding(4);
            this.grb_datos1_mst.Name = "grb_datos1_mst";
            this.grb_datos1_mst.Padding = new System.Windows.Forms.Padding(4);
            this.grb_datos1_mst.Size = new System.Drawing.Size(581, 233);
            this.grb_datos1_mst.TabIndex = 164;
            this.grb_datos1_mst.TabStop = false;
            this.grb_datos1_mst.Text = "Datos de muestra";
            // 
            // cbo_id_cliente
            // 
            this.cbo_id_cliente.FormattingEnabled = true;
            this.cbo_id_cliente.Location = new System.Drawing.Point(144, 60);
            this.cbo_id_cliente.Name = "cbo_id_cliente";
            this.cbo_id_cliente.Size = new System.Drawing.Size(412, 28);
            this.cbo_id_cliente.TabIndex = 95;
            // 
            // cbo_id_muestra
            // 
            this.cbo_id_muestra.FormattingEnabled = true;
            this.cbo_id_muestra.Location = new System.Drawing.Point(144, 26);
            this.cbo_id_muestra.Name = "cbo_id_muestra";
            this.cbo_id_muestra.Size = new System.Drawing.Size(412, 28);
            this.cbo_id_muestra.TabIndex = 94;
            this.cbo_id_muestra.SelectedIndexChanged += new System.EventHandler(this.cbo_id_muestra_SelectedIndexChanged);
            // 
            // cbo_tipo_mst
            // 
            this.cbo_tipo_mst.FormattingEnabled = true;
            this.cbo_tipo_mst.Location = new System.Drawing.Point(144, 172);
            this.cbo_tipo_mst.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_tipo_mst.Name = "cbo_tipo_mst";
            this.cbo_tipo_mst.Size = new System.Drawing.Size(412, 28);
            this.cbo_tipo_mst.TabIndex = 93;
            // 
            // Lbl_tip_mst
            // 
            this.Lbl_tip_mst.AutoSize = true;
            this.Lbl_tip_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tip_mst.Location = new System.Drawing.Point(85, 175);
            this.Lbl_tip_mst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tip_mst.Name = "Lbl_tip_mst";
            this.Lbl_tip_mst.Size = new System.Drawing.Size(51, 22);
            this.Lbl_tip_mst.TabIndex = 92;
            this.Lbl_tip_mst.Text = "Tipo:";
            // 
            // Lbl_id_mst
            // 
            this.Lbl_id_mst.AutoSize = true;
            this.Lbl_id_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_mst.Location = new System.Drawing.Point(12, 32);
            this.Lbl_id_mst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_mst.Name = "Lbl_id_mst";
            this.Lbl_id_mst.Size = new System.Drawing.Size(112, 22);
            this.Lbl_id_mst.TabIndex = 90;
            this.Lbl_id_mst.Text = "Id Muestra:";
            // 
            // Lbl_id_clt_mst
            // 
            this.Lbl_id_clt_mst.AutoSize = true;
            this.Lbl_id_clt_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_clt_mst.Location = new System.Drawing.Point(19, 69);
            this.Lbl_id_clt_mst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_clt_mst.Name = "Lbl_id_clt_mst";
            this.Lbl_id_clt_mst.Size = new System.Drawing.Size(107, 22);
            this.Lbl_id_clt_mst.TabIndex = 89;
            this.Lbl_id_clt_mst.Text = "Id Cliente: ";
            // 
            // Lbl_descr_mst
            // 
            this.Lbl_descr_mst.AutoSize = true;
            this.Lbl_descr_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descr_mst.Location = new System.Drawing.Point(8, 140);
            this.Lbl_descr_mst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descr_mst.Name = "Lbl_descr_mst";
            this.Lbl_descr_mst.Size = new System.Drawing.Size(121, 22);
            this.Lbl_descr_mst.TabIndex = 85;
            this.Lbl_descr_mst.Text = "Descripcion:";
            // 
            // txt_descr_mst
            // 
            this.txt_descr_mst.Location = new System.Drawing.Point(144, 140);
            this.txt_descr_mst.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descr_mst.Multiline = true;
            this.txt_descr_mst.Name = "txt_descr_mst";
            this.txt_descr_mst.Size = new System.Drawing.Size(412, 24);
            this.txt_descr_mst.TabIndex = 82;
            // 
            // Lbl_cantidad_mst
            // 
            this.Lbl_cantidad_mst.AutoSize = true;
            this.Lbl_cantidad_mst.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad_mst.Location = new System.Drawing.Point(21, 105);
            this.Lbl_cantidad_mst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_cantidad_mst.Name = "Lbl_cantidad_mst";
            this.Lbl_cantidad_mst.Size = new System.Drawing.Size(104, 22);
            this.Lbl_cantidad_mst.TabIndex = 81;
            this.Lbl_cantidad_mst.Text = "Cantidad:";
            // 
            // txt_cant_mst
            // 
            this.txt_cant_mst.Location = new System.Drawing.Point(144, 106);
            this.txt_cant_mst.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cant_mst.Name = "txt_cant_mst";
            this.txt_cant_mst.Size = new System.Drawing.Size(412, 26);
            this.txt_cant_mst.TabIndex = 80;
            // 
            // Lbl_muestra
            // 
            this.Lbl_muestra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_muestra.AutoSize = true;
            this.Lbl_muestra.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_muestra.Location = new System.Drawing.Point(429, 21);
            this.Lbl_muestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_muestra.Name = "Lbl_muestra";
            this.Lbl_muestra.Size = new System.Drawing.Size(166, 41);
            this.Lbl_muestra.TabIndex = 160;
            this.Lbl_muestra.Text = "Muestras";
            // 
            // btn_busc_id_mst
            // 
            this.btn_busc_id_mst.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_id_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_id_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_id_mst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_id_mst.Location = new System.Drawing.Point(868, 385);
            this.btn_busc_id_mst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_busc_id_mst.Name = "btn_busc_id_mst";
            this.btn_busc_id_mst.Size = new System.Drawing.Size(152, 49);
            this.btn_busc_id_mst.TabIndex = 169;
            this.btn_busc_id_mst.Text = "BUSCAR";
            this.btn_busc_id_mst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_id_mst.UseVisualStyleBackColor = true;
            this.btn_busc_id_mst.Click += new System.EventHandler(this.btn_busc_id_mst_Click);
            // 
            // btn_elim_mst
            // 
            this.btn_elim_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_mst.Location = new System.Drawing.Point(288, 78);
            this.btn_elim_mst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_elim_mst.Name = "btn_elim_mst";
            this.btn_elim_mst.Size = new System.Drawing.Size(125, 66);
            this.btn_elim_mst.TabIndex = 163;
            this.btn_elim_mst.Text = "ELIMINAR";
            this.btn_elim_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_mst.UseVisualStyleBackColor = true;
            this.btn_elim_mst.Click += new System.EventHandler(this.btn_elim_mst_Click);
            // 
            // btn_actlz_mst
            // 
            this.btn_actlz_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_mst.Location = new System.Drawing.Point(155, 78);
            this.btn_actlz_mst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actlz_mst.Name = "btn_actlz_mst";
            this.btn_actlz_mst.Size = new System.Drawing.Size(125, 66);
            this.btn_actlz_mst.TabIndex = 162;
            this.btn_actlz_mst.Text = "ACTUALIZAR";
            this.btn_actlz_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_mst.UseVisualStyleBackColor = true;
            this.btn_actlz_mst.Click += new System.EventHandler(this.btn_actlz_mst_Click);
            // 
            // btn_guardar_mst
            // 
            this.btn_guardar_mst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_mst.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_mst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_mst.Location = new System.Drawing.Point(21, 78);
            this.btn_guardar_mst.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar_mst.Name = "btn_guardar_mst";
            this.btn_guardar_mst.Size = new System.Drawing.Size(125, 66);
            this.btn_guardar_mst.TabIndex = 161;
            this.btn_guardar_mst.Text = "GUARDAR";
            this.btn_guardar_mst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_mst.UseVisualStyleBackColor = true;
            this.btn_guardar_mst.Click += new System.EventHandler(this.btn_guardar_mst_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_logo.Image = global::WindowsFormsApplication1.Properties.Resources.Clinica;
            this.pic_logo.Location = new System.Drawing.Point(924, 21);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(141, 123);
            this.pic_logo.TabIndex = 159;
            this.pic_logo.TabStop = false;
            // 
            // frm_muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 646);
            this.Controls.Add(this.btn_busc_id_mst);
            this.Controls.Add(this.txt_busc_id_mst);
            this.Controls.Add(this.lbl_busca_mst);
            this.Controls.Add(this.grb_vista_mst);
            this.Controls.Add(this.grb_datos2_mst);
            this.Controls.Add(this.grb_datos1_mst);
            this.Controls.Add(this.btn_elim_mst);
            this.Controls.Add(this.btn_actlz_mst);
            this.Controls.Add(this.btn_guardar_mst);
            this.Controls.Add(this.Lbl_muestra);
            this.Controls.Add(this.pic_logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_muestra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muestra";
            this.grb_vista_mst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busc_mst)).EndInit();
            this.grb_datos2_mst.ResumeLayout(false);
            this.grb_datos2_mst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_id_clt_mst)).EndInit();
            this.grb_datos1_mst.ResumeLayout(false);
            this.grb_datos1_mst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_busc_id_mst;
        internal System.Windows.Forms.TextBox txt_busc_id_mst;
        internal System.Windows.Forms.Label lbl_busca_mst;
        private System.Windows.Forms.GroupBox grb_vista_mst;
        private System.Windows.Forms.DataGridView dgv_busc_mst;
        private System.Windows.Forms.GroupBox grb_datos2_mst;
        private System.Windows.Forms.DataGridView dgv_id_clt_mst;
        private System.Windows.Forms.Button btn_busc_id_clt_mst;
        internal System.Windows.Forms.Label Lbl_id_usur_per;
        internal System.Windows.Forms.TextBox txt_busc_id_clt_mst;
        private System.Windows.Forms.GroupBox grb_datos1_mst;
        internal System.Windows.Forms.Label Lbl_id_mst;
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
        private System.Windows.Forms.ComboBox cbo_id_muestra;
    }
}