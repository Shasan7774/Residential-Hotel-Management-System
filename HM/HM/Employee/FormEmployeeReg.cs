using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;

namespace HM.Employee
{
    public partial class FormEmployeeReg : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        public FormEmployeeReg()
        {
            InitializeComponent();
        }

        

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtEmpName.Text))
            {
                errorProviderEmpReg.Clear();
                errorProviderEmpReg.SetError(txtEmpName,"Name Required.");
            }
            else if (string.IsNullOrEmpty(txtEmpPhone.Text))
            {
                errorProviderEmpReg.Clear();
                errorProviderEmpReg.SetError(txtEmpPhone,"Phone Number Required.");
            }
            else if (string.IsNullOrEmpty(txtEmpEmail.Text))
            {
                errorProviderEmpReg.Clear();
                errorProviderEmpReg.SetError(txtEmpEmail,"Email Required.");
            }
            else if (comboBoxEmpRegRole.SelectedIndex ==-1)
            {
                errorProviderEmpReg.Clear();
                errorProviderEmpReg.SetError(comboBoxEmpRegRole,"Role Required.");
            }
            else if (string.IsNullOrEmpty(txtEmpSalary.Text))
            {
                errorProviderEmpReg.Clear();
                errorProviderEmpReg.SetError(txtEmpSalary,"Salary Required.");
            }
            else
            {
                errorProviderEmpReg.Clear();
                result = true;
            }
            return result;
        }

        private bool ifEmployeeExits(String Name, String mobile)
        {
            con.DataGet("Select 1 from DBEmp where EmpName='"+Name+"' and EmpPhone='"+mobile+"'");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            if (DT.Rows.Count>0)
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
            if (Validation())
            {
                if (ifEmployeeExits(txtEmpName.Text,txtEmpPhone.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this,"Employee Already Exits.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    con.DataSend("INSERT INTO DBEmp (EmpName, EmpPhone, EmpAddress, EmpEmail, EmpDOB, EmpRole, EmpSalary) VALUES('"+txtEmpName.Text+"','"+txtEmpPhone.Text+"','"+txtEmpAddress.Text+"','"+txtEmpEmail.Text+"','"+dateTimePickerEmpReg.Value.ToString("dd/MM/yyyy")+"','"+comboBoxEmpRegRole.Text+"','"+txtEmpSalary.Text+"')");
                    MetroFramework.MetroMessageBox.Show(this,"Sucessfully Saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearData();

                }
            }
        }

        private void LoadData()
        {
            con.DataGet("Select * from DBEmp");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewEmpReg.Rows.Clear();

            foreach (DataRow DR in DT.Rows)
            {
                int n = dataGridViewEmpReg.Rows.Add();
                dataGridViewEmpReg.Rows[n].Cells["dgID"].Value = DR["EmpID"].ToString();
                dataGridViewEmpReg.Rows[n].Cells["dgName"].Value = DR["EmpName"].ToString();
                dataGridViewEmpReg.Rows[n].Cells["dgPhone"].Value = DR["EmpPhone"].ToString();
                dataGridViewEmpReg.Rows[n].Cells["dgAddress"].Value = DR["EmpAddress"].ToString();
                dataGridViewEmpReg.Rows[n].Cells["dgEmail"].Value = DR["EmpEmail"].ToString();
                dataGridViewEmpReg.Rows[n].Cells["dgDOB"].Value = DR["EmpDOB"].ToString();
                dataGridViewEmpReg.Rows[n].Cells["dgRole"].Value = DR["EmpRole"].ToString();
                dataGridViewEmpReg.Rows[n].Cells["dgSalary"].Value = DR["EmpSalary"].ToString();
            }
        }
        private void clearData()
        {
            txtEmpID.Clear();
            txtEmpAddress.Clear();
            txtEmpEmail.Clear();
            txtEmpName.Clear();
            txtEmpPhone.Clear();
            txtEmpSalary.Clear();
            dateTimePickerEmpReg.Value = DateTime.Now;
            comboBoxEmpRegRole.SelectedIndex = -1;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void FormEmployeeReg_Load(object sender, EventArgs e)
        {
            LoadData();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dataGridViewEmpReg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtEmpID.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgID"].Value.ToString();
            txtEmpAddress.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgAddress"].Value.ToString();
            txtEmpEmail.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgEmail"].Value.ToString();
            txtEmpName.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtEmpPhone.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgPhone"].Value.ToString();
            txtEmpSalary.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgSalary"].Value.ToString();
            dateTimePickerEmpReg.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgDOB"].Value.ToString();
            comboBoxEmpRegRole.Text = dataGridViewEmpReg.SelectedRows[0].Cells["dgRole"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend("UPDATE DBEmp SET EmpName ='" + txtEmpName.Text + "', EmpPhone ='" + txtEmpPhone.Text + "', EmpAddress ='" + txtEmpAddress.Text + "', EmpEmail ='" + txtEmpEmail.Text + "', EmpDOB ='" + dateTimePickerEmpReg.Value.ToString("dd/MM/yyyy") + "', EmpRole ='"+comboBoxEmpRegRole.Text+"', EmpSalary ='"+txtEmpSalary.Text+"' Where EmpID ='"+txtEmpID.Text+"'");
                MetroFramework.MetroMessageBox.Show(this,"updated Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                con.DataSend("Delete from DBEmp Where EmpID ='" + txtEmpID.Text + "'");
                MetroFramework.MetroMessageBox.Show(this,"Delete Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void txtEmpSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber (e.KeyChar)& (Keys)e.KeyChar!=Keys.Back & e.KeyChar != '.')
            {
                e.Handled= true;
            }
        }

        private void btnESearch_Click(object sender, EventArgs e)
        {
            Employee.FormEmpSearch EM = new FormEmpSearch();
            EM.Show();
        }

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmpName.Text.Length > 0)
                {
                    txtEmpPhone.Focus();
                }
                else
                {
                    txtEmpName.Focus();
                }
            }
        }

        private void txtEmpPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmpPhone.Text.Length > 0)
                {
                    txtEmpAddress.Focus();
                }
                else
                {
                    txtEmpPhone.Focus();
                }
            }
        }

        private void txtEmpAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmpAddress.Text.Length > 0)
                {
                    txtEmpEmail.Focus();
                }
                else
                {
                    txtEmpAddress.Focus();
                }
            }
        }

        private void txtEmpEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEmpEmail.Text.Length > 0)
                {
                    dateTimePickerEmpReg.Focus();
                }
                else
                {
                    txtEmpEmail.Focus();
                }
            }
        }
    }

}

