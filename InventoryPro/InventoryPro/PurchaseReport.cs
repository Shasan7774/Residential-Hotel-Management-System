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
    public partial class PurchaseReport : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");

        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void buttonAllPurchase_Click(object sender, EventArgs e)
        {

            int i = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from purchase";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;


            foreach (DataRow dr in DT.Rows)
            {
                i = i + Convert.ToInt32( dr["pTotal"].ToString());
            }

            label3.Text = i.ToString();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string startdate, EndDate;

            startdate = dateTimePickerStart.Value.ToString("dd/MM/yyyy");
            EndDate = dateTimePickerEnd.Value.ToString("dd/MM/yyyy");
            int i = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from purchase where purDate >='"+startdate.ToString()+"' AND purDate <='"+EndDate.ToString()+"' ";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;


            foreach (DataRow dr in DT.Rows)
            {
                i = i + Convert.ToInt32(dr["pTotal"].ToString());
            }

            label3.Text = i.ToString();

        }
    }
}
