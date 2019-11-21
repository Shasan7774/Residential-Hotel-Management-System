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

namespace HM
{
    public partial class MDIControl : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;

        public MDIControl()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userRegiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FromUserRegister UR = new User.FromUserRegister();
            UR.MdiParent = this;
            UR.Show();
        }

        bool close = true;
        private void MDIControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this,"Are you sure You want to Exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    close = false;
                    Application.Exit();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User.FormChangePass CP = new User.FormChangePass();
            CP.MdiParent = this;
            CP.Show();
        }

        private void employeeRegisterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Employee.FormEmployeeReg FE = new Employee.FormEmployeeReg();
            FE.MdiParent = this;
            FE.Show();
        }

        private void guestRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest.FormGuestInfo GI = new Guest.FormGuestInfo();
            GI.MdiParent = this;
            GI.Show();
        }

        private void hotelExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotel.FormHotelExpense Hf = new Hotel.FormHotelExpense();
            Hf.MdiParent = this;
            Hf.Show();
        }

        private void hotelInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hotel.FormInventory HH = new Hotel.FormInventory();
            HH.MdiParent = this;
            HH.Show();
        }

        private void MDIControl_Load(object sender, EventArgs e)
        {

        }

        private void guestSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guest.FormSearch ff = new Guest.FormSearch();
            ff.MdiParent = this;
            ff.Show();
        }

        private void employeeSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.FormEmpSearch fff = new Employee.FormEmpSearch();
            fff.MdiParent = this;
            fff.Show();
        }
    }
}
