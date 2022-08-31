namespace OneFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.rbOdd = new System.Windows.Forms.RadioButton();
            this.rbEven = new System.Windows.Forms.RadioButton();
            this.btDisplay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.gbChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requested numbers";
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 16;
            this.lbNumbers.Location = new System.Drawing.Point(46, 75);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(151, 244);
            this.lbNumbers.TabIndex = 1;
            // 
            // gbChoice
            // 
            this.gbChoice.Controls.Add(this.rbBoth);
            this.gbChoice.Controls.Add(this.rbOdd);
            this.gbChoice.Controls.Add(this.rbEven);
            this.gbChoice.Location = new System.Drawing.Point(219, 36);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(174, 164);
            this.gbChoice.TabIndex = 2;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "Number selection:";
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Location = new System.Drawing.Point(6, 93);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(167, 20);
            this.rbBoth.TabIndex = 2;
            this.rbBoth.TabStop = true;
            this.rbBoth.Text = "Evan and odd numbers";
            this.rbBoth.UseVisualStyleBackColor = true;
            // 
            // rbOdd
            // 
            this.rbOdd.AutoSize = true;
            this.rbOdd.Location = new System.Drawing.Point(6, 66);
            this.rbOdd.Name = "rbOdd";
            this.rbOdd.Size = new System.Drawing.Size(137, 20);
            this.rbOdd.TabIndex = 1;
            this.rbOdd.TabStop = true;
            this.rbOdd.Text = "Only odd numbers";
            this.rbOdd.UseVisualStyleBackColor = true;
            // 
            // rbEven
            // 
            this.rbEven.AutoSize = true;
            this.rbEven.Location = new System.Drawing.Point(6, 39);
            this.rbEven.Name = "rbEven";
            this.rbEven.Size = new System.Drawing.Size(143, 20);
            this.rbEven.TabIndex = 0;
            this.rbEven.TabStop = true;
            this.rbEven.Text = "Only even numbers";
            this.rbEven.UseVisualStyleBackColor = true;
            // 
            // btDisplay
            // 
            this.btDisplay.Location = new System.Drawing.Point(225, 206);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(121, 23);
            this.btDisplay.TabIndex = 3;
            this.btDisplay.Text = "Display numbers";
            this.btDisplay.UseVisualStyleBackColor = true;
            this.btDisplay.Click += new System.EventHandler(this.btDisplay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "How many numbers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sum of numbers";
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(347, 243);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 22);
            this.tbNumber.TabIndex = 6;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(347, 284);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 22);
            this.tbSum.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 350);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDisplay);
            this.Controls.Add(this.gbChoice);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbChoice.ResumeLayout(false);
            this.gbChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.RadioButton rbBoth;
        private System.Windows.Forms.RadioButton rbOdd;
        private System.Windows.Forms.RadioButton rbEven;
    }
}

