namespace HM.Employee
{
    partial class FormEmployeeReg
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnESearch = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxEmpRegRole = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEmpReg = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmpReg = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderEmpReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpReg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnESearch);
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.comboBoxEmpRegRole);
            this.panel2.Controls.Add(this.dateTimePickerEmpReg);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtEmpEmail);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEmpSalary);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEmpAddress);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEmpPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEmpName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(140, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 309);
            this.panel2.TabIndex = 1;
            // 
            // btnESearch
            // 
            this.btnESearch.Location = new System.Drawing.Point(628, 256);
            this.btnESearch.Name = "btnESearch";
            this.btnESearch.Size = new System.Drawing.Size(137, 37);
            this.btnESearch.TabIndex = 20;
            this.btnESearch.Text = "Search";
            this.btnESearch.UseVisualStyleBackColor = true;
            this.btnESearch.Click += new System.EventHandler(this.btnESearch_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(159, 24);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(289, 27);
            this.txtEmpID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(462, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(295, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(122, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxEmpRegRole
            // 
            this.comboBoxEmpRegRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpRegRole.FormattingEnabled = true;
            this.comboBoxEmpRegRole.Items.AddRange(new object[] {
            "Manger",
            "Receptionist",
            "Cleaner",
            "Security Guard",
            "Driver",
            "Chef",
            "Waiter"});
            this.comboBoxEmpRegRole.Location = new System.Drawing.Point(628, 163);
            this.comboBoxEmpRegRole.Name = "comboBoxEmpRegRole";
            this.comboBoxEmpRegRole.Size = new System.Drawing.Size(227, 28);
            this.comboBoxEmpRegRole.TabIndex = 14;
            // 
            // dateTimePickerEmpReg
            // 
            this.dateTimePickerEmpReg.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerEmpReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEmpReg.Location = new System.Drawing.Point(628, 68);
            this.dateTimePickerEmpReg.Name = "dateTimePickerEmpReg";
            this.dateTimePickerEmpReg.Size = new System.Drawing.Size(227, 27);
            this.dateTimePickerEmpReg.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(628, 27);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(227, 27);
            this.txtEmpEmail.TabIndex = 9;
            this.txtEmpEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpEmail_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(628, 114);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(227, 27);
            this.txtEmpSalary.TabIndex = 7;
            this.txtEmpSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpSalary_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salary";
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Location = new System.Drawing.Point(159, 163);
            this.txtEmpAddress.Multiline = true;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.Size = new System.Drawing.Size(289, 70);
            this.txtEmpAddress.TabIndex = 5;
            this.txtEmpAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpAddress_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(159, 114);
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(289, 27);
            this.txtEmpPhone.TabIndex = 3;
            this.txtEmpPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpPhone_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(159, 68);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(289, 27);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dataGridViewEmpReg
            // 
            this.dataGridViewEmpReg.AllowUserToAddRows = false;
            this.dataGridViewEmpReg.AllowUserToDeleteRows = false;
            this.dataGridViewEmpReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgName,
            this.dgPhone,
            this.dgAddress,
            this.dgEmail,
            this.dgDOB,
            this.dgRole,
            this.dgSalary});
            this.dataGridViewEmpReg.Location = new System.Drawing.Point(62, 408);
            this.dataGridViewEmpReg.Name = "dataGridViewEmpReg";
            this.dataGridViewEmpReg.ReadOnly = true;
            this.dataGridViewEmpReg.RowTemplate.Height = 24;
            this.dataGridViewEmpReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpReg.Size = new System.Drawing.Size(1050, 217);
            this.dataGridViewEmpReg.TabIndex = 2;
            this.dataGridViewEmpReg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewEmpReg_MouseDoubleClick);
            // 
            // dgID
            // 
            this.dgID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgID.HeaderText = "ID";
            this.dgID.Name = "dgID";
            this.dgID.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgPhone
            // 
            this.dgPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgPhone.HeaderText = "Phone";
            this.dgPhone.Name = "dgPhone";
            this.dgPhone.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // dgDOB
            // 
            this.dgDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDOB.HeaderText = "Date of Birth";
            this.dgDOB.Name = "dgDOB";
            this.dgDOB.ReadOnly = true;
            // 
            // dgRole
            // 
            this.dgRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgRole.HeaderText = "Role";
            this.dgRole.Name = "dgRole";
            this.dgRole.ReadOnly = true;
            // 
            // dgSalary
            // 
            this.dgSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgSalary.HeaderText = "Salary";
            this.dgSalary.Name = "dgSalary";
            this.dgSalary.ReadOnly = true;
            // 
            // errorProviderEmpReg
            // 
            this.errorProviderEmpReg.ContainerControl = this;
            // 
            // FormEmployeeReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 648);
            this.Controls.Add(this.dataGridViewEmpReg);
            this.Controls.Add(this.panel2);
            this.Name = "FormEmployeeReg";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Employee Register";
            this.Load += new System.EventHandler(this.FormEmployeeReg_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmpReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxEmpRegRole;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmpReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmpReg;
        private System.Windows.Forms.ErrorProvider errorProviderEmpReg;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSalary;
        private System.Windows.Forms.Button btnESearch;
    }
}