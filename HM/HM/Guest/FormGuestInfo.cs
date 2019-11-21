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

namespace HM.Guest
{
    public partial class FormGuestInfo : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
 
        public FormGuestInfo()
        {
            InitializeComponent();
        }

        private void FormGuestInfo_Load(object sender, EventArgs e)
        {
            LoadData();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void clearData()
        {
           
            txtGAddress.Clear();
            txtGContact.Clear();
            txtGEmail.Clear();
            txtGID.Clear();
            txtGName.Clear();
            txtGPassport.Clear();     
            dateGBirth.Value = DateTime.Now;
            dateGEntry.Value = DateTime.Now;
            dateGLeave.Value = DateTime.Now;
 
        }

        public bool validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtGName.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(txtGName, "Name Required.");
            }
            else if (string.IsNullOrEmpty(txtGContact.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(txtGContact, "Contact Required.");
            }
            else if (string.IsNullOrEmpty(txtGPassport.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(txtGPassport, "Email Required.");
            }
            else if (string.IsNullOrEmpty(dateGBirth.Text))
            {
                errorProviderGuest.Clear();
                errorProviderGuest.SetError(dateGBirth, "Date of Birth Required.");
            }
            else
            {
                errorProviderGuest.Clear();
                result = true;
            }
            return result;
        }

        private bool IfUserNameExits(string num)
        {
            con.DataGet("Select 1 from DBGuest where RoomNum ='" + num + "'");
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
               con.DataSend("INSERT INTO DBGuest (gstName, gstContact, gstEmail, gstPass,gstType, gstAddress, gstDOB,gstEntry,gstLeave) VALUES('" + txtGName.Text + "','" + txtGContact.Text + "','" + txtGEmail.Text + "','" + txtGPassport.Text + "','" + comboBoxGType.Text + "','" + txtGAddress.Text + "','" + dateGBirth.Value.ToString("dd/MM/yyyy") +"','"+dateGEntry.Value.ToString("dd/MM/yyyy")+"','"+dateGLeave.Value.ToString("dd/MM/yyyy")+"')");
               MetroFramework.MetroMessageBox.Show(this, "Record Saved Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               LoadData();
               clearData();
            }
        }

        private void LoadData()
        {
            con.DataGet("Select * from DBGuest");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewGuest.Rows.Clear();

            foreach (DataRow DR in DT.Rows)
            {
                int n = dataGridViewGuest.Rows.Add();
                dataGridViewGuest.Rows[n].Cells["dgGID"].Value = DR["GID"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgName"].Value = DR["gstName"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgContact"].Value = DR["gstContact"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgAddress"].Value = DR["gstAddress"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgEmail"].Value = DR["gstEmail"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgDOB"].Value = DR["gstDOB"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgPassport"].Value = DR["gstPass"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgGType"].Value = DR["gstType"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgEntry"].Value = DR["gstEntry"].ToString();
                dataGridViewGuest.Rows[n].Cells["dgLeave"].Value = DR["gstLeave"].ToString();

            }
        }

        private void dataGridViewGuest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtGID.Text = dataGridViewGuest.SelectedRows[0].Cells["dgGID"].Value.ToString();
            txtGName.Text = dataGridViewGuest.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtGContact.Text = dataGridViewGuest.SelectedRows[0].Cells["dgContact"].Value.ToString();
            txtGEmail.Text = dataGridViewGuest.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtGPassport.Text = dataGridViewGuest.SelectedRows[0].Cells["dgPassport"].Value.ToString();
            dateGBirth.Text = dataGridViewGuest.SelectedRows[0].Cells["dgDOB"].Value.ToString();
            txtGAddress.Text = dataGridViewGuest.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            dateGEntry.Text = dataGridViewGuest.SelectedRows[0].Cells["dgEntry"].Value.ToString();
            dateGLeave.Text = dataGridViewGuest.SelectedRows[0].Cells["dgLeave"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend(@"UPDATE DBGuest SET gstName ='" + txtGName.Text + "', gstContact ='" + txtGContact.Text + "', gstEmail ='" + txtGEmail.Text + "', gstPass ='" + txtGPassport.Text + "',gstType='" + comboBoxGType.Text + "', gstAddress ='" + txtGAddress.Text + "', gstDOB ='" + dateGBirth.Value.ToString("dd/MM/yyyy") + "',gstEntry='"+dateGEntry.Value.ToString("dd/MM/yyyy")+"',gstLeave='"+dateGLeave.Value.ToString("dd/MM/yyyy")+"'  Where GID ='" + txtGID.Text + "' ");
                MetroFramework.MetroMessageBox.Show(this,"Updated Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                con.DataSend("Delete from DBGuest Where GID ='" + txtGID.Text + "'");
                MetroFramework.MetroMessageBox.Show(this,"Delete Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void FormGuestInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Guest.FormSearch FGG = new FormSearch();
            FGG.Show();
        }

        private void txtGName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGName.Text.Length > 0)
                {
                    txtGContact.Focus();
                }
                else
                {
                    txtGName.Focus();
                }
            }
        }

        private void txtGContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGContact.Text.Length > 0)
                {
                    txtGEmail.Focus();
                }
                else
                {
                    txtGContact.Focus();
                }
            }
        }

        private void txtGEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtGEmail.Text.Length > 0)
                {
                    txtGPassport.Focus();
                }
                else
                {
                    txtGEmail.Focus();
                }
            }
        }

        private void btnGFood_Click(object sender, EventArgs e)
        {
            Food.FormFoodAndService fg = new Food.FormFoodAndService();
            fg.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Guest.FormBooking ghj = new FormBooking();
            ghj.Show();
        }
        public static string subtotal;
        public static string roomCharge;
        public static string foodCharge;
        public static string ServicePayment;
        public static string vatToPAY;
        public static string totalToPay;
       
        private void btnTotal_Click(object sender, EventArgs e)
        {
            string fbills = Food.FormFoodAndService.foodbills;
            string serCharge = Food.FormFoodAndService.netServiceharge;
            string roomfare = Guest.FormBooking.Roomfare;

          double r = Convert.ToDouble(fbills);
            foodCharge = r.ToString();

            double s = Convert.ToDouble(serCharge);
            ServicePayment = s.ToString();

           double rent = Convert.ToDouble(roomfare);
            roomCharge = rent.ToString();
            
          
 

           double total = r + s + rent;

            subtotal = total.ToString();
           double vat = (total * 0.15);

            vatToPAY = vat.ToString();

           double haveToPay = (total + vat);
            totalToPay = haveToPay.ToString();

            Guest.FormTotal ghj = new FormTotal();
            ghj.Show();
        }
    }
}
