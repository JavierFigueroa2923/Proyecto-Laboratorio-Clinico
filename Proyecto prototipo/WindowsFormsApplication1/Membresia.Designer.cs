namespace WindowsFormsApplication1
{
    partial class Membresia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membresia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_membresia = new System.Windows.Forms.Label();
            this.gpb_ingreso_datos = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_beneficio = new System.Windows.Forms.TextBox();
            this.txt_id_clt = new System.Windows.Forms.TextBox();
            this.txt_membresia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guardar_membresia = new System.Windows.Forms.Button();
            this.btn_actlz_membresia = new System.Windows.Forms.Button();
            this.btn_elim_membresia = new System.Windows.Forms.Button();
            this.gpb_vista_clientes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_buscar_clt = new System.Windows.Forms.TextBox();
            this.btn_busc_memb = new System.Windows.Forms.Button();
            this.btn_act_datos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpb_ingreso_datos.SuspendLayout();
            this.gpb_vista_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(697, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 102);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.gpb_ingreso_datos.Controls.Add(this.dateTimePicker2);
            this.gpb_ingreso_datos.Controls.Add(this.dateTimePicker1);
            this.gpb_ingreso_datos.Controls.Add(this.txt_beneficio);
            this.gpb_ingreso_datos.Controls.Add(this.txt_id_clt);
            this.gpb_ingreso_datos.Controls.Add(this.txt_membresia);
            this.gpb_ingreso_datos.Controls.Add(this.label5);
            this.gpb_ingreso_datos.Controls.Add(this.label4);
            this.gpb_ingreso_datos.Controls.Add(this.label3);
            this.gpb_ingreso_datos.Controls.Add(this.label2);
            this.gpb_ingreso_datos.Controls.Add(this.label1);
            this.gpb_ingreso_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_ingreso_datos.Location = new System.Drawing.Point(12, 160);
            this.gpb_ingreso_datos.Name = "gpb_ingreso_datos";
            this.gpb_ingreso_datos.Size = new System.Drawing.Size(337, 357);
            this.gpb_ingreso_datos.TabIndex = 58;
            this.gpb_ingreso_datos.TabStop = false;
            this.gpb_ingreso_datos.Text = "Ingreso de datos";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 327);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(310, 24);
            this.dateTimePicker2.TabIndex = 162;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 24);
            this.dateTimePicker1.TabIndex = 161;
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
            // 
            // txt_membresia
            // 
            this.txt_membresia.Location = new System.Drawing.Point(9, 41);
            this.txt_membresia.Name = "txt_membresia";
            this.txt_membresia.Size = new System.Drawing.Size(310, 24);
            this.txt_membresia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de expiración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de expedición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Beneficios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Membresía";
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
            // 
            // gpb_vista_clientes
            // 
            this.gpb_vista_clientes.Controls.Add(this.dataGridView1);
            this.gpb_vista_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_clientes.Location = new System.Drawing.Point(355, 174);
            this.gpb_vista_clientes.Name = "gpb_vista_clientes";
            this.gpb_vista_clientes.Size = new System.Drawing.Size(460, 318);
            this.gpb_vista_clientes.TabIndex = 161;
            this.gpb_vista_clientes.TabStop = false;
            this.gpb_vista_clientes.Text = "Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_buscar_clt
            // 
            this.txt_buscar_clt.Location = new System.Drawing.Point(413, 135);
            this.txt_buscar_clt.Name = "txt_buscar_clt";
            this.txt_buscar_clt.Size = new System.Drawing.Size(261, 20);
            this.txt_buscar_clt.TabIndex = 162;
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
            // 
            // btn_act_datos
            // 
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
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 165;
            this.label6.Text = "Buscar";
            // 
            // Membresia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_act_datos);
            this.Controls.Add(this.btn_busc_memb);
            this.Controls.Add(this.txt_buscar_clt);
            this.Controls.Add(this.gpb_vista_clientes);
            this.Controls.Add(this.btn_elim_membresia);
            this.Controls.Add(this.btn_actlz_membresia);
            this.Controls.Add(this.btn_guardar_membresia);
            this.Controls.Add(this.gpb_ingreso_datos);
            this.Controls.Add(this.lbl_membresia);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Membresia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpb_ingreso_datos.ResumeLayout(false);
            this.gpb_ingreso_datos.PerformLayout();
            this.gpb_vista_clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_membresia;
        private System.Windows.Forms.GroupBox gpb_ingreso_datos;
        private System.Windows.Forms.Button btn_guardar_membresia;
        private System.Windows.Forms.Button btn_actlz_membresia;
        private System.Windows.Forms.Button btn_elim_membresia;
        private System.Windows.Forms.TextBox txt_beneficio;
        private System.Windows.Forms.TextBox txt_id_clt;
        private System.Windows.Forms.TextBox txt_membresia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gpb_vista_clientes;
        private System.Windows.Forms.TextBox txt_buscar_clt;
        private System.Windows.Forms.Button btn_busc_memb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_act_datos;
        private System.Windows.Forms.Label label6;
    }
}