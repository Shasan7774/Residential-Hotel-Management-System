namespace InventoryPro
{
    partial class unit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddUnit = new System.Windows.Forms.TextBox();
            this.buttonAddUnit = new System.Windows.Forms.Button();
            this.dataGridViewUnit = new System.Windows.Forms.DataGridView();
            this.buttonDeleteUnit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Unit:";
            // 
            // textBoxAddUnit
            // 
            this.textBoxAddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddUnit.Location = new System.Drawing.Point(144, 28);
            this.textBoxAddUnit.Name = "textBoxAddUnit";
            this.textBoxAddUnit.Size = new System.Drawing.Size(233, 27);
            this.textBoxAddUnit.TabIndex = 1;
            // 
            // buttonAddUnit
            // 
            this.buttonAddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUnit.Location = new System.Drawing.Point(173, 78);
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.Size = new System.Drawing.Size(149, 38);
            this.buttonAddUnit.TabIndex = 2;
            this.buttonAddUnit.Text = "Add Unit";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
            this.buttonAddUnit.Click += new System.EventHandler(this.buttonAddUnit_Click);
            // 
            // dataGridViewUnit
            // 
            this.dataGridViewUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit.Location = new System.Drawing.Point(27, 151);
            this.dataGridViewUnit.Name = "dataGridViewUnit";
            this.dataGridViewUnit.RowTemplate.Height = 24;
            this.dataGridViewUnit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnit.Size = new System.Drawing.Size(909, 305);
            this.dataGridViewUnit.TabIndex = 3;
            // 
            // buttonDeleteUnit
            // 
            this.buttonDeleteUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUnit.Location = new System.Drawing.Point(368, 480);
            this.buttonDeleteUnit.Name = "buttonDeleteUnit";
            this.buttonDeleteUnit.Size = new System.Drawing.Size(149, 38);
            this.buttonDeleteUnit.TabIndex = 4;
            this.buttonDeleteUnit.Text = "Delete";
            this.buttonDeleteUnit.UseVisualStyleBackColor = true;
            this.buttonDeleteUnit.Click += new System.EventHandler(this.buttonDeleteUnit_Click);
            // 
            // unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 545);
            this.Controls.Add(this.buttonDeleteUnit);
            this.Controls.Add(this.dataGridViewUnit);
            this.Controls.Add(this.buttonAddUnit);
            this.Controls.Add(this.textBoxAddUnit);
            this.Controls.Add(this.label1);
            this.Name = "unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "unit";
            this.Load += new System.EventHandler(this.unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddUnit;
        private System.Windows.Forms.Button buttonAddUnit;
        private System.Windows.Forms.DataGridView dataGridViewUnit;
        private System.Windows.Forms.Button buttonDeleteUnit;
    }
}