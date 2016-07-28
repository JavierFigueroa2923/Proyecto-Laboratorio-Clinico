namespace Proyecto
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Total = new System.Windows.Forms.TextBox();
            this.total_en_letras = new System.Windows.Forms.TextBox();
            this.observaciones = new System.Windows.Forms.TextBox();
            this.valor4 = new System.Windows.Forms.TextBox();
            this.valor3 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.valor1 = new System.Windows.Forms.TextBox();
            this.concepto4 = new System.Windows.Forms.RichTextBox();
            this.concepto3 = new System.Windows.Forms.RichTextBox();
            this.concepto2 = new System.Windows.Forms.RichTextBox();
            this.concepto1 = new System.Windows.Forms.RichTextBox();
            this.cantidad4 = new System.Windows.Forms.TextBox();
            this.cantidad3 = new System.Windows.Forms.TextBox();
            this.cantidad2 = new System.Windows.Forms.TextBox();
            this.cantidad1 = new System.Windows.Forms.TextBox();
            this.condicion = new System.Windows.Forms.TextBox();
            this.vendedor = new System.Windows.Forms.TextBox();
            this.factura = new System.Windows.Forms.TextBox();
            this.nit = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.FECHA = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Arial", 9F);
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(15, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Arial", 9F);
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(15, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Font = new System.Drawing.Font("Arial", 9F);
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(17, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 43);
            this.button3.TabIndex = 3;
            this.button3.Tag = "Regresar a menu";
            this.button3.Text = "Regresar a Menu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Proyecto.Properties.Resources.Grimpsa_FFCC_A_150602__3_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.total_en_letras);
            this.panel1.Controls.Add(this.observaciones);
            this.panel1.Controls.Add(this.valor4);
            this.panel1.Controls.Add(this.valor3);
            this.panel1.Controls.Add(this.valor2);
            this.panel1.Controls.Add(this.valor1);
            this.panel1.Controls.Add(this.concepto4);
            this.panel1.Controls.Add(this.concepto3);
            this.panel1.Controls.Add(this.concepto2);
            this.panel1.Controls.Add(this.concepto1);
            this.panel1.Controls.Add(this.cantidad4);
            this.panel1.Controls.Add(this.cantidad3);
            this.panel1.Controls.Add(this.cantidad2);
            this.panel1.Controls.Add(this.cantidad1);
            this.panel1.Controls.Add(this.condicion);
            this.panel1.Controls.Add(this.vendedor);
            this.panel1.Controls.Add(this.factura);
            this.panel1.Controls.Add(this.nit);
            this.panel1.Controls.Add(this.direccion);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.FECHA);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 686);
            this.panel1.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(583, 478);
            this.Total.Margin = new System.Windows.Forms.Padding(2);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(87, 20);
            this.Total.TabIndex = 26;
            // 
            // total_en_letras
            // 
            this.total_en_letras.Location = new System.Drawing.Point(197, 520);
            this.total_en_letras.Margin = new System.Windows.Forms.Padding(2);
            this.total_en_letras.Name = "total_en_letras";
            this.total_en_letras.Size = new System.Drawing.Size(472, 20);
            this.total_en_letras.TabIndex = 25;
            this.total_en_letras.TextChanged += new System.EventHandler(this.total_en_letras_TextChanged);
            // 
            // observaciones
            // 
            this.observaciones.Location = new System.Drawing.Point(197, 499);
            this.observaciones.Margin = new System.Windows.Forms.Padding(2);
            this.observaciones.Name = "observaciones";
            this.observaciones.Size = new System.Drawing.Size(471, 20);
            this.observaciones.TabIndex = 24;
            // 
            // valor4
            // 
            this.valor4.Location = new System.Drawing.Point(580, 419);
            this.valor4.Margin = new System.Windows.Forms.Padding(2);
            this.valor4.Name = "valor4";
            this.valor4.Size = new System.Drawing.Size(87, 20);
            this.valor4.TabIndex = 23;
            this.valor4.Text = "0";
            // 
            // valor3
            // 
            this.valor3.Location = new System.Drawing.Point(580, 364);
            this.valor3.Margin = new System.Windows.Forms.Padding(2);
            this.valor3.Name = "valor3";
            this.valor3.Size = new System.Drawing.Size(87, 20);
            this.valor3.TabIndex = 22;
            this.valor3.Text = "0";
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(580, 302);
            this.valor2.Margin = new System.Windows.Forms.Padding(2);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(87, 20);
            this.valor2.TabIndex = 21;
            this.valor2.Text = "0";
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(580, 251);
            this.valor1.Margin = new System.Windows.Forms.Padding(2);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(87, 20);
            this.valor1.TabIndex = 20;
            this.valor1.Text = "0";
            // 
            // concepto4
            // 
            this.concepto4.Location = new System.Drawing.Point(191, 412);
            this.concepto4.Margin = new System.Windows.Forms.Padding(2);
            this.concepto4.Name = "concepto4";
            this.concepto4.Size = new System.Drawing.Size(381, 46);
            this.concepto4.TabIndex = 19;
            this.concepto4.Text = "";
            // 
            // concepto3
            // 
            this.concepto3.Location = new System.Drawing.Point(191, 348);
            this.concepto3.Margin = new System.Windows.Forms.Padding(2);
            this.concepto3.Name = "concepto3";
            this.concepto3.Size = new System.Drawing.Size(381, 46);
            this.concepto3.TabIndex = 18;
            this.concepto3.Text = "";
            // 
            // concepto2
            // 
            this.concepto2.Location = new System.Drawing.Point(191, 297);
            this.concepto2.Margin = new System.Windows.Forms.Padding(2);
            this.concepto2.Name = "concepto2";
            this.concepto2.Size = new System.Drawing.Size(381, 46);
            this.concepto2.TabIndex = 17;
            this.concepto2.Text = "";
            // 
            // concepto1
            // 
            this.concepto1.Location = new System.Drawing.Point(190, 240);
            this.concepto1.Margin = new System.Windows.Forms.Padding(2);
            this.concepto1.Name = "concepto1";
            this.concepto1.Size = new System.Drawing.Size(381, 46);
            this.concepto1.TabIndex = 16;
            this.concepto1.Text = "";
            // 
            // cantidad4
            // 
            this.cantidad4.Location = new System.Drawing.Point(122, 419);
            this.cantidad4.Margin = new System.Windows.Forms.Padding(2);
            this.cantidad4.Name = "cantidad4";
            this.cantidad4.Size = new System.Drawing.Size(60, 20);
            this.cantidad4.TabIndex = 15;
            // 
            // cantidad3
            // 
            this.cantidad3.Location = new System.Drawing.Point(122, 364);
            this.cantidad3.Margin = new System.Windows.Forms.Padding(2);
            this.cantidad3.Name = "cantidad3";
            this.cantidad3.Size = new System.Drawing.Size(60, 20);
            this.cantidad3.TabIndex = 14;
            this.cantidad3.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // cantidad2
            // 
            this.cantidad2.Location = new System.Drawing.Point(122, 302);
            this.cantidad2.Margin = new System.Windows.Forms.Padding(2);
            this.cantidad2.Name = "cantidad2";
            this.cantidad2.Size = new System.Drawing.Size(60, 20);
            this.cantidad2.TabIndex = 13;
            // 
            // cantidad1
            // 
            this.cantidad1.Location = new System.Drawing.Point(122, 251);
            this.cantidad1.Margin = new System.Windows.Forms.Padding(2);
            this.cantidad1.Name = "cantidad1";
            this.cantidad1.Size = new System.Drawing.Size(60, 20);
            this.cantidad1.TabIndex = 12;
            // 
            // condicion
            // 
            this.condicion.Location = new System.Drawing.Point(572, 203);
            this.condicion.Margin = new System.Windows.Forms.Padding(2);
            this.condicion.Name = "condicion";
            this.condicion.Size = new System.Drawing.Size(101, 20);
            this.condicion.TabIndex = 11;
            // 
            // vendedor
            // 
            this.vendedor.Location = new System.Drawing.Point(470, 203);
            this.vendedor.Margin = new System.Windows.Forms.Padding(2);
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(76, 20);
            this.vendedor.TabIndex = 10;
            // 
            // factura
            // 
            this.factura.Location = new System.Drawing.Point(598, 120);
            this.factura.Margin = new System.Windows.Forms.Padding(2);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(76, 20);
            this.factura.TabIndex = 9;
            // 
            // nit
            // 
            this.nit.Location = new System.Drawing.Point(173, 192);
            this.nit.Margin = new System.Windows.Forms.Padding(2);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(265, 20);
            this.nit.TabIndex = 8;
            this.nit.TextChanged += new System.EventHandler(this.nit_TextChanged);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(173, 164);
            this.direccion.Margin = new System.Windows.Forms.Padding(2);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(265, 20);
            this.direccion.TabIndex = 7;
            this.direccion.TextChanged += new System.EventHandler(this.direccion_TextChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(173, 140);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(265, 20);
            this.nombre.TabIndex = 6;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // FECHA
            // 
            this.FECHA.Location = new System.Drawing.Point(173, 112);
            this.FECHA.Margin = new System.Windows.Forms.Padding(2);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(265, 20);
            this.FECHA.TabIndex = 0;
            this.FECHA.TextChanged += new System.EventHandler(this.FECHA_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(818, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 260);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.BackgroundImage = global::Proyecto.Properties.Resources.impresion;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Arial", 9F);
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(17, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 72);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 683);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox FECHA;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox nit;
        private System.Windows.Forms.TextBox factura;
        private System.Windows.Forms.TextBox vendedor;
        private System.Windows.Forms.TextBox condicion;
        private System.Windows.Forms.TextBox cantidad1;
        private System.Windows.Forms.TextBox cantidad2;
        private System.Windows.Forms.TextBox cantidad3;
        private System.Windows.Forms.TextBox cantidad4;
        private System.Windows.Forms.RichTextBox concepto1;
        private System.Windows.Forms.RichTextBox concepto2;
        private System.Windows.Forms.RichTextBox concepto3;
        private System.Windows.Forms.RichTextBox concepto4;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.TextBox valor3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox total_en_letras;
        private System.Windows.Forms.TextBox observaciones;
        private System.Windows.Forms.TextBox valor4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.PrintDialog printDialog1;
        public System.Drawing.Printing.PrintDocument printDocument1;
    }
}