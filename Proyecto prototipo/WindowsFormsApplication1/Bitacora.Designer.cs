namespace WindowsFormsApplication1
{
    partial class Bitacora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bitacora));
            this.dgv_bitacora = new System.Windows.Forms.DataGridView();
            this.gpb_bitacora = new System.Windows.Forms.GroupBox();
            this.txt_accion_bitacora = new System.Windows.Forms.TextBox();
            this.lbl_accion_bitacora = new System.Windows.Forms.Label();
            this.txt_busc_usuario = new System.Windows.Forms.TextBox();
            this.lbl_busc_usuario = new System.Windows.Forms.Label();
            this.btn_acept_bitacora = new System.Windows.Forms.Button();
            this.btn_cancl_bitacora = new System.Windows.Forms.Button();
            this.btn_nuevo_bitacora = new System.Windows.Forms.Button();
            this.btn_buscar_bitacora = new System.Windows.Forms.Button();
            this.btn_act_bitacora = new System.Windows.Forms.Button();
            this.btn_elim_bitacora = new System.Windows.Forms.Button();
            this.btn_actlz_bitacora = new System.Windows.Forms.Button();
            this.btn_guardar_bitacora = new System.Windows.Forms.Button();
            this.lbl_bitacora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).BeginInit();
            this.gpb_bitacora.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_bitacora
            // 
            this.dgv_bitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bitacora.Location = new System.Drawing.Point(22, 72);
            this.dgv_bitacora.Name = "dgv_bitacora";
            this.dgv_bitacora.Size = new System.Drawing.Size(913, 302);
            this.dgv_bitacora.TabIndex = 0;
            // 
            // gpb_bitacora
            // 
            this.gpb_bitacora.Controls.Add(this.txt_accion_bitacora);
            this.gpb_bitacora.Controls.Add(this.lbl_accion_bitacora);
            this.gpb_bitacora.Controls.Add(this.txt_busc_usuario);
            this.gpb_bitacora.Controls.Add(this.lbl_busc_usuario);
            this.gpb_bitacora.Controls.Add(this.dgv_bitacora);
            this.gpb_bitacora.Location = new System.Drawing.Point(39, 121);
            this.gpb_bitacora.Name = "gpb_bitacora";
            this.gpb_bitacora.Size = new System.Drawing.Size(951, 389);
            this.gpb_bitacora.TabIndex = 1;
            this.gpb_bitacora.TabStop = false;
            this.gpb_bitacora.Text = "Bitacora";
            // 
            // txt_accion_bitacora
            // 
            this.txt_accion_bitacora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_accion_bitacora.Location = new System.Drawing.Point(533, 35);
            this.txt_accion_bitacora.Name = "txt_accion_bitacora";
            this.txt_accion_bitacora.Size = new System.Drawing.Size(388, 20);
            this.txt_accion_bitacora.TabIndex = 169;
            this.txt_accion_bitacora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_accion_bitacora_KeyUp);
            // 
            // lbl_accion_bitacora
            // 
            this.lbl_accion_bitacora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_accion_bitacora.AutoSize = true;
            this.lbl_accion_bitacora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accion_bitacora.Location = new System.Drawing.Point(460, 35);
            this.lbl_accion_bitacora.Name = "lbl_accion_bitacora";
            this.lbl_accion_bitacora.Size = new System.Drawing.Size(66, 20);
            this.lbl_accion_bitacora.TabIndex = 170;
            this.lbl_accion_bitacora.Text = "Accion:";
            // 
            // txt_busc_usuario
            // 
            this.txt_busc_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busc_usuario.Location = new System.Drawing.Point(94, 35);
            this.txt_busc_usuario.Name = "txt_busc_usuario";
            this.txt_busc_usuario.Size = new System.Drawing.Size(346, 20);
            this.txt_busc_usuario.TabIndex = 167;
            this.txt_busc_usuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_busc_usuario_KeyUp);
            // 
            // lbl_busc_usuario
            // 
            this.lbl_busc_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_busc_usuario.AutoSize = true;
            this.lbl_busc_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_usuario.Location = new System.Drawing.Point(21, 35);
            this.lbl_busc_usuario.Name = "lbl_busc_usuario";
            this.lbl_busc_usuario.Size = new System.Drawing.Size(67, 20);
            this.lbl_busc_usuario.TabIndex = 168;
            this.lbl_busc_usuario.Text = "Usuario:";
            // 
            // btn_acept_bitacora
            // 
            this.btn_acept_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.check_icon;
            this.btn_acept_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acept_bitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acept_bitacora.Enabled = false;
            this.btn_acept_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_acept_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acept_bitacora.Location = new System.Drawing.Point(654, 50);
            this.btn_acept_bitacora.Name = "btn_acept_bitacora";
            this.btn_acept_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_acept_bitacora.TabIndex = 171;
            this.btn_acept_bitacora.UseVisualStyleBackColor = true;
            // 
            // btn_cancl_bitacora
            // 
            this.btn_cancl_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.delete_icon;
            this.btn_cancl_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancl_bitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancl_bitacora.Enabled = false;
            this.btn_cancl_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_cancl_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancl_bitacora.Location = new System.Drawing.Point(583, 50);
            this.btn_cancl_bitacora.Name = "btn_cancl_bitacora";
            this.btn_cancl_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_cancl_bitacora.TabIndex = 170;
            this.btn_cancl_bitacora.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo_bitacora
            // 
            this.btn_nuevo_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_New_icon;
            this.btn_nuevo_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo_bitacora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_bitacora.Location = new System.Drawing.Point(226, 50);
            this.btn_nuevo_bitacora.Name = "btn_nuevo_bitacora";
            this.btn_nuevo_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_nuevo_bitacora.TabIndex = 169;
            this.btn_nuevo_bitacora.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_bitacora
            // 
            this.btn_buscar_bitacora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Zoom_icon;
            this.btn_buscar_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_buscar_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_bitacora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar_bitacora.Location = new System.Drawing.Point(510, 50);
            this.btn_buscar_bitacora.Name = "btn_buscar_bitacora";
            this.btn_buscar_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_buscar_bitacora.TabIndex = 168;
            this.btn_buscar_bitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar_bitacora.UseVisualStyleBackColor = true;
            this.btn_buscar_bitacora.Click += new System.EventHandler(this.btn_buscar_bitacora_Click);
            // 
            // btn_act_bitacora
            // 
            this.btn_act_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Button_Refresh_icon;
            this.btn_act_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_act_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_act_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_act_bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_act_bitacora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_act_bitacora.Location = new System.Drawing.Point(725, 50);
            this.btn_act_bitacora.Name = "btn_act_bitacora";
            this.btn_act_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_act_bitacora.TabIndex = 167;
            this.btn_act_bitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_act_bitacora.UseVisualStyleBackColor = true;
            this.btn_act_bitacora.Click += new System.EventHandler(this.btn_act_bitacora_Click);
            // 
            // btn_elim_bitacora
            // 
            this.btn_elim_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.File_Delete_icon;
            this.btn_elim_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_elim_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_elim_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elim_bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_bitacora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_bitacora.Location = new System.Drawing.Point(439, 50);
            this.btn_elim_bitacora.Name = "btn_elim_bitacora";
            this.btn_elim_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_elim_bitacora.TabIndex = 166;
            this.btn_elim_bitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_bitacora.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_bitacora
            // 
            this.btn_actlz_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Edit_Document_icon;
            this.btn_actlz_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actlz_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_actlz_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actlz_bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_bitacora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_bitacora.Location = new System.Drawing.Point(368, 50);
            this.btn_actlz_bitacora.Name = "btn_actlz_bitacora";
            this.btn_actlz_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_actlz_bitacora.TabIndex = 165;
            this.btn_actlz_bitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_bitacora.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_bitacora
            // 
            this.btn_guardar_bitacora.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Save_icon;
            this.btn_guardar_bitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar_bitacora.FlatAppearance.BorderSize = 0;
            this.btn_guardar_bitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_bitacora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_bitacora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_bitacora.Location = new System.Drawing.Point(297, 50);
            this.btn_guardar_bitacora.Name = "btn_guardar_bitacora";
            this.btn_guardar_bitacora.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar_bitacora.TabIndex = 164;
            this.btn_guardar_bitacora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_bitacora.UseVisualStyleBackColor = true;
            // 
            // lbl_bitacora
            // 
            this.lbl_bitacora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_bitacora.AutoSize = true;
            this.lbl_bitacora.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bitacora.Location = new System.Drawing.Point(435, 10);
            this.lbl_bitacora.Name = "lbl_bitacora";
            this.lbl_bitacora.Size = new System.Drawing.Size(130, 34);
            this.lbl_bitacora.TabIndex = 171;
            this.lbl_bitacora.Text = "Bitacora";
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 522);
            this.Controls.Add(this.lbl_bitacora);
            this.Controls.Add(this.btn_acept_bitacora);
            this.Controls.Add(this.btn_cancl_bitacora);
            this.Controls.Add(this.btn_nuevo_bitacora);
            this.Controls.Add(this.btn_buscar_bitacora);
            this.Controls.Add(this.btn_act_bitacora);
            this.Controls.Add(this.btn_elim_bitacora);
            this.Controls.Add(this.btn_actlz_bitacora);
            this.Controls.Add(this.btn_guardar_bitacora);
            this.Controls.Add(this.gpb_bitacora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bitacora)).EndInit();
            this.gpb_bitacora.ResumeLayout(false);
            this.gpb_bitacora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_bitacora;
        private System.Windows.Forms.GroupBox gpb_bitacora;
        internal System.Windows.Forms.TextBox txt_busc_usuario;
        internal System.Windows.Forms.Label lbl_busc_usuario;
        internal System.Windows.Forms.TextBox txt_accion_bitacora;
        internal System.Windows.Forms.Label lbl_accion_bitacora;
        private System.Windows.Forms.Button btn_acept_bitacora;
        private System.Windows.Forms.Button btn_cancl_bitacora;
        private System.Windows.Forms.Button btn_nuevo_bitacora;
        private System.Windows.Forms.Button btn_buscar_bitacora;
        private System.Windows.Forms.Button btn_act_bitacora;
        private System.Windows.Forms.Button btn_elim_bitacora;
        private System.Windows.Forms.Button btn_actlz_bitacora;
        private System.Windows.Forms.Button btn_guardar_bitacora;
        internal System.Windows.Forms.Label lbl_bitacora;
    }
}