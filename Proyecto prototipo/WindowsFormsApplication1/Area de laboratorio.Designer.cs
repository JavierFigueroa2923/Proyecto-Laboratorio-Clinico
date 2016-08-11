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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_de_laboratorio));
            this.lbl_area_laboratorio = new System.Windows.Forms.Label();
            this.gpb_datos_area_lab = new System.Windows.Forms.GroupBox();
            this.txt_id_lab = new System.Windows.Forms.TextBox();
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
            this.cbo_buscar = new System.Windows.Forms.ComboBox();
            this.txt_descrip_area = new System.Windows.Forms.TextBox();
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
            this.lbl_area_laboratorio.Location = new System.Drawing.Point(268, 25);
            this.lbl_area_laboratorio.Name = "lbl_area_laboratorio";
            this.lbl_area_laboratorio.Size = new System.Drawing.Size(291, 34);
            this.lbl_area_laboratorio.TabIndex = 56;
            this.lbl_area_laboratorio.Text = "Área de Laboratorio";
            // 
            // gpb_datos_area_lab
            // 
            this.gpb_datos_area_lab.Controls.Add(this.txt_descrip_area);
            this.gpb_datos_area_lab.Controls.Add(this.txt_id_lab);
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
            // txt_id_lab
            // 
            this.txt_id_lab.Location = new System.Drawing.Point(6, 44);
            this.txt_id_lab.Name = "txt_id_lab";
            this.txt_id_lab.Size = new System.Drawing.Size(315, 24);
            this.txt_id_lab.TabIndex = 5;
            this.txt_id_lab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_lab_KeyPress);
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
            this.lbl_busq.Location = new System.Drawing.Point(368, 131);
            this.lbl_busq.Name = "lbl_busq";
            this.lbl_busq.Size = new System.Drawing.Size(55, 18);
            this.lbl_busq.TabIndex = 157;
            this.lbl_busq.Text = "Buscar";
            // 
            // btn_buscar_lab
            // 
            this.btn_buscar_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lab.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_buscar_lab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar_lab.Location = new System.Drawing.Point(676, 120);
            this.btn_buscar_lab.Name = "btn_buscar_lab";
            this.btn_buscar_lab.Size = new System.Drawing.Size(65, 52);
            this.btn_buscar_lab.TabIndex = 156;
            this.btn_buscar_lab.Text = "BUSCAR";
            this.btn_buscar_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar_lab.UseVisualStyleBackColor = true;
            this.btn_buscar_lab.Click += new System.EventHandler(this.btn_buscar_lab_Click);
            // 
            // btn_act_data
            // 
            this.btn_act_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act_data.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_act_data.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_act_data.Location = new System.Drawing.Point(747, 118);
            this.btn_act_data.Name = "btn_act_data";
            this.btn_act_data.Size = new System.Drawing.Size(65, 54);
            this.btn_act_data.TabIndex = 155;
            this.btn_act_data.Text = "RENOVAR";
            this.btn_act_data.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_act_data.UseVisualStyleBackColor = true;
            // 
            // btn_elim_area
            // 
            this.btn_elim_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_area.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_area.Location = new System.Drawing.Point(212, 86);
            this.btn_elim_area.Name = "btn_elim_area";
            this.btn_elim_area.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_area.TabIndex = 151;
            this.btn_elim_area.Text = "ELIMINAR";
            this.btn_elim_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_area.UseVisualStyleBackColor = true;
            this.btn_elim_area.Click += new System.EventHandler(this.btn_elim_area_Click);
            // 
            // btn_actlz_area
            // 
            this.btn_actlz_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_area.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_area.Location = new System.Drawing.Point(112, 86);
            this.btn_actlz_area.Name = "btn_actlz_area";
            this.btn_actlz_area.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_area.TabIndex = 150;
            this.btn_actlz_area.Text = "ACTUALIZAR";
            this.btn_actlz_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_area.UseVisualStyleBackColor = true;
            this.btn_actlz_area.Click += new System.EventHandler(this.btn_actlz_area_Click);
            // 
            // btn_guardar_area
            // 
            this.btn_guardar_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_area.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_area.Location = new System.Drawing.Point(12, 86);
            this.btn_guardar_area.Name = "btn_guardar_area";
            this.btn_guardar_area.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_area.TabIndex = 68;
            this.btn_guardar_area.Text = "GUARDAR";
            this.btn_guardar_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // cbo_buscar
            // 
            this.cbo_buscar.FormattingEnabled = true;
            this.cbo_buscar.Location = new System.Drawing.Point(430, 127);
            this.cbo_buscar.Name = "cbo_buscar";
            this.cbo_buscar.Size = new System.Drawing.Size(240, 21);
            this.cbo_buscar.TabIndex = 160;
            // 
            // txt_descrip_area
            // 
            this.txt_descrip_area.Location = new System.Drawing.Point(9, 92);
            this.txt_descrip_area.Multiline = true;
            this.txt_descrip_area.Name = "txt_descrip_area";
            this.txt_descrip_area.Size = new System.Drawing.Size(315, 100);
            this.txt_descrip_area.TabIndex = 8;
            // 
            // Area_de_laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 496);
            this.Controls.Add(this.cbo_buscar);
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
        private System.Windows.Forms.TextBox txt_id_lab;
        private System.Windows.Forms.Label lbl_descrip_area_lab;
        private System.Windows.Forms.Label lbl_id_lab;
        private System.Windows.Forms.GroupBox gpb_vista_labs;
        private System.Windows.Forms.Button btn_act_data;
        private System.Windows.Forms.Button btn_buscar_lab;
        private System.Windows.Forms.Label lbl_busq;
        private System.Windows.Forms.DataGridView dgv_area_labs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbo_buscar;
        private System.Windows.Forms.TextBox txt_descrip_area;
    }
}