namespace Print
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
            this.lbEnter = new System.Windows.Forms.Label();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEnter
            // 
            this.lbEnter.AutoSize = true;
            this.lbEnter.Location = new System.Drawing.Point(8, 6);
            this.lbEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnter.Name = "lbEnter";
            this.lbEnter.Size = new System.Drawing.Size(64, 16);
            this.lbEnter.TabIndex = 0;
            this.lbEnter.Text = "Enter text:";
            // 
            // tbEnter
            // 
            this.tbEnter.Location = new System.Drawing.Point(13, 26);
            this.tbEnter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(147, 22);
            this.tbEnter.TabIndex = 1;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(41, 56);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(85, 28);
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btPotvrdi_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(13, 100);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 16);
            this.lbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 125);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.lbEnter);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnter;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbResult;
    }
}

