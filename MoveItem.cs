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
    public partial class MoveItem : Form
    {
        Connection con = new Connection();
        public MoveItem()
        {
            InitializeComponent();
            string itm_query = "select * from items";
            MySqlDataAdapter mda = new MySqlDataAdapter(itm_query, con.ActiveCon());
            DataSet mds = new DataSet();
            mda.Fill(mds, "Move Items");
            cmbItems.DisplayMember = "Item_Name";
            cmbItems.ValueMember = "Item_code";
            cmbItems.DataSource = mds.Tables["Move Items"];

            string locFrom_query = "select * from locations";
            MySqlDataAdapter lmda = new MySqlDataAdapter(locFrom_query, con.ActiveCon());
            DataSet lds = new DataSet();
            lmda.Fill(lds, "Location_From");
            cmb_From.DisplayMember = "Location_Name";
            cmb_From.ValueMember = "Location_id";
            cmb_From.DataSource = lds.Tables["Location_From"];

            string locTO_query = "select * from locations";
            MySqlDataAdapter lTOmda = new MySqlDataAdapter(locTO_query, con.ActiveCon());
            DataSet lTods = new DataSet();
            lmda.Fill(lTods, "Location_to");
            cmb_To.DisplayMember = "Location_Name";
            cmb_To.ValueMember = "Location_id";
            cmb_To.DataSource = lTods.Tables["Location_to"];
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Is not implemented yet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
