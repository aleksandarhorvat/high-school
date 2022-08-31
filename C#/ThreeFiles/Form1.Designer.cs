namespace ThreeFiles
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
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.cbSelectFile = new System.Windows.Forms.ComboBox();
            this.gbChoice = new System.Windows.Forms.GroupBox();
            this.rbAverage = new System.Windows.Forms.RadioButton();
            this.rbMaxNumberOfAppearances = new System.Windows.Forms.RadioButton();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.lRezultat = new System.Windows.Forms.Label();
            this.gbChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 16;
            this.lbNumbers.Location = new System.Drawing.Point(79, 112);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(120, 180);
            this.lbNumbers.TabIndex = 0;
            // 
            // cbSelectFile
            // 
            this.cbSelectFile.FormattingEnabled = true;
            this.cbSelectFile.Items.AddRange(new object[] {
            "File1",
            "File2",
            "File3"});
            this.cbSelectFile.Location = new System.Drawing.Point(78, 58);
            this.cbSelectFile.Name = "cbSelectFile";
            this.cbSelectFile.Size = new System.Drawing.Size(133, 24);
            this.cbSelectFile.TabIndex = 1;
            this.cbSelectFile.Text = "Select a file";
            this.cbSelectFile.SelectedIndexChanged += new System.EventHandler(this.cbSelectFile_SelectedIndexChanged);
            // 
            // gbChoice
            // 
            this.gbChoice.Controls.Add(this.rbAverage);
            this.gbChoice.Controls.Add(this.rbMaxNumberOfAppearances);
            this.gbChoice.Controls.Add(this.rbMax);
            this.gbChoice.Enabled = false;
            this.gbChoice.Location = new System.Drawing.Point(313, 79);
            this.gbChoice.Name = "gbChoice";
            this.gbChoice.Size = new System.Drawing.Size(230, 115);
            this.gbChoice.TabIndex = 4;
            this.gbChoice.TabStop = false;
            this.gbChoice.Text = "Choice";
            // 
            // rbAverage
            // 
            this.rbAverage.AutoSize = true;
            this.rbAverage.Location = new System.Drawing.Point(6, 75);
            this.rbAverage.Name = "rbAverage";
            this.rbAverage.Size = new System.Drawing.Size(80, 20);
            this.rbAverage.TabIndex = 2;
            this.rbAverage.TabStop = true;
            this.rbAverage.Text = "Average";
            this.rbAverage.UseVisualStyleBackColor = true;
            this.rbAverage.CheckedChanged += new System.EventHandler(this.rbAverage_CheckedChanged);
            // 
            // rbMaxNumberOfAppearances
            // 
            this.rbMaxNumberOfAppearances.AutoSize = true;
            this.rbMaxNumberOfAppearances.Location = new System.Drawing.Point(6, 48);
            this.rbMaxNumberOfAppearances.Name = "rbMaxNumberOfAppearances";
            this.rbMaxNumberOfAppearances.Size = new System.Drawing.Size(217, 20);
            this.rbMaxNumberOfAppearances.TabIndex = 1;
            this.rbMaxNumberOfAppearances.TabStop = true;
            this.rbMaxNumberOfAppearances.Text = "Max an number of appearances";
            this.rbMaxNumberOfAppearances.UseVisualStyleBackColor = true;
            this.rbMaxNumberOfAppearances.CheckedChanged += new System.EventHandler(this.rbMaxNumberOfAppearances_CheckedChanged);
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Location = new System.Drawing.Point(6, 21);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(53, 20);
            this.rbMax.TabIndex = 0;
            this.rbMax.TabStop = true;
            this.rbMax.Text = "Max";
            this.rbMax.UseVisualStyleBackColor = true;
            this.rbMax.CheckedChanged += new System.EventHandler(this.rbMax_CheckedChanged);
            // 
            // lRezultat
            // 
            this.lRezultat.AutoSize = true;
            this.lRezultat.Location = new System.Drawing.Point(222, 221);
            this.lRezultat.Name = "lRezultat";
            this.lRezultat.Size = new System.Drawing.Size(44, 16);
            this.lRezultat.TabIndex = 5;
            this.lRezultat.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 356);
            this.Controls.Add(this.lRezultat);
            this.Controls.Add(this.gbChoice);
            this.Controls.Add(this.cbSelectFile);
            this.Controls.Add(this.lbNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbChoice.ResumeLayout(false);
            this.gbChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.ComboBox cbSelectFile;
        private System.Windows.Forms.GroupBox gbChoice;
        private System.Windows.Forms.RadioButton rbAverage;
        private System.Windows.Forms.RadioButton rbMaxNumberOfAppearances;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.Label lRezultat;
    }
}

