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

namespace HM.Employee
{
    public partial class FormEmpSearch : MetroFramework.Forms.MetroForm
    {
        public FormEmpSearch()
        {
            InitializeComponent();
        }

        int count = 0;
        Connection con = new Connection();
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable DT;

        private void FormEmpSearch_Load(object sender, EventArgs e)
        {

        }

        public void FSerach()
        {
            count = 0;
            con.DataGet("select * from DBEmp where EmpName like'" + txtESearch.Text + "%'");
            da = new SqlDataAdapter(cmd);
            DT = new DataTable();
            con.sda.Fill(DT);
            dataGridViewESearch.DataSource = DT;
            count = Convert.ToInt32(DT.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("data not found");
            }
        }

        private void txtESearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            FSerach();
        }

        private void dataGridViewESearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
