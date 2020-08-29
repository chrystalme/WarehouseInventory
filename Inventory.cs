using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WarehouseInventory
{
    public partial class Inventory : Form
    {
        
        Connection con = new Connection();
        
        public Inventory()
        {
            InitializeComponent();
            string itm_query = "select * from Locations";           
            MySqlDataAdapter mda = new MySqlDataAdapter(itm_query, con.ActiveCon());
            DataSet mds = new DataSet();
            mda.Fill(mds, "Locations");
            cmbLocation.DisplayMember = "Location_Name";
            cmbLocation.ValueMember = "Location_id";
            cmbLocation.DataSource = mds.Tables["Locations"];
            show_all_Items();
            CreateInvID();
            show_inventory();
        }
        #region Show all items method in the side panel
        void show_all_Items()
        {
            string query = $@"SELECT item_code as `Item Code`, Item_Name As `Item Name`,
                                    Item_Description As `Item Description`,
                                     Item_Type As `Item Type`
                            FROM items itm JOIN item_types itp 
                                               ON itm.item_type_id = itp.item_types_id";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con.ActiveCon());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            itemsView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = itemsView.Rows.Add();
                itemsView.Rows[n].Cells[0].Value = item["Item Code"].ToString();
                itemsView.Rows[n].Cells[1].Value = item["Item Name"].ToString();

            }
        }
        #endregion

        private void itemsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtItemCode.Text = itemsView.SelectedRows[0].Cells[0].Value.ToString();
            txtItemName.Text = itemsView.SelectedRows[0].Cells[1].Value.ToString();
            CreateInvID();
        }
        bool ValidIntData()
        {
            int units = 0;
            string unitQuantity = txtUnitQuantity.Text.ToString();

            int NumOfBoxes = 0;
            string numOfBoxes = txtNumOfBoxes.Text.ToString();

            if (int.TryParse(unitQuantity, out units))
            {
                return true;
            }
            if (int.TryParse(numOfBoxes, out NumOfBoxes))
            {
                return true;
            }
            else
            {
                return false;
            }

            
            
        }
        void Save_Item()
        {
            
            if (ValidIntData() && validateInput())
            {
                if (itemExist())
                {
                    MessageBox.Show(txtItemName.Text + " at Location : " + cmbLocation.Text + " already exist in the Inventory.");
                    return;
                }else
                {
                    int units = Convert.ToInt32( txtUnitQuantity.Text.ToString());
                    int NumOfBoxes = Convert.ToInt32(txtNumOfBoxes.Text.ToString());

                    int total_Avail = NumOfBoxes * units;
                    string query = $@"insert into inventories (Inventory_Id, item_Code, Unit_quantity, Number_Of_Boxes, Total_Available, Location_id, Date_Created)
                                    Values ({txtInvID.Text},
                                            '{txtItemCode.Text}', 
                                            {units}, 
                                            {NumOfBoxes},   
                                            {total_Avail},
                                            {cmbLocation.SelectedValue},
                                            CURDATE() )";
                    MySqlCommand cmd = new MySqlCommand(query, con.ActiveCon());
                    cmd.ExecuteNonQuery();
                }   
                

            }else
            {
                MessageBox.Show("Check your data once again, cause something seem to be wrong.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save_Item();
            CreateInvID();
            clearText();
            show_inventory();
        }
        bool validateInput()
        {
            if (txtItemCode.Text == "")
            {
                return false;
            }            
            if (cmbLocation.SelectedIndex < 0)
            {
                return false;
            }else
            {
                return true;
            }            
        }
        bool validID()
        {
            MySqlDataAdapter mda = new MySqlDataAdapter($"SELECT inventory_id FROM inventories where inventory_id = {txtInvID.Text} ", con.ActiveCon());
            DataTable dt = new DataTable();
            mda.Fill(dt);

            if (dt.Rows.Count != 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        void CreateInvID()
        {
            MySqlDataAdapter mda = new MySqlDataAdapter("ProcedureNewInventory", con.ActiveCon());
            mda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            mda.Fill(dt);            
            txtInvID.Text = dt.Rows[0][0].ToString();
        }
        void show_inventory()
        {
            string query = @"SELECT 
                            inv.inventory_id,
                            I.item_Name,
                            inv.unit_quantity,
                            inv.Number_of_boxes,
                            l.Location_Name,
                            Date_Format(inv.Date_Created, '%d-%M-%Y') AS Date_Created,
                            Date_Format(inv.Date_Last_Restocked, '%d-%M-%Y') AS Date_Last_Restocked
                        FROM
                            inventories inv
                                JOIN
                            locations l USING (Location_id)
                                JOIN
                            items I USING(item_Code)";
            MySqlDataAdapter mda = new MySqlDataAdapter(query, con.ActiveCon());
            DataTable dt = new DataTable();
            mda.Fill(dt);
            inventoryView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = inventoryView.Rows.Add();
                inventoryView.Rows[n].Cells[0].Value = item["Inventory_Id"].ToString();
                inventoryView.Rows[n].Cells[1].Value = item["Item_Name"].ToString();
                inventoryView.Rows[n].Cells[2].Value = item["Unit_quantity"].ToString();
                inventoryView.Rows[n].Cells[3].Value = item["Number_of_Boxes"].ToString();
                inventoryView.Rows[n].Cells[4].Value = item["Location_Name"].ToString();
                inventoryView.Rows[n].Cells[5].Value = item["Date_Created"].ToString();
                inventoryView.Rows[n].Cells[6].Value = item["Date_Last_Restocked"].ToString();
            }

        }
        #region Method to clear the textboxes 
        void clearText()
        {
            txtItemCode.Clear();
            txtItemName.Clear();
            txtNumOfBoxes.Clear();
            txtUnitQuantity.Clear();
            txtUnitQuantity.Focus();
            cmbLocation.SelectedIndex = 0;
        }
        #endregion

        private void inventoryView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            txtInvID.Text = inventoryView.SelectedRows[0].Cells[0].Value.ToString();
            txtItemName.Text = inventoryView.SelectedRows[0].Cells[1].Value.ToString();
            txtUnitQuantity.Text = inventoryView.SelectedRows[0].Cells[2].Value.ToString();
            txtNumOfBoxes.Text = inventoryView.SelectedRows[0].Cells[3].Value.ToString();
            txtItemCode.Clear();
                       
            
        }
        bool itemExist()
        {
            //int invID = Convert.ToInt32(txtInvID.Text.ToString());
            string ItemName = txtItemName.Text.ToLower();
            string invLocation = cmbLocation.Text.ToLower();
            MySqlDataAdapter mda = new MySqlDataAdapter($@"SELECT 
                                                inv.inventory_id,
                                                I.item_Name,
                                                l.Location_Name
                                            FROM
                                                inventories inv
                                                    JOIN
                                                locations l USING(Location_id)
                                                    JOIN
                                                items I USING(item_Code) 
                                            WHERE
                                                LOWER(I.Item_Name) = '{ItemName}'
                                                    AND LOWER(l.Location_Name) = '{invLocation}'", con.ActiveCon());
            DataTable dt = new DataTable();
            mda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete : " + txtItemName.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand($"Delete from inventories where inventory_id = {txtInvID.Text.ToString()}", con.ActiveCon());
                cmd.ExecuteNonQuery();
                show_inventory();
                clearText();
            }else
            {
                return;
            }
            
        }
        #region Method for Restock Task
        void restock()
        {

            try
            {
                if (ValidIntData() && validID())
                {
                    string query_restock = $@"select unit_quantity, Number_of_boxes
                                                    FROM Inventories
                                WHERE inventory_id = {txtInvID.Text}";
                    MySqlDataAdapter mda = new MySqlDataAdapter(query_restock, con.ActiveCon());
                    DataTable dt = new DataTable();
                    mda.Fill(dt);
                    int old_unit = Convert.ToInt32(dt.Rows[0][0].ToString());
                    int old_Num = Convert.ToInt32(dt.Rows[0][1].ToString());
                    int new_unit = Convert.ToInt32(txtUnitQuantity.Text.ToString());
                    int new_Num = Convert.ToInt32(txtNumOfBoxes.Text.ToString());
                    if (old_Num == new_Num)
                    {
                        DialogResult result = MessageBox.Show("Are you sure you don't want to change the Number of Boxes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                        if (result == DialogResult.Yes)
                        {
                            int new_Total_Available = (old_Num * old_unit) + (new_Num * new_unit);
                            int num_of_boxes = old_Num + new_Num;
                            MySqlCommand cmd = new MySqlCommand($@"update inventories set unit_quantity = {new_unit}, number_of_boxes = {num_of_boxes},total_available = {new_Total_Available}, date_last_restocked = CURDATE()
                                                                    where inventory_id = {txtInvID.Text}", con.ActiveCon());                            
                            cmd.ExecuteNonQuery();
                            StringBuilder sb = new StringBuilder();
                            sb.Append("You have added : " + new_Total_Available + " to "+txtItemName.Text+" in "+ cmbLocation.Text);
                            MessageBox.Show(sb.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            show_inventory();
                        }else
                        {
                            return;
                        }
                    }else
                    {
                        int new_Total_Available = (old_Num * old_unit) + (new_Num * new_unit);
                        int num_of_boxes = old_Num + new_Num;
                        MySqlCommand cmd = new MySqlCommand($@"update inventories set unit_quantity = {new_unit}, number_of_boxes = {num_of_boxes},total_available = {new_Total_Available}, date_last_restocked = CURDATE()
                                                                    where inventory_id = {txtInvID.Text}", con.ActiveCon());
                        cmd.ExecuteNonQuery();
                        StringBuilder sb = new StringBuilder();
                        sb.Append("You have added : " + new_Total_Available + " to " + txtItemName.Text + " in " + cmbLocation.Text);
                        MessageBox.Show(sb.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        show_inventory();
                    }
                    
                }
                else
                {
                    DialogResult result = MessageBox.Show("Data not valid for restocking", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        return;
                    }
                }
                
            }

            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);

            } 
        }       

        private void btnReStock_Click(object sender, EventArgs e)
        {
            restock();
        }
        #endregion

        private void txtItemSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (string.IsNullOrEmpty(txtItemSearch.Text))
                    {
                        show_all_Items();
                    }
                    else
                    {
                        string word = txtItemSearch.Text.ToLower();
                        string query = string.Format($@"SELECT * from items
                        WHERE LOWER(item_Name) like '%{word}%'");
                        MySqlDataAdapter a = new MySqlDataAdapter(query, con.ActiveCon());
                        DataTable dt = new DataTable();
                        a.Fill(dt);
                        itemsView.Rows.Clear();
                        foreach (DataRow item in dt.Rows)
                        {
                            int n = itemsView.Rows.Add();
                            itemsView.Rows[n].Cells[0].Value = item["Item_Code"].ToString();
                            itemsView.Rows[n].Cells[1].Value = item["Item_Name"].ToString();

                        }
                        //itemsView.DataSource = dt;
                        //itemsView.AutoResizeColumns();
                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }

}
    