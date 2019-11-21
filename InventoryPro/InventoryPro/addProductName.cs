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
    public partial class addProductName : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");
        public addProductName()
        {
            InitializeComponent();
        }

        private void addProductName_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            addfill();
            addfillDatagrid();
        }

        public void addfill()
        {
            comboBoxProductUnit.Items.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            foreach (DataRow Dr in DT.Rows)
            {
                comboBoxProductUnit.Items.Add(Dr["unit"].ToString());
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into productname values('"+textBoxProductName.Text+"','"+comboBoxProductUnit.SelectedItem.ToString()+"')";
            cmd.ExecuteNonQuery();

            textBoxProductName.Text = "";
            addfillDatagrid();
            MessageBox.Show("Product Insert Succesfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void addfillDatagrid()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from productName";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridViewProductName.DataSource = DT;
        }

        private void dataGridViewProductName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridViewProductName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panelProductUpdate.Visible = true;

            int i = Convert.ToInt32(dataGridViewProductName.SelectedCells[0].Value.ToString());

            comboBoxProductUpdate.Items.Clear();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from units";
            cmd2.ExecuteNonQuery();
            DataTable DT2 = new DataTable();
            SqlDataAdapter SDA2 = new SqlDataAdapter(cmd2);
            SDA2.Fill(DT2);
            foreach (DataRow Dr2 in DT2.Rows)
            {
                comboBoxProductUpdate.Items.Add(Dr2["unit"].ToString());
            }

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from productName where id = '" + i + "'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            foreach (DataRow Dr in DT.Rows)
            {
                textBoxProductUpdate.Text = Dr["productName"].ToString();
                comboBoxProductUpdate.SelectedItem = Dr["units"].ToString();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridViewProductName.SelectedCells[0].Value.ToString());

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update productName set productname='"+textBoxProductUpdate.Text+"',units='"+comboBoxProductUpdate.SelectedItem.ToString()+"' where id = '"+i+"'";
            cmd.ExecuteNonQuery();
            panelProductUpdate.Visible = false;
            addfillDatagrid();
        }
    }
}
