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
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membreciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoEmpleadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioDeSuministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeExamenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeSuministrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoExamenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tituloEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMuestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muestraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_usuario = new System.Windows.Forms.Label();
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
            this.actualizarInventarioToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.permisoToolStripMenuItem,
            this.etiquetasToolStripMenuItem,
            this.areaLaboratorioToolStripMenuItem,
            this.membreciaToolStripMenuItem,
            this.cargoEmpleadoToolStripMenuItem1,
            this.inventarioDeSuministrosToolStripMenuItem,
            this.tipoDeExamenToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            this.mantenimientosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientosToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.actualizarClienteToolStripMenuItem.Text = "Actualizar Cliente";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar Empleado";
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // actualizarExamenesToolStripMenuItem
            // 
            this.actualizarExamenesToolStripMenuItem.Name = "actualizarExamenesToolStripMenuItem";
            this.actualizarExamenesToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.actualizarExamenesToolStripMenuItem.Text = "Actualizar Examenes";
            this.actualizarExamenesToolStripMenuItem.Click += new System.EventHandler(this.actualizarExamenesToolStripMenuItem_Click);
            // 
            // actualizarPagosToolStripMenuItem
            // 
            this.actualizarPagosToolStripMenuItem.Name = "actualizarPagosToolStripMenuItem";
            this.actualizarPagosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.actualizarPagosToolStripMenuItem.Text = "Actualizar Pagos";
            this.actualizarPagosToolStripMenuItem.Click += new System.EventHandler(this.actualizarPagosToolStripMenuItem_Click);
            // 
            // actualizarAseguradoraToolStripMenuItem
            // 
            this.actualizarAseguradoraToolStripMenuItem.Name = "actualizarAseguradoraToolStripMenuItem";
            this.actualizarAseguradoraToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.actualizarAseguradoraToolStripMenuItem.Text = "Actualizar Aseguradora";
            this.actualizarAseguradoraToolStripMenuItem.Click += new System.EventHandler(this.actualizarAseguradoraToolStripMenuItem_Click);
            // 
            // actualizarLaboratorioToolStripMenuItem
            // 
            this.actualizarLaboratorioToolStripMenuItem.Name = "actualizarLaboratorioToolStripMenuItem";
            this.actualizarLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.actualizarLaboratorioToolStripMenuItem.Text = "Actualizar Laboratorio";
            this.actualizarLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.actualizarLaboratorioToolStripMenuItem_Click);
            // 
            // actualizarInventarioToolStripMenuItem
            // 
            this.actualizarInventarioToolStripMenuItem.Name = "actualizarInventarioToolStripMenuItem";
            this.actualizarInventarioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.actualizarInventarioToolStripMenuItem.Text = "Actualizar Inventario";
            this.actualizarInventarioToolStripMenuItem.Click += new System.EventHandler(this.actualizarInventarioToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // permisoToolStripMenuItem
            // 
            this.permisoToolStripMenuItem.Name = "permisoToolStripMenuItem";
            this.permisoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.permisoToolStripMenuItem.Text = "Roles";
            this.permisoToolStripMenuItem.Click += new System.EventHandler(this.permisoToolStripMenuItem_Click);
            // 
            // etiquetasToolStripMenuItem
            // 
            this.etiquetasToolStripMenuItem.Name = "etiquetasToolStripMenuItem";
            this.etiquetasToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.etiquetasToolStripMenuItem.Text = "Etiquetas";
            this.etiquetasToolStripMenuItem.Click += new System.EventHandler(this.etiquetasToolStripMenuItem_Click);
            // 
            // areaLaboratorioToolStripMenuItem
            // 
            this.areaLaboratorioToolStripMenuItem.Name = "areaLaboratorioToolStripMenuItem";
            this.areaLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.areaLaboratorioToolStripMenuItem.Text = "Area Laboratorio";
            this.areaLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.areaLaboratorioToolStripMenuItem_Click);
            // 
            // membreciaToolStripMenuItem
            // 
            this.membreciaToolStripMenuItem.Name = "membreciaToolStripMenuItem";
            this.membreciaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.membreciaToolStripMenuItem.Text = "Membrecia";
            this.membreciaToolStripMenuItem.Click += new System.EventHandler(this.membreciaToolStripMenuItem_Click);
            // 
            // cargoEmpleadoToolStripMenuItem1
            // 
            this.cargoEmpleadoToolStripMenuItem1.Name = "cargoEmpleadoToolStripMenuItem1";
            this.cargoEmpleadoToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.cargoEmpleadoToolStripMenuItem1.Text = "Cargo Empleado";
            this.cargoEmpleadoToolStripMenuItem1.Click += new System.EventHandler(this.cargoEmpleadoToolStripMenuItem1_Click);
            // 
            // inventarioDeSuministrosToolStripMenuItem
            // 
            this.inventarioDeSuministrosToolStripMenuItem.Name = "inventarioDeSuministrosToolStripMenuItem";
            this.inventarioDeSuministrosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.inventarioDeSuministrosToolStripMenuItem.Text = "Inventario De Suministros";
            this.inventarioDeSuministrosToolStripMenuItem.Click += new System.EventHandler(this.inventarioDeSuministrosToolStripMenuItem_Click);
            // 
            // tipoDeExamenToolStripMenuItem
            // 
            this.tipoDeExamenToolStripMenuItem.Name = "tipoDeExamenToolStripMenuItem";
            this.tipoDeExamenToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.tipoDeExamenToolStripMenuItem.Text = "Tipo De Examen";
            this.tipoDeExamenToolStripMenuItem.Click += new System.EventHandler(this.tipoDeExamenToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagosToolStripMenuItem,
            this.reporteDeSuministrosToolStripMenuItem,
            this.facturasToolStripMenuItem,
            this.resultadoExamenesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
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
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // resultadoExamenesToolStripMenuItem
            // 
            this.resultadoExamenesToolStripMenuItem.Name = "resultadoExamenesToolStripMenuItem";
            this.resultadoExamenesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.resultadoExamenesToolStripMenuItem.Text = "Resultado Examenes";
            this.resultadoExamenesToolStripMenuItem.Click += new System.EventHandler(this.resultadoExamenesToolStripMenuItem_Click);
            // 
            // creacionToolStripMenuItem
            // 
            this.creacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tituloEmpleadoToolStripMenuItem,
            this.tipoMuestraToolStripMenuItem,
            this.muestraToolStripMenuItem,
            this.cotizacionToolStripMenuItem});
            this.creacionToolStripMenuItem.Name = "creacionToolStripMenuItem";
            this.creacionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.creacionToolStripMenuItem.Text = "Creacion";
            // 
            // tituloEmpleadoToolStripMenuItem
            // 
            this.tituloEmpleadoToolStripMenuItem.Name = "tituloEmpleadoToolStripMenuItem";
            this.tituloEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tituloEmpleadoToolStripMenuItem.Text = "Titulo Empleado";
            this.tituloEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.tituloEmpleadoToolStripMenuItem_Click);
            // 
            // tipoMuestraToolStripMenuItem
            // 
            this.tipoMuestraToolStripMenuItem.Name = "tipoMuestraToolStripMenuItem";
            this.tipoMuestraToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tipoMuestraToolStripMenuItem.Text = "Tipo Muestra";
            this.tipoMuestraToolStripMenuItem.Click += new System.EventHandler(this.tipoMuestraToolStripMenuItem_Click);
            // 
            // muestraToolStripMenuItem
            // 
            this.muestraToolStripMenuItem.Name = "muestraToolStripMenuItem";
            this.muestraToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.muestraToolStripMenuItem.Text = "Muestra";
            this.muestraToolStripMenuItem.Click += new System.EventHandler(this.muestraToolStripMenuItem_Click);
            // 
            // cotizacionToolStripMenuItem
            // 
            this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
            this.cotizacionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cotizacionToolStripMenuItem.Text = "Cotizacion";
            this.cotizacionToolStripMenuItem.Click += new System.EventHandler(this.cotizacionToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem3});
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem3.Text = "Cerrar Sesion";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
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
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_usuario.Location = new System.Drawing.Point(626, 6);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(0, 15);
            this.lbl_usuario.TabIndex = 4;
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(789, 467);
            this.Controls.Add(this.lbl_usuario);
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
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarExamenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarAseguradoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeSuministrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membreciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tituloEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoEmpleadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoMuestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muestraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadoExamenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeSuministrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeExamenToolStripMenuItem;
    }
}



