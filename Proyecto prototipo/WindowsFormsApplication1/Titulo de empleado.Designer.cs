namespace WindowsFormsApplication1
{
    partial class Titulo_de_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titulo_de_empleado));
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.tit_empleado = new System.Windows.Forms.Label();
            this.gbp_ingre_datos_titulo_emp = new System.Windows.Forms.GroupBox();
            this.descrip_titulo = new System.Windows.Forms.Label();
            this.fecha_obt_titulo = new System.Windows.Forms.Label();
            this.nombre_titulo_emp = new System.Windows.Forms.Label();
            this.id_lab = new System.Windows.Forms.Label();
            this.id_titulo_emp = new System.Windows.Forms.Label();
            this.id_empleado = new System.Windows.Forms.Label();
            this.decrip_titulo_emp = new System.Windows.Forms.TextBox();
            this.text_fecha_obt_titulo = new System.Windows.Forms.TextBox();
            this.txt_nom_titulo = new System.Windows.Forms.TextBox();
            this.txt_id_lab = new System.Windows.Forms.TextBox();
            this.txt_id_emp = new System.Windows.Forms.TextBox();
            this.txt_id_titulo_emp = new System.Windows.Forms.TextBox();
            this.btn_guardar_titulo_emp = new System.Windows.Forms.Button();
            this.btn_actlz_titulo_emp = new System.Windows.Forms.Button();
            this.gbp_busqueda_empleado = new System.Windows.Forms.GroupBox();
            this.busqueda_datos_empleado = new System.Windows.Forms.DataGridView();
            this.actualizar_titulo_emp = new System.Windows.Forms.Button();
            this.btn_busc_emp = new System.Windows.Forms.Button();
            this.buscar_emp = new System.Windows.Forms.Label();
            this.txt_buscar_emp = new System.Windows.Forms.TextBox();
            this.btn_elim_titulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.gbp_ingre_datos_titulo_emp.SuspendLayout();
            this.gbp_busqueda_empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_datos_empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_logo
            // 
            this.Pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(724, 12);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 100);
            this.Pic_logo.TabIndex = 55;
            this.Pic_logo.TabStop = false;
            // 
            // tit_empleado
            // 
            this.tit_empleado.AutoSize = true;
            this.tit_empleado.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit_empleado.Location = new System.Drawing.Point(285, 23);
            this.tit_empleado.Name = "tit_empleado";
            this.tit_empleado.Size = new System.Drawing.Size(276, 34);
            this.tit_empleado.TabIndex = 56;
            this.tit_empleado.Text = "Título de Empleado";
            // 
            // gbp_ingre_datos_titulo_emp
            // 
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.descrip_titulo);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.fecha_obt_titulo);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.nombre_titulo_emp);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.id_lab);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.id_titulo_emp);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.id_empleado);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.decrip_titulo_emp);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.text_fecha_obt_titulo);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.txt_nom_titulo);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.txt_id_lab);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.txt_id_emp);
            this.gbp_ingre_datos_titulo_emp.Controls.Add(this.txt_id_titulo_emp);
            this.gbp_ingre_datos_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp_ingre_datos_titulo_emp.Location = new System.Drawing.Point(12, 162);
            this.gbp_ingre_datos_titulo_emp.Name = "gbp_ingre_datos_titulo_emp";
            this.gbp_ingre_datos_titulo_emp.Size = new System.Drawing.Size(374, 382);
            this.gbp_ingre_datos_titulo_emp.TabIndex = 57;
            this.gbp_ingre_datos_titulo_emp.TabStop = false;
            this.gbp_ingre_datos_titulo_emp.Text = "Ingreso de datos";
            // 
            // descrip_titulo
            // 
            this.descrip_titulo.AutoSize = true;
            this.descrip_titulo.Location = new System.Drawing.Point(6, 267);
            this.descrip_titulo.Name = "descrip_titulo";
            this.descrip_titulo.Size = new System.Drawing.Size(145, 18);
            this.descrip_titulo.TabIndex = 72;
            this.descrip_titulo.Text = "Descripción del título";
            // 
            // fecha_obt_titulo
            // 
            this.fecha_obt_titulo.AutoSize = true;
            this.fecha_obt_titulo.Location = new System.Drawing.Point(6, 219);
            this.fecha_obt_titulo.Name = "fecha_obt_titulo";
            this.fecha_obt_titulo.Size = new System.Drawing.Size(196, 18);
            this.fecha_obt_titulo.TabIndex = 71;
            this.fecha_obt_titulo.Text = "Fecha de obtención del título";
            // 
            // nombre_titulo_emp
            // 
            this.nombre_titulo_emp.AutoSize = true;
            this.nombre_titulo_emp.Location = new System.Drawing.Point(6, 168);
            this.nombre_titulo_emp.Name = "nombre_titulo_emp";
            this.nombre_titulo_emp.Size = new System.Drawing.Size(120, 18);
            this.nombre_titulo_emp.TabIndex = 70;
            this.nombre_titulo_emp.Text = "Nombre del título";
            // 
            // id_lab
            // 
            this.id_lab.AutoSize = true;
            this.id_lab.Location = new System.Drawing.Point(6, 120);
            this.id_lab.Name = "id_lab";
            this.id_lab.Size = new System.Drawing.Size(99, 18);
            this.id_lab.TabIndex = 70;
            this.id_lab.Text = "Id Laboratorio";
            // 
            // id_titulo_emp
            // 
            this.id_titulo_emp.AutoSize = true;
            this.id_titulo_emp.Location = new System.Drawing.Point(6, 24);
            this.id_titulo_emp.Name = "id_titulo_emp";
            this.id_titulo_emp.Size = new System.Drawing.Size(150, 18);
            this.id_titulo_emp.TabIndex = 7;
            this.id_titulo_emp.Text = "Id Titulo de Empleado";
            // 
            // id_empleado
            // 
            this.id_empleado.AutoSize = true;
            this.id_empleado.Location = new System.Drawing.Point(6, 72);
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Size = new System.Drawing.Size(90, 18);
            this.id_empleado.TabIndex = 6;
            this.id_empleado.Text = "Id Empleado";
            // 
            // decrip_titulo_emp
            // 
            this.decrip_titulo_emp.Location = new System.Drawing.Point(6, 288);
            this.decrip_titulo_emp.Multiline = true;
            this.decrip_titulo_emp.Name = "decrip_titulo_emp";
            this.decrip_titulo_emp.Size = new System.Drawing.Size(348, 82);
            this.decrip_titulo_emp.TabIndex = 5;
            // 
            // text_fecha_obt_titulo
            // 
            this.text_fecha_obt_titulo.Location = new System.Drawing.Point(6, 240);
            this.text_fecha_obt_titulo.Name = "text_fecha_obt_titulo";
            this.text_fecha_obt_titulo.Size = new System.Drawing.Size(348, 24);
            this.text_fecha_obt_titulo.TabIndex = 4;
            // 
            // txt_nom_titulo
            // 
            this.txt_nom_titulo.Location = new System.Drawing.Point(6, 189);
            this.txt_nom_titulo.Name = "txt_nom_titulo";
            this.txt_nom_titulo.Size = new System.Drawing.Size(348, 24);
            this.txt_nom_titulo.TabIndex = 3;
            // 
            // txt_id_lab
            // 
            this.txt_id_lab.Location = new System.Drawing.Point(6, 141);
            this.txt_id_lab.Name = "txt_id_lab";
            this.txt_id_lab.Size = new System.Drawing.Size(348, 24);
            this.txt_id_lab.TabIndex = 2;
            // 
            // txt_id_emp
            // 
            this.txt_id_emp.Location = new System.Drawing.Point(6, 93);
            this.txt_id_emp.Name = "txt_id_emp";
            this.txt_id_emp.Size = new System.Drawing.Size(348, 24);
            this.txt_id_emp.TabIndex = 1;
            // 
            // txt_id_titulo_emp
            // 
            this.txt_id_titulo_emp.Location = new System.Drawing.Point(6, 45);
            this.txt_id_titulo_emp.Name = "txt_id_titulo_emp";
            this.txt_id_titulo_emp.Size = new System.Drawing.Size(348, 24);
            this.txt_id_titulo_emp.TabIndex = 0;
            // 
            // btn_guardar_titulo_emp
            // 
            this.btn_guardar_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_titulo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_titulo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_titulo_emp.Location = new System.Drawing.Point(12, 88);
            this.btn_guardar_titulo_emp.Name = "btn_guardar_titulo_emp";
            this.btn_guardar_titulo_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_titulo_emp.TabIndex = 68;
            this.btn_guardar_titulo_emp.Text = "GUARDAR";
            this.btn_guardar_titulo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_titulo_emp.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_titulo_emp
            // 
            this.btn_actlz_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_titulo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_titulo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_titulo_emp.Location = new System.Drawing.Point(112, 88);
            this.btn_actlz_titulo_emp.Name = "btn_actlz_titulo_emp";
            this.btn_actlz_titulo_emp.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_titulo_emp.TabIndex = 69;
            this.btn_actlz_titulo_emp.Text = "ACTUALIZAR";
            this.btn_actlz_titulo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_titulo_emp.UseVisualStyleBackColor = true;
            // 
            // gbp_busqueda_empleado
            // 
            this.gbp_busqueda_empleado.Controls.Add(this.busqueda_datos_empleado);
            this.gbp_busqueda_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp_busqueda_empleado.Location = new System.Drawing.Point(405, 186);
            this.gbp_busqueda_empleado.Name = "gbp_busqueda_empleado";
            this.gbp_busqueda_empleado.Size = new System.Drawing.Size(419, 358);
            this.gbp_busqueda_empleado.TabIndex = 70;
            this.gbp_busqueda_empleado.TabStop = false;
            this.gbp_busqueda_empleado.Text = "Busqueda de empleado";
            // 
            // busqueda_datos_empleado
            // 
            this.busqueda_datos_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busqueda_datos_empleado.Location = new System.Drawing.Point(6, 23);
            this.busqueda_datos_empleado.Name = "busqueda_datos_empleado";
            this.busqueda_datos_empleado.Size = new System.Drawing.Size(407, 323);
            this.busqueda_datos_empleado.TabIndex = 0;
            // 
            // actualizar_titulo_emp
            // 
            this.actualizar_titulo_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_titulo_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.actualizar_titulo_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.actualizar_titulo_emp.Location = new System.Drawing.Point(759, 126);
            this.actualizar_titulo_emp.Name = "actualizar_titulo_emp";
            this.actualizar_titulo_emp.Size = new System.Drawing.Size(65, 54);
            this.actualizar_titulo_emp.TabIndex = 155;
            this.actualizar_titulo_emp.Text = "RENOVAR";
            this.actualizar_titulo_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.actualizar_titulo_emp.UseVisualStyleBackColor = true;
            // 
            // btn_busc_emp
            // 
            this.btn_busc_emp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_emp.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_emp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_emp.Location = new System.Drawing.Point(688, 128);
            this.btn_busc_emp.Name = "btn_busc_emp";
            this.btn_busc_emp.Size = new System.Drawing.Size(65, 52);
            this.btn_busc_emp.TabIndex = 156;
            this.btn_busc_emp.Text = "BUSCAR";
            this.btn_busc_emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_emp.UseVisualStyleBackColor = true;
            // 
            // buscar_emp
            // 
            this.buscar_emp.AutoSize = true;
            this.buscar_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_emp.Location = new System.Drawing.Point(405, 143);
            this.buscar_emp.Name = "buscar_emp";
            this.buscar_emp.Size = new System.Drawing.Size(55, 18);
            this.buscar_emp.TabIndex = 157;
            this.buscar_emp.Text = "Buscar";
            // 
            // txt_buscar_emp
            // 
            this.txt_buscar_emp.Location = new System.Drawing.Point(466, 143);
            this.txt_buscar_emp.Name = "txt_buscar_emp";
            this.txt_buscar_emp.Size = new System.Drawing.Size(215, 20);
            this.txt_buscar_emp.TabIndex = 158;
            // 
            // btn_elim_titulo
            // 
            this.btn_elim_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_titulo.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_titulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_titulo.Location = new System.Drawing.Point(212, 88);
            this.btn_elim_titulo.Name = "btn_elim_titulo";
            this.btn_elim_titulo.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_titulo.TabIndex = 159;
            this.btn_elim_titulo.Text = "ELIMINAR";
            this.btn_elim_titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_titulo.UseVisualStyleBackColor = true;
            // 
            // Titulo_de_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 579);
            this.Controls.Add(this.btn_elim_titulo);
            this.Controls.Add(this.txt_buscar_emp);
            this.Controls.Add(this.buscar_emp);
            this.Controls.Add(this.btn_busc_emp);
            this.Controls.Add(this.actualizar_titulo_emp);
            this.Controls.Add(this.gbp_busqueda_empleado);
            this.Controls.Add(this.btn_actlz_titulo_emp);
            this.Controls.Add(this.btn_guardar_titulo_emp);
            this.Controls.Add(this.gbp_ingre_datos_titulo_emp);
            this.Controls.Add(this.tit_empleado);
            this.Controls.Add(this.Pic_logo);
            this.Name = "Titulo_de_empleado";
            this.Text = "Titulo de empleado";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.gbp_ingre_datos_titulo_emp.ResumeLayout(false);
            this.gbp_ingre_datos_titulo_emp.PerformLayout();
            this.gbp_busqueda_empleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.busqueda_datos_empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox Pic_logo;
        private System.Windows.Forms.Label tit_empleado;
        private System.Windows.Forms.GroupBox gbp_ingre_datos_titulo_emp;
        private System.Windows.Forms.Button btn_guardar_titulo_emp;
        private System.Windows.Forms.Button btn_actlz_titulo_emp;
        private System.Windows.Forms.Label descrip_titulo;
        private System.Windows.Forms.Label fecha_obt_titulo;
        private System.Windows.Forms.Label nombre_titulo_emp;
        private System.Windows.Forms.Label id_lab;
        private System.Windows.Forms.Label id_titulo_emp;
        private System.Windows.Forms.Label id_empleado;
        private System.Windows.Forms.TextBox decrip_titulo_emp;
        private System.Windows.Forms.TextBox text_fecha_obt_titulo;
        private System.Windows.Forms.TextBox txt_nom_titulo;
        private System.Windows.Forms.TextBox txt_id_lab;
        private System.Windows.Forms.TextBox txt_id_emp;
        private System.Windows.Forms.TextBox txt_id_titulo_emp;
        private System.Windows.Forms.GroupBox gbp_busqueda_empleado;
        private System.Windows.Forms.Button actualizar_titulo_emp;
        private System.Windows.Forms.DataGridView busqueda_datos_empleado;
        private System.Windows.Forms.Button btn_busc_emp;
        private System.Windows.Forms.Label buscar_emp;
        private System.Windows.Forms.TextBox txt_buscar_emp;
        private System.Windows.Forms.Button btn_elim_titulo;
    }
}