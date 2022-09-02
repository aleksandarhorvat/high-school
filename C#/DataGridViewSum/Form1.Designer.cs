namespace DataGridViewSum
{
    partial class Form1
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btFill = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(16, 50);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(365, 274);
            this.dgvTable.TabIndex = 0;
            // 
            // btFill
            // 
            this.btFill.Location = new System.Drawing.Point(16, 15);
            this.btFill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFill.Name = "btFill";
            this.btFill.Size = new System.Drawing.Size(100, 28);
            this.btFill.TabIndex = 1;
            this.btFill.Text = "Fill table";
            this.btFill.UseVisualStyleBackColor = true;
            this.btFill.Click += new System.EventHandler(this.btFill_Click);
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(124, 15);
            this.btSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(100, 28);
            this.btSum.TabIndex = 2;
            this.btSum.Text = "Sum";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(232, 15);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(148, 22);
            this.tbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 340);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.btFill);
            this.Controls.Add(this.dgvTable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btFill;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.TextBox tbResult;
    }
}

