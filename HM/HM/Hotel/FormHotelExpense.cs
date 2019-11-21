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

namespace HM.Hotel
{
    public partial class FormHotelExpense : MetroFramework.Forms.MetroForm
    {

        Connection con = new Connection();
        public FormHotelExpense()
        {
            InitializeComponent();
        }

        private void FormHotelExpense_Load(object sender, EventArgs e)
        {
            
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadData();

        }

        private void ClearData()
        {
            txtExpCost.Clear();
            txtExpID.Clear();
            comboBoxExpStatus.SelectedIndex = -1;
            comboBoxExpType.SelectedIndex = -1;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        public bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtExpCost.Text))
            {
                errorProviderExp.Clear();
                errorProviderExp.SetError(txtExpCost, "Cost Required.");
            }
            else if (comboBoxExpStatus.SelectedIndex ==-1)
            {
                errorProviderExp.Clear();
                errorProviderExp.SetError(comboBoxExpStatus,"Expense Required.");
            }
            else if (comboBoxExpType.SelectedIndex ==-1)
            {
                errorProviderExp.Clear();
                errorProviderExp.SetError(comboBoxExpType,"Type Required.");
            }
            else
            {
                errorProviderExp.Clear();
                result = true;
            }
            return result;
        }

        private void LoadData()
        {
            con.DataGet("Select * from DBExp");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewExp.Rows.Clear();

            foreach (DataRow DR in DT.Rows)
            {
                int n = dataGridViewExp.Rows.Add();
                dataGridViewExp.Rows[n].Cells["dgEID"].Value = DR["EID"].ToString();
                dataGridViewExp.Rows[n].Cells["dgExpType"].Value = DR["ExpType"].ToString();
                dataGridViewExp.Rows[n].Cells["dgExpCost"].Value = DR["ExpCost"].ToString();
                dataGridViewExp.Rows[n].Cells["dgStatus"].Value = DR["ExpStatus"].ToString();
            }
        }

        private void txtExpCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dataGridViewExp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtExpID.Text = dataGridViewExp.SelectedRows[0].Cells["dgEID"].Value.ToString();
            txtExpCost.Text = dataGridViewExp.SelectedRows[0].Cells["dgExpCost"].Value.ToString();
            comboBoxExpStatus.Text = dataGridViewExp.SelectedRows[0].Cells["dgStatus"].Value.ToString();
            comboBoxExpType.Text = dataGridViewExp.SelectedRows[0].Cells["dgStatus"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           con.DataSend("INSERT INTO DBExp (ExpType, ExpCost, ExpStatus) VALUES('" + comboBoxExpType.Text + "','" + txtExpCost.Text + "','" + comboBoxExpStatus.Text + "')");
           MetroFramework.MetroMessageBox.Show(this,"Record Saved Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           ClearData();
           LoadData(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend(@"UPDATE DBExp SET ExpType ='"+comboBoxExpType.Text+"', ExpCost ='"+txtExpCost.Text+"', ExpStatus ='"+comboBoxExpStatus.Text+"' Where EID = '"+txtExpID.Text+"'");
                MetroFramework.MetroMessageBox.Show(this,"Updated Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearData();
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
                con.DataSend("Delete from DBExp Where EID ='" + txtExpID.Text + "'");
                MetroFramework.MetroMessageBox.Show(this,"Delete Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
