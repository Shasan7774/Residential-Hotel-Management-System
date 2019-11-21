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
    public partial class unit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");
        public unit()
        {
            InitializeComponent();
        }

         private void buttonAddUnit_Click(object sender, EventArgs e)
         {

             int count = 0;

             SqlCommand cmd1 = con.CreateCommand();
             cmd1.CommandType = CommandType.Text;
             cmd1.CommandText = "select * from units where unit='"+textBoxAddUnit.Text+"'";
             cmd1.ExecuteNonQuery();
             DataTable DT1 = new DataTable();
             SqlDataAdapter SDA1 = new SqlDataAdapter(cmd1);
             SDA1.Fill(DT1);
             count = Convert.ToInt32( DT1.Rows.Count.ToString());

             if (count == 0)
             {
                 SqlCommand cmd = con.CreateCommand();
                 cmd.CommandType = CommandType.Text;
                 cmd.CommandText = "insert into units values('" + textBoxAddUnit.Text + "')";
                 cmd.ExecuteNonQuery();
                 Disp();
             }
             else
             {
                 MessageBox.Show("This Unit is Already Added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }

   

            /*
        private void buttonAddUnit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into units values('" + textBoxAddUnit.Text + "')";
                cmd.ExecuteNonQuery();
                Disp();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        */


        private void unit_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            Disp();
        }

        public void Disp()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units ";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridViewUnit.DataSource = DT;

        }

        private void buttonDeleteUnit_Click(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(dataGridViewUnit.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from units where id='" + id + "'";
            cmd.ExecuteNonQuery();
            Disp();
        }
    }
}
