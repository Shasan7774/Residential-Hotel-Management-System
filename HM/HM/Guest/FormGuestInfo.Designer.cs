namespace HM.Guest
{
    partial class FormGuestInfo
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxGType = new System.Windows.Forms.ComboBox();
            this.txtGID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dateGBirth = new System.Windows.Forms.DateTimePicker();
            this.txtGAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGPassport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewGuest = new System.Windows.Forms.DataGridView();
            this.errorProviderGuest = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGFood = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateGLeave = new System.Windows.Forms.DateTimePicker();
            this.dateGEntry = new System.Windows.Forms.DateTimePicker();
            this.dgGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPassport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnGFood);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dateGLeave);
            this.panel1.Controls.Add(this.dateGEntry);
            this.panel1.Controls.Add(this.comboBoxGType);
            this.panel1.Controls.Add(this.txtGID);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.dateGBirth);
            this.panel1.Controls.Add(this.txtGAddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtGPassport);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtGContact);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 410);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxGType
            // 
            this.comboBoxGType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGType.FormattingEnabled = true;
            this.comboBoxGType.Items.AddRange(new object[] {
            "Passport",
            "NID",
            "Driving License"});
            this.comboBoxGType.Location = new System.Drawing.Point(769, 21);
            this.comboBoxGType.Name = "comboBoxGType";
            this.comboBoxGType.Size = new System.Drawing.Size(104, 28);
            this.comboBoxGType.TabIndex = 16;
            // 
            // txtGID
            // 
            this.txtGID.Location = new System.Drawing.Point(155, 21);
            this.txtGID.Name = "txtGID";
            this.txtGID.ReadOnly = true;
            this.txtGID.Size = new System.Drawing.Size(265, 27);
            this.txtGID.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(35, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 20);
            this.label20.TabIndex = 9;
            this.label20.Text = "Guest ID";
            // 
            // dateGBirth
            // 
            this.dateGBirth.CustomFormat = "dd/MM/yyyy";
            this.dateGBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGBirth.Location = new System.Drawing.Point(603, 79);
            this.dateGBirth.Name = "dateGBirth";
            this.dateGBirth.Size = new System.Drawing.Size(265, 27);
            this.dateGBirth.TabIndex = 8;
            // 
            // txtGAddress
            // 
            this.txtGAddress.Location = new System.Drawing.Point(155, 208);
            this.txtGAddress.Multiline = true;
            this.txtGAddress.Name = "txtGAddress";
            this.txtGAddress.Size = new System.Drawing.Size(265, 75);
            this.txtGAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date Of Birth";
            // 
            // txtGPassport
            // 
            this.txtGPassport.Location = new System.Drawing.Point(603, 22);
            this.txtGPassport.Name = "txtGPassport";
            this.txtGPassport.Size = new System.Drawing.Size(155, 27);
            this.txtGPassport.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identification";
            // 
            // txtGEmail
            // 
            this.txtGEmail.Location = new System.Drawing.Point(155, 159);
            this.txtGEmail.Name = "txtGEmail";
            this.txtGEmail.Size = new System.Drawing.Size(265, 27);
            this.txtGEmail.TabIndex = 5;
            this.txtGEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGEmail_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtGContact
            // 
            this.txtGContact.Location = new System.Drawing.Point(155, 111);
            this.txtGContact.Name = "txtGContact";
            this.txtGContact.Size = new System.Drawing.Size(265, 27);
            this.txtGContact.TabIndex = 3;
            this.txtGContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGContact_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contact";
            // 
            // txtGName
            // 
            this.txtGName.Location = new System.Drawing.Point(155, 63);
            this.txtGName.Name = "txtGName";
            this.txtGName.Size = new System.Drawing.Size(265, 27);
            this.txtGName.TabIndex = 1;
            this.txtGName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(159, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 51);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(313, 504);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 51);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(468, 504);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 51);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewGuest
            // 
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.AllowUserToDeleteRows = false;
            this.dataGridViewGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgGID,
            this.dgName,
            this.dgContact,
            this.dgEmail,
            this.dgPassport,
            this.dgGType,
            this.dgDOB,
            this.dgAddress,
            this.dgEntry,
            this.dgLeave});
            this.dataGridViewGuest.Location = new System.Drawing.Point(51, 585);
            this.dataGridViewGuest.Name = "dataGridViewGuest";
            this.dataGridViewGuest.ReadOnly = true;
            this.dataGridViewGuest.RowTemplate.Height = 24;
            this.dataGridViewGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuest.Size = new System.Drawing.Size(845, 275);
            this.dataGridViewGuest.TabIndex = 28;
            this.dataGridViewGuest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewGuest_MouseDoubleClick);
            // 
            // errorProviderGuest
            // 
            this.errorProviderGuest.ContainerControl = this;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(626, 504);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 51);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGFood
            // 
            this.btnGFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGFood.Location = new System.Drawing.Point(629, 245);
            this.btnGFood.Name = "btnGFood";
            this.btnGFood.Size = new System.Drawing.Size(187, 38);
            this.btnGFood.TabIndex = 31;
            this.btnGFood.Text = "Food and Service";
            this.btnGFood.UseVisualStyleBackColor = true;
            this.btnGFood.Click += new System.EventHandler(this.btnGFood_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(629, 358);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(187, 34);
            this.btnTotal.TabIndex = 32;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(629, 306);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(187, 34);
            this.btnBooking.TabIndex = 33;
            this.btnBooking.Text = "Room Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 20);
            this.label12.TabIndex = 50;
            this.label12.Text = "Departure Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 52;
            this.label11.Text = "Entry Date";
            // 
            // dateGLeave
            // 
            this.dateGLeave.CustomFormat = "dd/MM/yyyy";
            this.dateGLeave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGLeave.Location = new System.Drawing.Point(603, 188);
            this.dateGLeave.Name = "dateGLeave";
            this.dateGLeave.Size = new System.Drawing.Size(265, 27);
            this.dateGLeave.TabIndex = 51;
            // 
            // dateGEntry
            // 
            this.dateGEntry.CustomFormat = "dd/MM/yyyy";
            this.dateGEntry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateGEntry.Location = new System.Drawing.Point(603, 132);
            this.dateGEntry.Name = "dateGEntry";
            this.dateGEntry.Size = new System.Drawing.Size(265, 27);
            this.dateGEntry.TabIndex = 49;
            // 
            // dgGID
            // 
            this.dgGID.HeaderText = "ID";
            this.dgGID.Name = "dgGID";
            this.dgGID.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgContact
            // 
            this.dgContact.HeaderText = "Contact";
            this.dgContact.Name = "dgContact";
            this.dgContact.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // dgPassport
            // 
            this.dgPassport.HeaderText = "Identity";
            this.dgPassport.Name = "dgPassport";
            this.dgPassport.ReadOnly = true;
            // 
            // dgGType
            // 
            this.dgGType.HeaderText = "Identity Type";
            this.dgGType.Name = "dgGType";
            this.dgGType.ReadOnly = true;
            // 
            // dgDOB
            // 
            this.dgDOB.HeaderText = "Date of Birth";
            this.dgDOB.Name = "dgDOB";
            this.dgDOB.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            // 
            // dgEntry
            // 
            this.dgEntry.HeaderText = "Entry Date";
            this.dgEntry.Name = "dgEntry";
            this.dgEntry.ReadOnly = true;
            // 
            // dgLeave
            // 
            this.dgLeave.HeaderText = "Departure Date";
            this.dgLeave.Name = "dgLeave";
            this.dgLeave.ReadOnly = true;
            // 
            // FormGuestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 908);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewGuest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FormGuestInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Guest Info";
            this.Load += new System.EventHandler(this.FormGuestInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateGBirth;
        private System.Windows.Forms.TextBox txtGAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGPassport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewGuest;
        private System.Windows.Forms.TextBox txtGID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ErrorProvider errorProviderGuest;
        private System.Windows.Forms.ComboBox comboBoxGType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnGFood;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateGLeave;
        private System.Windows.Forms.DateTimePicker dateGEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPassport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLeave;
    }
}