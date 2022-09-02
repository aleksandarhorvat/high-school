namespace Rectangle
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
            this.lbSurfaceArea = new System.Windows.Forms.Label();
            this.lbCircumference = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(5, 138);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(100, 28);
            this.btCalculate.TabIndex = 0;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbSurfaceArea
            // 
            this.lbSurfaceArea.AutoSize = true;
            this.lbSurfaceArea.Location = new System.Drawing.Point(102, 187);
            this.lbSurfaceArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSurfaceArea.Name = "lbSurfaceArea";
            this.lbSurfaceArea.Size = new System.Drawing.Size(0, 16);
            this.lbSurfaceArea.TabIndex = 1;
            // 
            // lbCircumference
            // 
            this.lbCircumference.AutoSize = true;
            this.lbCircumference.Location = new System.Drawing.Point(111, 224);
            this.lbCircumference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCircumference.Name = "lbCircumference";
            this.lbCircumference.Size = new System.Drawing.Size(0, 16);
            this.lbCircumference.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Surface area:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Circumference:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "x1 coordinate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "y1 coordinate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "x2 coordinate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "y2 coordinate:";
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(100, 8);
            this.tbX1.Margin = new System.Windows.Forms.Padding(4);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(132, 22);
            this.tbX1.TabIndex = 13;
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(100, 35);
            this.tbY1.Margin = new System.Windows.Forms.Padding(4);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(132, 22);
            this.tbY1.TabIndex = 14;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(99, 67);
            this.tbX2.Margin = new System.Windows.Forms.Padding(4);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(132, 22);
            this.tbX2.TabIndex = 15;
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(99, 99);
            this.tbY2.Margin = new System.Windows.Forms.Padding(4);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(132, 22);
            this.tbY2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 249);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCircumference);
            this.Controls.Add(this.lbSurfaceArea);
            this.Controls.Add(this.btCalculate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label lbSurfaceArea;
        private System.Windows.Forms.Label lbCircumference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY2;
    }
}

