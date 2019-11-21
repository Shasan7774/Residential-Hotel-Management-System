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
    public partial class Sales : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");
        DataTable DT = new DataTable();
        int tot = 0;
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            DT.Clear();
            DT.Columns.Add("product");
            DT.Columns.Add("price");
            DT.Columns.Add("qty");
            DT.Columns.Add("total");
        }

        private void textBoxProductSales_KeyUp(object sender, KeyEventArgs e)
        {
            listBoxSales.Visible = true;

            listBoxSales.Items.Clear();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Stock where pName like('"+textBoxProductSales.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);

            foreach(DataRow Dr in DT.Rows)
            {
                listBoxSales.Items.Add(Dr["pName"].ToString());
            }
        }

        private void textBoxProductSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxSales.Focus();
                listBoxSales.SelectedIndex = 0;

            }
        }  

        private void listBoxSales_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    this.listBoxSales.SelectedIndex = this.listBoxSales.SelectedIndex + 1;
                }
                if (e.KeyCode == Keys.Up)
                {
                    this.listBoxSales.SelectedIndex = this.listBoxSales.SelectedIndex - 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxProductSales.Text = listBoxSales.SelectedItem.ToString();
                    listBoxSales.Visible = false;
                    textBoxPrice.Focus();
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void textBoxPrice_Enter(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select top 1 * from purchase where pName = '" + textBoxProductSales.Text + "' order by id desc";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);

            foreach(DataRow Dr in DT.Rows)
            {
                textBoxPrice.Text = Dr["pPrice"].ToString();
            }
        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    textBoxTotal.Text = Convert.ToString(Convert.ToInt32(textBoxPrice.Text) * Convert.ToInt32(textBoxQuantity.Text));
                    //textBoxTotal.Focus();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int stock = 0;
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Stock where pName = '" + textBoxProductSales.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable DT1 = new DataTable();
            SqlDataAdapter SDA1 = new SqlDataAdapter(cmd1);
            SDA1.Fill(DT1);

            foreach (DataRow Dr1 in DT1.Rows)
            {
                stock =Convert.ToInt32( Dr1["pQuantity"].ToString());
            }

            if (Convert.ToInt32(textBoxQuantity.Text)>stock)
            {
                MessageBox.Show("This much value isn't Avaliable.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DataRow Dr = DT.NewRow();
                Dr["product"] = textBoxProductSales.Text;
                Dr["price"] = textBoxPrice.Text;
                Dr["qty"] = textBoxQuantity.Text;
                Dr["total"] = textBoxTotal.Text;

                DT.Rows.Add(Dr);
                dataGridViewSales.DataSource = DT;
                tot = tot + Convert.ToInt32(Dr["total"].ToString());
                label10.Text = tot.ToString();
            }
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tot = 0;
                DT.Rows.RemoveAt(Convert.ToInt32(dataGridViewSales.CurrentCell.RowIndex.ToString()));
                foreach(DataRow dr1 in DT.Rows )
                {
                    tot = tot + Convert.ToInt32(dr1["total"].ToString());
                    label10.Text = tot.ToString();
                }

            }
            catch (Exception Ex)
            {

            }
        }

        private void buttonSavePrint_Click(object sender, EventArgs e)
        {
            string orderid = "";
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into OrderUser values('"+textBoxFirst.Text+"','"+textBoxLast.Text+"','"+comboBoxBillType.Text+"','"+dateTimePickerSales.Value.ToString("dd-MM-yyyy")+"')";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select top 1 * from OrderUser order by id desc";
            cmd2.ExecuteNonQuery();

            DataTable DT2 = new DataTable();
            SqlDataAdapter SDA2 = new SqlDataAdapter(cmd2);
            SDA2.Fill(DT2);

            foreach(DataRow Dr2 in DT2.Rows)
            {
                orderid = Dr2["id"].ToString();
            }

            foreach (DataRow Dr in DT.Rows)
            {
                int qty = 0;
                string pname = "";

                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "insert into orderItem values('" + orderid.ToString() + "','" + Dr["product"].ToString() + "','" + Dr["price"].ToString() + "','" + Dr["qty"].ToString() + "','" + Dr["total"].ToString() + "')";
                cmd3.ExecuteNonQuery();

                qty =Convert.ToInt32( Dr["qty"].ToString());
                pname = Dr["product"].ToString();

                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update Stock set pQuantity=pQuantity- '"+qty+"' where pName = '"+pname.ToString()+"' ";
                cmd6.ExecuteNonQuery();


            }
            clr();
            DT.Clear();
            dataGridViewSales.DataSource = DT;
            MessageBox.Show("Record Inserted Sucessfully.","Message",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);


            BillGenerate BG = new BillGenerate();
            BG.getValue(Convert.ToInt32(orderid.ToString()));
            BG.Show();

        }
        public void clr()
        {
            textBoxFirst.Text = "";
            textBoxLast.Text = "";
            textBoxProductSales.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            textBoxTotal.Text = "";
            label10.Text = "";
        }

        private void textBoxProductSales_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
