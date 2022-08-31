namespace Swap
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
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(59, 41);
            this.tbFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(132, 22);
            this.tbFirst.TabIndex = 0;
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(315, 41);
            this.tbSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(132, 22);
            this.tbSecond.TabIndex = 1;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(205, 111);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(100, 28);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 290);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.tbFirst);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbSecond;
        private System.Windows.Forms.Button btConfirm;
    }
}

