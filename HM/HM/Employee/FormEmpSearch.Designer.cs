namespace HM.Employee
{
    partial class FormEmpSearch
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
            this.dataGridViewESearch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtESearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewESearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewESearch
            // 
            this.dataGridViewESearch.AllowUserToAddRows = false;
            this.dataGridViewESearch.AllowUserToDeleteRows = false;
            this.dataGridViewESearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewESearch.Location = new System.Drawing.Point(38, 163);
            this.dataGridViewESearch.Name = "dataGridViewESearch";
            this.dataGridViewESearch.ReadOnly = true;
            this.dataGridViewESearch.RowTemplate.Height = 24;
            this.dataGridViewESearch.Size = new System.Drawing.Size(843, 380);
            this.dataGridViewESearch.TabIndex = 7;
            this.dataGridViewESearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewESearch_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "By Name";
            // 
            // txtESearch
            // 
            this.txtESearch.Location = new System.Drawing.Point(333, 100);
            this.txtESearch.Name = "txtESearch";
            this.txtESearch.Size = new System.Drawing.Size(237, 22);
            this.txtESearch.TabIndex = 5;
            this.txtESearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtESearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Here";
            // 
            // FormEmpSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 566);
            this.Controls.Add(this.dataGridViewESearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtESearch);
            this.Controls.Add(this.label1);
            this.Name = "FormEmpSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Employee Search";
            this.Load += new System.EventHandler(this.FormEmpSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewESearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewESearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtESearch;
        private System.Windows.Forms.Label label1;
    }
}