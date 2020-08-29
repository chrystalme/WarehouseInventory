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
    public partial class Location : Form
    {
        Connection conn = new Connection();
        public Location()
        {
            InitializeComponent();
            createNew();
            ShowLocations();
        }

        private void createNew()
        {
            MySqlDataAdapter mysda = new MySqlDataAdapter("ProcedureNewLocation", conn.ActiveCon());
            mysda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            mysda.Fill(dt);
            txtLocID.Text = dt.Rows[0][0].ToString();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            createNew();
            txtLocName.Clear();
            txtLocName.Focus();
        }
        private void ShowLocations()
        {
            try
            {
                string locations = "Select * from Locations";
                MySqlDataAdapter mda = new MySqlDataAdapter(locations, conn.ActiveCon());
                DataTable dt = new DataTable();
                mda.Fill(dt);
                LocationGrid.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = LocationGrid.Rows.Add();
                    LocationGrid.Rows[n].Cells[0].Value = item["Location_Id"].ToString();
                    LocationGrid.Rows[n].Cells[1].Value = item["Location_Name"].ToString();
                    LocationGrid.Rows[n].Cells[2].Value = item["Location_Code"].ToString();
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void LocationGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtLocID.Text = LocationGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtLocName.Text = LocationGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!locationExist() && LocationValid())
                {
                    string addLocation = $@"Insert into Locations (Location_id, Location_Name, Location_Code)
                                                Values ({txtLocID.Text}, '{txtLocName.Text}', UPPer(Left('{txtLocName.Text}', 3)))";
                    MySqlCommand cmd = new MySqlCommand(addLocation, conn.ActiveCon());
                    cmd.ExecuteNonQuery();
                    ShowLocations();
                    btn_New_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Please, enter a new and valid location", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private bool locationExist()
        {            
                string locName = txtLocName.Text.ToLower();
                MySqlDataAdapter mda = new MySqlDataAdapter($@"Select * from Locations where lower(location_name) = '{locName}';", conn.ActiveCon());
                DataTable dt = new DataTable();
                mda.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }            
            
        }
       bool LocationValid()
        {
            if (txtLocName.Text == null)
            {
                return false;
            }
            if (txtLocName.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand($"Delete from Locations where location_Id = {txtLocID.Text}", conn.ActiveCon());
                MySqlCommand cmd2 = new MySqlCommand($"Delete from inventories where location_id = {txtLocID.Text}", conn.ActiveCon());
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                ShowLocations();
                txtLocName.Clear();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {            
                if (LocationValid())
                {
                    MySqlCommand cmd = new MySqlCommand($@"Update locations set Location_Name = '{txtLocName.Text}',
                                                                            Location_Code = UPPer(Left('{txtLocName.Text}', 3)) 
                                                        where location_id = {txtLocID.Text}", conn.ActiveCon());
                    cmd.ExecuteNonQuery();
                    ShowLocations();
            }else
            {
                MessageBox.Show("You have nothing to update.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                
            
            
        }
    }
}
