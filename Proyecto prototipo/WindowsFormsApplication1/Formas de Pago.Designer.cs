namespace WindowsFormsApplication1
{
    partial class frm_act_pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_pago));
            this.label4 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_datos_frm_pg = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_busc_lab = new System.Windows.Forms.Button();
            this.txt_busc_lab = new System.Windows.Forms.TextBox();
            this.lbl_busca_lab = new System.Windows.Forms.Label();
            this.btn_elim_pcnt = new System.Windows.Forms.Button();
            this.btn_actlz_pcnt = new System.Windows.Forms.Button();
            this.btn_guardar_pcnt = new System.Windows.Forms.Button();
            this.gpb_vista_labs = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpb_datos_frm_pg.SuspendLayout();
            this.gpb_vista_labs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(340, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 34);
            this.label4.TabIndex = 58;
            this.label4.Text = "Formas de Pago";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(107, 17);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(187, 23);
            this.textBox10.TabIndex = 56;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(107, 80);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(246, 134);
            this.textBox9.TabIndex = 55;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(107, 50);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(246, 23);
            this.textBox8.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(31, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Id Pago:";
            // 
            // gpb_datos_frm_pg
            // 
            this.gpb_datos_frm_pg.Controls.Add(this.textBox9);
            this.gpb_datos_frm_pg.Controls.Add(this.label1);
            this.gpb_datos_frm_pg.Controls.Add(this.textBox10);
            this.gpb_datos_frm_pg.Controls.Add(this.label2);
            this.gpb_datos_frm_pg.Controls.Add(this.label3);
            this.gpb_datos_frm_pg.Controls.Add(this.textBox8);
            this.gpb_datos_frm_pg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_frm_pg.Location = new System.Drawing.Point(12, 116);
            this.gpb_datos_frm_pg.Name = "gpb_datos_frm_pg";
            this.gpb_datos_frm_pg.Size = new System.Drawing.Size(361, 224);
            this.gpb_datos_frm_pg.TabIndex = 59;
            this.gpb_datos_frm_pg.TabStop = false;
            this.gpb_datos_frm_pg.Text = "Datos Generales";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(695, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 54);
            this.button1.TabIndex = 154;
            this.button1.Text = "RENOVAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_busc_lab
            // 
            this.btn_busc_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_lab.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_lab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_lab.Location = new System.Drawing.Point(624, 56);
            this.btn_busc_lab.Name = "btn_busc_lab";
            this.btn_busc_lab.Size = new System.Drawing.Size(65, 52);
            this.btn_busc_lab.TabIndex = 153;
            this.btn_busc_lab.Text = "BUSCAR";
            this.btn_busc_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_lab.UseVisualStyleBackColor = true;
            // 
            // txt_busc_lab
            // 
            this.txt_busc_lab.Location = new System.Drawing.Point(410, 88);
            this.txt_busc_lab.Name = "txt_busc_lab";
            this.txt_busc_lab.Size = new System.Drawing.Size(208, 20);
            this.txt_busc_lab.TabIndex = 152;
            // 
            // lbl_busca_lab
            // 
            this.lbl_busca_lab.AutoSize = true;
            this.lbl_busca_lab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_lab.Location = new System.Drawing.Point(342, 90);
            this.lbl_busca_lab.Name = "lbl_busca_lab";
            this.lbl_busca_lab.Size = new System.Drawing.Size(62, 20);
            this.lbl_busca_lab.TabIndex = 151;
            this.lbl_busca_lab.Text = "Buscar:";
            // 
            // btn_elim_pcnt
            // 
            this.btn_elim_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_pcnt.Location = new System.Drawing.Point(212, 62);
            this.btn_elim_pcnt.Name = "btn_elim_pcnt";
            this.btn_elim_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_pcnt.TabIndex = 150;
            this.btn_elim_pcnt.Text = "ELIMINAR";
            this.btn_elim_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_pcnt.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_pcnt
            // 
            this.btn_actlz_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_pcnt.Location = new System.Drawing.Point(112, 62);
            this.btn_actlz_pcnt.Name = "btn_actlz_pcnt";
            this.btn_actlz_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_pcnt.TabIndex = 149;
            this.btn_actlz_pcnt.Text = "ACTUALIZAR";
            this.btn_actlz_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_pcnt.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_pcnt
            // 
            this.btn_guardar_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_pcnt.Location = new System.Drawing.Point(12, 62);
            this.btn_guardar_pcnt.Name = "btn_guardar_pcnt";
            this.btn_guardar_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_pcnt.TabIndex = 148;
            this.btn_guardar_pcnt.Text = "GUARDAR";
            this.btn_guardar_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_pcnt.UseVisualStyleBackColor = true;
            // 
            // gpb_vista_labs
            // 
            this.gpb_vista_labs.Controls.Add(this.dataGridView1);
            this.gpb_vista_labs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_labs.Location = new System.Drawing.Point(379, 116);
            this.gpb_vista_labs.Name = "gpb_vista_labs";
            this.gpb_vista_labs.Size = new System.Drawing.Size(505, 224);
            this.gpb_vista_labs.TabIndex = 147;
            this.gpb_vista_labs.TabStop = false;
            this.gpb_vista_labs.Text = "Formas de realizar pagos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(766, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 118);
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_act_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_busc_lab);
            this.Controls.Add(this.txt_busc_lab);
            this.Controls.Add(this.lbl_busca_lab);
            this.Controls.Add(this.btn_elim_pcnt);
            this.Controls.Add(this.btn_actlz_pcnt);
            this.Controls.Add(this.btn_guardar_pcnt);
            this.Controls.Add(this.gpb_vista_labs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpb_datos_frm_pg);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_act_pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas de Pagos";
            this.gpb_datos_frm_pg.ResumeLayout(false);
            this.gpb_datos_frm_pg.PerformLayout();
            this.gpb_vista_labs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_datos_frm_pg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_busc_lab;
        internal System.Windows.Forms.TextBox txt_busc_lab;
        internal System.Windows.Forms.Label lbl_busca_lab;
        private System.Windows.Forms.Button btn_elim_pcnt;
        private System.Windows.Forms.Button btn_actlz_pcnt;
        private System.Windows.Forms.Button btn_guardar_pcnt;
        private System.Windows.Forms.GroupBox gpb_vista_labs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}