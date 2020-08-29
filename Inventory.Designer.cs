namespace WarehouseInventory
{
    partial class Inventory
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReStock = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.inventoryView = new System.Windows.Forms.DataGridView();
            this.Inventory_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Boxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_Modified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsView = new System.Windows.Forms.DataGridView();
            this.Item_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInvID = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtNumOfBoxes = new System.Windows.Forms.TextBox();
            this.txtUnitQuantity = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(532, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReStock
            // 
            this.btnReStock.Location = new System.Drawing.Point(624, 18);
            this.btnReStock.Name = "btnReStock";
            this.btnReStock.Size = new System.Drawing.Size(86, 36);
            this.btnReStock.TabIndex = 1;
            this.btnReStock.Text = "Re Stock";
            this.btnReStock.UseVisualStyleBackColor = true;
            this.btnReStock.Click += new System.EventHandler(this.btnReStock_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(532, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(624, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // inventoryView
            // 
            this.inventoryView.AllowUserToAddRows = false;
            this.inventoryView.AllowUserToDeleteRows = false;
            this.inventoryView.AllowUserToResizeColumns = false;
            this.inventoryView.AllowUserToResizeRows = false;
            this.inventoryView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.inventoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inventory_Id,
            this.Name_Item,
            this.Unit_Quantity,
            this.Num_Boxes,
            this.Locations,
            this.Date_Created,
            this.Last_Modified});
            this.inventoryView.Location = new System.Drawing.Point(14, 134);
            this.inventoryView.Name = "inventoryView";
            this.inventoryView.ReadOnly = true;
            this.inventoryView.RowHeadersVisible = false;
            this.inventoryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryView.Size = new System.Drawing.Size(699, 412);
            this.inventoryView.TabIndex = 2;
            this.inventoryView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.inventoryView_MouseDoubleClick);
            // 
            // Inventory_Id
            // 
            this.Inventory_Id.HeaderText = "Inventory ID";
            this.Inventory_Id.Name = "Inventory_Id";
            this.Inventory_Id.ReadOnly = true;
            // 
            // Name_Item
            // 
            this.Name_Item.HeaderText = "Item Name";
            this.Name_Item.Name = "Name_Item";
            this.Name_Item.ReadOnly = true;
            // 
            // Unit_Quantity
            // 
            this.Unit_Quantity.HeaderText = "Unit Quantity";
            this.Unit_Quantity.Name = "Unit_Quantity";
            this.Unit_Quantity.ReadOnly = true;
            this.Unit_Quantity.Width = 70;
            // 
            // Num_Boxes
            // 
            this.Num_Boxes.HeaderText = "Number Of Boxes";
            this.Num_Boxes.Name = "Num_Boxes";
            this.Num_Boxes.ReadOnly = true;
            this.Num_Boxes.Width = 70;
            // 
            // Locations
            // 
            this.Locations.HeaderText = "Locations";
            this.Locations.Name = "Locations";
            this.Locations.ReadOnly = true;
            // 
            // Date_Created
            // 
            this.Date_Created.HeaderText = "Date Created";
            this.Date_Created.Name = "Date_Created";
            this.Date_Created.ReadOnly = true;
            // 
            // Last_Modified
            // 
            this.Last_Modified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Last_Modified.HeaderText = "Date Restocked";
            this.Last_Modified.Name = "Last_Modified";
            this.Last_Modified.ReadOnly = true;
            // 
            // itemsView
            // 
            this.itemsView.AllowUserToAddRows = false;
            this.itemsView.AllowUserToDeleteRows = false;
            this.itemsView.AllowUserToResizeColumns = false;
            this.itemsView.AllowUserToResizeRows = false;
            this.itemsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.itemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_code,
            this.Item_Name});
            this.itemsView.Location = new System.Drawing.Point(3, 78);
            this.itemsView.Name = "itemsView";
            this.itemsView.ReadOnly = true;
            this.itemsView.RowHeadersVisible = false;
            this.itemsView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.itemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsView.Size = new System.Drawing.Size(226, 471);
            this.itemsView.TabIndex = 5;
            this.itemsView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemsView_MouseDoubleClick);
            // 
            // Item_code
            // 
            this.Item_code.HeaderText = "Item Code";
            this.Item_code.Name = "Item_code";
            this.Item_code.ReadOnly = true;
            this.Item_code.Width = 80;
            // 
            // Item_Name
            // 
            this.Item_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search :";
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Location = new System.Drawing.Point(12, 47);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(140, 20);
            this.txtItemSearch.TabIndex = 1;
            this.txtItemSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemSearch_KeyPress);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.itemsView);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtItemSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.inventoryView);
            this.splitContainer1.Panel2.Controls.Add(this.txtInvID);
            this.splitContainer1.Panel2.Controls.Add(this.txtItemCode);
            this.splitContainer1.Panel2.Controls.Add(this.cmbLocation);
            this.splitContainer1.Panel2.Controls.Add(this.txtNumOfBoxes);
            this.splitContainer1.Panel2.Controls.Add(this.txtUnitQuantity);
            this.splitContainer1.Panel2.Controls.Add(this.txtItemName);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnReStock);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Size = new System.Drawing.Size(974, 561);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 8;
            // 
            // txtInvID
            // 
            this.txtInvID.Enabled = false;
            this.txtInvID.Location = new System.Drawing.Point(316, 46);
            this.txtInvID.Name = "txtInvID";
            this.txtInvID.Size = new System.Drawing.Size(116, 20);
            this.txtInvID.TabIndex = 5;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Location = new System.Drawing.Point(316, 18);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(116, 20);
            this.txtItemCode.TabIndex = 5;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(98, 46);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(121, 21);
            this.cmbLocation.TabIndex = 3;
            // 
            // txtNumOfBoxes
            // 
            this.txtNumOfBoxes.Location = new System.Drawing.Point(98, 108);
            this.txtNumOfBoxes.Name = "txtNumOfBoxes";
            this.txtNumOfBoxes.Size = new System.Drawing.Size(147, 20);
            this.txtNumOfBoxes.TabIndex = 5;
            // 
            // txtUnitQuantity
            // 
            this.txtUnitQuantity.Location = new System.Drawing.Point(98, 78);
            this.txtUnitQuantity.Name = "txtUnitQuantity";
            this.txtUnitQuantity.Size = new System.Drawing.Size(147, 20);
            this.txtUnitQuantity.TabIndex = 4;
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(98, 18);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(147, 20);
            this.txtItemName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Num of Boxes :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(251, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "Inv Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unit Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(251, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item Code :";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(974, 561);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Inventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            ((System.ComponentModel.ISupportInitialize)(this.inventoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView inventoryView;
        private System.Windows.Forms.DataGridView itemsView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtNumOfBoxes;
        private System.Windows.Forms.TextBox txtUnitQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInvID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Boxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_Modified;
    }
}