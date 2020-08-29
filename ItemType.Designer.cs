namespace WarehouseInventory
{
    partial class ItemType
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
            this.btn_New = new System.Windows.Forms.Button();
            this.itemTypes = new System.Windows.Forms.DataGridView();
            this.Item_Type_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeDesc = new System.Windows.Forms.TextBox();
            this.lblHidden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(216, 14);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 36);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // itemTypes
            // 
            this.itemTypes.AllowUserToAddRows = false;
            this.itemTypes.AllowUserToDeleteRows = false;
            this.itemTypes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.itemTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Type_Id,
            this.Item_Type,
            this.Item_Desc});
            this.itemTypes.Location = new System.Drawing.Point(12, 115);
            this.itemTypes.Name = "itemTypes";
            this.itemTypes.ReadOnly = true;
            this.itemTypes.RowHeadersVisible = false;
            this.itemTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemTypes.Size = new System.Drawing.Size(360, 112);
            this.itemTypes.TabIndex = 1;
            this.itemTypes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemTypes_MouseDoubleClick);
            // 
            // Item_Type_Id
            // 
            this.Item_Type_Id.HeaderText = "Item Type Id";
            this.Item_Type_Id.Name = "Item_Type_Id";
            this.Item_Type_Id.ReadOnly = true;
            // 
            // Item_Type
            // 
            this.Item_Type.HeaderText = "Item Type";
            this.Item_Type.Name = "Item_Type";
            this.Item_Type.ReadOnly = true;
            // 
            // Item_Desc
            // 
            this.Item_Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item_Desc.HeaderText = "Type Description";
            this.Item_Desc.Name = "Item_Desc";
            this.Item_Desc.ReadOnly = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(297, 56);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 36);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(216, 56);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 36);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(297, 14);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 36);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Type :";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(84, 15);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(126, 20);
            this.txtItemType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type Desc :";
            // 
            // txtTypeDesc
            // 
            this.txtTypeDesc.Location = new System.Drawing.Point(84, 41);
            this.txtTypeDesc.Multiline = true;
            this.txtTypeDesc.Name = "txtTypeDesc";
            this.txtTypeDesc.Size = new System.Drawing.Size(126, 36);
            this.txtTypeDesc.TabIndex = 3;
            // 
            // lblHidden
            // 
            this.lblHidden.AutoSize = true;
            this.lblHidden.Location = new System.Drawing.Point(9, 79);
            this.lblHidden.Name = "lblHidden";
            this.lblHidden.Size = new System.Drawing.Size(15, 13);
            this.lblHidden.TabIndex = 4;
            this.lblHidden.Text = "id";
            this.lblHidden.Visible = false;
            // 
            // ItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 244);
            this.Controls.Add(this.lblHidden);
            this.Controls.Add(this.txtTypeDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemTypes);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_New);
            this.MaximizeBox = false;
            this.Name = "ItemType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Type";
            ((System.ComponentModel.ISupportInitialize)(this.itemTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView itemTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypeDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Type_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Desc;
        private System.Windows.Forms.Label lblHidden;
    }
}