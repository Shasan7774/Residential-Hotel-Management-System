namespace HM.Guest
{
    partial class FormBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTotalFare = new System.Windows.Forms.Button();
            this.comboBoxExc = new System.Windows.Forms.ComboBox();
            this.comboBoxMini = new System.Windows.Forms.ComboBox();
            this.comboBoxDouble = new System.Windows.Forms.ComboBox();
            this.comboBoxSingle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtroomTotal = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMini = new System.Windows.Forms.TextBox();
            this.txtDouble = new System.Windows.Forms.TextBox();
            this.txtEcecutive = new System.Windows.Forms.TextBox();
            this.txtSingle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.checkBoxMiniSuit = new System.Windows.Forms.CheckBox();
            this.checkBoxExecutiveSuite = new System.Windows.Forms.CheckBox();
            this.checkBoxDoubleRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxSingleRoom = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTotalFare);
            this.panel1.Controls.Add(this.comboBoxExc);
            this.panel1.Controls.Add(this.comboBoxMini);
            this.panel1.Controls.Add(this.comboBoxDouble);
            this.panel1.Controls.Add(this.comboBoxSingle);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtroomTotal);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.checkBoxMiniSuit);
            this.panel1.Controls.Add(this.checkBoxExecutiveSuite);
            this.panel1.Controls.Add(this.checkBoxDoubleRoom);
            this.panel1.Controls.Add(this.checkBoxSingleRoom);
            this.panel1.Location = new System.Drawing.Point(143, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 488);
            this.panel1.TabIndex = 1;
            // 
            // btnTotalFare
            // 
            this.btnTotalFare.Location = new System.Drawing.Point(407, 360);
            this.btnTotalFare.Name = "btnTotalFare";
            this.btnTotalFare.Size = new System.Drawing.Size(150, 37);
            this.btnTotalFare.TabIndex = 49;
            this.btnTotalFare.Text = "Total Fare";
            this.btnTotalFare.UseVisualStyleBackColor = true;
            this.btnTotalFare.Click += new System.EventHandler(this.btnTotalFare_Click);
            // 
            // comboBoxExc
            // 
            this.comboBoxExc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExc.FormattingEnabled = true;
            this.comboBoxExc.Location = new System.Drawing.Point(197, 155);
            this.comboBoxExc.Name = "comboBoxExc";
            this.comboBoxExc.Size = new System.Drawing.Size(193, 24);
            this.comboBoxExc.TabIndex = 44;
            // 
            // comboBoxMini
            // 
            this.comboBoxMini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMini.FormattingEnabled = true;
            this.comboBoxMini.Location = new System.Drawing.Point(197, 202);
            this.comboBoxMini.Name = "comboBoxMini";
            this.comboBoxMini.Size = new System.Drawing.Size(193, 24);
            this.comboBoxMini.TabIndex = 43;
            // 
            // comboBoxDouble
            // 
            this.comboBoxDouble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDouble.FormattingEnabled = true;
            this.comboBoxDouble.Location = new System.Drawing.Point(197, 109);
            this.comboBoxDouble.Name = "comboBoxDouble";
            this.comboBoxDouble.Size = new System.Drawing.Size(193, 24);
            this.comboBoxDouble.TabIndex = 42;
            // 
            // comboBoxSingle
            // 
            this.comboBoxSingle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSingle.FormattingEnabled = true;
            this.comboBoxSingle.Location = new System.Drawing.Point(197, 67);
            this.comboBoxSingle.Name = "comboBoxSingle";
            this.comboBoxSingle.Size = new System.Drawing.Size(193, 24);
            this.comboBoxSingle.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Total";
            // 
            // txtroomTotal
            // 
            this.txtroomTotal.Location = new System.Drawing.Point(464, 291);
            this.txtroomTotal.Name = "txtroomTotal";
            this.txtroomTotal.ReadOnly = true;
            this.txtroomTotal.Size = new System.Drawing.Size(70, 22);
            this.txtroomTotal.TabIndex = 36;
            this.txtroomTotal.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMini);
            this.panel3.Controls.Add(this.txtDouble);
            this.panel3.Controls.Add(this.txtEcecutive);
            this.panel3.Controls.Add(this.txtSingle);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(443, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 227);
            this.panel3.TabIndex = 37;
            // 
            // txtMini
            // 
            this.txtMini.Location = new System.Drawing.Point(21, 190);
            this.txtMini.Name = "txtMini";
            this.txtMini.ReadOnly = true;
            this.txtMini.Size = new System.Drawing.Size(70, 22);
            this.txtMini.TabIndex = 35;
            this.txtMini.Text = "0";
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(21, 95);
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.ReadOnly = true;
            this.txtDouble.Size = new System.Drawing.Size(70, 22);
            this.txtDouble.TabIndex = 33;
            this.txtDouble.Text = "0";
            // 
            // txtEcecutive
            // 
            this.txtEcecutive.Location = new System.Drawing.Point(21, 144);
            this.txtEcecutive.Name = "txtEcecutive";
            this.txtEcecutive.ReadOnly = true;
            this.txtEcecutive.Size = new System.Drawing.Size(70, 22);
            this.txtEcecutive.TabIndex = 32;
            this.txtEcecutive.Text = "0";
            // 
            // txtSingle
            // 
            this.txtSingle.Location = new System.Drawing.Point(21, 52);
            this.txtSingle.Name = "txtSingle";
            this.txtSingle.ReadOnly = true;
            this.txtSingle.Size = new System.Drawing.Size(70, 22);
            this.txtSingle.TabIndex = 30;
            this.txtSingle.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Room Fare";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(38, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 17);
            this.label25.TabIndex = 30;
            this.label25.Text = "Food";
            // 
            // checkBoxMiniSuit
            // 
            this.checkBoxMiniSuit.AutoSize = true;
            this.checkBoxMiniSuit.Location = new System.Drawing.Point(41, 204);
            this.checkBoxMiniSuit.Name = "checkBoxMiniSuit";
            this.checkBoxMiniSuit.Size = new System.Drawing.Size(95, 21);
            this.checkBoxMiniSuit.TabIndex = 27;
            this.checkBoxMiniSuit.Text = "Mini Suite ";
            this.checkBoxMiniSuit.UseVisualStyleBackColor = true;
            this.checkBoxMiniSuit.CheckedChanged += new System.EventHandler(this.checkBoxMiniSuit_CheckedChanged);
            // 
            // checkBoxExecutiveSuite
            // 
            this.checkBoxExecutiveSuite.AutoSize = true;
            this.checkBoxExecutiveSuite.Location = new System.Drawing.Point(41, 159);
            this.checkBoxExecutiveSuite.Name = "checkBoxExecutiveSuite";
            this.checkBoxExecutiveSuite.Size = new System.Drawing.Size(126, 21);
            this.checkBoxExecutiveSuite.TabIndex = 17;
            this.checkBoxExecutiveSuite.Text = "Executive Suite";
            this.checkBoxExecutiveSuite.UseVisualStyleBackColor = true;
            this.checkBoxExecutiveSuite.CheckedChanged += new System.EventHandler(this.checkBoxExecutiveSuite_CheckedChanged);
            // 
            // checkBoxDoubleRoom
            // 
            this.checkBoxDoubleRoom.AutoSize = true;
            this.checkBoxDoubleRoom.Location = new System.Drawing.Point(41, 111);
            this.checkBoxDoubleRoom.Name = "checkBoxDoubleRoom";
            this.checkBoxDoubleRoom.Size = new System.Drawing.Size(116, 21);
            this.checkBoxDoubleRoom.TabIndex = 12;
            this.checkBoxDoubleRoom.Text = "Double Room";
            this.checkBoxDoubleRoom.UseVisualStyleBackColor = true;
            this.checkBoxDoubleRoom.CheckedChanged += new System.EventHandler(this.checkBoxDoubleRoom_CheckedChanged);
            // 
            // checkBoxSingleRoom
            // 
            this.checkBoxSingleRoom.AutoSize = true;
            this.checkBoxSingleRoom.Location = new System.Drawing.Point(41, 67);
            this.checkBoxSingleRoom.Name = "checkBoxSingleRoom";
            this.checkBoxSingleRoom.Size = new System.Drawing.Size(110, 21);
            this.checkBoxSingleRoom.TabIndex = 2;
            this.checkBoxSingleRoom.Text = "Single Room";
            this.checkBoxSingleRoom.UseVisualStyleBackColor = true;
            this.checkBoxSingleRoom.CheckedChanged += new System.EventHandler(this.checkBoxSingleRoom_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(616, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 37);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 622);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Name = "FormBooking";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Room Booking";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtroomTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMini;
        private System.Windows.Forms.TextBox txtDouble;
        private System.Windows.Forms.TextBox txtEcecutive;
        private System.Windows.Forms.TextBox txtSingle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox checkBoxMiniSuit;
        private System.Windows.Forms.CheckBox checkBoxExecutiveSuite;
        private System.Windows.Forms.CheckBox checkBoxDoubleRoom;
        private System.Windows.Forms.CheckBox checkBoxSingleRoom;
        private System.Windows.Forms.ComboBox comboBoxExc;
        private System.Windows.Forms.ComboBox comboBoxMini;
        private System.Windows.Forms.ComboBox comboBoxDouble;
        private System.Windows.Forms.ComboBox comboBoxSingle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTotalFare;
    }
}