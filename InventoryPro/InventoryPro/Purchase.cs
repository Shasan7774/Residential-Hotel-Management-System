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
    public partial class Purchase : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");

        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            fillProductName();
            fillDealerName();
        }

        public void fillProductName()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from productName";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);

            foreach (DataRow DR in DT.Rows)
            {

                comboBoxProductName.Items.Add(DR["productname"].ToString());
            }
        }

        public void fillDealerName()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealerInfo";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);

            foreach (DataRow DR in DT.Rows)
            {

                comboBoxDealerName.Items.Add(DR["dealerName"].ToString());
            }
        }
        private void comboBoxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from productName where productname='"+comboBoxProductName.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);

            foreach (DataRow DR in DT.Rows)
            {
                label3.Text = DR["units"].ToString();
            }
        }

        private void textBoxProductPrice_Leave(object sender, EventArgs e)
        {
            textBoxProductTotal.Text = Convert.ToString(Convert.ToInt32( textBoxProductQuantity.Text) * Convert.ToInt32(textBoxProductPrice.Text));
        }

        private void buttonPurchase_Click(object sender, EventArgs e)
        {

            int i;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Stock where pName='" + comboBoxProductName.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable DT1 = new DataTable();
            SqlDataAdapter SDA1 = new SqlDataAdapter(cmd1);
            SDA1.Fill(DT1);
            i = Convert.ToInt32(DT1.Rows.Count.ToString());

            if (i==0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into purchase values('" + comboBoxProductName.Text + "','" + textBoxProductQuantity.Text + "','" + label3.Text + "','" + textBoxProductPrice.Text + "','" + textBoxProductTotal.Text + "','" + dateTimePickerPurchaseDate.Value.ToString("dd-MM-yyyy") + "','" + comboBoxDealerName.Text + "','" + comboBoxPurchaseType.Text + "','" + dateTimePickerExpireDate.Value.ToString("dd-MM-yyyy") + "','" + textBoxProfit.Text + "')";
                cmd.ExecuteNonQuery();

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into Stock values('" + comboBoxProductName.Text + "','" + textBoxProductQuantity.Text + "','" + label3.Text + "')";
                cmd3.ExecuteNonQuery();
            }
            else
            {

                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "insert into purchase values('" + comboBoxProductName.Text + "','" + textBoxProductQuantity.Text + "','" + label3.Text + "','" + textBoxProductPrice.Text + "','" + textBoxProductTotal.Text + "','" + dateTimePickerPurchaseDate.Value.ToString("dd-MM-yyyy") + "','" + comboBoxDealerName.Text + "','" + comboBoxPurchaseType.Text + "','" + dateTimePickerExpireDate.Value.ToString("dd-MM-yyyy") + "','" + textBoxProfit.Text + "')";
                cmd2.ExecuteNonQuery();

                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "update Stock set proQuantity=proQuantity '" + textBoxProductQuantity.Text + "' where proName='" + comboBoxProductName.Text + "')";
                cmd5.ExecuteNonQuery();

            }

            

            MessageBox.Show("Record Inserted Successfully.","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
