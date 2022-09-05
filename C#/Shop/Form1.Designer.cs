
namespace Shop
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
            this.btCheckout = new System.Windows.Forms.Button();
            this.btCatalogue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCheckout
            // 
            this.btCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckout.Location = new System.Drawing.Point(78, 247);
            this.btCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(234, 60);
            this.btCheckout.TabIndex = 5;
            this.btCheckout.Text = "Checkout";
            this.btCheckout.UseVisualStyleBackColor = true;
            this.btCheckout.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // btCatalogue
            // 
            this.btCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCatalogue.Location = new System.Drawing.Point(78, 113);
            this.btCatalogue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCatalogue.Name = "btCatalogue";
            this.btCatalogue.Size = new System.Drawing.Size(234, 59);
            this.btCatalogue.TabIndex = 4;
            this.btCatalogue.Text = "Catalogue";
            this.btCatalogue.UseVisualStyleBackColor = true;
            this.btCatalogue.Click += new System.EventHandler(this.btCatalogue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 346);
            this.Controls.Add(this.btCheckout);
            this.Controls.Add(this.btCatalogue);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheckout;
        private System.Windows.Forms.Button btCatalogue;
        private System.Windows.Forms.Label label1;
    }
}

