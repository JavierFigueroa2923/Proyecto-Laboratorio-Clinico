namespace WindowsFormsApplication1
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarExamenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarAseguradoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenDePacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeSuministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsMenu,
            this.toolStripMenuItem1,
            this.mantenimientosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.creacionToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(789, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(66, 20);
            this.windowsMenu.Text = "&Ventanas";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileVerticalToolStripMenuItem.Text = "Mosaico &vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeAllToolStripMenuItem.Text = "C&errar todo";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarClienteToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.actualizarExamenesToolStripMenuItem,
            this.actualizarPagosToolStripMenuItem,
            this.actualizarAseguradoraToolStripMenuItem,
            this.actualizarLaboratorioToolStripMenuItem,
            this.actualizarInventarioToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.actualizarClienteToolStripMenuItem.Text = "Actualizar Cliente";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar Empleado";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // actualizarExamenesToolStripMenuItem
            // 
            this.actualizarExamenesToolStripMenuItem.Name = "actualizarExamenesToolStripMenuItem";
            this.actualizarExamenesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.actualizarExamenesToolStripMenuItem.Text = "Actualizar Examenes";
            this.actualizarExamenesToolStripMenuItem.Click += new System.EventHandler(this.actualizarExamenesToolStripMenuItem_Click);
            // 
            // actualizarPagosToolStripMenuItem
            // 
            this.actualizarPagosToolStripMenuItem.Name = "actualizarPagosToolStripMenuItem";
            this.actualizarPagosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.actualizarPagosToolStripMenuItem.Text = "Actualizar Pagos";
            this.actualizarPagosToolStripMenuItem.Click += new System.EventHandler(this.actualizarPagosToolStripMenuItem_Click);
            // 
            // actualizarAseguradoraToolStripMenuItem
            // 
            this.actualizarAseguradoraToolStripMenuItem.Name = "actualizarAseguradoraToolStripMenuItem";
            this.actualizarAseguradoraToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.actualizarAseguradoraToolStripMenuItem.Text = "Actualizar Aseguradora";
            this.actualizarAseguradoraToolStripMenuItem.Click += new System.EventHandler(this.actualizarAseguradoraToolStripMenuItem_Click);
            // 
            // actualizarLaboratorioToolStripMenuItem
            // 
            this.actualizarLaboratorioToolStripMenuItem.Name = "actualizarLaboratorioToolStripMenuItem";
            this.actualizarLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.actualizarLaboratorioToolStripMenuItem.Text = "Actualizar Laboratorio";
            this.actualizarLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.actualizarLaboratorioToolStripMenuItem_Click);
            // 
            // actualizarInventarioToolStripMenuItem
            // 
            this.actualizarInventarioToolStripMenuItem.Name = "actualizarInventarioToolStripMenuItem";
            this.actualizarInventarioToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.actualizarInventarioToolStripMenuItem.Text = "Actualizar Inventario";
            this.actualizarInventarioToolStripMenuItem.Click += new System.EventHandler(this.actualizarInventarioToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examenesToolStripMenuItem,
            this.examenDePacienteToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.reporteDeSuministrosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.examenesToolStripMenuItem.Text = "Examenes";
            this.examenesToolStripMenuItem.Click += new System.EventHandler(this.examenesToolStripMenuItem_Click);
            // 
            // examenDePacienteToolStripMenuItem
            // 
            this.examenDePacienteToolStripMenuItem.Name = "examenDePacienteToolStripMenuItem";
            this.examenDePacienteToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.examenDePacienteToolStripMenuItem.Text = "Examen de Paciente";
            this.examenDePacienteToolStripMenuItem.Click += new System.EventHandler(this.examenDePacienteToolStripMenuItem_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // reporteDeSuministrosToolStripMenuItem
            // 
            this.reporteDeSuministrosToolStripMenuItem.Name = "reporteDeSuministrosToolStripMenuItem";
            this.reporteDeSuministrosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reporteDeSuministrosToolStripMenuItem.Text = "Reporte de Suministros";
            this.reporteDeSuministrosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeSuministrosToolStripMenuItem_Click);
            // 
            // creacionToolStripMenuItem
            // 
            this.creacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCotizacionToolStripMenuItem,
            this.nuevoLaboratorioToolStripMenuItem,
            this.nuevoExamenToolStripMenuItem});
            this.creacionToolStripMenuItem.Name = "creacionToolStripMenuItem";
            this.creacionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.creacionToolStripMenuItem.Text = "Creacion";
            // 
            // nuevaCotizacionToolStripMenuItem
            // 
            this.nuevaCotizacionToolStripMenuItem.Name = "nuevaCotizacionToolStripMenuItem";
            this.nuevaCotizacionToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuevaCotizacionToolStripMenuItem.Text = "Nueva Cotizacion";
            this.nuevaCotizacionToolStripMenuItem.Click += new System.EventHandler(this.nuevaCotizacionToolStripMenuItem_Click);
            // 
            // nuevoLaboratorioToolStripMenuItem
            // 
            this.nuevoLaboratorioToolStripMenuItem.Name = "nuevoLaboratorioToolStripMenuItem";
            this.nuevoLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuevoLaboratorioToolStripMenuItem.Text = "Nuevo Laboratorio";
            this.nuevoLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.nuevoLaboratorioToolStripMenuItem_Click);
            // 
            // nuevoExamenToolStripMenuItem
            // 
            this.nuevoExamenToolStripMenuItem.Name = "nuevoExamenToolStripMenuItem";
            this.nuevoExamenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuevoExamenToolStripMenuItem.Text = "Nuevo Examen";
            this.nuevoExamenToolStripMenuItem.Click += new System.EventHandler(this.nuevoExamenToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 445);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(789, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 467);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenDePacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarExamenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarAseguradoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeSuministrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoExamenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarInventarioToolStripMenuItem;
    }
}



