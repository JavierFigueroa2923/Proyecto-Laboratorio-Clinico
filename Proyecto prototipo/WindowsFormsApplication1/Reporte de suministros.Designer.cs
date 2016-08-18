namespace WindowsFormsApplication1
{
    partial class Reporte_de_suministros
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
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_nombre_paciente = new System.Windows.Forms.TextBox();
            this.Lbl_paciente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.reporte_ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_imprimir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.printer_icon;
            this.btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imprimir.Location = new System.Drawing.Point(587, 97);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(57, 40);
            this.btn_imprimir.TabIndex = 51;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // txt_nombre_paciente
            // 
            this.txt_nombre_paciente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_paciente.Location = new System.Drawing.Point(106, 97);
            this.txt_nombre_paciente.Name = "txt_nombre_paciente";
            this.txt_nombre_paciente.Size = new System.Drawing.Size(175, 26);
            this.txt_nombre_paciente.TabIndex = 50;
            // 
            // Lbl_paciente
            // 
            this.Lbl_paciente.AutoSize = true;
            this.Lbl_paciente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_paciente.Location = new System.Drawing.Point(28, 97);
            this.Lbl_paciente.Name = "Lbl_paciente";
            this.Lbl_paciente.Size = new System.Drawing.Size(72, 20);
            this.Lbl_paciente.TabIndex = 49;
            this.Lbl_paciente.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.button1.Location = new System.Drawing.Point(335, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 48;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(12, 27);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(295, 33);
            this.lbl_titulo.TabIndex = 47;
            this.lbl_titulo.Text = "Listado de suministros";
            // 
            // reporte_
            // 
            this.reporte_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reporte_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporte_.Location = new System.Drawing.Point(18, 148);
            this.reporte_.Name = "reporte_";
            this.reporte_.Size = new System.Drawing.Size(688, 320);
            this.reporte_.TabIndex = 46;
            // 
            // Reporte_de_suministros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 480);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.txt_nombre_paciente);
            this.Controls.Add(this.Lbl_paciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.reporte_);
            this.Name = "Reporte_de_suministros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte_de_suministros";
            this.Load += new System.EventHandler(this.Reporte_de_suministros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txt_nombre_paciente;
        private System.Windows.Forms.Label Lbl_paciente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView reporte_;
    }
}