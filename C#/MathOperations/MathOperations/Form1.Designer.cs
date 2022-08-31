namespace MathOperations
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
            this.btCalculate = new System.Windows.Forms.Button();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(40, 69);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(100, 28);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // cmbChoice
            // 
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Items.AddRange(new object[] {
            "Reciprocal value",
            "Square root",
            "Square",
            "Cube"});
            this.cmbChoice.Location = new System.Drawing.Point(148, 69);
            this.cmbChoice.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(160, 24);
            this.cmbChoice.TabIndex = 1;
            this.cmbChoice.SelectedIndexChanged += new System.EventHandler(this.cmbChoice_SelectedIndexChanged);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(349, 73);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 16);
            this.lbResult.TabIndex = 2;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(40, 16);
            this.tbA.Margin = new System.Windows.Forms.Padding(4);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(132, 22);
            this.tbA.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 138);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.btCalculate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbA;
    }
}

