using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryPro
{
    public partial class DealerInfo : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");
        public DealerInfo()
        {
            InitializeComponent();
        }

        private void buttonInsertDealer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dealerInfo values ('"+textBoxDealerName.Text+"','"+textBoxDealerCompany.Text+"','"+textBoxDealerContact.Text+"','"+textBoxDealerAddress.Text+"','"+textBoxDealerCity.Text+"')";
            cmd.ExecuteNonQuery();
            clearDealer();
            dealerDataGrid();
            MessageBox.Show("Dealer info Insert sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        public void dealerDataGrid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealerInfo";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridViewDealerInfo.DataSource = DT;
        }

        public void clearDealer()
        {
            textBoxDealerName.Text = "";
            textBoxDealerCompany.Text = "";
            textBoxDealerContact.Text = "";
            textBoxDealerAddress.Text = "";
            textBoxDealerCity.Text = "";
        }

        private void DealerInfo_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            dealerDataGrid();
        }

        private void buttonDeleteDealer_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridViewDealerInfo.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from dealerInfo where id='" + id + "'";
            cmd.ExecuteNonQuery();
            dealerDataGrid();
            Display();
        }

        public void Display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealerInfo ";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridViewDealerInfo.DataSource = DT;

        }

        private void buttonUpdateSelected_Click(object sender, EventArgs e)
        {
            panelDealerUpdate.Visible = true;

            int i = Convert.ToInt32(dataGridViewDealerInfo.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealerInfo where id='"+i+"' ";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            
            foreach (DataRow Dr in DT.Rows)
            {
                textBoxUpdateDN.Text = Dr["dealerName"].ToString();
                textBoxUpdateCN.Text = Dr["dealerCompanyName"].ToString();
                textBoxupdateContact.Text = Dr["contact"].ToString();
                textBoxUpdateAddress.Text = Dr["address"].ToString();
                textBoxUpdateCity.Text= Dr["city"].ToString();
            }
        }

        private void buttonUpdateDealer_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridViewDealerInfo.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update dealerInfo set dealerName='" + textBoxUpdateDN.Text + "',dealerCompanyName='" + textBoxUpdateCN.Text + "',contact='" + textBoxupdateContact.Text + "',address='" + textBoxUpdateAddress.Text + "',city='" + textBoxUpdateCity.Text + "' where id='" + i + "' ";
            cmd.ExecuteNonQuery();

            panelDealerUpdate.Visible = false;
            dealerDataGrid();
        }
    }
}
