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
    public partial class WarehouseInventory : Form
    {
        Connection conn = new Connection();
        public WarehouseInventory()
        {
            InitializeComponent();
            run_Query();
    }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem additem = new AddItem();
            additem.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoveItem moveitem = new MoveItem();
            moveitem.Show();
        }
        private void run_Query()
        {
            string error_msg = "";
            string inventory = $@"SELECT 
                                Item_code,
                                I.Item_Name,
                                I.Item_Description,
                                SUM(INV.Total_Available) 'Total Available',SUM(INV.Number_of_Boxes) 'Num_Of_Boxes'
                            FROM
                                items I
                                    JOIN
                                inventories INV USING (Item_Code)
                            GROUP BY Item_code
                            ORDER BY Item_Code ASC";
            string supplies = $@"SELECT 
                                    i.Item_code,
                                    i.item_Name,
                                    tt.item_type,
                                    SUM(s.Quantity_supplied) 'Total Supplied'
                                FROM
                                    supplied s
                                        JOIN
                                    items i USING (item_code)
                                        JOIN
                                    item_types tt ON tt.item_types_id = i.Item_Type_Id
                                GROUP BY Item_code
                                ORDER BY Item_Code ASC";
            try
            {
                MySqlDataAdapter a = new MySqlDataAdapter(inventory, conn.ActiveCon());
                DataTable dt = new DataTable();
                a.Fill(dt);
                Inventory.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = Inventory.Rows.Add();
                    Inventory.Rows[n].Cells[0].Value = item["Item_Code"].ToString();
                    Inventory.Rows[n].Cells[1].Value = item["Item_Name"].ToString();
                    Inventory.Rows[n].Cells[2].Value = item["Item_Description"].ToString();
                    Inventory.Rows[n].Cells[3].Value = item["Num_Of_Boxes"].ToString();
                    Inventory.Rows[n].Cells[4].Value = item["Total Available"].ToString();
                }
                MySqlDataAdapter b = new MySqlDataAdapter(supplies, conn.ActiveCon());
                DataTable ds = new DataTable();
                b.Fill(ds);
                Supply.Rows.Clear();
                foreach (DataRow item in ds.Rows)
                {
                    int n = Supply.Rows.Add();
                    Supply.Rows[n].Cells[0].Value = item["item_Name"].ToString();
                    Supply.Rows[n].Cells[1].Value = item["item_type"].ToString();
                    Supply.Rows[n].Cells[2].Value = item["Total Supplied"].ToString();
                }
                MySqlDataAdapter report1 = new MySqlDataAdapter("SELECT count(*) from items", conn.ActiveCon());
                DataTable dt1 = new DataTable();
                report1.Fill(dt1);
                lbl_Num_of_items.Text = "Number of Items : " + dt1.Rows[0][0].ToString();

                MySqlDataAdapter supplied = new MySqlDataAdapter("select SUM(Quantity_Supplied) from supplied", conn.ActiveCon());
                DataTable dt2 = new DataTable();
                supplied.Fill(dt2);
                lbl_Total_supplied.Text = "Total Supplied : " + dt2.Rows[0][0].ToString(); 

            }
            catch (Exception ex)
            {
                error_msg = ex.Message;
                MessageBox.Show(error_msg);

            }
            

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            run_Query();
        }

        private void itemTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemType itemType = new ItemType();
            itemType.Show();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            location.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

      
    }
}
