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
    public partial class Login : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\REN\Desktop\InventoryPro\InventoryPro\DatabaseInventory.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (con.State ==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from registration where username = '" + textBoxUserName.Text + "' and password ='" + textBoxPassword.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable DT = new DataTable();
                SqlDataAdapter SDA = new SqlDataAdapter(cmd);
                SDA.Fill(DT);
                i = Convert.ToInt32(DT.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("Invalid User Name and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.Hide();
                    MDIParentOne MDI = new MDIParentOne();
                    MDI.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database connection Error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
