namespace HM.User
{
    partial class FromUserRegister
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxUserRegRole = new System.Windows.Forms.ComboBox();
            this.dateTimePickerUserReg = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserRegEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserRegAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserRegPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserRegUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserRegName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUserRegister = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderUserReg = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserReg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.comboBoxUserRegRole);
            this.panel1.Controls.Add(this.dateTimePickerUserReg);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUserRegEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUserRegAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUserRegPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUserRegUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserRegName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 293);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(624, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(462, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 37);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(295, 231);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 37);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxUserRegRole
            // 
            this.comboBoxUserRegRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserRegRole.FormattingEnabled = true;
            this.comboBoxUserRegRole.Items.AddRange(new object[] {
            "Admin",
            "Receptionist"});
            this.comboBoxUserRegRole.Location = new System.Drawing.Point(655, 113);
            this.comboBoxUserRegRole.Name = "comboBoxUserRegRole";
            this.comboBoxUserRegRole.Size = new System.Drawing.Size(289, 28);
            this.comboBoxUserRegRole.TabIndex = 14;
            // 
            // dateTimePickerUserReg
            // 
            this.dateTimePickerUserReg.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerUserReg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerUserReg.Location = new System.Drawing.Point(655, 74);
            this.dateTimePickerUserReg.Name = "dateTimePickerUserReg";
            this.dateTimePickerUserReg.Size = new System.Drawing.Size(289, 27);
            this.dateTimePickerUserReg.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth";
            // 
            // txtUserRegEmail
            // 
            this.txtUserRegEmail.Location = new System.Drawing.Point(655, 27);
            this.txtUserRegEmail.Name = "txtUserRegEmail";
            this.txtUserRegEmail.Size = new System.Drawing.Size(289, 27);
            this.txtUserRegEmail.TabIndex = 9;
            this.txtUserRegEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserRegEmail_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // txtUserRegAddress
            // 
            this.txtUserRegAddress.Location = new System.Drawing.Point(160, 150);
            this.txtUserRegAddress.Multiline = true;
            this.txtUserRegAddress.Name = "txtUserRegAddress";
            this.txtUserRegAddress.Size = new System.Drawing.Size(289, 65);
            this.txtUserRegAddress.TabIndex = 7;
            this.txtUserRegAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserRegAddress_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // txtUserRegPass
            // 
            this.txtUserRegPass.Location = new System.Drawing.Point(160, 110);
            this.txtUserRegPass.Name = "txtUserRegPass";
            this.txtUserRegPass.Size = new System.Drawing.Size(289, 27);
            this.txtUserRegPass.TabIndex = 5;
            this.txtUserRegPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserRegPass_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtUserRegUserName
            // 
            this.txtUserRegUserName.Location = new System.Drawing.Point(160, 68);
            this.txtUserRegUserName.Name = "txtUserRegUserName";
            this.txtUserRegUserName.Size = new System.Drawing.Size(289, 27);
            this.txtUserRegUserName.TabIndex = 3;
            this.txtUserRegUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserRegUserName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // txtUserRegName
            // 
            this.txtUserRegName.Location = new System.Drawing.Point(160, 27);
            this.txtUserRegName.Name = "txtUserRegName";
            this.txtUserRegName.Size = new System.Drawing.Size(289, 27);
            this.txtUserRegName.TabIndex = 1;
            this.txtUserRegName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserRegName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dataGridViewUserRegister
            // 
            this.dataGridViewUserRegister.AllowUserToAddRows = false;
            this.dataGridViewUserRegister.AllowUserToDeleteRows = false;
            this.dataGridViewUserRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgName,
            this.dgDOB,
            this.dgEmail,
            this.dgUserName,
            this.dgRole,
            this.dgAddress});
            this.dataGridViewUserRegister.Location = new System.Drawing.Point(23, 399);
            this.dataGridViewUserRegister.Name = "dataGridViewUserRegister";
            this.dataGridViewUserRegister.ReadOnly = true;
            this.dataGridViewUserRegister.RowTemplate.Height = 24;
            this.dataGridViewUserRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserRegister.Size = new System.Drawing.Size(1054, 209);
            this.dataGridViewUserRegister.TabIndex = 1;
            this.dataGridViewUserRegister.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewUserRegister_MouseDoubleClick);
            // 
            // dgSno
            // 
            this.dgSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgSno.HeaderText = "S.No";
            this.dgSno.Name = "dgSno";
            this.dgSno.ReadOnly = true;
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgDOB
            // 
            this.dgDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDOB.HeaderText = "DOB";
            this.dgDOB.Name = "dgDOB";
            this.dgDOB.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // dgUserName
            // 
            this.dgUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgUserName.HeaderText = "User Name";
            this.dgUserName.Name = "dgUserName";
            this.dgUserName.ReadOnly = true;
            // 
            // dgRole
            // 
            this.dgRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgRole.HeaderText = "Role";
            this.dgRole.Name = "dgRole";
            this.dgRole.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            // 
            // errorProviderUserReg
            // 
            this.errorProviderUserReg.ContainerControl = this;
            // 
            // FromUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 631);
            this.Controls.Add(this.dataGridViewUserRegister);
            this.Controls.Add(this.panel1);
            this.Name = "FromUserRegister";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "User Register";
            this.Load += new System.EventHandler(this.FromUserRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxUserRegRole;
        private System.Windows.Forms.DateTimePicker dateTimePickerUserReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserRegEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserRegAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserRegPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserRegUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserRegName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewUserRegister;
        private System.Windows.Forms.ErrorProvider errorProviderUserReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
    }
}