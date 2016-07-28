namespace WindowsFormsApplication1
{
    partial class Reporte_examenes
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reporte_ = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdb_paciente = new System.Windows.Forms.RadioButton();
            this.rdb_Examen = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button1.Location = new System.Drawing.Point(541, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccione el metodo de reporte:";
            // 
            // reporte_
            // 
            this.reporte_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporte_.Location = new System.Drawing.Point(12, 166);
            this.reporte_.Name = "reporte_";
            this.reporte_.Size = new System.Drawing.Size(626, 283);
            this.reporte_.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // rdb_paciente
            // 
            this.rdb_paciente.AutoSize = true;
            this.rdb_paciente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdb_paciente.Location = new System.Drawing.Point(11, 82);
            this.rdb_paciente.Name = "rdb_paciente";
            this.rdb_paciente.Size = new System.Drawing.Size(93, 24);
            this.rdb_paciente.TabIndex = 16;
            this.rdb_paciente.TabStop = true;
            this.rdb_paciente.Text = "Paciente";
            this.rdb_paciente.UseVisualStyleBackColor = true;
            this.rdb_paciente.CheckedChanged += new System.EventHandler(this.rdb_mes_CheckedChanged);
            // 
            // rdb_Examen
            // 
            this.rdb_Examen.AutoSize = true;
            this.rdb_Examen.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rdb_Examen.Location = new System.Drawing.Point(317, 85);
            this.rdb_Examen.Name = "rdb_Examen";
            this.rdb_Examen.Size = new System.Drawing.Size(51, 24);
            this.rdb_Examen.TabIndex = 18;
            this.rdb_Examen.TabStop = true;
            this.rdb_Examen.Text = "Dia";
            this.rdb_Examen.UseVisualStyleBackColor = true;
            this.rdb_Examen.CheckedChanged += new System.EventHandler(this.rdb_Examen_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.radioButton2.Location = new System.Drawing.Point(11, 112);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 24);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fecha exacta";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.radioButton3.Location = new System.Drawing.Point(317, 112);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 24);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mes";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(374, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(374, 116);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 21);
            this.comboBox3.TabIndex = 25;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(608, 72);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(33, 31);
            this.btn_regresar.TabIndex = 12;
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // Reporte_examenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 461);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdb_Examen);
            this.Controls.Add(this.rdb_paciente);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.reporte_);
            this.Name = "Reporte_examenes";
            this.Text = "Reporte de Examenes";
            ((System.ComponentModel.ISupportInitialize)(this.reporte_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DataGridView reporte_;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdb_paciente;
        private System.Windows.Forms.RadioButton rdb_Examen;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}