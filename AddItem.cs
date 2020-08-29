using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WarehouseInventory
{
    public partial class AddItem : Form
    {
        Connection conn = new Connection();
        public AddItem()
        {
            InitializeComponent();
            try
            {

                string query2 = "Select * from item_types";
                MySqlDataAdapter da1 = new MySqlDataAdapter(query2, conn.ActiveCon());
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Item");
                cmb_Item_Type.DisplayMember = "Item_Type";
                cmb_Item_Type.ValueMember = "Item_Types_Id";
                cmb_Item_Type.DataSource = ds1.Tables["Item"];
                show_all_Items();
                createNew();

            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured! " + ex.ToString());
            }


        }
        #region New Button
        private void btn_new_Click(object sender, EventArgs e)
        {
            Clear();
            createNew();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            show_all_Items();
            Clear();
        }
        #endregion
        #region Save Button
        private void btn_save_click(object sender, EventArgs e)
        {

            if (validateData() == false)
            {
                try
                {

                    if (isItemPresent() == true)
                    {

                        MessageBox.Show(txt_ItemName.Text + " already exist!");
                        return;
                    }
                    else
                    {
                        //Item does not exist
                        string query = $@"INSERT INTO items
                            ( Item_code, Item_Name, Item_Description, Item_Type_Id, Date_Created )
                            VALUES
                            ('{txtItemCode.Text}','{txt_ItemName.Text.Trim()}','{txtDesc.Text.Trim() }',{cmb_Item_Type.SelectedValue.ToString()},CURDATE());";
                        MySqlCommand cmd = new MySqlCommand(query, conn.ActiveCon());
                        cmd.ExecuteNonQuery();
                        
                        MessageBox.Show(txt_ItemName.Text + " added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        show_all_Items();
                        Clear();
                        createNew();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                return;
            }


        }
        #endregion
        #region ValidateData
        private bool validateData()
        {
            if (txt_ItemName.Text == ""  )
            {
                MessageBox.Show("Please, Enter Item Name ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cmb_Item_Type.SelectedIndex < -1)
            {
                MessageBox.Show("Please, select a valid item type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else
            {
                return false;
            }


        }
        #endregion
        #region Clear Table data
        private void Clear()
        {
            txt_ItemName.Clear();
            txtDesc.Clear();
            txt_ItemName.Focus();
            cmb_Item_Type.SelectedIndex = 0;
        }
        #endregion

        #region Is item Present
        public bool isItemPresent()
        {
            string itemName = txt_ItemName.Text.ToLower();
            string itemDesc = txtDesc.Text.ToLower();
            string queryItems = string.Format($@"Select item_name, item_description, item_type_id from items 
                                                where lower(item_name) = '{itemName}';");            
            MySqlDataAdapter a = new MySqlDataAdapter(queryItems, conn.ActiveCon());
            DataTable dt = new DataTable();            
            a.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        #endregion
        #region Run Query to show all items
        public void show_all_Items()
        {
            string query = $@"SELECT item_code as `Item Code`, Item_Name As `Item Name`,
                                    Item_Description As `Item Description`,
                                     Item_Type As `Item Type`
                            FROM items itm JOIN item_types itp 
                                               ON itm.item_type_id = itp.item_types_id";            
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn.ActiveCon());
            DataTable dt = new DataTable();           
            adapter.Fill(dt);
            items.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = items.Rows.Add();
                items.Rows[n].Cells[0].Value = item["Item Code"].ToString();
                items.Rows[n].Cells[1].Value = item["Item Name"].ToString();
                items.Rows[n].Cells[2].Value = item["Item Description"].ToString();
                items.Rows[n].Cells[3].Value = item["Item Type"].ToString();
            }
                              
            lblCount.Text = "Record Count : " + dt.Rows.Count.ToString();

            #endregion
        }
        #region create New item code
        public void createNew()
        {
            MySqlDataAdapter mysda = new MySqlDataAdapter("Proc_New_Item", conn.ActiveCon());
            mysda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            txtItemCode.Text = dt.Rows[0][0].ToString();
        }

        #endregion
        #region Load data to edit and Update
        private void items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int n = items.SelectedRows[0].Index;
            txtItemCode.Text = items.Rows[n].Cells[0].Value.ToString();
            txt_ItemName.Text = items.Rows[n].Cells[1].Value.ToString();
            txtDesc.Text = items.Rows[n].Cells[2].Value.ToString();
            cmb_Item_Type.Text = items.Rows[n].Cells[3].Value.ToString();
        }
        #endregion

        public void Update_items()
        {
            if (ItemExist())
            {
                Connection conn = new Connection();
                string query = $@"update items set item_Name = '{txt_ItemName.Text}',
                                              item_description = '{txtDesc.Text}',
                                              item_type_id = {cmb_Item_Type.SelectedValue},
                                                date_Modified = CURDATE()
                                where item_code = '{txtItemCode.Text}'";
                MySqlCommand cmd = new MySqlCommand(query, conn.ActiveCon());
                cmd.ExecuteNonQuery();
                Clear();
                createNew();
            }
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_items();
            show_all_Items();
        }
        public void DeleteRecord()
        {
            DialogResult dialogResult = 
                MessageBox.Show("Are you sure you want perform this delete? All items in the inventory relating to this item will be deleted.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Connection conn = new Connection();
                string query = $@"Delete from items 
                                where item_code = '{txtItemCode.Text}'";
                MySqlCommand cmd = new MySqlCommand(query, conn.ActiveCon());
                cmd.ExecuteNonQuery();
                string deleteInventory = $@"Delete from inventories
                                where item_code = '{txtItemCode.Text}'";
                MySqlCommand cmd2 = new MySqlCommand(deleteInventory, conn.ActiveCon());
                cmd2.ExecuteNonQuery();

            }else
            {
                return;
            }
            
        }
        public bool ItemExist()
        {
            string itemName = txt_ItemName.Text.ToLower();
            MySqlDataAdapter mda = new MySqlDataAdapter($@"Select Item_Name from Items where lower(Item_Name) ='{itemName}' and item_code = '{txtItemCode.Text}'; ", conn.ActiveCon());
            DataTable dt = new DataTable();
            mda.Fill(dt);
            if (dt.Rows.Count > 0 )
            {
                return true;
            }else
            {
                return false;
            }
            
        }


        
    }
}
    


