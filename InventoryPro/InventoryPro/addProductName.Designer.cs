namespace InventoryPro
{
    partial class addProductName
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
            this.paneladdProduct = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.comboBoxProductUnit = new System.Windows.Forms.ComboBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridViewProductName = new System.Windows.Forms.DataGridView();
            this.panelProductUpdate = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxProductUpdate = new System.Windows.Forms.ComboBox();
            this.textBoxProductUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paneladdProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductName)).BeginInit();
            this.panelProductUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneladdProduct
            // 
            this.paneladdProduct.Controls.Add(this.buttonInsert);
            this.paneladdProduct.Controls.Add(this.comboBoxProductUnit);
            this.paneladdProduct.Controls.Add(this.textBoxProductName);
            this.paneladdProduct.Controls.Add(this.label2);
            this.paneladdProduct.Controls.Add(this.label1);
            this.paneladdProduct.Location = new System.Drawing.Point(50, 22);
            this.paneladdProduct.Name = "paneladdProduct";
            this.paneladdProduct.Size = new System.Drawing.Size(1051, 74);
            this.paneladdProduct.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Unit:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(160, 24);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(252, 27);
            this.textBoxProductName.TabIndex = 2;
            // 
            // comboBoxProductUnit
            // 
            this.comboBoxProductUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductUnit.FormattingEnabled = true;
            this.comboBoxProductUnit.Location = new System.Drawing.Point(562, 23);
            this.comboBoxProductUnit.Name = "comboBoxProductUnit";
            this.comboBoxProductUnit.Size = new System.Drawing.Size(276, 28);
            this.comboBoxProductUnit.TabIndex = 3;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Location = new System.Drawing.Point(892, 20);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(94, 33);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridViewProductName
            // 
            this.dataGridViewProductName.AllowUserToAddRows = false;
            this.dataGridViewProductName.AllowUserToDeleteRows = false;
            this.dataGridViewProductName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductName.Location = new System.Drawing.Point(487, 115);
            this.dataGridViewProductName.Name = "dataGridViewProductName";
            this.dataGridViewProductName.ReadOnly = true;
            this.dataGridViewProductName.RowTemplate.Height = 24;
            this.dataGridViewProductName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductName.Size = new System.Drawing.Size(614, 195);
            this.dataGridViewProductName.TabIndex = 5;
            this.dataGridViewProductName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductName_CellClick);
            this.dataGridViewProductName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductName_CellContentClick);
            // 
            // panelProductUpdate
            // 
            this.panelProductUpdate.Controls.Add(this.buttonUpdate);
            this.panelProductUpdate.Controls.Add(this.comboBoxProductUpdate);
            this.panelProductUpdate.Controls.Add(this.textBoxProductUpdate);
            this.panelProductUpdate.Controls.Add(this.label3);
            this.panelProductUpdate.Controls.Add(this.label4);
            this.panelProductUpdate.Location = new System.Drawing.Point(50, 115);
            this.panelProductUpdate.Name = "panelProductUpdate";
            this.panelProductUpdate.Size = new System.Drawing.Size(397, 195);
            this.panelProductUpdate.TabIndex = 5;
            this.panelProductUpdate.Visible = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(200, 128);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 33);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // comboBoxProductUpdate
            // 
            this.comboBoxProductUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProductUpdate.FormattingEnabled = true;
            this.comboBoxProductUpdate.Location = new System.Drawing.Point(160, 71);
            this.comboBoxProductUpdate.Name = "comboBoxProductUpdate";
            this.comboBoxProductUpdate.Size = new System.Drawing.Size(201, 28);
            this.comboBoxProductUpdate.TabIndex = 3;
            // 
            // textBoxProductUpdate
            // 
            this.textBoxProductUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductUpdate.Location = new System.Drawing.Point(160, 24);
            this.textBoxProductUpdate.Name = "textBoxProductUpdate";
            this.textBoxProductUpdate.Size = new System.Drawing.Size(201, 27);
            this.textBoxProductUpdate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product Name:";
            // 
            // addProductName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.panelProductUpdate);
            this.Controls.Add(this.dataGridViewProductName);
            this.Controls.Add(this.paneladdProduct);
            this.Name = "addProductName";
            this.Text = "Product Name";
            this.Load += new System.EventHandler(this.addProductName_Load);
            this.paneladdProduct.ResumeLayout(false);
            this.paneladdProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductName)).EndInit();
            this.panelProductUpdate.ResumeLayout(false);
            this.panelProductUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladdProduct;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxProductUnit;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewProductName;
        private System.Windows.Forms.Panel panelProductUpdate;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxProductUpdate;
        private System.Windows.Forms.TextBox textBoxProductUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}