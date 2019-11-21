namespace HM.Hotel
{
    partial class FormHotelExpense
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtExpCost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExpStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxExpType = new System.Windows.Forms.ComboBox();
            this.dataGridViewExp = new System.Windows.Forms.DataGridView();
            this.errorProviderExp = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgExpType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgExpCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtExpID);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtExpCost);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxExpStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxExpType);
            this.panel1.Location = new System.Drawing.Point(243, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 253);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Expense ID";
            // 
            // txtExpID
            // 
            this.txtExpID.Location = new System.Drawing.Point(211, 13);
            this.txtExpID.Name = "txtExpID";
            this.txtExpID.ReadOnly = true;
            this.txtExpID.Size = new System.Drawing.Size(242, 22);
            this.txtExpID.TabIndex = 31;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(366, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 51);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expense Cost";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(211, 185);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 51);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtExpCost
            // 
            this.txtExpCost.Location = new System.Drawing.Point(211, 94);
            this.txtExpCost.Name = "txtExpCost";
            this.txtExpCost.Size = new System.Drawing.Size(242, 22);
            this.txtExpCost.TabIndex = 4;
            this.txtExpCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpCost_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(53, 185);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 51);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expense Status";
            // 
            // comboBoxExpStatus
            // 
            this.comboBoxExpStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpStatus.FormattingEnabled = true;
            this.comboBoxExpStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.comboBoxExpStatus.Location = new System.Drawing.Point(211, 136);
            this.comboBoxExpStatus.Name = "comboBoxExpStatus";
            this.comboBoxExpStatus.Size = new System.Drawing.Size(242, 24);
            this.comboBoxExpStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense Type";
            // 
            // comboBoxExpType
            // 
            this.comboBoxExpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpType.FormattingEnabled = true;
            this.comboBoxExpType.Items.AddRange(new object[] {
            "Electricity",
            "Gas",
            "Cleaning",
            "Maintenance"});
            this.comboBoxExpType.Location = new System.Drawing.Point(211, 50);
            this.comboBoxExpType.Name = "comboBoxExpType";
            this.comboBoxExpType.Size = new System.Drawing.Size(242, 24);
            this.comboBoxExpType.TabIndex = 0;
            // 
            // dataGridViewExp
            // 
            this.dataGridViewExp.AllowUserToAddRows = false;
            this.dataGridViewExp.AllowUserToDeleteRows = false;
            this.dataGridViewExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEID,
            this.dgExpType,
            this.dgExpCost,
            this.dgStatus});
            this.dataGridViewExp.Location = new System.Drawing.Point(75, 358);
            this.dataGridViewExp.Name = "dataGridViewExp";
            this.dataGridViewExp.ReadOnly = true;
            this.dataGridViewExp.RowTemplate.Height = 24;
            this.dataGridViewExp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExp.Size = new System.Drawing.Size(910, 207);
            this.dataGridViewExp.TabIndex = 1;
            this.dataGridViewExp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewExp_MouseDoubleClick);
            // 
            // errorProviderExp
            // 
            this.errorProviderExp.ContainerControl = this;
            // 
            // dgEID
            // 
            this.dgEID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgEID.HeaderText = "ID";
            this.dgEID.Name = "dgEID";
            this.dgEID.ReadOnly = true;
            // 
            // dgExpType
            // 
            this.dgExpType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgExpType.HeaderText = "Expense Type";
            this.dgExpType.Name = "dgExpType";
            this.dgExpType.ReadOnly = true;
            // 
            // dgExpCost
            // 
            this.dgExpCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgExpCost.HeaderText = "Expense Cost";
            this.dgExpCost.Name = "dgExpCost";
            this.dgExpCost.ReadOnly = true;
            // 
            // dgStatus
            // 
            this.dgStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgStatus.HeaderText = "Expense Status";
            this.dgStatus.Name = "dgStatus";
            this.dgStatus.ReadOnly = true;
            // 
            // FormHotelExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 588);
            this.Controls.Add(this.dataGridViewExp);
            this.Controls.Add(this.panel1);
            this.Name = "FormHotelExpense";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hotel Expense";
            this.Load += new System.EventHandler(this.FormHotelExpense_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderExp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExpStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxExpType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExpID;
        private System.Windows.Forms.ErrorProvider errorProviderExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgExpType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgExpCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
    }
}