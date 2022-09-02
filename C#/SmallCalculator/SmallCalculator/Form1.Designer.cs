namespace SmallCalculator
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
            this.lbEnterFirst = new System.Windows.Forms.Label();
            this.lbEnterSecond = new System.Windows.Forms.Label();
            this.tbEnterFirst = new System.Windows.Forms.TextBox();
            this.tbEnterSecond = new System.Windows.Forms.TextBox();
            this.btAddition = new System.Windows.Forms.Button();
            this.btSubtraction = new System.Windows.Forms.Button();
            this.btMultiplication = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEnterFirst
            // 
            this.lbEnterFirst.AutoSize = true;
            this.lbEnterFirst.Location = new System.Drawing.Point(16, 44);
            this.lbEnterFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnterFirst.Name = "lbEnterFirst";
            this.lbEnterFirst.Size = new System.Drawing.Size(133, 16);
            this.lbEnterFirst.TabIndex = 0;
            this.lbEnterFirst.Text = "Enter the first number:";
            // 
            // lbEnterSecond
            // 
            this.lbEnterSecond.AutoSize = true;
            this.lbEnterSecond.Location = new System.Drawing.Point(16, 92);
            this.lbEnterSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnterSecond.Name = "lbEnterSecond";
            this.lbEnterSecond.Size = new System.Drawing.Size(137, 16);
            this.lbEnterSecond.TabIndex = 1;
            this.lbEnterSecond.Text = "Enter second number:";
            // 
            // tbEnterFirst
            // 
            this.tbEnterFirst.Location = new System.Drawing.Point(168, 44);
            this.tbEnterFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEnterFirst.Name = "tbEnterFirst";
            this.tbEnterFirst.Size = new System.Drawing.Size(132, 22);
            this.tbEnterFirst.TabIndex = 2;
            // 
            // tbEnterSecond
            // 
            this.tbEnterSecond.Location = new System.Drawing.Point(168, 92);
            this.tbEnterSecond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEnterSecond.Name = "tbEnterSecond";
            this.tbEnterSecond.Size = new System.Drawing.Size(132, 22);
            this.tbEnterSecond.TabIndex = 3;
            // 
            // btAddition
            // 
            this.btAddition.Location = new System.Drawing.Point(20, 162);
            this.btAddition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddition.Name = "btAddition";
            this.btAddition.Size = new System.Drawing.Size(100, 28);
            this.btAddition.TabIndex = 4;
            this.btAddition.Text = "Addition";
            this.btAddition.UseVisualStyleBackColor = true;
            this.btAddition.Click += new System.EventHandler(this.btAddition_Click);
            // 
            // btSubtraction
            // 
            this.btSubtraction.Location = new System.Drawing.Point(157, 162);
            this.btSubtraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubtraction.Name = "btSubtraction";
            this.btSubtraction.Size = new System.Drawing.Size(100, 28);
            this.btSubtraction.TabIndex = 5;
            this.btSubtraction.Text = "Subtraction";
            this.btSubtraction.UseVisualStyleBackColor = true;
            this.btSubtraction.Click += new System.EventHandler(this.btSubstraction_Click);
            // 
            // btMultiplication
            // 
            this.btMultiplication.Location = new System.Drawing.Point(280, 162);
            this.btMultiplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btMultiplication.Name = "btMultiplication";
            this.btMultiplication.Size = new System.Drawing.Size(100, 28);
            this.btMultiplication.TabIndex = 6;
            this.btMultiplication.Text = "Multiplication";
            this.btMultiplication.UseVisualStyleBackColor = true;
            this.btMultiplication.Click += new System.EventHandler(this.btMultiplication_Click);
            // 
            // btDivision
            // 
            this.btDivision.Location = new System.Drawing.Point(404, 162);
            this.btDivision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(100, 28);
            this.btDivision.TabIndex = 7;
            this.btDivision.Text = "Division";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btDivision_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(148, 201);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 54);
            this.lbResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 263);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btMultiplication);
            this.Controls.Add(this.btSubtraction);
            this.Controls.Add(this.btAddition);
            this.Controls.Add(this.tbEnterSecond);
            this.Controls.Add(this.tbEnterFirst);
            this.Controls.Add(this.lbEnterSecond);
            this.Controls.Add(this.lbEnterFirst);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEnterFirst;
        private System.Windows.Forms.Label lbEnterSecond;
        private System.Windows.Forms.TextBox tbEnterFirst;
        private System.Windows.Forms.TextBox tbEnterSecond;
        private System.Windows.Forms.Button btAddition;
        private System.Windows.Forms.Button btSubtraction;
        private System.Windows.Forms.Button btMultiplication;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Label lbResult;
    }
}

