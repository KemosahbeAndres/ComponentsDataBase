namespace ComponentsViewer
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.sContainer = new System.Windows.Forms.SplitContainer();
            this.sContainerLeft = new System.Windows.Forms.SplitContainer();
            this.searchPanel = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.filterPanel = new System.Windows.Forms.GroupBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.comboFilter = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.detailsGroup = new System.Windows.Forms.GroupBox();
            this.dComment = new System.Windows.Forms.Label();
            this.dEquivalents = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.dInventory = new System.Windows.Forms.Label();
            this.lblEquivalents = new System.Windows.Forms.Label();
            this.dPackage = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.dDescription = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.dCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dCategory = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNCom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNCat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capsulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).BeginInit();
            this.sContainer.Panel1.SuspendLayout();
            this.sContainer.Panel2.SuspendLayout();
            this.sContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainerLeft)).BeginInit();
            this.sContainerLeft.Panel1.SuspendLayout();
            this.sContainerLeft.Panel2.SuspendLayout();
            this.sContainerLeft.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.detailsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mainContainer.IsSplitterFixed = true;
            this.mainContainer.Location = new System.Drawing.Point(3, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.sContainer);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.detailsGroup);
            this.mainContainer.Panel2.Padding = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.mainContainer.Size = new System.Drawing.Size(985, 379);
            this.mainContainer.SplitterDistance = 769;
            this.mainContainer.TabIndex = 0;
            // 
            // sContainer
            // 
            this.sContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sContainer.IsSplitterFixed = true;
            this.sContainer.Location = new System.Drawing.Point(0, 0);
            this.sContainer.Name = "sContainer";
            // 
            // sContainer.Panel1
            // 
            this.sContainer.Panel1.Controls.Add(this.sContainerLeft);
            // 
            // sContainer.Panel2
            // 
            this.sContainer.Panel2.Controls.Add(this.dataGrid);
            this.sContainer.Size = new System.Drawing.Size(769, 379);
            this.sContainer.SplitterDistance = 200;
            this.sContainer.TabIndex = 2;
            // 
            // sContainerLeft
            // 
            this.sContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainerLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sContainerLeft.IsSplitterFixed = true;
            this.sContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.sContainerLeft.Name = "sContainerLeft";
            this.sContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sContainerLeft.Panel1
            // 
            this.sContainerLeft.Panel1.Controls.Add(this.searchPanel);
            // 
            // sContainerLeft.Panel2
            // 
            this.sContainerLeft.Panel2.Controls.Add(this.filterPanel);
            this.sContainerLeft.Size = new System.Drawing.Size(200, 379);
            this.sContainerLeft.SplitterDistance = 80;
            this.sContainerLeft.TabIndex = 2;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.btnSearch);
            this.searchPanel.Controls.Add(this.textBox1);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(15);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(15);
            this.searchPanel.Size = new System.Drawing.Size(200, 80);
            this.searchPanel.TabIndex = 1;
            this.searchPanel.TabStop = false;
            this.searchPanel.Text = "Busqueda";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(133, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 0;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.btnApplyFilter);
            this.filterPanel.Controls.Add(this.lblFilter);
            this.filterPanel.Controls.Add(this.comboFilter);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(200, 295);
            this.filterPanel.TabIndex = 0;
            this.filterPanel.TabStop = false;
            this.filterPanel.Text = "Filtrar";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(105, 19);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Aplicar";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(9, 29);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(53, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filtrar por:";
            // 
            // comboFilter
            // 
            this.comboFilter.FormattingEnabled = true;
            this.comboFilter.Location = new System.Drawing.Point(9, 48);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Size = new System.Drawing.Size(185, 21);
            this.comboFilter.TabIndex = 0;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(565, 379);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            this.dataGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGrid_DataError);
            // 
            // detailsGroup
            // 
            this.detailsGroup.Controls.Add(this.dComment);
            this.detailsGroup.Controls.Add(this.dEquivalents);
            this.detailsGroup.Controls.Add(this.lblComment);
            this.detailsGroup.Controls.Add(this.dInventory);
            this.detailsGroup.Controls.Add(this.lblEquivalents);
            this.detailsGroup.Controls.Add(this.dPackage);
            this.detailsGroup.Controls.Add(this.lblInventory);
            this.detailsGroup.Controls.Add(this.lblPackage);
            this.detailsGroup.Controls.Add(this.dDescription);
            this.detailsGroup.Controls.Add(this.imageBox);
            this.detailsGroup.Controls.Add(this.dCode);
            this.detailsGroup.Controls.Add(this.lblDescription);
            this.detailsGroup.Controls.Add(this.dCategory);
            this.detailsGroup.Controls.Add(this.lblCode);
            this.detailsGroup.Controls.Add(this.lblCategory);
            this.detailsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGroup.Location = new System.Drawing.Point(1, 0);
            this.detailsGroup.Name = "detailsGroup";
            this.detailsGroup.Size = new System.Drawing.Size(208, 379);
            this.detailsGroup.TabIndex = 5;
            this.detailsGroup.TabStop = false;
            this.detailsGroup.Text = "Detalles";
            // 
            // dComment
            // 
            this.dComment.AutoSize = true;
            this.dComment.Location = new System.Drawing.Point(74, 329);
            this.dComment.Name = "dComment";
            this.dComment.Size = new System.Drawing.Size(0, 13);
            this.dComment.TabIndex = 8;
            // 
            // dEquivalents
            // 
            this.dEquivalents.AutoSize = true;
            this.dEquivalents.Location = new System.Drawing.Point(74, 306);
            this.dEquivalents.Name = "dEquivalents";
            this.dEquivalents.Size = new System.Drawing.Size(0, 13);
            this.dEquivalents.TabIndex = 7;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(6, 329);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(68, 13);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "Comentarios:";
            // 
            // dInventory
            // 
            this.dInventory.AutoSize = true;
            this.dInventory.Location = new System.Drawing.Point(74, 283);
            this.dInventory.Name = "dInventory";
            this.dInventory.Size = new System.Drawing.Size(0, 13);
            this.dInventory.TabIndex = 6;
            // 
            // lblEquivalents
            // 
            this.lblEquivalents.AutoSize = true;
            this.lblEquivalents.Location = new System.Drawing.Point(6, 306);
            this.lblEquivalents.Name = "lblEquivalents";
            this.lblEquivalents.Size = new System.Drawing.Size(71, 13);
            this.lblEquivalents.TabIndex = 7;
            this.lblEquivalents.Text = "Equivalentes:";
            // 
            // dPackage
            // 
            this.dPackage.AutoSize = true;
            this.dPackage.Location = new System.Drawing.Point(74, 260);
            this.dPackage.Name = "dPackage";
            this.dPackage.Size = new System.Drawing.Size(0, 13);
            this.dPackage.TabIndex = 5;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(6, 283);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(57, 13);
            this.lblInventory.TabIndex = 6;
            this.lblInventory.Text = "Inventario:";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(6, 260);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(48, 13);
            this.lblPackage.TabIndex = 5;
            this.lblPackage.Text = "Capsula:";
            // 
            // dDescription
            // 
            this.dDescription.AutoSize = true;
            this.dDescription.Location = new System.Drawing.Point(74, 214);
            this.dDescription.Name = "dDescription";
            this.dDescription.Size = new System.Drawing.Size(0, 13);
            this.dDescription.TabIndex = 3;
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.White;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageBox.Location = new System.Drawing.Point(3, 16);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(202, 162);
            this.imageBox.TabIndex = 4;
            this.imageBox.TabStop = false;
            // 
            // dCode
            // 
            this.dCode.AutoSize = true;
            this.dCode.Location = new System.Drawing.Point(74, 191);
            this.dCode.Name = "dCode";
            this.dCode.Size = new System.Drawing.Size(0, 13);
            this.dCode.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 214);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Descripcion:";
            // 
            // dCategory
            // 
            this.dCategory.AutoSize = true;
            this.dCategory.Location = new System.Drawing.Point(74, 237);
            this.dCategory.Name = "dCategory";
            this.dCategory.Size = new System.Drawing.Size(0, 13);
            this.dCategory.TabIndex = 2;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 191);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(43, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Codigo:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 237);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Categoria:";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(991, 24);
            this.mainMenu.TabIndex = 4;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 431);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(991, 22);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolBar
            // 
            this.toolBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnReset});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(991, 25);
            this.toolBar.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNCom,
            this.btnNCat,
            this.btnCap});
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(55, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnNCom
            // 
            this.btnNCom.Name = "btnNCom";
            this.btnNCom.Size = new System.Drawing.Size(144, 22);
            this.btnNCom.Text = "Componente";
            this.btnNCom.Click += new System.EventHandler(this.btnNCom_Click);
            // 
            // btnNCat
            // 
            this.btnNCat.Name = "btnNCat";
            this.btnNCat.Size = new System.Drawing.Size(144, 22);
            this.btnNCat.Text = "Categoria";
            // 
            // btnCap
            // 
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(144, 22);
            this.btnCap.Text = "Capsula";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mainContainer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 49);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.mainPanel.Size = new System.Drawing.Size(991, 382);
            this.mainPanel.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 22);
            this.btnReset.Text = "Actualizar";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componenteToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.capsulaToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // componenteToolStripMenuItem
            // 
            this.componenteToolStripMenuItem.Name = "componenteToolStripMenuItem";
            this.componenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.componenteToolStripMenuItem.Text = "Componente";
            this.componenteToolStripMenuItem.Click += new System.EventHandler(this.componenteToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // capsulaToolStripMenuItem
            // 
            this.capsulaToolStripMenuItem.Name = "capsulaToolStripMenuItem";
            this.capsulaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.capsulaToolStripMenuItem.Text = "Capsula";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 453);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Components";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.sContainer.Panel1.ResumeLayout(false);
            this.sContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainer)).EndInit();
            this.sContainer.ResumeLayout(false);
            this.sContainerLeft.Panel1.ResumeLayout(false);
            this.sContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainerLeft)).EndInit();
            this.sContainerLeft.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.detailsGroup.ResumeLayout(false);
            this.detailsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ToolStripDropDownButton btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnNCom;
        private System.Windows.Forms.ToolStripMenuItem btnNCat;
        private System.Windows.Forms.ToolStripMenuItem btnCap;
        private System.Windows.Forms.GroupBox searchPanel;
        private System.Windows.Forms.SplitContainer sContainer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SplitContainer sContainerLeft;
        private System.Windows.Forms.GroupBox filterPanel;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox comboFilter;
        private System.Windows.Forms.GroupBox detailsGroup;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label dComment;
        private System.Windows.Forms.Label dEquivalents;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label dInventory;
        private System.Windows.Forms.Label lblEquivalents;
        private System.Windows.Forms.Label dPackage;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label dDescription;
        private System.Windows.Forms.Label dCode;
        private System.Windows.Forms.Label dCategory;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capsulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

