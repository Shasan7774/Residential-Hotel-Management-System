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
    public partial class FormInventory : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }

        private bool Validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(txtPName.Text))
            {
                errorProviderIvn.Clear();
                errorProviderIvn.SetError(txtPName, "Name Needed.");
            }
            else if (comboBoxpType.SelectedIndex ==-1)
            {
                errorProviderIvn.Clear();
                errorProviderIvn.SetError(comboBoxpType, "Type Needed.");
            }
            else if (string.IsNullOrEmpty(txtPprice.Text))
            {
                errorProviderIvn.Clear();
                errorProviderIvn.SetError(txtPprice, "Price Needed.");
            }
            else if (string.IsNullOrEmpty(txtPQuantity.Text))
            {
                errorProviderIvn.Clear();
                errorProviderIvn.SetError(txtPQuantity, "Quantity Needed.");
            }
            else
            {
                errorProviderIvn.Clear();
                result = true;
            }
            return result;
        }

        private void clearData()
        {
            txtID.Clear();
            txtPQuantity.Clear();
            txtPprice.Clear();
            txtPName.Clear();
            comboBoxpType.SelectedIndex = -1;
        }

        private void txtPQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtPprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void LoadData()
        {
            con.DataGet("Select * from DBInv");
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewInventory.Rows.Clear();

            foreach (DataRow row in DT.Rows)
            {
                int n = dataGridViewInventory.Rows.Add();
                dataGridViewInventory.Rows[n].Cells["dgID"].Value = row["ID"].ToString();
                dataGridViewInventory.Rows[n].Cells["dgName"].Value = row["pName"].ToString();
                dataGridViewInventory.Rows[n].Cells["dgType"].Value = row["pType"].ToString();
                dataGridViewInventory.Rows[n].Cells["dgQuantity"].Value = row["PQuan"].ToString();
                dataGridViewInventory.Rows[n].Cells["dgPrice"].Value = row["pPrice"].ToString();
                dataGridViewInventory.Rows[n].Cells["dgTotal"].Value = row["pTotal"].ToString();
            }
        }

        private void dataGridViewInventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtPName.Text = dataGridViewInventory.SelectedRows[0].Cells["dgName"].Value.ToString();
            txtID.Text =dataGridViewInventory.SelectedRows[0].Cells["dgID"].Value.ToString();
            txtPprice.Text = dataGridViewInventory.SelectedRows[0].Cells["pPrice"].Value.ToString();
            txtPQuantity.Text = dataGridViewInventory.SelectedRows[0].Cells["dgQuantity"].Value.ToString();
            comboBoxpType.Text = dataGridViewInventory.SelectedRows[0].Cells["dgRole"].Value.ToString();
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        double x, y, z;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend("Delete from DBInv Where ID ='" + txtID.Text + "'");
                MetroFramework.MetroMessageBox.Show(this,"Delete Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void txtPName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPName.Text.Length > 0)
                {
                    txtPQuantity.Focus();
                }
                else
                {
                    txtPName.Focus();
                }
            }
        }

        private void txtPQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPQuantity.Text.Length > 0)
                {
                    txtPprice.Focus();
                }
                else
                {
                    txtPQuantity.Focus();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure want to Update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.DataSend(@"UPDATE DBInv SET pName ='"+txtPName.Text+ "', pType ='"+comboBoxpType.Text+ "', pQuan ='"+txtPQuantity.Text+ "', pPrice ='"+txtPprice.Text+"', Where ID ='"+txtID.Text+"'");
                MetroFramework.MetroMessageBox.Show(this,"Updated Sucessfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            x = double.Parse(txtPprice.Text);
            y = double.Parse(txtPQuantity.Text);
            z = x * y;

            if(Validation())
            {
                con.DataSend(@"INSERT INTO DBInv (pName, pType, pQuan, pPrice, pTotal) VALUES('"+txtPName.Text+ "','"+comboBoxpType.Text+ "','"+txtPQuantity.Text+ "','"+txtPprice.Text+ "','"+z+"') ");
                MetroFramework.MetroMessageBox.Show(this,"Record Saved Sucessfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearData();
                LoadData();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
