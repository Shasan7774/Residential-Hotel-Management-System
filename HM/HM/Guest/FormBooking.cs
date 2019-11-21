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

namespace HM.Guest
{
    public partial class FormBooking : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;



      

        public FormBooking()
        {
            InitializeComponent();
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSingleRoom_CheckedChanged(object sender, EventArgs e)
        {

            con.DataGet("select * from roomDB where roomType ='" + checkBoxSingleRoom.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtSingle.Text = dr["roomFare"].ToString();
                comboBoxSingle.Items.Add(dr["roomNum"].ToString());
            }
        }

        private void checkBoxDoubleRoom_CheckedChanged(object sender, EventArgs e)
        {

            con.DataGet("select * from roomDB where roomType ='" + checkBoxDoubleRoom.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtDouble.Text = dr["roomFare"].ToString();
                comboBoxDouble.Items.Add(dr["roomNum"].ToString());
            }

        }

        private void checkBoxExecutiveSuite_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from roomDB where roomType ='" + checkBoxExecutiveSuite.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtEcecutive.Text = dr["roomFare"].ToString();
                comboBoxExc.Items.Add(dr["roomNum"].ToString());
            }
        }

        private void checkBoxMiniSuit_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from roomDB where roomType ='" + checkBoxMiniSuit.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtMini.Text = dr["roomFare"].ToString();
                comboBoxMini.Items.Add(dr["roomNum"].ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guest.FormGuestInfo kkk = new FormGuestInfo();
            kkk.Show();
        }

        public static string Roomfare;
        double fare;
        private void btnTotalFare_Click(object sender, EventArgs e)
        {
           /* if (txtDouble.Text == "" || txtEcecutive.Text == "" || txtMini.Text == "" || txtSingle.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Insert Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {*/
                double i = double.Parse(txtSingle.Text);
                double j = double.Parse(txtDouble.Text);
                double k = double.Parse(txtEcecutive.Text);
                double l = double.Parse(txtMini.Text);

                fare = (i + j + k + l);
            txtroomTotal.Text = fare.ToString();
                Roomfare = fare.ToString();
            //}
        }
    }
}
