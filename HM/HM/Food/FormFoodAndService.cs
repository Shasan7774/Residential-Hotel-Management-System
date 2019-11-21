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

namespace HM.Food
{
    public partial class FormFoodAndService : MetroFramework.Forms.MetroForm
    {
        Connection con = new Connection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da;
        public FormFoodAndService()
        {
            InitializeComponent();
        }

        private void FormFoodAndService_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSalmon_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from fooddatabase where foodname ='" + checkBoxSalmon.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtSalmon.Text = dr["foodprice"].ToString();
            }
        }

        

        private void checkBoxSquashRaviooli_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from fooddatabase where foodname ='" + checkBoxLobsterRavioli.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtSquashRavioli.Text = dr["foodprice"].ToString();
            }
        }

        private void checkBoxLobsterRavioli_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from fooddatabase where foodname ='" + checkBoxLobsterRavioli.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtLobster.Text = dr["foodprice"].ToString();
            }
        }

       

        private void checkBoxChicken_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from fooddatabase where foodname ='" + checkBoxChicken.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtChicken.Text = dr["foodprice"].ToString();
            }
        }

        private void checkBoxCleaning_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from HotelService where servicename ='" + checkBoxCleaning.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtCleaning.Text = dr["servicecharge"].ToString();
            }
        }

        private void checkBoxIron_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from HotelService where servicename ='" + checkBoxIron.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtIron.Text = dr["servicecharge"].ToString();
            }
        }

        private void checkBoxSpa_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from HotelService where servicename ='" + checkBoxSpa.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtSpa.Text = dr["servicecharge"].ToString();
            }
        }

        private void checkBoxBaby_CheckedChanged(object sender, EventArgs e)
        {
            con.DataGet("select * from HotelService where servicename ='" + checkBoxBaby.Text + "' ");
            da = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            con.sda.Fill(DT);
            foreach (DataRow dr in DT.Rows)
            {
                txtBaby.Text = dr["servicecharge"].ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public static string foodbills;

        double payment;
        /*
         */
        private void btnFoodTotal_Click(object sender, EventArgs e)
        {
            if (txtChickenQty.Text == "" || txtLobsterQty.Text == "" || txtSalmonQty.Text == "" || txtSquashRavioliQty.Text == "")
            {

                MetroFramework.MetroMessageBox.Show(this, "Insert Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                double c = double.Parse(txtChicken.Text);
                double cQ = double.Parse(txtChickenQty.Text);

                double squash =Convert.ToDouble(txtSquashRavioli.Text);
                double squashQ = double.Parse(txtSquashRavioliQty.Text);

                double l = double.Parse(txtLobster.Text);
                double lQ = double.Parse(txtLobsterQty.Text);

                double salmon = double.Parse(txtSalmon.Text);
                double salmonQ = double.Parse(txtSalmonQty.Text);

                payment = (c * cQ) + (squash * squashQ) + (l * lQ) + (salmon * salmonQ);
                txtFoodTotal.Text = payment.ToString();
                foodbills = payment.ToString();

                //  con.DataSend("INSERT INTO DBGuest (gstName, gstContact, gstEmail, gstPass,gstType, gstAddress, gstDOB) VALUES('" + txtGName.Text + "','" + txtGContact.Text + "','" + txtGEmail.Text + "','" + txtGPassport.Text + "','" + comboBoxGType.Text + "','" + txtGAddress.Text + "','" + dateGBirth.Value.ToString("dd/MM/yyyy") +"')");
                con.DataSend("insert into DBtotal (ftotal) values('" + txtFoodTotal.Text + "')");
                da = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                con.sda.Fill(DT);
            }

        }
        public static string netServiceharge;
        double totalServiceCharge;
        private void btnSCharge_Click(object sender, EventArgs e)
        {

            if (txtCleaningQty.Text == "" || txtIronQty.Text == "" || txtSpa.Text == "" || txtBabyQty.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Insert Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                double a = double.Parse(txtCleaning.Text);
                double aQ = double.Parse(txtCleaningQty.Text);

                double b = double.Parse(txtIron.Text);
                double bQ = double.Parse(txtIronQty.Text);

                double c1 = double.Parse(txtSpa.Text);
                double c1Q = double.Parse(txtSpaQty.Text);

                double d = double.Parse(txtBaby.Text);
                double dQ = double.Parse(txtBabyQty.Text);


                totalServiceCharge = (a * aQ) + (b * bQ) + (c1 * c1Q) + (d * dQ);
                txtHotelTotal.Text = totalServiceCharge.ToString();
                //totalServiceCharge = double.Parse(txtHotelTotal.Text);

                netServiceharge = totalServiceCharge.ToString();

                con.DataSend("Insert into DBtotal (stotal) values('" + txtHotelTotal.Text + "')");
                DataTable DT = new DataTable();
                con.sda.Fill(DT);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guest.FormGuestInfo ghh = new Guest.FormGuestInfo();
            ghh.Show();
        }
    }
}
