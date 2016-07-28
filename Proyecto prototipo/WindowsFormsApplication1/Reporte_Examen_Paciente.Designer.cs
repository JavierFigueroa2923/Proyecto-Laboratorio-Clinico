namespace WindowsFormsApplication1
{
    partial class Reporte_Examen_Paciente
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
            this.txt_nombre_paciente = new System.Windows.Forms.TextBox();
            this.Lbl_paciente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reporte_ = new System.Windows.Forms.DataGridView();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre_paciente
            // 
            this.txt_nombre_paciente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_paciente.Location = new System.Drawing.Point(100, 115);
            this.txt_nombre_paciente.Name = "txt_nombre_paciente";
            this.txt_nombre_paciente.Size = new System.Drawing.Size(175, 26);
            this.txt_nombre_paciente.TabIndex = 38;
            // 
            // Lbl_paciente
            // 
            this.Lbl_paciente.AutoSize = true;
            this.Lbl_paciente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_paciente.Location = new System.Drawing.Point(22, 115);
            this.Lbl_paciente.Name = "Lbl_paciente";
            this.Lbl_paciente.Size = new System.Drawing.Size(72, 20);
            this.Lbl_paciente.TabIndex = 37;
            this.Lbl_paciente.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button1.Location = new System.Drawing.Point(329, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 36;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 33);
            this.label1.TabIndex = 35;
            this.label1.Text = "Listado de examenes de el paciente:";
            // 
            // reporte_
            // 
            this.reporte_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporte_.Location = new System.Drawing.Point(12, 166);
            this.reporte_.Name = "reporte_";
            this.reporte_.Size = new System.Drawing.Size(626, 283);
            this.reporte_.TabIndex = 33;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.printer_icon;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.Location = new System.Drawing.Point(581, 115);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(57, 40);
            this.btn_imprimir.TabIndex = 39;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Previous_icon;
            this.btn_regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar.Location = new System.Drawing.Point(605, 69);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(33, 31);
            this.btn_regresar.TabIndex = 34;
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // Reporte_Examen_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 461);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txt_nombre_paciente);
            this.Controls.Add(this.Lbl_paciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.reporte_);
            this.Name = "Reporte_Examen_Paciente";
            this.Text = "Reporte_Examen_Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.reporte_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txt_nombre_paciente;
        private System.Windows.Forms.Label Lbl_paciente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DataGridView reporte_;
    }
}