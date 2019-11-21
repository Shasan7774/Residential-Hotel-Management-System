namespace HM
{
    partial class MDIControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.guestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userRegiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.hotelToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(803, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // guestToolStripMenuItem
            // 
            this.guestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestRegisterToolStripMenuItem,
            this.guestSearchToolStripMenuItem});
            this.guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            this.guestToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.guestToolStripMenuItem.Text = "Guest";
            // 
            // guestRegisterToolStripMenuItem
            // 
            this.guestRegisterToolStripMenuItem.Name = "guestRegisterToolStripMenuItem";
            this.guestRegisterToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.guestRegisterToolStripMenuItem.Text = "Guest Register";
            this.guestRegisterToolStripMenuItem.Click += new System.EventHandler(this.guestRegisterToolStripMenuItem_Click);
            // 
            // guestSearchToolStripMenuItem
            // 
            this.guestSearchToolStripMenuItem.Name = "guestSearchToolStripMenuItem";
            this.guestSearchToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.guestSearchToolStripMenuItem.Text = "Guest Search";
            this.guestSearchToolStripMenuItem.Click += new System.EventHandler(this.guestSearchToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegisterToolStripMenuItem,
            this.employeeSearchToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeRegisterToolStripMenuItem
            // 
            this.employeeRegisterToolStripMenuItem.Name = "employeeRegisterToolStripMenuItem";
            this.employeeRegisterToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.employeeRegisterToolStripMenuItem.Text = "Employee Register";
            this.employeeRegisterToolStripMenuItem.Click += new System.EventHandler(this.employeeRegisterToolStripMenuItem_Click_1);
            // 
            // employeeSearchToolStripMenuItem
            // 
            this.employeeSearchToolStripMenuItem.Name = "employeeSearchToolStripMenuItem";
            this.employeeSearchToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.employeeSearchToolStripMenuItem.Text = "Employee Search";
            this.employeeSearchToolStripMenuItem.Click += new System.EventHandler(this.employeeSearchToolStripMenuItem_Click);
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelExpenseToolStripMenuItem,
            this.hotelInventoryToolStripMenuItem});
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.hotelToolStripMenuItem.Text = "Hotel";
            // 
            // hotelExpenseToolStripMenuItem
            // 
            this.hotelExpenseToolStripMenuItem.Name = "hotelExpenseToolStripMenuItem";
            this.hotelExpenseToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.hotelExpenseToolStripMenuItem.Text = "Hotel Expense";
            this.hotelExpenseToolStripMenuItem.Click += new System.EventHandler(this.hotelExpenseToolStripMenuItem_Click);
            // 
            // hotelInventoryToolStripMenuItem
            // 
            this.hotelInventoryToolStripMenuItem.Name = "hotelInventoryToolStripMenuItem";
            this.hotelInventoryToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.hotelInventoryToolStripMenuItem.Text = "Hotel Inventory";
            this.hotelInventoryToolStripMenuItem.Click += new System.EventHandler(this.hotelInventoryToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userRegiToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // userRegiToolStripMenuItem
            // 
            this.userRegiToolStripMenuItem.Name = "userRegiToolStripMenuItem";
            this.userRegiToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.userRegiToolStripMenuItem.Text = "User Register";
            this.userRegiToolStripMenuItem.Click += new System.EventHandler(this.userRegiToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // MDIControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIControl";
            this.Text = "Hotel Management";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIControl_FormClosing);
            this.Load += new System.EventHandler(this.MDIControl_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userRegiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeSearchToolStripMenuItem;
    }
}



