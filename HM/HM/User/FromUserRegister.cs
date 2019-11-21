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
using MetroFramework;

namespace HM.User
{
    public partial class FromUserRegister : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        public FromUserRegister()
        {
            InitializeComponent();
        }

        private void FromUserRegister_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadData();

        }

        private void clearData()
        {
            txtUserRegName.Clear();
            txtUserRegUserName.Clear();
            txtUserRegAddress.Clear();
            txtUserRegEmail.Clear();
            txtUserRegPass.Clear();
            comboBoxUserRegRole.SelectedIndex = -1;
            dateTimePickerUserReg.Value = DateTime.Now;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        public bool validation()
        {
            bool result = false;

            if (string.IsNullOrEmpty(txtUserRegName.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegName, "Name Required");
            }
            else if (string.IsNullOrEmpty(txtUserRegUserName.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegUserName, "User Name Required");
            }
            else if (string.IsNullOrEmpty(txtUserRegPass.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegPass, "Password Required");
            }
            else if (txtUserRegPass.Text.Length < 4)
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegPass, "Password Minimum 4 Character Required");
            }
            else if (string.IsNullOrEmpty(txtUserRegEmail.Text))
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(txtUserRegEmail, "Email Required");
            }
            else if (comboBoxUserRegRole.SelectedIndex == -1)
            {
                errorProviderUserReg.Clear();
                errorProviderUserReg.SetError(comboBoxUserRegRole, "Role Required");
            }
            else
            {
                errorProviderUserReg.Clear();
                result = true;
            }
            return result;
        }

        private bool IfUserNameExits(string userName)
        {
            con.DataGet("Select 1 from DBUser where UserName ='" + userName + "'");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (IfUserNameExits(txtUserRegUserName.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this,"User Name Already Exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.DataSend("INSERT INTO DBUser (Name, Email, UserName, Password, Role, DOB, Address) VALUES('" + txtUserRegName.Text + "','" + txtUserRegEmail.Text + "','" + txtUserRegUserName.Text + "','" + txtUserRegPass + "','" + comboBoxUserRegRole.Text + "','" + dateTimePickerUserReg.Value.ToString("dd/MM/yyyy") + "','" + txtUserRegAddress.Text + "')");
                    MetroFramework.MetroMessageBox.Show(this,"Record Saved Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    clearData();
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            con.DataGet("Select * from DBUser");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewUserRegister.Rows.Clear();

            foreach (DataRow row in DT.Rows)
            {
                int n = dataGridViewUserRegister.Rows.Add();
                dataGridViewUserRegister.Rows[n].Cells["dgSno"].Value = row["UserId"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgName"].Value = row["Name"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgDOB"].Value = row["DOB"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgEmail"].Value = row["Email"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgUserName"].Value = row["UserName"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgRole"].Value = row["Role"].ToString();
                dataGridViewUserRegister.Rows[n].Cells["dgAddress"].Value = row["Address"].ToString();
            }
        }

        private void dataGridViewUserRegister_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtUserRegName.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtUserRegUserName.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgUserName"].Value.ToString();
            txtUserRegEmail.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtUserRegAddress.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            dateTimePickerUserReg.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgDOB"].Value.ToString();
            comboBoxUserRegRole.Text = dataGridViewUserRegister.SelectedRows[0].Cells["dgRole"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend("UPDATE DBUser SET Name ='" + txtUserRegName.Text + "', Email ='" + txtUserRegEmail.Text + "', Role ='" + comboBoxUserRegRole.Text + "', DOB ='" + dateTimePickerUserReg.Value.ToString("dd/MM/yyyy") + "', Address ='" + txtUserRegAddress.Text + "' where UserName='" + txtUserRegUserName.Text + "' ");
                MetroFramework.MetroMessageBox.Show(this,"Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend("DELETE FROM DBUser where UserName ='"+txtUserRegUserName.Text+"'");
                MetroFramework.MetroMessageBox.Show(this,"Delete Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void txtUserRegName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserRegName.Text.Length > 0)
                {
                    txtUserRegUserName.Focus();
                }
                else
                {
                    txtUserRegName.Focus();
                }
            }
        }

        private void txtUserRegUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserRegUserName.Text.Length > 0)
                {
                    txtUserRegPass.Focus();
                }
                else
                {
                    txtUserRegUserName.Focus();
                }
            }
        }

        private void txtUserRegPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserRegPass.Text.Length > 0)
                {
                    txtUserRegAddress.Focus();
                }
                else
                {
                    txtUserRegPass.Focus();
                }
            }
        }

        private void txtUserRegAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserRegAddress.Text.Length > 0)
                {
                    txtUserRegEmail.Focus();
                }
                else
                {
                    txtUserRegEmail.Focus();
                }
            }
        }

        private void txtUserRegEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUserRegEmail.Text.Length > 0)
                {
                    dateTimePickerUserReg.Focus();
                }
                else
                {
                    txtUserRegEmail.Focus();
                }
            }
        }
    }

}

