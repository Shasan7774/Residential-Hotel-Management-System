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
    public partial class BillGenerate : Form
    {
        int j;
        int tot = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");


        public BillGenerate()
        {
            InitializeComponent();
        }

        public void getValue(int i)
        {
            j = i;

        }

        private void BillGenerate_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            DataSet1 DS1 = new DataSet1();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from OrderUser where id = '" + j+ "'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DS1.DataTable1);

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from orderItem where orderID = '" + j + "'";
            cmd2.ExecuteNonQuery();
            DataTable DT2 = new DataTable();
            SqlDataAdapter SDA2 = new SqlDataAdapter(cmd2);
            SDA2.Fill(DS1.DataTable2);
            SDA2.Fill(DT2);

            tot = 0;
            foreach(DataRow DR in DT2.Rows)
            {
                tot = tot + Convert.ToInt32(DR["total"].ToString());
            }

            CrystalReport1 CR = new CrystalReport1();
            CR.SetDataSource(DS1);
            CR.SetParameterValue("total",tot.ToString());
            crystalReportViewer1.ReportSource = CR; 

        }
    }
}
