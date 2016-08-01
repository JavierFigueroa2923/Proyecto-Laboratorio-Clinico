namespace WindowsFormsApplication1
{
    partial class Cotizacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_paciente = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_nit = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Lbl_referencia = new System.Windows.Forms.Label();
            this.Lbl_descuento = new System.Windows.Forms.Label();
            this.Lbl_tipo_precio = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratorio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(38, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de cotizacion";
            // 
            // lbl_paciente
            // 
            this.lbl_paciente.AutoSize = true;
            this.lbl_paciente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_paciente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_paciente.Location = new System.Drawing.Point(20, 208);
            this.lbl_paciente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paciente.Name = "lbl_paciente";
            this.lbl_paciente.Size = new System.Drawing.Size(148, 20);
            this.lbl_paciente.TabIndex = 3;
            this.lbl_paciente.Text = "Datos del Paciente";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.printer_icon;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.Location = new System.Drawing.Point(622, 455);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(86, 80);
            this.btn_imprimir.TabIndex = 34;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(99, 95);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(160, 26);
            this.textBox8.TabIndex = 35;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(217, 137);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(160, 26);
            this.textBox9.TabIndex = 36;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(225, 57);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(310, 26);
            this.textBox10.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 16);
            this.panel1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21F);
            this.label4.Location = new System.Drawing.Point(24, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 34);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cotizacion para pacientes";
            // 
            // Lbl_nit
            // 
            this.Lbl_nit.AutoSize = true;
            this.Lbl_nit.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_nit.Location = new System.Drawing.Point(4, 260);
            this.Lbl_nit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nit.Name = "Lbl_nit";
            this.Lbl_nit.Size = new System.Drawing.Size(32, 20);
            this.Lbl_nit.TabIndex = 4;
            this.Lbl_nit.Text = "Nit:";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_telefono.Location = new System.Drawing.Point(4, 300);
            this.Lbl_telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(75, 20);
            this.Lbl_telefono.TabIndex = 5;
            this.Lbl_telefono.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.Location = new System.Drawing.Point(4, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre del paciente:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 260);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(402, 26);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 300);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(402, 26);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 336);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(353, 26);
            this.textBox4.TabIndex = 14;
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_direccion.Location = new System.Drawing.Point(4, 380);
            this.Lbl_direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(84, 20);
            this.Lbl_direccion.TabIndex = 7;
            this.Lbl_direccion.Text = "Direccion:";
            // 
            // Lbl_referencia
            // 
            this.Lbl_referencia.AutoSize = true;
            this.Lbl_referencia.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_referencia.Location = new System.Drawing.Point(4, 420);
            this.Lbl_referencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_referencia.Name = "Lbl_referencia";
            this.Lbl_referencia.Size = new System.Drawing.Size(109, 20);
            this.Lbl_referencia.TabIndex = 8;
            this.Lbl_referencia.Text = "Quien refiere:";
            // 
            // Lbl_descuento
            // 
            this.Lbl_descuento.AutoSize = true;
            this.Lbl_descuento.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_descuento.Location = new System.Drawing.Point(-4, 489);
            this.Lbl_descuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descuento.Name = "Lbl_descuento";
            this.Lbl_descuento.Size = new System.Drawing.Size(105, 20);
            this.Lbl_descuento.TabIndex = 9;
            this.Lbl_descuento.Text = "% Descuento";
            // 
            // Lbl_tipo_precio
            // 
            this.Lbl_tipo_precio.AutoSize = true;
            this.Lbl_tipo_precio.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_tipo_precio.Location = new System.Drawing.Point(266, 489);
            this.Lbl_tipo_precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tipo_precio.Name = "Lbl_tipo_precio";
            this.Lbl_tipo_precio.Size = new System.Drawing.Size(117, 20);
            this.Lbl_tipo_precio.TabIndex = 10;
            this.Lbl_tipo_precio.Text = "Tipo de precio:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(133, 377);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(402, 26);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(133, 420);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(402, 26);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(133, 483);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(115, 26);
            this.textBox7.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(382, 481);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 55);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 28);
            this.comboBox2.TabIndex = 38;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 592);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lbl_tipo_precio);
            this.Controls.Add(this.Lbl_descuento);
            this.Controls.Add(this.Lbl_referencia);
            this.Controls.Add(this.Lbl_direccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lbl_telefono);
            this.Controls.Add(this.Lbl_nit);
            this.Controls.Add(this.lbl_paciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cotizacion";
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_paciente;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_nit;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.Label Lbl_referencia;
        private System.Windows.Forms.Label Lbl_descuento;
        private System.Windows.Forms.Label Lbl_tipo_precio;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}