﻿namespace DeleteFirstLastWord
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btFirst = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(16, 58);
            this.btFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(100, 28);
            this.btFirst.TabIndex = 1;
            this.btFirst.Text = "First word";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(124, 58);
            this.btLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(100, 28);
            this.btLast.TabIndex = 2;
            this.btLast.Text = "Last word";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 119);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btLast;
    }
}

