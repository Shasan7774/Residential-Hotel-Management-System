using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data.SqlClient;

namespace HM
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        
        Connection con = new Connection();

        private string type;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            con.DataGet("Select * from DBUser where UserName ='" + txtLoginUserName.Text + "'and Password ='" + txtLoginPass.Text + "'");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                type = DT.Rows[0][5].ToString().Trim();

                if (type=="Admin")
                {
                    this.Hide();
                    MDIControl MDI = new MDIControl();
                    MDI.Show();
                }
                else
                {
                    this.Hide();
                    Guest.FormGuestInfo MDIA = new Guest.FormGuestInfo();
                    MDIA.Show();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid user name and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User.FormChangePass CP = new User.FormChangePass();
            CP.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtLoginUserName_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
