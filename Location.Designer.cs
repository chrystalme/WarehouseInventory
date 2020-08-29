namespace WarehouseInventory
{
    partial class Location
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
            this.LocationGrid = new System.Windows.Forms.DataGridView();
            this.Location_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocID = new System.Windows.Forms.TextBox();
            this.txtLocName = new System.Windows.Forms.TextBox();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LocationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationGrid
            // 
            this.LocationGrid.AllowUserToAddRows = false;
            this.LocationGrid.AllowUserToDeleteRows = false;
            this.LocationGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.LocationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Location_ID,
            this.Location_Name,
            this.Location_Code});
            this.LocationGrid.Location = new System.Drawing.Point(12, 112);
            this.LocationGrid.Name = "LocationGrid";
            this.LocationGrid.ReadOnly = true;
            this.LocationGrid.RowHeadersVisible = false;
            this.LocationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocationGrid.Size = new System.Drawing.Size(411, 161);
            this.LocationGrid.TabIndex = 0;
            this.LocationGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LocationGrid_MouseDoubleClick);
            // 
            // Location_ID
            // 
            this.Location_ID.HeaderText = "Location ID";
            this.Location_ID.Name = "Location_ID";
            this.Location_ID.ReadOnly = true;
            // 
            // Location_Name
            // 
            this.Location_Name.HeaderText = "Location Name";
            this.Location_Name.Name = "Location_Name";
            this.Location_Name.ReadOnly = true;
            this.Location_Name.Width = 150;
            // 
            // Location_Code
            // 
            this.Location_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location_Code.HeaderText = "Location Code";
            this.Location_Code.Name = "Location_Code";
            this.Location_Code.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Location ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location Name :";
            // 
            // txtLocID
            // 
            this.txtLocID.Enabled = false;
            this.txtLocID.Location = new System.Drawing.Point(118, 22);
            this.txtLocID.Name = "txtLocID";
            this.txtLocID.Size = new System.Drawing.Size(94, 20);
            this.txtLocID.TabIndex = 3;
            // 
            // txtLocName
            // 
            this.txtLocName.Location = new System.Drawing.Point(118, 56);
            this.txtLocName.Name = "txtLocName";
            this.txtLocName.Size = new System.Drawing.Size(138, 20);
            this.txtLocName.TabIndex = 4;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(267, 11);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 30);
            this.btn_New.TabIndex = 5;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(267, 49);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 30);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(348, 49);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 30);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(348, 12);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 30);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(435, 285);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.txtLocName);
            this.Controls.Add(this.txtLocID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationGrid);
            this.MaximizeBox = false;
            this.Name = "Location";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            ((System.ComponentModel.ISupportInitialize)(this.LocationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LocationGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocID;
        private System.Windows.Forms.TextBox txtLocName;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_Code;
    }
}