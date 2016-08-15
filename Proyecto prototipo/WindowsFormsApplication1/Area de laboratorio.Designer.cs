namespace WindowsFormsApplication1
{
    partial class Area_de_laboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_de_laboratorio));
            this.lbl_area_laboratorio = new System.Windows.Forms.Label();
            this.gpb_datos_area_lab = new System.Windows.Forms.GroupBox();
            this.txt_descrip_area = new System.Windows.Forms.TextBox();
            this.lbl_descrip_area_lab = new System.Windows.Forms.Label();
            this.lbl_id_lab = new System.Windows.Forms.Label();
            this.gpb_vista_labs = new System.Windows.Forms.GroupBox();
            this.dgv_area_labs = new System.Windows.Forms.DataGridView();
            this.lbl_busq = new System.Windows.Forms.Label();
            this.btn_buscar_lab = new System.Windows.Forms.Button();
            this.btn_act_data = new System.Windows.Forms.Button();
            this.btn_elim_area = new System.Windows.Forms.Button();
            this.btn_actlz_area = new System.Windows.Forms.Button();
            this.btn_guardar_area = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.cbo_id_lab = new System.Windows.Forms.ComboBox();
            this.txt_busc_are_lab = new System.Windows.Forms.TextBox();
            this.gpb_datos_area_lab.SuspendLayout();
            this.gpb_vista_labs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_area_labs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_area_laboratorio
            // 
            this.lbl_area_laboratorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_area_laboratorio.AutoSize = true;
            this.lbl_area_laboratorio.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area_laboratorio.Location = new System.Drawing.Point(268, 9);
            this.lbl_area_laboratorio.Name = "lbl_area_laboratorio";
            this.lbl_area_laboratorio.Size = new System.Drawing.Size(291, 34);
            this.lbl_area_laboratorio.TabIndex = 56;
            this.lbl_area_laboratorio.Text = "Área de Laboratorio";
            // 
            // gpb_datos_area_lab
            // 
            this.gpb_datos_area_lab.Controls.Add(this.cbo_id_lab);
            this.gpb_datos_area_lab.Controls.Add(this.txt_descrip_area);
            this.gpb_datos_area_lab.Controls.Add(this.lbl_descrip_area_lab);
            this.gpb_datos_area_lab.Controls.Add(this.lbl_id_lab);
            this.gpb_datos_area_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_area_lab.Location = new System.Drawing.Point(12, 167);
            this.gpb_datos_area_lab.Name = "gpb_datos_area_lab";
            this.gpb_datos_area_lab.Size = new System.Drawing.Size(344, 287);
            this.gpb_datos_area_lab.TabIndex = 152;
            this.gpb_datos_area_lab.TabStop = false;
            this.gpb_datos_area_lab.Text = "Ingreso de datos";
            // 
            // txt_descrip_area
            // 
            this.txt_descrip_area.Location = new System.Drawing.Point(9, 92);
            this.txt_descrip_area.Multiline = true;
            this.txt_descrip_area.Name = "txt_descrip_area";
            this.txt_descrip_area.Size = new System.Drawing.Size(315, 100);
            this.txt_descrip_area.TabIndex = 8;
            // 
            // lbl_descrip_area_lab
            // 
            this.lbl_descrip_area_lab.AutoSize = true;
            this.lbl_descrip_area_lab.Location = new System.Drawing.Point(6, 71);
            this.lbl_descrip_area_lab.Name = "lbl_descrip_area_lab";
            this.lbl_descrip_area_lab.Size = new System.Drawing.Size(143, 18);
            this.lbl_descrip_area_lab.TabIndex = 3;
            this.lbl_descrip_area_lab.Text = "Descripción del área";
            // 
            // lbl_id_lab
            // 
            this.lbl_id_lab.AutoSize = true;
            this.lbl_id_lab.Location = new System.Drawing.Point(6, 23);
            this.lbl_id_lab.Name = "lbl_id_lab";
            this.lbl_id_lab.Size = new System.Drawing.Size(99, 18);
            this.lbl_id_lab.TabIndex = 1;
            this.lbl_id_lab.Text = "Id Laboratorio";
            // 
            // gpb_vista_labs
            // 
            this.gpb_vista_labs.Controls.Add(this.dgv_area_labs);
            this.gpb_vista_labs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_labs.Location = new System.Drawing.Point(371, 167);
            this.gpb_vista_labs.Name = "gpb_vista_labs";
            this.gpb_vista_labs.Size = new System.Drawing.Size(447, 317);
            this.gpb_vista_labs.TabIndex = 153;
            this.gpb_vista_labs.TabStop = false;
            this.gpb_vista_labs.Text = "Laboratorios";
            // 
            // dgv_area_labs
            // 
            this.dgv_area_labs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_area_labs.Location = new System.Drawing.Point(6, 23);
            this.dgv_area_labs.Name = "dgv_area_labs";
            this.dgv_area_labs.Size = new System.Drawing.Size(435, 288);
            this.dgv_area_labs.TabIndex = 0;
            // 
            // lbl_busq
            // 
            this.lbl_busq.AutoSize = true;
            this.lbl_busq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busq.Location = new System.Drawing.Point(384, 144);
            this.lbl_busq.Name = "lbl_busq";
            this.lbl_busq.Size = new System.Drawing.Size(55, 18);
            this.lbl_busq.TabIndex = 157;
            this.lbl_busq.Text = "Buscar";
            // 
            // btn_buscar_lab
            // 
            this.btn_buscar_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar_lab.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_buscar_lab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_lab.FlatAppearance.BorderSize = 0;
            this.btn_buscar_lab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar_lab.Location = new System.Drawing.Point(302, 56);
            this.btn_buscar_lab.Name = "btn_buscar_lab";
            this.btn_buscar_lab.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_lab.TabIndex = 156;
            this.btn_buscar_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip5.SetToolTip(this.btn_buscar_lab, "Buscar");
            this.btn_buscar_lab.UseVisualStyleBackColor = true;
            this.btn_buscar_lab.Click += new System.EventHandler(this.btn_buscar_lab_Click);
            // 
            // btn_act_data
            // 
            this.btn_act_data.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_act_data.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_act_data.FlatAppearance.BorderSize = 0;
            this.btn_act_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act_data.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_act_data.Location = new System.Drawing.Point(517, 56);
            this.btn_act_data.Name = "btn_act_data";
            this.btn_act_data.Size = new System.Drawing.Size(65, 65);
            this.btn_act_data.TabIndex = 155;
            this.btn_act_data.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip8.SetToolTip(this.btn_act_data, "Actualizar");
            this.btn_act_data.UseVisualStyleBackColor = true;
            this.btn_act_data.Click += new System.EventHandler(this.btn_act_data_Click);
            // 
            // btn_elim_area
            // 
            this.btn_elim_area.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_area.FlatAppearance.BorderSize = 0;
            this.btn_elim_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_area.Location = new System.Drawing.Point(231, 56);
            this.btn_elim_area.Name = "btn_elim_area";
            this.btn_elim_area.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_area.TabIndex = 151;
            this.btn_elim_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip4.SetToolTip(this.btn_elim_area, "Eliminar");
            this.btn_elim_area.UseVisualStyleBackColor = true;
            this.btn_elim_area.Click += new System.EventHandler(this.btn_elim_area_Click);
            // 
            // btn_actlz_area
            // 
            this.btn_actlz_area.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_area.FlatAppearance.BorderSize = 0;
            this.btn_actlz_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_area.Location = new System.Drawing.Point(160, 56);
            this.btn_actlz_area.Name = "btn_actlz_area";
            this.btn_actlz_area.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_area.TabIndex = 150;
            this.btn_actlz_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.btn_actlz_area, "Modificar");
            this.btn_actlz_area.UseVisualStyleBackColor = true;
            this.btn_actlz_area.Click += new System.EventHandler(this.btn_actlz_area_Click);
            // 
            // btn_guardar_area
            // 
            this.btn_guardar_area.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_area.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_area.FlatAppearance.BorderSize = 0;
            this.btn_guardar_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_area.Location = new System.Drawing.Point(89, 56);
            this.btn_guardar_area.Name = "btn_guardar_area";
            this.btn_guardar_area.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_area.TabIndex = 68;
            this.btn_guardar_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip2.SetToolTip(this.btn_guardar_area, "Guardar");
            this.btn_guardar_area.UseVisualStyleBackColor = true;
            this.btn_guardar_area.Click += new System.EventHandler(this.btn_guardar_area_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Clinica;
            this.pictureBox1.Location = new System.Drawing.Point(715, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // btn_nuevo_pcnt
            // 
            this.btn_nuevo_pcnt.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_pcnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_pcnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_pcnt.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_pcnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_pcnt.Location = new System.Drawing.Point(18, 56);
            this.btn_nuevo_pcnt.Name = "btn_nuevo_pcnt";
            this.btn_nuevo_pcnt.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_pcnt.TabIndex = 161;
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
            this.btn_acept.Location = new System.Drawing.Point(446, 56);
            this.btn_acept.Name = "btn_acept";
            this.btn_acept.Size = new System.Drawing.Size(65, 65);
            this.btn_acept.TabIndex = 163;
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
            this.btn_cancl.Location = new System.Drawing.Point(375, 56);
            this.btn_cancl.Name = "btn_cancl";
            this.btn_cancl.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl.TabIndex = 162;
            this.toolTip6.SetToolTip(this.btn_cancl, "Cancelar");
            this.btn_cancl.UseVisualStyleBackColor = true;
            this.btn_cancl.Click += new System.EventHandler(this.btn_cancl_pcnt_Click);
            // 
            // cbo_id_lab
            // 
            this.cbo_id_lab.FormattingEnabled = true;
            this.cbo_id_lab.Location = new System.Drawing.Point(9, 47);
            this.cbo_id_lab.Name = "cbo_id_lab";
            this.cbo_id_lab.Size = new System.Drawing.Size(315, 26);
            this.cbo_id_lab.TabIndex = 9;
            // 
            // txt_busc_are_lab
            // 
            this.txt_busc_are_lab.Location = new System.Drawing.Point(446, 142);
            this.txt_busc_are_lab.Name = "txt_busc_are_lab";
            this.txt_busc_are_lab.Size = new System.Drawing.Size(353, 20);
            this.txt_busc_are_lab.TabIndex = 164;
            this.txt_busc_are_lab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_are_lab_KeyUp);
            // 
            // Area_de_laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 496);
            this.Controls.Add(this.txt_busc_are_lab);
            this.Controls.Add(this.btn_acept);
            this.Controls.Add(this.btn_cancl);
            this.Controls.Add(this.btn_nuevo_pcnt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_busq);
            this.Controls.Add(this.btn_buscar_lab);
            this.Controls.Add(this.btn_act_data);
            this.Controls.Add(this.gpb_vista_labs);
            this.Controls.Add(this.gpb_datos_area_lab);
            this.Controls.Add(this.btn_elim_area);
            this.Controls.Add(this.btn_actlz_area);
            this.Controls.Add(this.btn_guardar_area);
            this.Controls.Add(this.lbl_area_laboratorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Area_de_laboratorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area de laboratorio";
            this.Load += new System.EventHandler(this.Area_de_laboratorio_Load);
            this.gpb_datos_area_lab.ResumeLayout(false);
            this.gpb_datos_area_lab.PerformLayout();
            this.gpb_vista_labs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_area_labs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label lbl_area_laboratorio;
        private System.Windows.Forms.Button btn_guardar_area;
        private System.Windows.Forms.Button btn_actlz_area;
        private System.Windows.Forms.Button btn_elim_area;
        private System.Windows.Forms.GroupBox gpb_datos_area_lab;
        private System.Windows.Forms.Label lbl_descrip_area_lab;
        private System.Windows.Forms.Label lbl_id_lab;
        private System.Windows.Forms.GroupBox gpb_vista_labs;
        private System.Windows.Forms.Button btn_act_data;
        private System.Windows.Forms.Button btn_buscar_lab;
        private System.Windows.Forms.Label lbl_busq;
        private System.Windows.Forms.DataGridView dgv_area_labs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_descrip_area;
        private System.Windows.Forms.Button btn_nuevo_pcnt;
        private System.Windows.Forms.Button btn_acept;
        private System.Windows.Forms.Button btn_cancl;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ComboBox cbo_id_lab;
        private System.Windows.Forms.TextBox txt_busc_are_lab;
    }
}