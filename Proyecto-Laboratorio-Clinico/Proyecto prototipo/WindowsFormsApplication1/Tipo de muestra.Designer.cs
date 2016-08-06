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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tipo_de_muestra));
            this.lbl_tipo_muestra = new System.Windows.Forms.Label();
            this.gpb_ingr_datos = new System.Windows.Forms.GroupBox();
            this.txt_descp_muestra = new System.Windows.Forms.TextBox();
            this.lbl_descrp_tip_mst = new System.Windows.Forms.Label();
            this.txt_nombre_tipo = new System.Windows.Forms.TextBox();
            this.lbl_nom_mst = new System.Windows.Forms.Label();
            this.lbl_id_mst = new System.Windows.Forms.Label();
            this.txt_tp_muestra = new System.Windows.Forms.TextBox();
            this.btn_elim_tp_muestra = new System.Windows.Forms.Button();
            this.btn_actlz_tipo_muestra = new System.Windows.Forms.Button();
            this.btn_guardar_tipo_muestra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_vista_tipos_mist = new System.Windows.Forms.GroupBox();
            this.dgv_muestras = new System.Windows.Forms.DataGridView();
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
            this.gpb_ingr_datos.Controls.Add(this.lbl_id_mst);
            this.gpb_ingr_datos.Controls.Add(this.txt_tp_muestra);
            this.gpb_ingr_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ingr_datos.Location = new System.Drawing.Point(12, 166);
            this.gpb_ingr_datos.Name = "gpb_ingr_datos";
            this.gpb_ingr_datos.Size = new System.Drawing.Size(362, 292);
            this.gpb_ingr_datos.TabIndex = 162;
            this.gpb_ingr_datos.TabStop = false;
            this.gpb_ingr_datos.Text = "Datos generales";
            // 
            // txt_descp_muestra
            // 
            this.txt_descp_muestra.Location = new System.Drawing.Point(9, 193);
            this.txt_descp_muestra.Multiline = true;
            this.txt_descp_muestra.Name = "txt_descp_muestra";
            this.txt_descp_muestra.Size = new System.Drawing.Size(326, 93);
            this.txt_descp_muestra.TabIndex = 5;
            // 
            // lbl_descrp_tip_mst
            // 
            this.lbl_descrp_tip_mst.AutoSize = true;
            this.lbl_descrp_tip_mst.Location = new System.Drawing.Point(6, 172);
            this.lbl_descrp_tip_mst.Name = "lbl_descrp_tip_mst";
            this.lbl_descrp_tip_mst.Size = new System.Drawing.Size(216, 18);
            this.lbl_descrp_tip_mst.TabIndex = 4;
            this.lbl_descrp_tip_mst.Text = "Descripción del tipo de muestra";
            // 
            // txt_nombre_tipo
            // 
            this.txt_nombre_tipo.Location = new System.Drawing.Point(9, 124);
            this.txt_nombre_tipo.Name = "txt_nombre_tipo";
            this.txt_nombre_tipo.Size = new System.Drawing.Size(326, 24);
            this.txt_nombre_tipo.TabIndex = 3;
            // 
            // lbl_nom_mst
            // 
            this.lbl_nom_mst.AutoSize = true;
            this.lbl_nom_mst.Location = new System.Drawing.Point(6, 103);
            this.lbl_nom_mst.Name = "lbl_nom_mst";
            this.lbl_nom_mst.Size = new System.Drawing.Size(191, 18);
            this.lbl_nom_mst.TabIndex = 2;
            this.lbl_nom_mst.Text = "Nombre del tipo de muestra";
            // 
            // lbl_id_mst
            // 
            this.lbl_id_mst.AutoSize = true;
            this.lbl_id_mst.Location = new System.Drawing.Point(6, 36);
            this.lbl_id_mst.Name = "lbl_id_mst";
            this.lbl_id_mst.Size = new System.Drawing.Size(130, 18);
            this.lbl_id_mst.TabIndex = 1;
            this.lbl_id_mst.Text = "Id Tipo de muestra";
            // 
            // txt_tp_muestra
            // 
            this.txt_tp_muestra.Location = new System.Drawing.Point(9, 57);
            this.txt_tp_muestra.Name = "txt_tp_muestra";
            this.txt_tp_muestra.Size = new System.Drawing.Size(326, 24);
            this.txt_tp_muestra.TabIndex = 0;
            this.txt_tp_muestra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tp_muestra_KeyPress);
            // 
            // btn_elim_tp_muestra
            // 
            this.btn_elim_tp_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_tp_muestra.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_tp_muestra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_tp_muestra.Location = new System.Drawing.Point(212, 90);
            this.btn_elim_tp_muestra.Name = "btn_elim_tp_muestra";
            this.btn_elim_tp_muestra.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_tp_muestra.TabIndex = 161;
            this.btn_elim_tp_muestra.Text = "ELIMINAR";
            this.btn_elim_tp_muestra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_tp_muestra.UseVisualStyleBackColor = true;
            this.btn_elim_tp_muestra.Click += new System.EventHandler(this.btn_elim_tp_muestra_Click);
            // 
            // btn_actlz_tipo_muestra
            // 
            this.btn_actlz_tipo_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_tipo_muestra.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_tipo_muestra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_tipo_muestra.Location = new System.Drawing.Point(112, 90);
            this.btn_actlz_tipo_muestra.Name = "btn_actlz_tipo_muestra";
            this.btn_actlz_tipo_muestra.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_tipo_muestra.TabIndex = 72;
            this.btn_actlz_tipo_muestra.Text = "ACTUALIZAR";
            this.btn_actlz_tipo_muestra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_tipo_muestra.UseVisualStyleBackColor = true;
            this.btn_actlz_tipo_muestra.Click += new System.EventHandler(this.btn_actlz_tipo_muestra_Click);
            // 
            // btn_guardar_tipo_muestra
            // 
            this.btn_guardar_tipo_muestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_tipo_muestra.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_tipo_muestra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_tipo_muestra.Location = new System.Drawing.Point(12, 90);
            this.btn_guardar_tipo_muestra.Name = "btn_guardar_tipo_muestra";
            this.btn_guardar_tipo_muestra.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_tipo_muestra.TabIndex = 70;
            this.btn_guardar_tipo_muestra.Text = "GUARDAR";
            this.btn_guardar_tipo_muestra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // Tipo_de_muestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 492);
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
        private System.Windows.Forms.Label lbl_id_mst;
        private System.Windows.Forms.TextBox txt_tp_muestra;
        private System.Windows.Forms.GroupBox gpb_vista_tipos_mist;
        private System.Windows.Forms.DataGridView dgv_muestras;
    }
}