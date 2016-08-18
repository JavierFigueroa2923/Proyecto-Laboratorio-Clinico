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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_inventario));
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.Lbl_cant = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.gpb_datos_inv_sumin = new System.Windows.Forms.GroupBox();
            this.cbo_id_laboratorio = new System.Windows.Forms.ComboBox();
            this.lbl_laboratorio = new System.Windows.Forms.Label();
            this.txt_prec_vent_inv_sumin = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txt_prec_comp_inv_sumin = new System.Windows.Forms.TextBox();
            this.lbl_prec_vent_inv_sumin = new System.Windows.Forms.Label();
            this.txt_nombre_sm = new System.Windows.Forms.TextBox();
            this.lbl_nom_sumin = new System.Windows.Forms.Label();
            this.gpb_vista_inv_sumin = new System.Windows.Forms.GroupBox();
            this.dgv_vista_inv_sumin = new System.Windows.Forms.DataGridView();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.btn_busc_tip_exam = new System.Windows.Forms.Button();
            this.txt_busc_tips_exam = new System.Windows.Forms.TextBox();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.btn_elim_inv_sumin = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.gpb_datos_inv_sumin.SuspendLayout();
            this.gpb_vista_inv_sumin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_inv_sumin)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(2, 84);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 56;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(114, 84);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(297, 150);
            this.txt_desc.TabIndex = 9;
            // 
            // Lbl_cant
            // 
            this.Lbl_cant.AutoSize = true;
            this.Lbl_cant.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cant.Location = new System.Drawing.Point(6, 240);
            this.Lbl_cant.Name = "Lbl_cant";
            this.Lbl_cant.Size = new System.Drawing.Size(160, 20);
            this.Lbl_cant.TabIndex = 54;
            this.Lbl_cant.Text = "Cantidad disponible:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(172, 240);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(79, 23);
            this.txt_cantidad.TabIndex = 10;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
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
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(345, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(351, 34);
            this.Lbl_titulo.TabIndex = 51;
            this.Lbl_titulo.Text = "Inventario de Suministros";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // gpb_datos_inv_sumin
            // 
            this.gpb_datos_inv_sumin.Controls.Add(this.cbo_id_laboratorio);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl_laboratorio);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_prec_vent_inv_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_prec_comp_inv_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl_prec_vent_inv_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_nombre_sm);
            this.gpb_datos_inv_sumin.Controls.Add(this.lbl_nom_sumin);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_desc);
            this.gpb_datos_inv_sumin.Controls.Add(this.txt_cantidad);
            this.gpb_datos_inv_sumin.Controls.Add(this.Lbl_cant);
            this.gpb_datos_inv_sumin.Controls.Add(this.Lbl_descripcion);
            this.gpb_datos_inv_sumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_inv_sumin.Location = new System.Drawing.Point(12, 132);
            this.gpb_datos_inv_sumin.Name = "gpb_datos_inv_sumin";
            this.gpb_datos_inv_sumin.Size = new System.Drawing.Size(423, 337);
            this.gpb_datos_inv_sumin.TabIndex = 60;
            this.gpb_datos_inv_sumin.TabStop = false;
            this.gpb_datos_inv_sumin.Text = "Informacion del Inventario";
            // 
            // cbo_id_laboratorio
            // 
            this.cbo_id_laboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_id_laboratorio.FormattingEnabled = true;
            this.cbo_id_laboratorio.Location = new System.Drawing.Point(136, 308);
            this.cbo_id_laboratorio.Name = "cbo_id_laboratorio";
            this.cbo_id_laboratorio.Size = new System.Drawing.Size(121, 24);
            this.cbo_id_laboratorio.TabIndex = 13;
            // 
            // lbl_laboratorio
            // 
            this.lbl_laboratorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_laboratorio.AutoSize = true;
            this.lbl_laboratorio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbl_laboratorio.Location = new System.Drawing.Point(32, 308);
            this.lbl_laboratorio.Name = "lbl_laboratorio";
            this.lbl_laboratorio.Size = new System.Drawing.Size(98, 20);
            this.lbl_laboratorio.TabIndex = 65;
            this.lbl_laboratorio.Text = "Laboratorio:";
            // 
            // txt_prec_vent_inv_sumin
            // 
            this.txt_prec_vent_inv_sumin.Location = new System.Drawing.Point(363, 273);
            this.txt_prec_vent_inv_sumin.Name = "txt_prec_vent_inv_sumin";
            this.txt_prec_vent_inv_sumin.Size = new System.Drawing.Size(46, 23);
            this.txt_prec_vent_inv_sumin.TabIndex = 12;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(248, 273);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(109, 20);
            this.lbl.TabIndex = 64;
            this.lbl.Text = "Precio Venta:";
            this.lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_prec_comp_inv_sumin
            // 
            this.txt_prec_comp_inv_sumin.Location = new System.Drawing.Point(136, 273);
            this.txt_prec_comp_inv_sumin.Name = "txt_prec_comp_inv_sumin";
            this.txt_prec_comp_inv_sumin.Size = new System.Drawing.Size(46, 23);
            this.txt_prec_comp_inv_sumin.TabIndex = 11;
            // 
            // lbl_prec_vent_inv_sumin
            // 
            this.lbl_prec_vent_inv_sumin.AutoSize = true;
            this.lbl_prec_vent_inv_sumin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prec_vent_inv_sumin.Location = new System.Drawing.Point(6, 273);
            this.lbl_prec_vent_inv_sumin.Name = "lbl_prec_vent_inv_sumin";
            this.lbl_prec_vent_inv_sumin.Size = new System.Drawing.Size(124, 20);
            this.lbl_prec_vent_inv_sumin.TabIndex = 62;
            this.lbl_prec_vent_inv_sumin.Text = "Precio Compra:";
            // 
            // txt_nombre_sm
            // 
            this.txt_nombre_sm.Location = new System.Drawing.Point(169, 55);
            this.txt_nombre_sm.Name = "txt_nombre_sm";
            this.txt_nombre_sm.Size = new System.Drawing.Size(242, 23);
            this.txt_nombre_sm.TabIndex = 8;
            // 
            // lbl_nom_sumin
            // 
            this.lbl_nom_sumin.AutoSize = true;
            this.lbl_nom_sumin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_sumin.Location = new System.Drawing.Point(2, 55);
            this.lbl_nom_sumin.Name = "lbl_nom_sumin";
            this.lbl_nom_sumin.Size = new System.Drawing.Size(146, 20);
            this.lbl_nom_sumin.TabIndex = 60;
            this.lbl_nom_sumin.Text = "Nombre Suministro:";
            // 
            // gpb_vista_inv_sumin
            // 
            this.gpb_vista_inv_sumin.Controls.Add(this.dgv_vista_inv_sumin);
            this.gpb_vista_inv_sumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_inv_sumin.Location = new System.Drawing.Point(441, 132);
            this.gpb_vista_inv_sumin.Name = "gpb_vista_inv_sumin";
            this.gpb_vista_inv_sumin.Size = new System.Drawing.Size(489, 337);
            this.gpb_vista_inv_sumin.TabIndex = 61;
            this.gpb_vista_inv_sumin.TabStop = false;
            this.gpb_vista_inv_sumin.Text = "Suministros";
            // 
            // dgv_vista_inv_sumin
            // 
            this.dgv_vista_inv_sumin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vista_inv_sumin.Location = new System.Drawing.Point(6, 22);
            this.dgv_vista_inv_sumin.Name = "dgv_vista_inv_sumin";
            this.dgv_vista_inv_sumin.Size = new System.Drawing.Size(477, 306);
            this.dgv_vista_inv_sumin.TabIndex = 0;
            // 
            // lbl_busc_tip_exam
            // 
            this.lbl_busc_tip_exam.AutoSize = true;
            this.lbl_busc_tip_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(587, 104);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 135;
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
            this.btn_busc_tip_exam.Location = new System.Drawing.Point(296, 59);
            this.btn_busc_tip_exam.Name = "btn_busc_tip_exam";
            this.btn_busc_tip_exam.Size = new System.Drawing.Size(65, 65);
            this.btn_busc_tip_exam.TabIndex = 5;
            this.btn_busc_tip_exam.Text = " ";
            this.btn_busc_tip_exam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_busc_tip_exam, "Buscar");
            this.btn_busc_tip_exam.UseVisualStyleBackColor = true;
            this.btn_busc_tip_exam.Click += new System.EventHandler(this.btn_busc_tip_exam_Click);
            // 
            // txt_busc_tips_exam
            // 
            this.txt_busc_tips_exam.Location = new System.Drawing.Point(655, 106);
            this.txt_busc_tips_exam.Name = "txt_busc_tips_exam";
            this.txt_busc_tips_exam.Size = new System.Drawing.Size(158, 20);
            this.txt_busc_tips_exam.TabIndex = 14;
            this.txt_busc_tips_exam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_tips_exam_KeyUp);
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_aseg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_aseg.FlatAppearance.BorderSize = 0;
            this.btn_actlz_aseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(154, 59);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_aseg.TabIndex = 3;
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
            this.btn_guardar_aseg.Location = new System.Drawing.Point(83, 59);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_aseg.TabIndex = 2;
            this.btn_guardar_aseg.Text = " ";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_aseg, "Guardar");
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            this.btn_guardar_aseg.Click += new System.EventHandler(this.btn_guardar_aseg_Click);
            // 
            // btn_elim_inv_sumin
            // 
            this.btn_elim_inv_sumin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_inv_sumin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_inv_sumin.FlatAppearance.BorderSize = 0;
            this.btn_elim_inv_sumin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_inv_sumin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_inv_sumin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_inv_sumin.Location = new System.Drawing.Point(225, 59);
            this.btn_elim_inv_sumin.Name = "btn_elim_inv_sumin";
            this.btn_elim_inv_sumin.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_inv_sumin.TabIndex = 4;
            this.btn_elim_inv_sumin.Text = " ";
            this.btn_elim_inv_sumin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_inv_sumin, "Eliminar");
            this.btn_elim_inv_sumin.UseVisualStyleBackColor = true;
            this.btn_elim_inv_sumin.Click += new System.EventHandler(this.btn_elim_inv_sumin_Click);
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(12, 59);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 1;
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
            this.btn_acept.Location = new System.Drawing.Point(438, 59);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 145;
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
            this.btn_cancl.Location = new System.Drawing.Point(367, 59);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 6;
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
            this.btn_renov_pcnt.Location = new System.Drawing.Point(508, 59);
            this.btn_renov_pcnt.Name = "btn_renov_pcnt";
            this.btn_renov_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_renov_pcnt.TabIndex = 7;
            this.btn_renov_pcnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip8.SetToolTip(this.btn_renov_pcnt, "Actualizar");
            this.btn_renov_pcnt.UseVisualStyleBackColor = true;
            this.btn_renov_pcnt.Click += new System.EventHandler(this.btn_renov_pcnt_Click);
            // 
            // frm_act_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 481);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_renov_pcnt);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.btn_elim_inv_sumin);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_tip_exam);
            this.Controls.Add(this.txt_busc_tips_exam);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_inv_sumin);
            this.Controls.Add(this.gpb_datos_inv_sumin);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_act_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suministros";
            this.Load += new System.EventHandler(this.frm_act_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.gpb_datos_inv_sumin.ResumeLayout(false);
            this.gpb_datos_inv_sumin.PerformLayout();
            this.gpb_vista_inv_sumin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vista_inv_sumin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_desc;
        internal System.Windows.Forms.Label Lbl_cant;
        internal System.Windows.Forms.TextBox txt_cantidad;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.GroupBox gpb_datos_inv_sumin;
        internal System.Windows.Forms.TextBox txt_prec_vent_inv_sumin;
        internal System.Windows.Forms.Label lbl;
        internal System.Windows.Forms.TextBox txt_prec_comp_inv_sumin;
        internal System.Windows.Forms.Label lbl_prec_vent_inv_sumin;
        internal System.Windows.Forms.TextBox txt_nombre_sm;
        internal System.Windows.Forms.Label lbl_nom_sumin;
        private System.Windows.Forms.GroupBox gpb_vista_inv_sumin;
        private System.Windows.Forms.DataGridView dgv_vista_inv_sumin;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        private System.Windows.Forms.Button btn_busc_tip_exam;
        internal System.Windows.Forms.TextBox txt_busc_tips_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        private System.Windows.Forms.Button btn_elim_inv_sumin;
        private System.Windows.Forms.ComboBox cbo_id_laboratorio;
        private System.Windows.Forms.Label lbl_laboratorio;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.Button btn_renov_pcnt;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip8;
    }
}