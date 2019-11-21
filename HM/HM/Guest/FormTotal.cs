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

namespace HM.Guest
{
    public partial class FormTotal : MetroFramework.Forms.MetroForm
    {
        public FormTotal()
        {
            InitializeComponent();
        }
         //double pay;
        private void FormTotal_Load(object sender, EventArgs e)
        {
            labelRoomRent.Text = Guest.FormGuestInfo.roomCharge;
            labelServiceCharge.Text = Guest.FormGuestInfo.ServicePayment;
            labelFoodBills.Text = Guest.FormGuestInfo.foodCharge;
            labelSubTotal.Text = Guest.FormGuestInfo.subtotal;
            //double a = double.Parse(Guest.FormGuestInfo.subtotal);
            //   double a = double.Parse(labelSubTotal.Text);
            //  double totalVat = (a * .15);

            labelVat.Text = Guest.FormGuestInfo.vatToPAY;
            //double x = double.Parse(Guest.FormGuestInfo.vatToPAY);
            //double dis = double.Parse(txtDisscount.Text);
            labelNetPay.Text = Guest.FormGuestInfo.totalToPay;

            
        }
    }
}
