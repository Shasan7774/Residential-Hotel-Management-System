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
    public partial class NewUser : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");

        public NewUser()
        {
            InitializeComponent();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {

            int i = 0;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where username = '" + textBoxUserNameNew.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            i = Convert.ToInt32(DT.Rows.Count.ToString());
            if (i == 0)
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into registration values('"+textBoxFirstName.Text+"','"+textBoxLastName.Text+"','"+textBoxUserNameNew.Text+"','"+textBoxPasswordNew.Text+"','"+textBoxEmail.Text+"','"+textBoxContact.Text+"')";
                cmd1.ExecuteNonQuery();
                clearData();
                MessageBox.Show("New User Add Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Display();
            }
            else
            {
                MessageBox.Show("User Name Already Exits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Display()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration ";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter(cmd);
            SDA.Fill(DT);
            dataGridViewNewUser.DataSource = DT;

        }

        public void clearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxUserNameNew.Text = "";
            textBoxPasswordNew.Text = "";
            textBoxEmail.Text = "";
            textBoxContact.Text = "";
        }
        private void NewUser_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            Display();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

           // MessageBox.Show("Are you Sure you want to delete?.", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            int id;
                id = Convert.ToInt32(dataGridViewNewUser.SelectedCells[0].Value.ToString());
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from registration where id='" + id + "'";
                cmd.ExecuteNonQuery();
                Display();
            
        }
    }
}
