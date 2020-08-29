namespace WarehouseInventory
{
    partial class MoveItem
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
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_From = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_To = new System.Windows.Forms.ComboBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(139, 25);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(205, 21);
            this.cmbItems.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "From";
            // 
            // cmb_From
            // 
            this.cmb_From.FormattingEnabled = true;
            this.cmb_From.Location = new System.Drawing.Point(139, 52);
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.Size = new System.Drawing.Size(121, 21);
            this.cmb_From.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(74, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "To";
            // 
            // cmb_To
            // 
            this.cmb_To.FormattingEnabled = true;
            this.cmb_To.Location = new System.Drawing.Point(139, 79);
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.Size = new System.Drawing.Size(121, 21);
            this.cmb_To.TabIndex = 6;
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(139, 106);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(101, 20);
            this.txt_Qty.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelveticaNeueLT Std ExtBlk Cn", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(74, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(385, 22);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(88, 51);
            this.btnMove.TabIndex = 10;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // MoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(515, 197);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.cmb_To);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbItems);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "MoveItem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Move Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_From;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_To;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMove;
    }
}