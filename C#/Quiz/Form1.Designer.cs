
namespace Quiz
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
            this.lbQuestions = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBrojBodova = new System.Windows.Forms.Label();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.gpAnswers = new System.Windows.Forms.GroupBox();
            this.rbFinish = new System.Windows.Forms.RadioButton();
            this.gpAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuestions
            // 
            this.lbQuestions.AutoSize = true;
            this.lbQuestions.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestions.Location = new System.Drawing.Point(16, 11);
            this.lbQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(96, 47);
            this.lbQuestions.TabIndex = 1;
            this.lbQuestions.Text = "Quiz";
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(24, 333);
            this.pbProgress.Margin = new System.Windows.Forms.Padding(4);
            this.pbProgress.Maximum = 5;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(1065, 28);
            this.pbProgress.Step = 1;
            this.pbProgress.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your points:";
            // 
            // lbBrojBodova
            // 
            this.lbBrojBodova.AutoSize = true;
            this.lbBrojBodova.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojBodova.Location = new System.Drawing.Point(663, 365);
            this.lbBrojBodova.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBrojBodova.Name = "lbBrojBodova";
            this.lbBrojBodova.Size = new System.Drawing.Size(0, 47);
            this.lbBrojBodova.TabIndex = 4;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAnswer1.AutoCheck = false;
            this.rbAnswer1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer1.Location = new System.Drawing.Point(99, 23);
            this.rbAnswer1.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(301, 95);
            this.rbAnswer1.TabIndex = 0;
            this.rbAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAnswer1.UseVisualStyleBackColor = true;
            this.rbAnswer1.Click += new System.EventHandler(this.rbAnswer1_Click);
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAnswer2.AutoCheck = false;
            this.rbAnswer2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer2.Location = new System.Drawing.Point(716, 23);
            this.rbAnswer2.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(301, 95);
            this.rbAnswer2.TabIndex = 1;
            this.rbAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAnswer2.UseVisualStyleBackColor = true;
            this.rbAnswer2.Click += new System.EventHandler(this.rbAnswer2_Click);
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAnswer3.AutoCheck = false;
            this.rbAnswer3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer3.Location = new System.Drawing.Point(99, 144);
            this.rbAnswer3.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(301, 95);
            this.rbAnswer3.TabIndex = 2;
            this.rbAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAnswer3.UseVisualStyleBackColor = true;
            this.rbAnswer3.Click += new System.EventHandler(this.rbAnswer3_Click);
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAnswer4.AutoCheck = false;
            this.rbAnswer4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer4.Location = new System.Drawing.Point(716, 144);
            this.rbAnswer4.Margin = new System.Windows.Forms.Padding(4);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(301, 95);
            this.rbAnswer4.TabIndex = 3;
            this.rbAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAnswer4.UseVisualStyleBackColor = true;
            this.rbAnswer4.Click += new System.EventHandler(this.rbAnswer4_Click);
            // 
            // gpAnswers
            // 
            this.gpAnswers.Controls.Add(this.rbFinish);
            this.gpAnswers.Controls.Add(this.rbAnswer4);
            this.gpAnswers.Controls.Add(this.rbAnswer3);
            this.gpAnswers.Controls.Add(this.rbAnswer2);
            this.gpAnswers.Controls.Add(this.rbAnswer1);
            this.gpAnswers.Location = new System.Drawing.Point(25, 62);
            this.gpAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.gpAnswers.Name = "gpAnswers";
            this.gpAnswers.Padding = new System.Windows.Forms.Padding(4);
            this.gpAnswers.Size = new System.Drawing.Size(1065, 252);
            this.gpAnswers.TabIndex = 0;
            this.gpAnswers.TabStop = false;
            // 
            // rbFinish
            // 
            this.rbFinish.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFinish.AutoCheck = false;
            this.rbFinish.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFinish.Location = new System.Drawing.Point(408, 76);
            this.rbFinish.Margin = new System.Windows.Forms.Padding(4);
            this.rbFinish.Name = "rbFinish";
            this.rbFinish.Size = new System.Drawing.Size(301, 95);
            this.rbFinish.TabIndex = 4;
            this.rbFinish.Text = "Finish";
            this.rbFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFinish.UseVisualStyleBackColor = true;
            this.rbFinish.Visible = false;
            this.rbFinish.Click += new System.EventHandler(this.rbFinish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 426);
            this.Controls.Add(this.lbBrojBodova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lbQuestions);
            this.Controls.Add(this.gpAnswers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpAnswers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbQuestions;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBrojBodova;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.GroupBox gpAnswers;
        private System.Windows.Forms.RadioButton rbFinish;
    }
}

