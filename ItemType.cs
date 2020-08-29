using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WarehouseInventory
{
    public partial class ItemType : Form
    {
        Connection conn = new Connection();
        
        public ItemType()
        {
            InitializeComponent();
            showData();
            txtItemType.Focus();            
        }
        void showData()
        {
            MySqlDataAdapter mda = new MySqlDataAdapter("Select Item_Types_Id ,Item_Type, Item_types_details from item_types", conn.ActiveCon());
            DataTable dt = new DataTable();
            mda.Fill(dt);
            itemTypes.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = itemTypes.Rows.Add();
                itemTypes.Rows[n].Cells[0].Value = item["Item_Types_Id"].ToString();
                itemTypes.Rows[n].Cells[1].Value = item["Item_Type"].ToString();
                itemTypes.Rows[n].Cells[2].Value = item["Item_types_details"].ToString();
               
            }
        }

        private void itemTypes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtItemType.Text = itemTypes.SelectedRows[0].Cells[1].Value.ToString();
            txtTypeDesc.Text = itemTypes.SelectedRows[0].Cells[2].Value.ToString();
            lblHidden.Text = itemTypes.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txtItemType.Clear();
            txtTypeDesc.Clear();
            txtItemType.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtItemType.Text == null || txtItemType.Text == "" )
            {
                MessageBox.Show("You have to enter an Item type to create one", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                string query = $@"INSERT INTO item_types
                         (Item_Type, Item_types_details)
                                VALUES ('{txtItemType.Text}', '{txtTypeDesc.Text}');";
                MySqlCommand cmd = new MySqlCommand(query, conn.ActiveCon());
                cmd.ExecuteNonQuery();
                showData();
            }
            

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtItemType.Text == null || txtItemType.Text == "")
            {
                MessageBox.Show("You have nothing to update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string query = $@"update item_types set item_Type = '{txtItemType.Text}',
                                            item_types_details = '{txtTypeDesc.Text}'
                                    where item_types_id = {lblHidden.Text};";
                MySqlCommand cmd = new MySqlCommand(query, conn.ActiveCon());
                cmd.ExecuteNonQuery();
                showData();

            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
           
            if (lblHidden.Text == "" && itemTypes.Text =="")
            {
                MessageBox.Show("There is Nothing to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                
            }
            else
            {
                DialogResult itemDialog = MessageBox.Show("Are you sure you want to delete" + itemTypes.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (itemDialog == DialogResult.Yes)
                {
                    string query = $@"Delete from item_types
                                    where item_types_id = {lblHidden.Text};";
                    MySqlCommand cmd = new MySqlCommand(query, conn.ActiveCon());
                    cmd.ExecuteNonQuery();
                    showData();
                }else
                {
                    return;
                }
                
            }  

        }
    }
}
