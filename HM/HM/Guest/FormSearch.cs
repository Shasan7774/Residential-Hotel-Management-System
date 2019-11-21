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
    public partial class FormSearch : MetroFramework.Forms.MetroForm
    {
        public FormSearch()
        {
            InitializeComponent();
        }


        int count = 0;
        Connection con = new Connection();
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable DT;

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            FSerach();
        }

        public void FSerach()
        {
            count = 0;
            con.DataGet("select * from DBGuest where gstName like'" + txtSearch.Text + "%'");
            da = new SqlDataAdapter(cmd);
            DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewSearch.DataSource = DT;
            count = Convert.ToInt32(DT.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("data not found");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
