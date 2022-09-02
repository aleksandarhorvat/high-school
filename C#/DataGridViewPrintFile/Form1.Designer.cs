namespace DataGridViewPrintFile
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
            this.gpDimensions = new System.Windows.Forms.GroupBox();
            this.nudNumber2 = new System.Windows.Forms.NumericUpDown();
            this.nudNumber1 = new System.Windows.Forms.NumericUpDown();
            this.btWrite = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.gpDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(16, 108);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.Size = new System.Drawing.Size(323, 305);
            this.dgvTable.TabIndex = 0;
            // 
            // gpDimensions
            // 
            this.gpDimensions.Controls.Add(this.nudNumber2);
            this.gpDimensions.Controls.Add(this.nudNumber1);
            this.gpDimensions.Location = new System.Drawing.Point(16, 15);
            this.gpDimensions.Margin = new System.Windows.Forms.Padding(4);
            this.gpDimensions.Name = "gpDimensions";
            this.gpDimensions.Padding = new System.Windows.Forms.Padding(4);
            this.gpDimensions.Size = new System.Drawing.Size(187, 86);
            this.gpDimensions.TabIndex = 1;
            this.gpDimensions.TabStop = false;
            this.gpDimensions.Text = "Dimensions of the Matrix";
            // 
            // nudNumber2
            // 
            this.nudNumber2.Location = new System.Drawing.Point(95, 37);
            this.nudNumber2.Margin = new System.Windows.Forms.Padding(4);
            this.nudNumber2.Name = "nudNumber2";
            this.nudNumber2.Size = new System.Drawing.Size(77, 22);
            this.nudNumber2.TabIndex = 1;
            this.nudNumber2.ValueChanged += new System.EventHandler(this.nudNumber1_ValueChanged);
            // 
            // nudNumber1
            // 
            this.nudNumber1.Location = new System.Drawing.Point(9, 37);
            this.nudNumber1.Margin = new System.Windows.Forms.Padding(4);
            this.nudNumber1.Name = "nudNumber1";
            this.nudNumber1.Size = new System.Drawing.Size(77, 22);
            this.nudNumber1.TabIndex = 0;
            this.nudNumber1.ValueChanged += new System.EventHandler(this.nudNumber1_ValueChanged);
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(225, 48);
            this.btWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(100, 28);
            this.btWrite.TabIndex = 2;
            this.btWrite.Text = "Write in the file";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 428);
            this.Controls.Add(this.btWrite);
            this.Controls.Add(this.gpDimensions);
            this.Controls.Add(this.dgvTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.gpDimensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.GroupBox gpDimensions;
        private System.Windows.Forms.NumericUpDown nudNumber2;
        private System.Windows.Forms.NumericUpDown nudNumber1;
        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

