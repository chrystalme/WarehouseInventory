namespace WarehouseInventory
{
    partial class WarehouseInventory
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Inventory = new System.Windows.Forms.DataGridView();
            this.Item_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Boxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Supply = new System.Windows.Forms.DataGridView();
            this.Name_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_Of_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_supplied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Total_supplied = new System.Windows.Forms.Label();
            this.lbl_Num_of_items = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Supply)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.refreshF5ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.moveToolStripMenuItem,
            this.supplyToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Enabled = false;
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemTypesToolStripMenuItem,
            this.locationsToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Admin";
            // 
            // itemTypesToolStripMenuItem
            // 
            this.itemTypesToolStripMenuItem.Name = "itemTypesToolStripMenuItem";
            this.itemTypesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.itemTypesToolStripMenuItem.Text = "Item Types";
            this.itemTypesToolStripMenuItem.Click += new System.EventHandler(this.itemTypesToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // refreshF5ToolStripMenuItem
            // 
            this.refreshF5ToolStripMenuItem.Name = "refreshF5ToolStripMenuItem";
            this.refreshF5ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.refreshF5ToolStripMenuItem.Text = "Refresh";
            this.refreshF5ToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Inventory);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(802, 430);
            this.splitContainer1.SplitterDistance = 548;
            this.splitContainer1.TabIndex = 4;
            // 
            // Inventory
            // 
            this.Inventory.AllowUserToAddRows = false;
            this.Inventory.AllowUserToDeleteRows = false;
            this.Inventory.AllowUserToResizeColumns = false;
            this.Inventory.AllowUserToResizeRows = false;
            this.Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Code,
            this.Item_Name,
            this.Item_Description,
            this.Num_Boxes,
            this.Total_Available});
            this.Inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inventory.Location = new System.Drawing.Point(0, 0);
            this.Inventory.Name = "Inventory";
            this.Inventory.ReadOnly = true;
            this.Inventory.RowHeadersVisible = false;
            this.Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Inventory.Size = new System.Drawing.Size(548, 430);
            this.Inventory.TabIndex = 0;
            // 
            // Item_Code
            // 
            this.Item_Code.HeaderText = "Item Code";
            this.Item_Code.Name = "Item_Code";
            this.Item_Code.ReadOnly = true;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Item_Description
            // 
            this.Item_Description.HeaderText = "Item Description";
            this.Item_Description.Name = "Item_Description";
            this.Item_Description.ReadOnly = true;
            this.Item_Description.Width = 175;
            // 
            // Num_Boxes
            // 
            this.Num_Boxes.HeaderText = "Number of Boxes";
            this.Num_Boxes.Name = "Num_Boxes";
            this.Num_Boxes.ReadOnly = true;
            // 
            // Total_Available
            // 
            this.Total_Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total_Available.HeaderText = "Total Available";
            this.Total_Available.Name = "Total_Available";
            this.Total_Available.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Supply);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lbl_Total_supplied);
            this.splitContainer2.Panel2.Controls.Add(this.lbl_Num_of_items);
            this.splitContainer2.Size = new System.Drawing.Size(250, 430);
            this.splitContainer2.SplitterDistance = 293;
            this.splitContainer2.TabIndex = 0;
            // 
            // Supply
            // 
            this.Supply.AllowUserToAddRows = false;
            this.Supply.AllowUserToDeleteRows = false;
            this.Supply.AllowUserToResizeRows = false;
            this.Supply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Supply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_item,
            this.type_Of_Item,
            this.total_supplied});
            this.Supply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Supply.Location = new System.Drawing.Point(0, 0);
            this.Supply.Name = "Supply";
            this.Supply.ReadOnly = true;
            this.Supply.RowHeadersVisible = false;
            this.Supply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Supply.Size = new System.Drawing.Size(250, 293);
            this.Supply.TabIndex = 1;
            // 
            // Name_item
            // 
            this.Name_item.HeaderText = "Item Name";
            this.Name_item.Name = "Name_item";
            this.Name_item.ReadOnly = true;
            this.Name_item.Width = 150;
            // 
            // type_Of_Item
            // 
            this.type_Of_Item.HeaderText = "Item Type";
            this.type_Of_Item.Name = "type_Of_Item";
            this.type_Of_Item.ReadOnly = true;
            this.type_Of_Item.Width = 120;
            // 
            // total_supplied
            // 
            this.total_supplied.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_supplied.HeaderText = "Total Supplied";
            this.total_supplied.Name = "total_supplied";
            this.total_supplied.ReadOnly = true;
            // 
            // lbl_Total_supplied
            // 
            this.lbl_Total_supplied.AutoSize = true;
            this.lbl_Total_supplied.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lbl_Total_supplied.Location = new System.Drawing.Point(83, 53);
            this.lbl_Total_supplied.Name = "lbl_Total_supplied";
            this.lbl_Total_supplied.Size = new System.Drawing.Size(91, 14);
            this.lbl_Total_supplied.TabIndex = 1;
            this.lbl_Total_supplied.Text = "Total Supplied : 0 ";
            // 
            // lbl_Num_of_items
            // 
            this.lbl_Num_of_items.AutoSize = true;
            this.lbl_Num_of_items.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lbl_Num_of_items.Location = new System.Drawing.Point(74, 26);
            this.lbl_Num_of_items.Name = "lbl_Num_of_items";
            this.lbl_Num_of_items.Size = new System.Drawing.Size(102, 14);
            this.lbl_Num_of_items.TabIndex = 0;
            this.lbl_Num_of_items.Text = "Number of Items : 0 ";
            // 
            // WarehouseInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(808, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "WarehouseInventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Supply)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshF5ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView Supply;
        private System.Windows.Forms.DataGridView Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Boxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_Of_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_supplied;
        private System.Windows.Forms.Label lbl_Total_supplied;
        private System.Windows.Forms.Label lbl_Num_of_items;
    }
}

