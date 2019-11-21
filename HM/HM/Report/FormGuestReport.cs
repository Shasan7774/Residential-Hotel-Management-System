using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MetroFramework;

namespace HM.Report
{
    public partial class FormGuestReport : MetroFramework.Forms.MetroForm
    {

        GuestReport GP = new GuestReport();
        public FormGuestReport()
        {
            InitializeComponent();
        }

        private void FormGuestReport_Load(object sender, EventArgs e)
        {
            GP.Load(@"C:\Users\REN\Desktop\HM\HM\Report\GuestReport.rpt");
            Connection con = new Connection();
            DataSet dst = new DataSet();
            con.DataGet("Select * from DBGuest");
            con.sda.Fill(dst,"DBGuest");
            GP.SetDataSource(dst);
            crystalReportViewer1.ReportSource = GP;
        }
    }
}
